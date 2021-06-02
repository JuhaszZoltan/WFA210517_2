using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_13
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();

        private int _jatekosPont = 0;
        private int _gepPont = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        char[] lehetosegek = { 'k', 'p', 'o', };
        private void JatekosButton_Click(object sender, EventArgs e)
        {
            char g = lehetosegek[rnd.Next(lehetosegek.Length)];
            ColoringAIButton(g);

            char j = (sender as Button).Text.ToLower()[0];
            (sender as Button).BackColor = Color.Green;

            Kiertekeles(j, g);
        }

        private void Kiertekeles(char j, char g)
        {
            if (j == g)
            {
                MessageBox.Show(caption: "EREDMÉNY", text: "Döntetlen");
                ResetColor();
            }
            else if ((j == 'k' && g == 'o') || (j == 'p' && g == 'k') || (j == 'o' && g == 'p'))
            {
                MessageBox.Show(caption: "EREDMÉNY", text: "Győztél!");
                _jatekosPont++;
                ResetColor();
            }
            else
            {
                MessageBox.Show(caption: "EREDMÉNY", text: "A gép győzött!");
                _gepPont++;
                ResetColor();
            }

            lblJatekosPont.Text = $"{_jatekosPont} pont";
            lblGepPont.Text = $"{_gepPont} pont";
        }

        private void ColoringAIButton(char g)
        {
            switch (g)
            {
                case 'k': btnGepKo.BackColor = Color.Green; return;
                case 'p': btnGepPapir.BackColor = Color.Green; return;
                case 'o': btnGepOllo.BackColor = Color.Green; return;
            }
        }

        private void ResetColor()
        {
            foreach (var ctrl in this.Controls)
                if (ctrl is Button) (ctrl as Button).BackColor = Color.White;
        }
    }
}
