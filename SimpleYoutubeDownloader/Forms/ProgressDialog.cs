using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SimpleYoutubeDownloader
{
    public partial class ProgressDialog : Form
    {
        private Process process;

        public ProgressDialog(Process process)
        {
            InitializeComponent();

            this.process = process;

            // Start background process
            this.progressDialogWorker.RunWorkerAsync(process);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.process.Kill();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            this.Close();
        }

        private void progressDialogWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Process process = e.Argument as Process;
            BackgroundWorker worker = sender as BackgroundWorker;

            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                worker.ReportProgress(0, line);
            }
        }

        private void progressDialogWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string pattern = @"\[download\]\s{1,3}(\d+)\.\d+%\sof\s(\d+\.\d+[a-wA-W]+)\sat\s(\d+\.\d+[a-wA-W/]+)\sETA\s(\d+:\d+)";
            string consoleLine = e.UserState as string;

            Console.WriteLine(consoleLine);

            Match match = Regex.Match(consoleLine, pattern);
            if (match.Success)
            {
                this.Text = "Downloading";
                this.pbr_downloading.Style = ProgressBarStyle.Continuous;
                this.lbl_time_left.Text = "Estimated time left: " + match.Groups[4].Value;
                this.lbl_transfer_rate.Text = "Transfer rate: " + match.Groups[3].Value;
                this.pbr_downloading.Value = (int)Convert.ToSingle(match.Groups[1].Value);
            }
            else
            {
                this.lbl_time_left.Text = "";
                this.lbl_transfer_rate.Text = "Processing...";
                this.Text = "Processing";
                this.pbr_downloading.Style = ProgressBarStyle.Marquee;
            }
        }

        private void progressDialogWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                Console.WriteLine("Canceled!");
            }
            else if (e.Error != null)
            {
                Console.WriteLine("Error: " + e.Error.Message);
            }
            else
            {
                this.pbr_downloading.Style = ProgressBarStyle.Continuous;
                this.pbr_downloading.Value = 100;
                this.lbl_time_left.Text = "";
                this.lbl_transfer_rate.Text = "Completed";
                this.Text = "Completed";
                this.btn_cancel.Text = "Ok";
            }
        }
    }
}
