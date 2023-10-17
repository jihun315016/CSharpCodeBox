using MusicPlayer.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Forms
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            Init();
        }

        void Init()
        {
            // 속성 확인을 더 쉽게 하기 위해 소스에서 속성 지정
            this.IsMdiContainer = true;
            this.MainMenuStrip = menuStrip1;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            menuStrip1.Visible = false;

            // 이건 소스에서 하면 컨트롤 배치가 불편해서 디자이너에서 지정
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

            ccBtnAllListManage.FormName = "frmAllListManage";
            ccBtnSelectPlayList.FormName = "frmSelectPlayList";
            ccBtnDownloadMusic.FormName = "frmDownloadMusic";

            ccBtnAllListManage.Click += OpenCreateForm;
            ccBtnSelectPlayList.OpenForm += OpenCreateForm;
            ccBtnDownloadMusic.OpenForm += OpenCreateForm;
        }

        private void OpenCreateForm(object sender, EventArgs e)
        {
            ccButton btn = sender as ccButton;
            string appNamespace = this.GetType().Namespace; // MusicPlayer.Forms

            if (btn is null) return;

            Type type = Type.GetType($"{appNamespace}.{btn.FormName}");
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == type)
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = (Form)Activator.CreateInstance(type);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
