using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Model;

namespace Views
{
    public partial class FEleves : Form
    {
        private DaoCours daoCours = new DaoCours();
        private DaoEleve daoEleve = new DaoEleve();
        private string identity;
        public FEleves(string identity)
        {
            InitializeComponent();
            this.load();
            this.btnCharger.Click += BtnCharger_Click;
            this.btnAjouter.Click += BtnAjouter_Click;
            this.btnSupprimer.Click += BtnSupprimer_Click;
            this.btnModifier.Click += BtnModifier_Click;
            this.btnVoirCours.Click += BtnVoirCours_Click;
            this.identity = identity;
            this.lbluser.Text = this.identity;
            this.btneleve.Click += Btneleve_Click;
        }

        private void Btneleve_Click(object sender, EventArgs e)
        {
            try { 
            Eleve eleve = (Eleve)lbEleves.SelectedItem;
            Ffiche ffiche = new Ffiche(this.identity, eleve);
            ffiche.Show();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message ); }
        }

        private void BtnVoirCours_Click(object sender, EventArgs e)
        {
            try
            {
                Eleve eleve = (Eleve)lbEleves.SelectedItem;
                int id = eleve.Id;
                List<Cours> cours = daoCours.GetCoursByEleve(id);
                FVoir fVoir = new FVoir(cours, this.identity);
                fVoir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Eleve eleve = (Eleve)this.lbEleves.SelectedItem;
                FNewEleves fNewEleves = new FNewEleves(eleve);
                fNewEleves.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                Eleve eleve = (Eleve)this.lbEleves.SelectedItem;
                int id = eleve.Id;
                daoEleve.delete(id);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            this.load();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                FNewEleves fNewEleves = new FNewEleves();
                fNewEleves.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void BtnCharger_Click(object sender, EventArgs e)
        {
            this.load();
        }

        private void load()
        {
            lbEleves.Items.Clear();
            List<Eleve> eleves = daoEleve.GetAll();
            foreach (Eleve e in eleves)
            {
                lbEleves.Items.Add(e);

            }
        }

    }
}
