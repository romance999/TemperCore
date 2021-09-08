using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperCore
{
    public partial class Core : Form
    {
        public Core()
        {
            InitializeComponent();
        }

        private void Core_Load(object sender, EventArgs e)
        {
            LoadLabels();
        }

        private void LoadLabels()
        {
            siticoneLabel1.Text = $"{Application.ProductName} {Application.ProductVersion}";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dreamWriterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Path = @"C:\Program Files\DreamWriter";
                string dreamWriterFile = @"C:\Program Files\DreamWriter\DreamWriter.exe";
                bool folderexists = System.IO.Directory.Exists(Path);
                if (!folderexists)
                {
                    System.IO.Directory.CreateDirectory(Path);
                    MessageBox.Show("DreamWriter files not found, making folder now", Application.ProductName);
                    MessageBox.Show("Downloading DreamWriter", Application.ProductName);
                    string remoteUri = "https://link-to.net/349500/dream";
                    WebClient client = new WebClient();
                    WebClient myWebClient = new WebClient();
                    myWebClient.DownloadFile(remoteUri, dreamWriterFile);
                }
                if (folderexists)
                {
                    if (File.Exists(dreamWriterFile))
                    {
                        MessageBox.Show("DreamWriter is already installed", Application.ProductName);
                    }
                    else if (!File.Exists(dreamWriterFile))
                    {
                        MessageBox.Show("Downloading DreamWriter", Application.ProductName);
                        string remoteUri = "https://link-to.net/349500/dream";
                        WebClient client = new WebClient();
                        WebClient myWebClient = new WebClient();
                        myWebClient.DownloadFile(remoteUri, dreamWriterFile);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
    }
}
