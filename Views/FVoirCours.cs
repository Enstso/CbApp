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
    public partial class FVoirCours : Form
    {
        private DaoEleve daoEleve = new DaoEleve();
        private DaoParticipe daoParticipe = new DaoParticipe();
        private string identity;
        public FVoirCours(int idCours,bool admin,string identity)
        {
            InitializeComponent();
            if (admin == false)
            {
                this.btnAjouter.Enabled = false;
                this.btnAjouter.Visible = false;

                this.btnRafraichir.Enabled = false;
                this.btnRafraichir.Visible = false;

                this.btnSupprimer.Enabled = false;
                this.btnSupprimer.Visible = false;
            }
            this.tbIdCours.Text = idCours.ToString();
            this.load(daoEleve.GetElevesByCours(idCours));
            this.btnAjouter.Click += BtnAjouter_Click;
            this.btnSupprimer.Click += BtnSupprimer_Click;
            this.btnRafraichir.Click += BtnRafraichir_Click;
            this.identity = identity;
            this.lbluser.Text = this.identity;
            this.btneleve.Click += Btneleve_Click;
        }

        private void Btneleve_Click(object sender, EventArgs e)
        {
            try { 
            Eleve eleve=(Eleve)lbEleves.SelectedItem;
            Ffiche ffiche = new Ffiche(this.identity,eleve);
            ffiche.Show();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnRafraichir_Click(object sender, EventArgs e)
        {
            this.load(daoEleve.GetElevesByCours(Convert.ToInt32(tbIdCours.Text)));
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (lbEleves.SelectedIndex != -1)
            {
                Eleve eleve = (Eleve)lbEleves.SelectedItem;
                int idEleve = eleve.Id;
                int idCours = Convert.ToInt32(tbIdCours.Text);
                daoParticipe.SupprimerParticipation(idCours,idEleve);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            int idCours = Convert.ToInt32(tbIdCours.Text);
            FNewParticipe fNewParticipe = new FNewParticipe(idCours);
            fNewParticipe.Show();
        }

        public void load(List<Eleve> eleves)
        {
            lbEleves.Items.Clear();
            foreach(Eleve e in eleves)
            {
                lbEleves.Items.Add(e);
            }
        }


    }
}
