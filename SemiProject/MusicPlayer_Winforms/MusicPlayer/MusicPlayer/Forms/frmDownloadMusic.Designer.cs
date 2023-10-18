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
            lbxCurrent = new ListBox();
            listAll = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 286);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(444, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(16, 312);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(444, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "label1";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(466, 315);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(466, 286);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbxCurrent
            // 
            lbxCurrent.FormattingEnabled = true;
            lbxCurrent.ItemHeight = 15;
            lbxCurrent.Location = new Point(16, 27);
            lbxCurrent.Name = "lbxCurrent";
            lbxCurrent.Size = new Size(224, 244);
            lbxCurrent.TabIndex = 5;
            // 
            // listAll
            // 
            listAll.FormattingEnabled = true;
            listAll.ItemHeight = 15;
            listAll.Location = new Point(317, 27);
            listAll.Name = "listAll";
            listAll.Size = new Size(224, 244);
            listAll.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(246, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = ">>";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(246, 136);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(65, 23);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "<<";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // frmDownloadMusic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 352);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(listAll);
            Controls.Add(lbxCurrent);
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
        private ListBox lbxCurrent;
        private ListBox listAll;
        private Button btnAdd;
        private Button btnRemove;
    }
}