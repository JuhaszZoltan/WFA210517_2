using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_03
{
    public partial class FrmSzinezo : Form
    {
        readonly static Random rnd = new Random();
        readonly Color _originalBackColor;


        public FrmSzinezo()
        {
            InitializeComponent();

            _originalBackColor = this.BackColor;

            //pb1.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //pb2.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //pb3.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            //pb4.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            //pb1.Click += Pb_Click;
            //pb2.Click += Pb_Click;
            //pb3.Click += Pb_Click;
            //pb4.Click += Pb_Click;
            
            foreach (object control in this.Controls)
            {
                if (control is PictureBox)
                {
                    (control as PictureBox).BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    (control as PictureBox).Click += Pb_Click;
                }
            }

        }

        //is & as: egy példány és típus között
        //is: "x példány y osztálynak lehetne-e példánya? => igaz/hamis
        //as: "x típust kezeld úgy, mint y osztély példányát" -> konkrét típusú példány;

        private void Pb_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox) this.BackColor = (sender as PictureBox).BackColor;
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAlaphelyzet_Click(object sender, EventArgs e)
        {
            this.BackColor = _originalBackColor;
        }
    }
}
