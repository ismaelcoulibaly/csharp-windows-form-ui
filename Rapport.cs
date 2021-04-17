using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intra_inf1034
{
    public partial class Rapport : Form
    {
        int courant, epargne;
        public Rapport(int soldeCourant, int soldeEpargne)
        {
            InitializeComponent();
            this.courant = soldeCourant;
            this.epargne = soldeEpargne;
        }

        private void banqueTitre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

      

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            bottomLabel form1 = new bottomLabel();
            form1.ShowDialog();

        }

        private void rapportEpargneTxtBox_TextChanged(object sender, EventArgs e)
        {
            rapportEpargneTxtBox.Text = "" + epargne + "CAD";

        }

        private void rapportCourantTextBox_TextChanged(object sender, EventArgs e)
        {
           
                rapportCourantTextBox.Text = "" + courant + "CAD";
            
        }
    }
}
