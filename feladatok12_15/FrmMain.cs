using System;
using System.Drawing;
using System.Windows.Forms;

namespace feladatok12_15
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void TbKedvencSzo_TextChanged(object sender, EventArgs e)
        {
            tbKedvencSzo.BackColor =
                string.IsNullOrEmpty(tbKedvencSzo.Text) ?
                Color.White :
                Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void PbSmiley_MouseEnter(object sender, EventArgs e)
        {
            pbSmiley.Image = Properties.Resources.smiley_close;
        }

        private void pbSmiley_MouseLeave(object sender, EventArgs e)
        {
            pbSmiley.Image = Properties.Resources.smiley_open;
        }

        private void pbSmiley_Click(object sender, EventArgs e)
        {
            pbSmiley.Location = new Point(
                x: rnd.Next(panel.Width - pbSmiley.Width),
                y: rnd.Next(panel.Height - pbSmiley.Height));
        }

        private void btnTunjEl_Click(object sender, EventArgs e)
        {
            pbSmiley.Visible = false;
        }

        private void btnGyereVissza_Click(object sender, EventArgs e)
        {
            pbSmiley.Visible = true;
        }
    }
}
