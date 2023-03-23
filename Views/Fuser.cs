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
    public partial class FUser : Form
    {
        private DaoUser daoUser = new DaoUser();
        private DaoCours daoCours = new DaoCours();
        private string identity;
        public FUser(string identity)
        {
            InitializeComponent();
            
            this.Load();
            this.btnSuppimerUser.Click += BtnSuppimerUser_Click;
            this.btnAjouterUser.Click += BtnAjouterUser_Click;
            this.btnRafraichir.Click += BtnRafraichir_Click;
            this.btnVoirCours.Click += BtnVoirCours_Click;
            this.identity = identity;
            this.lbluser.Text = identity;
        }

        private void BtnVoirCours_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex != -1)
            {
                User user = (User)this.lbUsers.SelectedItem;
                int id = user.Id;
                FVoir fVoir = new FVoir(daoCours.GetCoursByUser(id),this.identity);
                fVoir.Show();
            }
        }

        private void BtnRafraichir_Click(object sender, EventArgs e)
        {
            this.Load();
        }

        private void BtnAjouterUser_Click(object sender, EventArgs e)
        {
            FNewUser Fuser = new FNewUser();
            Fuser.Show();
            this.Load();
        }

        private void BtnSuppimerUser_Click(object sender, EventArgs e)
        {
            if(lbUsers.SelectedIndex != -1)
            {
                User user = (User)this.lbUsers.SelectedItem;
                int id = user.Id;
                daoUser.Delete(id);
            }
            this.Load();
        }

        private void Load()
        {
            this.lbUsers.Items.Clear();
            List<User> users = daoUser.GetAll();
            foreach (User u in users)
            {
                lbUsers.Items.Add(u);
            }
        }
    }
}
