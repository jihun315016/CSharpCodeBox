namespace MusicPlayer.Forms
{
    partial class frmPlayer
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
            label1 = new Label();
            lbxMusic = new ListBox();
            txtCurMusic = new TextBox();
            btnSetting = new Button();
            btnPlay = new Button();
            btnStop = new Button();
            btnShuffle = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "MusicList";
            // 
            // lbxMusic
            // 
            lbxMusic.FormattingEnabled = true;
            lbxMusic.ItemHeight = 15;
            lbxMusic.Location = new Point(12, 27);
            lbxMusic.Name = "lbxMusic";
            lbxMusic.Size = new Size(364, 244);
            lbxMusic.TabIndex = 1;
            // 
            // txtCurMusic
            // 
            txtCurMusic.Location = new Point(12, 277);
            txtCurMusic.Name = "txtCurMusic";
            txtCurMusic.Size = new Size(308, 23);
            txtCurMusic.TabIndex = 2;
            // 
            // btnSetting
            // 
            btnSetting.Location = new Point(326, 277);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(50, 23);
            btnSetting.TabIndex = 3;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(139, 306);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 4;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(220, 306);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(301, 306);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(75, 23);
            btnShuffle.TabIndex = 6;
            btnShuffle.Text = "Shuffle";
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += btnShuffle_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 306);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // frmPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 343);
            Controls.Add(comboBox1);
            Controls.Add(btnShuffle);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Controls.Add(btnSetting);
            Controls.Add(txtCurMusic);
            Controls.Add(lbxMusic);
            Controls.Add(label1);
            Name = "frmPlayer";
            Text = "frmPlayer";
            Load += frmPlayer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbxMusic;
        private TextBox txtCurMusic;
        private Button btnSetting;
        private Button btnPlay;
        private Button btnStop;
        private Button btnShuffle;
        private ComboBox comboBox1;
    }
}