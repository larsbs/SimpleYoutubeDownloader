using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using SimpleYoutubeDownloader.Forms;

namespace SimpleYoutubeDownloader
{
    /**
     * Youtube video formats:
     * 
     * 22 -> mp4 (720p)
     * ?? -> mp4 (480p)
     * 18 -> mp4 (360p)
     * 
     * 35 -> flv (480p)
     * 34 -> flv (360p)
     * 05 -> flv (240p)
     * 
     * 36 -> 3gp (240p)
     * 17 -> 3gp (144p)
     * 
     */
    public partial class MainWindow : Form
    {
        private ProgressDialog dialog;

        public MainWindow()
        {
            InitializeComponent();

            // Set combobox default values
            this.cbx_audio_format.SelectedIndex = 0;
            this.cbx_quality.SelectedIndex = 0;
            this.cbx_video_format.SelectedIndex = 0;
        }

        private void OnShown(object sender, EventArgs e)
        {
            // Set downloads folder
            this.SetDownloadsFolder();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string youtubeURL = this.tbx_youtube_url.Text;
            string downloadsFolder = Properties.Settings.Default.downloadsFolder;

            if (youtubeURL == "" || youtubeURL == null)
            {
                MessageBox.Show("Enter a valid Youtube URL.", "Youtube URL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
#if DEBUG
            startInfo.FileName = @"C:\Users\Lars\Desarrollo\C#\SimpleYoutubeDownloader\SimpleYoutubeDownloader\Resources\youtube-dl.exe";
#else
            startInfo.FileName = @".\bin\youtube-dl.exe";
#endif
            startInfo.Arguments = Utils.ParseArguments(this.cbx_audio_format.Text, this.cbx_video_format.Text, this.cbx_quality.Text) + @" -o " + downloadsFolder + @"\%(title)s.%(ext)s " + youtubeURL;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            Process process = Process.Start(startInfo);

            dialog = new ProgressDialog(process);
            dialog.ShowDialog(this);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.tbx_youtube_url.Clear();
            this.cbx_quality.SelectedIndex = 0;
            this.cbx_audio_format.SelectedIndex = 0;
            this.cbx_video_format.SelectedIndex = 0;
            Properties.Settings.Default.Reset();
        }

        private void SetDownloadsFolder()
        {
            string downloadsFolder = Properties.Settings.Default.downloadsFolder;

            if (downloadsFolder == null || downloadsFolder == "" || Properties.Settings.Default.firstStart)
            {
                SelectDownloadsFolderDialog df = new SelectDownloadsFolderDialog();
                df.ShowDialog(this);
                Properties.Settings.Default.firstStart = false;
                Properties.Settings.Default.Save();
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            AboutDialog ad = new AboutDialog();
            ad.ShowDialog();
        }
    }
}
