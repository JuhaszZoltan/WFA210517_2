using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_11
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnAdatbevitel_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(tbNev.Text) && int.TryParse(tbPontszam.Text, out _))
            {
                var diak = new Diak()
                {
                    Nev = tbNev.Text,
                    Pontszam = int.Parse(tbPontszam.Text)
                };

                //RAM
                Program.diakok.Add(diak);
                //GUI
                AddRtbRow(diak);
            }
            else
            {
                MessageBox.Show(
                    caption: "HIBA",
                    text: "valami nem stimmel",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
        }

        private void btnAtlagpontszam_Click(object sender, EventArgs e)
        {
            float sum = 0;
            foreach (var diak in Program.diakok)
                sum += diak.Pontszam;
            float avg = sum / Program.diakok.Count;

            MessageBox.Show(
                caption: "ÁTLAGPONTSZÁM",
                text: string.Format("{0:0.00}", avg));
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sw = new StreamWriter(@"..\..\Resources\pontszamok.txt", false, Encoding.UTF8);

            foreach (var diak in Program.diakok)
                //HDD
                sw.WriteLine($"{diak.Nev};{diak.Pontszam}");
            sw.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var sr = new StreamReader(@"..\..\Resources\pontszamok.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine().Split(';');

                var diak = new Diak() 
                { 
                    Nev = sor[0],
                    Pontszam = int.Parse(sor[1]),
                };

                //RAM
                Program.diakok.Add(diak);
                //GUI
                AddRtbRow(diak);
            }
            sr.Close();
        }


        private void AddRtbRow(Diak d)
        {
            rtbDiakok.Text += string.Format("{0, -22} {1, 3}\n", d.Nev, d.Pontszam);
        }
    }
}
