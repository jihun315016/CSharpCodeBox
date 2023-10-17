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
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void frmPlayer_Load(object sender, EventArgs e)
        {
            btnSetting.BackgroundImage = Properties.Resources.Setting;
            btnSetting.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }
    }
}
