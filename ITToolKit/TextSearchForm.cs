using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ITToolKit
{
    public partial class TextSearchForm : Form
    {
        public TextSearchForm()
        {
            InitializeComponent();
            initComboBox();
        }

        private DriveInfo[] allDrives = DriveInfo.GetDrives();

        private void initComboBox()
        {
            foreach(DriveInfo d in allDrives)
            {
                selectDriveComboBox.Items.Add(d.Name);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            // TODO: Search starts at subfolders not the main drive itself. Fix this
            if (clearResultCheckbox.Checked)
            {
                resultListBox.Items.Clear();
            }
            string[] inputSearchStrings = searchStringsInput.Text.Split('\n');
            string[] directories = Directory.GetDirectories(selectDriveComboBox.SelectedItem.ToString(), "*", SearchOption.TopDirectoryOnly);
            string[] mainFiles = Directory.GetFiles(selectDriveComboBox.SelectedItem.ToString(), @"*.txt");
            string[] files = new string[] { };
            findFilesProgress.Minimum = 1;
            findFilesProgress.Value = 1;
            findFilesProgress.Maximum = directories.Length;
            Console.WriteLine(directories.Length);
            try
            {
                foreach (string mainFile in mainFiles)
                {
                    Array.Resize(ref files, files.Length + 1);
                    files[files.Length - 1] = mainFile;
                }
            } catch (UnauthorizedAccessException) { Console.Write("[SKIPPING] Base drive files not accessable"); }
            try
            {
                foreach (string dir in directories)
                {
                    findFilesProgress.Increment(1);
                    string[] tempFiles = Directory.GetFiles(dir + @"\", @"*.txt", SearchOption.AllDirectories);
                    foreach (string file in tempFiles)
                    {
                        
                        Array.Resize(ref files, files.Length + 1);
                        files[files.Length - 1] = file;
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.Write("[SKIPPING] No access to folder");
            }
            findFilesProgress.Value = findFilesProgress.Maximum;
            foreach (string inputString in inputSearchStrings)
            {
                foreach(string file in files)
                {
                    try
                    {
                        // Read file and compare to input string
                        if (File.ReadLines(file).Any(line => line.Contains(inputString)))
                        {
                            resultListBox.Items.Add(file);
                        }
                    } catch (System.IO.IOException)
                    {
                        Console.Write("[SKIPPING] System IO Exception");
                    }
                }
            }
            MessageBox.Show("Done Searching!");
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void selectDriveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(searchStringsInput.Text != "")
            {
                searchButton.Enabled = true;
            }
        }

        private void searchStringInput_TextChanged(object sender, EventArgs e)
        {
            if(selectDriveComboBox.SelectedIndex != -1)
            {
                searchButton.Enabled = true;
            }
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(resultListBox.SelectedItem != null) {
                openFileButton.Enabled = true;
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if(resultListBox.SelectedItem != null) { System.Diagnostics.Process.Start(resultListBox.SelectedItem.ToString()); }
        }
    }
}
