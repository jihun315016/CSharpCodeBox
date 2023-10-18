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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 286);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(598, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("맑은 고딕", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(16, 312);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(598, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "label1";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(620, 312);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(620, 286);
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
            lbxCurrent.Size = new Size(300, 244);
            lbxCurrent.TabIndex = 5;
            // 
            // listAll
            // 
            listAll.FormattingEnabled = true;
            listAll.ItemHeight = 15;
            listAll.Location = new Point(393, 27);
            listAll.Name = "listAll";
            listAll.Size = new Size(300, 244);
            listAll.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(322, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = ">>";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(322, 147);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(65, 23);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "<<";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 9;
            label1.Text = "Current Music List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(393, 9);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 10;
            label2.Text = "All Music List";
            // 
            // frmDownloadMusic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 352);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
    }
}