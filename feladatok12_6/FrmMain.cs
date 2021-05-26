using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_6
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMegallapit_Click(object sender, EventArgs e)
        {

            /*
            int also = int.Parse(tbAlso.Text);
            int felso = int.Parse(tbFelso.Text);
            int szam = int.Parse(tbSzam.Text);

            if (also <= szam && szam <= felso)
                lblEredmeny.Text = "Benne van az intervallumban";
            else lblEredmeny.Text = "Nincs benne az intervallumban";
            */

            /*
            lblEredmeny.Text = 
                int.Parse(tbAlso.Text) <= int.Parse(tbSzam.Text) 
                && int.Parse(tbSzam.Text) <= int.Parse(tbFelso.Text) 
                ? "Benne van az intervallumba" : "Nincs benne az intervallumban";
            */

            /*
            int also = 0;
            int felso = 0; 
            int szam = 0;

            //azt írjuk ide, amit a user potenciálisan elronthat
            try
            {
                also = int.Parse(tbAlso.Text);
                felso = int.Parse(tbFelso.Text);
                szam = int.Parse(tbSzam.Text);
            }
            //ez a blokk akkor fut le, ha a 'try' részben valamilyen hiba volt
            catch (Exception exception)
            {
                if(exception is FormatException)
                {
                    MessageBox.Show(
                        "Valamelyik adatmező értéke nem szám",
                        "HIBA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    
                    tbAlso.Text = null;
                    tbFelso.Text = null;
                    tbSzam.Text = null;

                    return;
                }
                if (exception is OutOfMemoryException)
                {
                    //valamilyen más hibaüzenet...
                }
                else return;
            }
            //ez a blokk MINDENFÉLEKÉPPEN lefut (ha volt hiba, ha nem, ha kilépett a catch, ha nem)
            finally
            {
                this.BackColor = Color.Red;
            }

            if (also <= szam && szam <= felso)
                lblEredmeny.Text = "Benne van az intervallumban";
            else lblEredmeny.Text = "Nincs benne az intervallumban";
            */


            string hibaLog = "";
            bool ok = true;


            if (!int.TryParse(tbAlso.Text, out int also))
            {
                lblAlso.ForeColor = Color.Red;
                hibaLog += "A 'alsó határ' adatmező értéke nem szám\n";
                tbAlso.Text = null;
                ok = false;
            }

            if (!int.TryParse(tbFelso.Text, out int felso))
            {
                lblFelso.ForeColor = Color.Red;
                hibaLog += "A 'felső határ' adatmező értéke nem szám\n";
                tbFelso.Text = null;
                ok = false;
            }

            if (!int.TryParse(tbSzam.Text, out int szam))
            {
                lblMegadottSzam.ForeColor = Color.Red;
                hibaLog += "A 'megadott szám' adatmező értéke nem szám\n";
                tbSzam.Text = null;
                ok = false;
            }

            if(ok)
            {
                if (also <= szam && szam <= felso)
                    lblEredmeny.Text = "Benne van az intervallumban";
                else lblEredmeny.Text = "Nincs benne az intervallumban";
            }
            else
            {
                MessageBox.Show(
                        $"{hibaLog}",
                        "HIBA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                lblAlso.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
                lblFelso.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
                lblEredmeny.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }
    }
}
