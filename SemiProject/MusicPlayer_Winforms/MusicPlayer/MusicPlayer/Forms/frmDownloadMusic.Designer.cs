namespace MusicPlayer.Forms
{
    partial class frmDownloadMusic
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
            txtSearch = new TextBox();
            lblTitle = new Label();
            btnDownload = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(53, 132);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(480, 23);
            txtSearch.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(53, 158);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(561, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "label1";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(539, 184);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(539, 131);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmDownloadMusic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 352);
            Controls.Add(btnSearch);
            Controls.Add(btnDownload);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Name = "frmDownloadMusic";
            Text = "frmDownloadMusic";
            Load += frmDownloadMusic_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label lblTitle;
        private Button btnDownload;
        private Button btnSearch;
    }
}