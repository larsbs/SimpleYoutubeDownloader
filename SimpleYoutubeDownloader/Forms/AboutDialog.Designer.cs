namespace SimpleYoutubeDownloader.Forms
{
    partial class AboutDialog
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_web = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_youtubedl = new System.Windows.Forms.LinkLabel();
            this.lbl_ffmpeg = new System.Windows.Forms.LinkLabel();
            this.btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleYoutubeDownloader.Properties.Resources.app_icon;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple Youtube Downloader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version: 0.1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copyright (c) 2013 - Lorenzo Ruiz (SimpleSW)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Web:";
            // 
            // lbl_web
            // 
            this.lbl_web.AutoSize = true;
            this.lbl_web.Location = new System.Drawing.Point(83, 102);
            this.lbl_web.Name = "lbl_web";
            this.lbl_web.Size = new System.Drawing.Size(235, 13);
            this.lbl_web.TabIndex = 5;
            this.lbl_web.TabStop = true;
            this.lbl_web.Text = "http://larsbs.github.io/simpleyoutubedownloader";
            this.lbl_web.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_web_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Powered by:";
            // 
            // lbl_youtubedl
            // 
            this.lbl_youtubedl.AutoSize = true;
            this.lbl_youtubedl.Location = new System.Drawing.Point(83, 125);
            this.lbl_youtubedl.Name = "lbl_youtubedl";
            this.lbl_youtubedl.Size = new System.Drawing.Size(56, 13);
            this.lbl_youtubedl.TabIndex = 7;
            this.lbl_youtubedl.TabStop = true;
            this.lbl_youtubedl.Text = "youtube-dl";
            this.lbl_youtubedl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_youtubedl_LinkClicked);
            // 
            // lbl_ffmpeg
            // 
            this.lbl_ffmpeg.AutoSize = true;
            this.lbl_ffmpeg.Location = new System.Drawing.Point(83, 139);
            this.lbl_ffmpeg.Name = "lbl_ffmpeg";
            this.lbl_ffmpeg.Size = new System.Drawing.Size(39, 13);
            this.lbl_ffmpeg.TabIndex = 8;
            this.lbl_ffmpeg.TabStop = true;
            this.lbl_ffmpeg.Text = "ffmpeg";
            this.lbl_ffmpeg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_ffmpeg_LinkClicked);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(243, 164);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 199);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_ffmpeg);
            this.Controls.Add(this.lbl_youtubedl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_web);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.Text = "About Simple Youtube Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbl_web;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lbl_youtubedl;
        private System.Windows.Forms.LinkLabel lbl_ffmpeg;
        private System.Windows.Forms.Button btn_OK;
    }
}