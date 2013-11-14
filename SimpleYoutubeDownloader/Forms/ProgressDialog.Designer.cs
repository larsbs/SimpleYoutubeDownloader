namespace SimpleYoutubeDownloader
{
    partial class ProgressDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbr_downloading = new System.Windows.Forms.ProgressBar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_time_left = new System.Windows.Forms.Label();
            this.lbl_transfer_rate = new System.Windows.Forms.Label();
            this.progressDialogWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pbr_downloading
            // 
            this.pbr_downloading.Location = new System.Drawing.Point(12, 51);
            this.pbr_downloading.Name = "pbr_downloading";
            this.pbr_downloading.Size = new System.Drawing.Size(260, 23);
            this.pbr_downloading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbr_downloading.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(197, 80);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_time_left
            // 
            this.lbl_time_left.AutoSize = true;
            this.lbl_time_left.Location = new System.Drawing.Point(12, 15);
            this.lbl_time_left.Name = "lbl_time_left";
            this.lbl_time_left.Size = new System.Drawing.Size(98, 13);
            this.lbl_time_left.TabIndex = 3;
            this.lbl_time_left.Text = "Estimated time left: ";
            // 
            // lbl_transfer_rate
            // 
            this.lbl_transfer_rate.AutoSize = true;
            this.lbl_transfer_rate.Location = new System.Drawing.Point(12, 29);
            this.lbl_transfer_rate.Name = "lbl_transfer_rate";
            this.lbl_transfer_rate.Size = new System.Drawing.Size(73, 13);
            this.lbl_transfer_rate.TabIndex = 4;
            this.lbl_transfer_rate.Text = "Transfer rate: ";
            // 
            // progressDialogWorker
            // 
            this.progressDialogWorker.WorkerReportsProgress = true;
            this.progressDialogWorker.WorkerSupportsCancellation = true;
            this.progressDialogWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.progressDialogWorker_DoWork);
            this.progressDialogWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.progressDialogWorker_ProgressChanged);
            this.progressDialogWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.progressDialogWorker_RunWorkerCompleted);
            // 
            // ProgressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.lbl_transfer_rate);
            this.Controls.Add(this.lbl_time_left);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pbr_downloading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressDialog";
            this.ShowIcon = false;
            this.Text = "Downloading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbr_downloading;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_time_left;
        private System.Windows.Forms.Label lbl_transfer_rate;
        private System.ComponentModel.BackgroundWorker progressDialogWorker;
    }
}