using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Forms
{
    public partial class frmDownloadMusic : Form
    {
        public frmDownloadMusic()
        {
            InitializeComponent();
        }

        private void frmDownloadMusic_Load(object sender, EventArgs e)
        {
            lblTitle.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (lblTitle.Text.Equals(string.Empty))
            {
                lblTitle.Text = string.Empty;
            }
        }
    }
}
