namespace MusicPlayer.Forms
{
    partial class frmSettings
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
            menuStrip1 = new MenuStrip();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ccBtnAllListManage = new Controls.ccButton();
            ccBtnSelectPlayList = new Controls.ccButton();
            ccBtnDownloadMusic = new Controls.ccButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ccBtnAllListManage);
            flowLayoutPanel1.Controls.Add(ccBtnSelectPlayList);
            flowLayoutPanel1.Controls.Add(ccBtnDownloadMusic);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(180, 411);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // ccBtnAllListManage
            // 
            ccBtnAllListManage.FormName = null;
            ccBtnAllListManage.Location = new Point(3, 3);
            ccBtnAllListManage.Name = "ccBtnAllListManage";
            ccBtnAllListManage.Size = new Size(170, 50);
            ccBtnAllListManage.TabIndex = 4;
            ccBtnAllListManage.Text = "All List";
            ccBtnAllListManage.UseVisualStyleBackColor = true;
            // 
            // ccBtnSelectPlayList
            // 
            ccBtnSelectPlayList.FormName = null;
            ccBtnSelectPlayList.Location = new Point(3, 59);
            ccBtnSelectPlayList.Name = "ccBtnSelectPlayList";
            ccBtnSelectPlayList.Size = new Size(170, 50);
            ccBtnSelectPlayList.TabIndex = 3;
            ccBtnSelectPlayList.Text = "Play List";
            ccBtnSelectPlayList.UseVisualStyleBackColor = true;
            // 
            // ccBtnDownloadMusic
            // 
            ccBtnDownloadMusic.FormName = null;
            ccBtnDownloadMusic.Location = new Point(3, 115);
            ccBtnDownloadMusic.Name = "ccBtnDownloadMusic";
            ccBtnDownloadMusic.Size = new Size(170, 50);
            ccBtnDownloadMusic.TabIndex = 2;
            ccBtnDownloadMusic.Text = "Download";
            ccBtnDownloadMusic.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 411);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmSettings";
            Text = "Setting";
            Load += frmSettings_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Controls.ccButton ccBtnDownloadMusic;
        private Controls.ccButton ccBtnSelectPlayList;
        private Controls.ccButton ccBtnAllListManage;
    }
}