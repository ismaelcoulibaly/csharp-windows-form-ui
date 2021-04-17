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
    public partial class bottomLabel : Form
    {
        public bottomLabel()
        {
            InitializeComponent();
        }

        int compteCourant = 200;//il s'agit des valeurs de depart de l'enonce
        int compteEpargne = 100;//on initialise les deux comptes a ces valeurs la

        private void compteCourantTextbox_TextChanged(object sender, EventArgs e)
        {
            compteCourantTextbox.Text = "" + compteCourant + "CAD";

        }
        private void compteEpargneTextbox_TextChanged(object sender, EventArgs e)
        {
            compteEpargneTextbox.Text = "" + compteEpargne + "CAD";

        }


        private void deposerBtn_Click(object sender, EventArgs e)
        {

            
            if (montant_textbox == null || montant_textbox.Text == Convert.ToString(0))
            {
                MessageBox.Show("Le montant entre est invalide ! Veuillez reesayer.");
                montant_textbox.Focus();
                    
            }
            if(compteCourant == -5 || compteEpargne == -5)
            {
                MessageBox.Show(" vous avez retiré tout l’argent de votre compte et vous devez 5$ à la banque");
            }

            if (courantCheckbox.Checked && compteCourant+Int32.Parse(montant_textbox.Text)>-5)
            {
                compteCourant += Int32.Parse(montant_textbox.Text);
                compteCourantTextbox.Text = "" + compteCourant + "CAD";
                extraLabel.Hide();
            }


            else if (epargneCheckbox.Checked && compteEpargne + Int32.Parse(montant_textbox.Text) > -5)
            {
                compteEpargne += Int32.Parse(montant_textbox.Text);
                compteEpargneTextbox.Text = "" + compteEpargne + "CAD";
                extraLabel.Hide();
                accepterBtn.Hide();
                refuserBtn.Hide();

            }

            if (!courantCheckbox.Checked && !epargneCheckbox.Checked)
            {
                MessageBox.Show("Vous devez choisir sur quel compte vous voulez faire une operation");

            }


        }

        private void retirerBtn_Click(object sender, EventArgs e)
        {
            
            if (montant_textbox == null || montant_textbox.Text == Convert.ToString(0))
            {
                MessageBox.Show("Le montant entre est invalide ! Veuillez reesayer.");
                montant_textbox.Focus();

            }

            if (compteCourant == -5 || compteEpargne == -5)
            {
                MessageBox.Show(" vous avez retiré tout l’argent de votre compte et vous devez 5$ à la banque");
            }

            if(courantCheckbox.Checked && compteCourant - Int32.Parse(montant_textbox.Text) > -5)
            {
                courantCheckbox.Focus();
                compteCourant -= Int32.Parse(montant_textbox.Text);
                compteCourantTextbox.Text = "" + compteCourant + "CAD";
                extraLabel.Hide();
            }

            else if (epargneCheckbox.Checked && compteEpargne - Int32.Parse(montant_textbox.Text) > -5) {

                epargneCheckbox.Focus();
                double frais = 0.02 * Convert.ToDouble(montant_textbox.Text);
                double total = frais + compteEpargne;
                if(total < -5)
                {
                    MessageBox.Show("Choississez un montant inferieur !");
                }
                compteEpargne -= Int32.Parse(montant_textbox.Text);
                compteEpargneTextbox.Text = "" + compteEpargne + "CAD";
                extraLabel.Show();//les buttons pour accepter et refuser s'affichent quand l'utilisateur choisit de retirer
                accepterBtn.Show();//de l'epargne
                refuserBtn.Show();//le label s'affiche avec les boutons
            }

            if (!courantCheckbox.Checked && !epargneCheckbox.Checked)
            {
                MessageBox.Show("Vous devez choisir sur quel compte vous voulez faire une operation");
                
            }
        }

        private void courantCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(courantCheckbox.Checked) {
               
                epargneCheckbox.Checked = false;
                courantCheckbox.Focus();
                extraLabel.Hide();
                accepterBtn.Hide();
                refuserBtn.Hide();

            }

        }

        private void epargneCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (epargneCheckbox.Checked) {
                courantCheckbox.Checked = false;
                epargneCheckbox.Focus();
                extraLabel.Show();
                accepterBtn.Show();
                refuserBtn.Show();
            }

        }

        private void extraLabel_Click(object sender, EventArgs e)
        {

        }

       

        private void accepterBtn_Click(object sender, EventArgs e)
        {
            if (epargneCheckbox.Checked)

                epargneCheckbox.Focus();
                double frais = 0.02 * Convert.ToDouble(montant_textbox.Text);
                double total = compteEpargne + frais;
            if (total < -5)
            {
                MessageBox.Show("Choississez un montant inferieur !");
            }
            else
            {
                compteEpargne -= (int)total;
                compteEpargneTextbox.Text = "" + compteEpargne + "CAD";
                extraLabel.Hide();//les buttons pour accepter et refuser s'affichent quand l'utilisateur choisit de retirer
                accepterBtn.Hide();//de l'epargne
                refuserBtn.Hide();//le label s'affiche avec les boutons
            
            }
        }

        private void refuserBtn_Click(object sender, EventArgs e)
        {
            if (epargneCheckbox.Checked)
            {
                extraLabel.Hide();
                accepterBtn.Hide();
                refuserBtn.Hide();
            }
        }

        private void rapportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rapport rapportForm = new Rapport(compteCourant,compteEpargne);
            rapportForm.ShowDialog();
        }

       
    }
}
