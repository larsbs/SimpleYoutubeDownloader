using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleYoutubeDownloader.Forms
{
    public partial class SelectDownloadsFolderDialog : Form
    {
        public SelectDownloadsFolderDialog()
        {
            InitializeComponent();
            this.tbx_downloads_location.Text = Properties.Settings.Default.downloadsFolder;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            DialogResult result = fb.ShowDialog();
            
            if (result != DialogResult.Cancel)
            {
                this.tbx_downloads_location.Text = fb.SelectedPath;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.downloadsFolder = this.tbx_downloads_location.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            string downloadsFolder = this.tbx_downloads_location.Text;

            if (downloadsFolder == null || downloadsFolder == "")
            {
                MessageBox.Show("Set default downloads folder.", "Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
