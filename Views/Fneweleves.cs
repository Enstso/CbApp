using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Dao;

namespace Views
{
    public partial class FNewEleves : Form
    {
        private DaoEleve daoEleve = new DaoEleve();

        public FNewEleves()
        {
            InitializeComponent();
            this.tbId.Visible = false;
            this.tbId.Enabled = false;

            this.btnValider.Click += BtnValider_Click;
            this.Text = "Ajouter";
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (this.tbNom.Text != "" && this.tbPrenom.Text != "" && this.tbMail.Text != "" && this.tbTelephone.Text != "")
            {
                Eleve eleve = new Eleve(this.tbNom.Text, this.tbPrenom.Text, this.tbMail.Text, this.tbTelephone.Text);
                daoEleve.Add(eleve);
            }
            this.Close();
        }

        // Surcharge
        public FNewEleves(Eleve eleve)
        {
            InitializeComponent();
            
            this.tbNom.Text = eleve.Nom;
            this.tbPrenom.Text = eleve.Prenom;
            this.tbMail.Text = eleve.Mail;
            this.tbTelephone.Text = eleve.Telephone;
            this.Text = "Modifier";
            this.btnValider.Click += BtnValiderModif_Click; ;
        }

        private void BtnValiderModif_Click(object sender, EventArgs e)
        {
            if (this.tbNom.Text != "" && this.tbPrenom.Text != "" && this.tbMail.Text != "" && this.tbTelephone.Text != "")
            {
                Eleve eleve = new Eleve(Convert.ToInt32(this.tbId.Text),this.tbNom.Text, this.tbPrenom.Text, this.tbMail.Text, this.tbTelephone.Text);
                daoEleve.Update(eleve);
            }
            this.Close();
        }
    }
}
