using System;
using System.Drawing;
using System.Windows.Forms;

namespace feladatok12_04
{
    public partial class FrmMain : Form
    {


        EredetiTulajdonsagok ep;

        public FrmMain()
        {
            InitializeComponent();

            ep = new EredetiTulajdonsagok()
            {
                BackColor = lblSzoveg.BackColor,
                ForeColor = lblSzoveg.ForeColor,
                Text = lblSzoveg.Text,
                Font = lblSzoveg.Font,
                TextAlign = lblSzoveg.TextAlign,
            };

        }

        private void btnKekBetu_Click(object sender, EventArgs e)
        {
            lblSzoveg.ForeColor = Color.Blue;
        }

        private void btnFeherHatter_Click(object sender, EventArgs e)
        {
            lblSzoveg.BackColor = Color.White;
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            lblSzoveg.Text = null;
        }

        private void btnBK_Click(object sender, EventArgs e)
        {
            lblSzoveg.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void btnKK_Click(object sender, EventArgs e)
        {
            lblSzoveg.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnJK_Click(object sender, EventArgs e)
        {
            lblSzoveg.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnNagyBetus_Click(object sender, EventArgs e)
        {
            lblSzoveg.Text = lblSzoveg.Text.ToUpper();
        }

        private void btnNagyitas_Click(object sender, EventArgs e)
        {
            //string fn = lblSzoveg.Font.Name;
            float fs = lblSzoveg.Font.Size;

            lblSzoveg.Font = new Font(
                familyName: lblSzoveg.Font.Name, 
                emSize: ++fs);
        }

        private void btnKicsinyites_Click(object sender, EventArgs e)
        {
            //float fs = lblSzoveg.Font.Size <= 1 ? lblSzoveg.Font.Size : lblSzoveg.Font.Size - 1;

            float fs = lblSzoveg.Font.Size;
            lblSzoveg.Font = new Font(
                familyName: lblSzoveg.Font.Name,
                emSize: fs <= 1 ? fs : --fs);
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlap_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            
            lblSzoveg.Text = ep.Text;
            lblSzoveg.TextAlign = ep.TextAlign;
            lblSzoveg.BackColor = ep.BackColor;
            lblSzoveg.ForeColor = ep.ForeColor;
            lblSzoveg.Font = ep.Font;
        }
    }

    struct EredetiTulajdonsagok
    {
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public Font Font { get; set; }
        public ContentAlignment TextAlign { get; set; }
        public string Text { get; set; }
    }


}
