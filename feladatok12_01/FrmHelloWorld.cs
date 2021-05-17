using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_01
{
    public partial class FrmHelloWorld : Form
    {

        static readonly Random rnd = new Random();

        public FrmHelloWorld()
        {
            InitializeComponent();
        }

        private void LblHW_Click(object sender, EventArgs e)
        {
            //ez volt az eredeti feladat:
            //MessageBox.Show("Hello World!");

            var dr = MessageBox.Show(
                text: "Szeretnéd megváltoztatni a szöveg háttérszínét?",
                caption: "kérdés",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Question);

            if (dr is DialogResult.Yes)
            {
                lblHelloWorld.BackColor = Color.FromArgb(
                    red: rnd.Next(256),
                    green: rnd.Next(256),
                    blue: rnd.Next(256));
            }
            
            //if (MessageBox.Show(
            //    "Szeretnéd megváltoztatni a szöveg háttérszínét?",
            //    "Színváltás", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            //    is DialogResult.Yes)
            //    lblHelloWorld.BackColor = Color.FromArgb(
            //        rnd.Next(256), rnd.Next(256), rnd.Next(256));
            
        }
    }
}
