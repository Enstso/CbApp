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
        DaoEleve daoEleve = new DaoEleve();
        DaoParticipe daoParticipe = new DaoParticipe();
        public FVoirCours(int idCours,bool admin)
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
