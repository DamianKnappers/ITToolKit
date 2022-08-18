using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITToolKit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string twLocation;
        public string twRunRunstring;
        public string ccLocation;
        public string ccRunRunString;
        public string adwRunRunString;
        public string Username = Environment.UserName;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initiate the local tool directory //
            string baseDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            if(!Directory.Exists(baseDir + @"\3rdParty"))
            {
                Directory.CreateDirectory(baseDir + @"\3rdParty");
            }

            // Initiate the regedit searches //

            // TeamViewer //
            twLocation = this.SearchRegString(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\", "DisplayName", "TeamViewer", "InstallLocation");
            if (twLocation != string.Empty) {
                tvwButton.Text = "Start";
                twRunRunstring = this.SearchRegString(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\", "DisplayName", "TeamViewer", "DisplayIcon");
            } else {
                twLocation = this.SearchRegString(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\", "DisplayName", "TeamViewer", "InstallLocation");
                twRunRunstring = this.SearchRegString(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\", "DisplayName", "TeamViewer", "DisplayIcon");
                if (twLocation != string.Empty)
                {
                    tvwButton.Text = "Start";
                } else { tvwButton.Text = "Installeer"; }
            }
            // CCleaner //
            ccLocation = this.SearchRegString(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\", "DisplayName", "CCleaner", "InstallLocation");
            if (ccLocation != string.Empty)
            {
                ccButton.Text = "Start";
                ccRunRunString = this.SearchRegString(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\", "DisplayName", "CCleaner", "DisplayIcon");
            }
            else
            {
                ccLocation = this.SearchRegString(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\", "DisplayName", "CCleaner", "InstallLocation");
                ccRunRunString = this.SearchRegString(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\", "DisplayName", "CCleaner", "DisplayIcon");
                if (ccLocation != string.Empty)
                {
                    ccButton.Text = "Start";
                }
                else { ccButton.Text = "Installeer"; }
            }
            // Anti Adware (Malwarebytes) //
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            adwRunRunString = projectDirectory + @"\3rdParty\adwcleaner.exe";
            try
            {
                if (File.Exists(adwRunRunString))
                {
                    adwButton.Text = "Start";
                }
                else {
                    adwRunRunString = null;
                    adwButton.Text = "Installeer"; 
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void adwButton_Click(object sender, EventArgs e)
        {
            if (adwButton.Text == "Start")
            {
                if (adwRunRunString != null)
                {
                    System.Diagnostics.Process.Start(adwRunRunString);
                }
                else
                {
                    MessageBox.Show("Can\'t find the executable for this Malwarebytes Anti-AdWare installation");
                }
            }
            else
            {
                // Anti Adware not installed, install code here
                Uri dwUrl = new Uri("https://adwcleaner.malwarebytes.com/adwcleaner?channel=release");
                try
                {
                    if (!File.Exists(adwRunRunString))
                    {
                        string newLOc = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\3rdParty\adwcleaner.exe";
                        WebClient wc = new WebClient();
                        wc.DownloadFileAsync(dwUrl, newLOc);
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(tvwDownloadChanged);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(adwDownloadCompleted);
                        adwRunRunString = newLOc;
                        adwButton.Text = "Start";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void ccButton_Click(object sender, EventArgs e)
        {
            if (ccButton.Text == "Start")
            {
                string runLocation = this.SearchRegString(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\", "DisplayName", "CCleaner", "DisplayIcon");
                if (ccRunRunString != null)
                {
                    System.Diagnostics.Process.Start(ccRunRunString);
                }
                else
                {
                    MessageBox.Show("Can\'t find the executable for this CCleaner installation");
                }
            }
            else
            {
                // CCleaner not installed, install code here
                Uri dwUrl = new Uri("https://bits.avcdn.net/productfamily_CCLEANER/insttype_FREE/platform_WIN_PIR/installertype_ONLINE/build_RELEASE");
                string filename = @"C:\Users\" + Username + @"\AppData\Local\Temp\ccleanerinstall.exe";
                try
                {
                    if (File.Exists(filename))
                    {
                        File.Delete(filename);
                    }
                    else
                    {
                        WebClient wc = new WebClient();
                        wc.DownloadFileAsync(dwUrl, filename);
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(tvwDownloadChanged);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(ccDownloadCompleted);
                        ccButton.Text = "Start";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void tvwButton_Click(object sender, EventArgs e)
        {
            if (tvwButton.Text == "Start") {
                string runLocation = this.SearchRegString(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\", "DisplayName", "TeamViewer", "DisplayIcon");
                if(twRunRunstring != null)
                {
                    System.Diagnostics.Process.Start(twRunRunstring);
                } else
                {
                    MessageBox.Show("Can\'t find the executable for this TeamViewer installation");
                }
            } else {
                // Teamviewer not installed, install code here
                Uri dwUrl = new Uri("https://dl.teamviewer.com/download/version_15x/TeamViewer_Setup_x64.exe");
                string filename = @"C:\Users\" + Username + @"\AppData\Local\Temp\tvwinstaller.exe";
                try {
                    if (File.Exists(filename))
                    {
                        File.Delete(filename);
                    }
                    else
                    {
                        WebClient wc = new WebClient();
                        wc.DownloadFileAsync(dwUrl, filename);
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(tvwDownloadChanged);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(tvwDownloadCompleted);
                        tvwButton.Text = "Start";
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        

        // Download Events //
        private void tvwDownloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            generalProgressbar.Value = e.ProgressPercentage;
            if(generalProgressbar.Value == generalProgressbar.Maximum)
            {
                generalProgressbar.Value = 0;
            }
        }

        private void ccDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("Download complete!, running exe", "Completed!");
                System.Diagnostics.Process.Start(@"C:\Users\" + Username + @"\AppData\Local\Temp\ccleanerinstall.exe");
            }
            else
            {
                MessageBox.Show("Something went wrong with the connection, please try again later");
                MessageBox.Show(e.Error.ToString());
            }
        }

        void adwDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("Download complete!, running exe", "Completed!");
                System.Diagnostics.Process.Start(adwRunRunString);
            }
            else
            {
                MessageBox.Show("Something went wrong with the connection, please try again later");
                MessageBox.Show(e.Error.ToString());
            }
        }

        private void tvwDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Error == null)
            {
                MessageBox.Show("Download complete!, running exe", "Completed!");
                System.Diagnostics.Process.Start(@"C:\Users\"+ Username + @"\AppData\Local\Temp\tvwinstaller.exe");
            }
            else
            {
                MessageBox.Show("Something went wrong with the connection, please try again later");
                MessageBox.Show(e.Error.ToString());
            }
        }

        // Re-Used Functions //
        private string SearchRegString(string keyname, string data, string valueToFind, string returnValue)
        {
            RegistryKey uninstallKey = Registry.LocalMachine.OpenSubKey(keyname);
            var programs = uninstallKey.GetSubKeyNames();
            foreach (var program in programs)
            {  
                RegistryKey subkey = uninstallKey.OpenSubKey(program);
                if (string.Equals(valueToFind, subkey.GetValue(data, string.Empty).ToString(), StringComparison.CurrentCulture))
                {
                    return subkey.GetValue(returnValue).ToString();
                }
            }
            return string.Empty;
        }

        private void openLostTextDialog_Click(object sender, EventArgs e)
        { 
            //private Form1 mainForm;
            //private TextSearchForm searchForm;
            TextSearchForm searchForm = new TextSearchForm();  
            searchForm.ShowDialog();
        }
    }
}

// Malwarebytes itself
// Registry DisplayName = Malwarebytes version 4.5.13.208
// Need to search for publisher, then sort on the products of Malwarebytes. Anti adware is registered differently. No other non dynamic things to go on.
// Path : Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{35065F43-4BB2-439A-BFF7-0F1014F2E0CD}_is1