using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimpleYoutubeDownloader.Forms
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_web_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"http://larsbs.github.io/simpleyoutubedownloader");
        }

        private void lbl_youtubedl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"http://rg3.github.io/youtube-dl");
        }

        private void lbl_ffmpeg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"http://ffmpeg.zeranoe.com/builds/");
        }
    }
}
