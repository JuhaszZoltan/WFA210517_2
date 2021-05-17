using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_02
{
    public partial class FrmGombEventek : Form
    {

        readonly static Random rnd = new Random();

        readonly string _originalButtonText;
        readonly string _originalFormText;
        readonly Color _originalBackColor;


        public FrmGombEventek()
        {
            InitializeComponent();

            _originalBackColor = this.BackColor;      
            _originalFormText = this.Text;
            _originalButtonText = btnGomb.Text;

            btnGomb.MouseLeave += BtnGomb_MouseLeave;
        }

        private void BtnGomb_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = _originalBackColor;   
            this.Text = _originalFormText;
            btnGomb.Text = _originalButtonText;
        }

        private void BtnGomb_Click(object sender, EventArgs e)
        {
            btnGomb.Text = btnGomb.Text.ToUpper();
        }

        private void BtnGomb_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X:= {Cursor.Position.X}; Y:= {Cursor.Position.Y}";
        }
    }
}
