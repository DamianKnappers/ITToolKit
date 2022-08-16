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
        public string Username = Environment.UserName;

        private void Form1_Load(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Can\'t find the executable for this TeamViewer installation");
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
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        
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
    }
}
