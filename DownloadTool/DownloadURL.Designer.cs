namespace DownloadTool
{
    partial class frmDownload
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
            this.lblDownloadURL = new System.Windows.Forms.Label();
            this.txtDownloadURL = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblDownloadURL
            // 
            this.lblDownloadURL.AutoSize = true;
            this.lblDownloadURL.Location = new System.Drawing.Point(9, 9);
            this.lblDownloadURL.Name = "lblDownloadURL";
            this.lblDownloadURL.Size = new System.Drawing.Size(80, 13);
            this.lblDownloadURL.TabIndex = 0;
            this.lblDownloadURL.Text = "Download URL";
            // 
            // txtDownloadURL
            // 
            this.txtDownloadURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadURL.Location = new System.Drawing.Point(12, 25);
            this.txtDownloadURL.Name = "txtDownloadURL";
            this.txtDownloadURL.Size = new System.Drawing.Size(776, 20);
            this.txtDownloadURL.TabIndex = 1;
            this.txtDownloadURL.Text = "https://masstamilan2019download.com/tamil/";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(12, 51);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 358);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(93, 51);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(695, 23);
            this.progressBar.TabIndex = 4;
            // 
            // frmDownload
            // 
            this.AcceptButton = this.btnDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtDownloadURL);
            this.Controls.Add(this.lblDownloadURL);
            this.Name = "frmDownload";
            this.Text = "Download URL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDownloadURL;
        private System.Windows.Forms.TextBox txtDownloadURL;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

