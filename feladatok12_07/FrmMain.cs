using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_07
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnDobas_Click(object sender, EventArgs e)
        {
            //TODO:
            //ha minimumot(1) dob a kocka, akkor legyen piros
            //ha maximumot(6) dob, akkor legyen zöld.

            rtbDobasok.Clear();

            try
            {
                int db = int.Parse(tbDB.Text);
                //var dobasok = new int[db];

                for (int i = 0; i < db; i++)
                {
                    int dobas = rnd.Next(1, 7);
                    //dobasok[i] = dobas;
                    rtbDobasok.Text += $"{dobas} ";
                }
               
                for (int i = 0; i < db*2; i += 2)
                {
                    rtbDobasok.Select(i, 1);

                    if(rtbDobasok.SelectedText == "1")
                    {
                        rtbDobasok.SelectionColor = Color.Red;
                    }
                    else if (rtbDobasok.SelectedText == "6")
                    {
                        rtbDobasok.SelectionColor = Color.Green;
                    }
                }

                /*
                for (int i = 0; i < dobasok.Length; i++)
                {
                    if (dobasok[i] == 1)
                    {
                        rtbDobasok.Select(i * 2, 1);
                        rtbDobasok.SelectionColor = Color.Red;
                    }
                    else if (dobasok[i] == 6)
                    {
                        rtbDobasok.Select(i * 2, 1);
                        rtbDobasok.SelectionColor = Color.Green;
                    }
                }
                */

                    
            }
            catch (Exception)
            {
                MessageBox.Show("számot írj be pls!");
            }
        }
    }
}
