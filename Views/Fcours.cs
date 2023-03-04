﻿using System;
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
    public partial class FCours : Form
    {
        DaoCours daoCours = new DaoCours();
        DaoEleve daoEleve = new DaoEleve();
        public FCours()
        {
            InitializeComponent();
            this.load();
            this.btnAjouter.Click += BtnAjouter_Click;
            this.btnModifier.Click += BtnModifier_Click;
            this.btnSupprimer.Click += BtnSupprimer_Click;
            this.btnCharger.Click += BtnCharger_Click;
            this.btnVoirEleves.Click += BtnVoirEleves_Click;
        }

        private void BtnVoirEleves_Click(object sender, EventArgs e)
        {
            if (lbCours.SelectedIndex != -1)
            {
                Cours cours = (Cours)this.lbCours.SelectedItem;
                int id = cours.Id;
                FVoirCours fVoirCours = new FVoirCours(id);
                fVoirCours.Show();
            }
        }

        private void BtnCharger_Click(object sender, EventArgs e)
        {
            this.load();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (lbCours.SelectedIndex != -1)
            {
                Cours cours = (Cours)this.lbCours.SelectedItem;
                int id = cours.Id;
                daoCours.delete(id);
            }
            this.load();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (lbCours.SelectedIndex != -1)
            {
                Cours cours = (Cours)this.lbCours.SelectedItem;
                FNewCours fNewCours = new FNewCours(cours);
                fNewCours.Show();
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            FNewCours fNewCours = new FNewCours();
            fNewCours.Show();
        }

        public void load()
        {
            lbCours.Items.Clear();
            List<Cours> cours = daoCours.GetAll();
            foreach (Cours c in cours)
            {
                lbCours.Items.Add(c);
            }
        }

    }
}
