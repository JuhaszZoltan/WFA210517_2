using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok12_09
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnHozzaad_Click(object sender, EventArgs e) => 
            lbLista.Items.Add(tbInput.Text);

        private void BtnOsszesTorles_Click(object sender, EventArgs e) =>
            lbLista.Items.Clear();

        private void btnKijeloltTorles_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbLista.Items.Count; i++)
            {
                if(lbLista.SelectedItems.Contains(lbLista.Items[i]))
                {
                    lbLista.Items.RemoveAt(i);
                }
            }
            lbLista.SelectedItem = null;
        }
           
    }
}
