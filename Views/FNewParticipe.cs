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
    public partial class FNewParticipe : Form
    {
        DaoEleve daoEleve = new DaoEleve();
        DaoParticipe daoParticipe = new DaoParticipe();

        public FNewParticipe(int idCours)
        {
            InitializeComponent();
            this.tbIdCours.Text = idCours.ToString();
            this.loadComboBox();
            this.btnValider.Click += BtnValider_Click;
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (this.cbEleve.SelectedIndex != -1)
            {
                Eleve eleve = (Eleve)cbEleve.SelectedItem;
                int idEleve = eleve.Id;
                int idCours = Convert.ToInt32(this.tbIdCours.Text);
                daoParticipe.AjouterParticipation(idCours,idEleve);
                this.Close();
            }
        }

        public void loadComboBox()
        {
            List<Eleve> eleves = daoEleve.GetElevesNeParticipantPasAuCours(Convert.ToInt32(this.tbIdCours.Text));
            foreach(Eleve e in eleves)
            {
                cbEleve.Items.Add(e);
            }
        }
    }
}
