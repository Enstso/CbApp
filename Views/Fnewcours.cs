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
    public partial class FNewCours : Form
    {
        DaoCours daoCours = new DaoCours();
        DaoUser daoUser = new DaoUser();

        public FNewCours()
        {
            InitializeComponent();
            this.Text = "Création Cours";
            this.tbId.Visible = false;
            this.tbProf.Visible = false;
            this.loadComboBox();
            this.btnValider.Click += BtnValider_Click;
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if(this.tbNom.Text != "" && this.cbProf.SelectedIndex != -1 && this.dtpDate.Value != null)
            {
                User user = (User)this.cbProf.SelectedItem;
                Cours cours = new Cours(user,this.dtpDate.Value, this.tbNom.Text);
                daoCours.Add(cours);
                this.Close();
            }
            else { MessageBox.Show("Veuillez Remplir tous les champs !"); }
        }

        //SURCHARGE
        public FNewCours(Cours cours)
        {
            InitializeComponent();
            this.Text = "Modifier Cours";
            User user = cours.User;
            this.tbUId.Text = user.Id.ToString();
            this.tbUNom.Text = user.Nom;
            this.tbUPrenom.Text = user.Prenom;
            this.tbUMdp.Text = user.Mdp;
            this.tbUAdmin.Text = user.Admin.ToString();
            this.tbNom.Text = cours.Nom;
            this.cbProf.Visible = false;
            this.tbProf.Text = cours.User.Nom;
            this.tbProf.Enabled = false;
            this.loadComboBox();
            this.tbId.Visible = false;
            this.tbId.Text = cours.Id.ToString();
            this.dtpDate.Value = cours.Date;
            this.btnValider.Click += BtnValider_Click1;
        }

        private void BtnValider_Click1(object sender, EventArgs e)
        {
            if (this.tbNom.Text!="" && this.dtpDate.Value!=null)
            {
                User user = new User(Convert.ToInt32(tbUId.Text),tbUNom.Text,tbUPrenom.Text,tbUMdp.Text,Convert.ToBoolean(tbUAdmin.Text));
                Cours cours = new Cours(Convert.ToInt32(this.tbId.Text),user , this.tbNom.Text, this.dtpDate.Value);
                daoCours.Update(cours);
                this.Close();
            }
        }

        public void loadComboBox()
        {
            List<User> users = daoUser.GetAll();
            foreach (User u in users)
            {
                this.cbProf.Items.Add(u);
            }
        }
    }
}
