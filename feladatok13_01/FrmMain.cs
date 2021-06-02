using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok13_01
{
    public partial class FrmMain : Form
    {

        static Random rnd = new Random();
        Button[] gombok;
        int _megoldas;


        public FrmMain()
        {
            InitializeComponent();
            MyInitializer(64);
        }

        private void MyInitializer(int meret)
        {
            AutoSize = true;
            gombok = new Button[meret];
            _megoldas = rnd.Next(20) + 1;

            int torespont = (int)Math.Round(Math.Sqrt(meret));

            for (int i = 0; i < gombok.Length; i++)
            {
                gombok[i] = new Button()
                {
                    Text = $"{i + 1}",
                    Bounds = new Rectangle(
                        x: i % torespont * 100,
                        y: i / torespont * 100,
                        width: 100,
                        height: 100),
                };

                this.Controls.Add(gombok[i]);
                gombok[i].Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int tipp = int.Parse((sender as Button).Text);

            if (tipp == _megoldas)
            {
                MessageBox.Show("győztél!");
                Application.Restart();
            }
            else if(tipp > _megoldas)
            {
                for (int i = Array.IndexOf(gombok, sender as Button); i < gombok.Length; i++)
                {
                    gombok[i].Enabled = false;
                }
                MessageBox.Show("túl nagy!");
            }
            else
            {
                for (int i = 0; i <= Array.IndexOf(gombok, sender as Button); i++)
                {
                    gombok[i].Enabled = false;
                }
                MessageBox.Show("túl kicsi!"); 
            }
        }
    }
}
