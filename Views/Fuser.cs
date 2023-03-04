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
        DaoUser daoUser = new DaoUser();
        DaoCours daoCours = new DaoCours();
        public FUser()
        {
            InitializeComponent();
            
            this.load();
            this.btnSuppimerUser.Click += BtnSuppimerUser_Click;
            this.btnAjouterUser.Click += BtnAjouterUser_Click;
            this.btnRafraichir.Click += BtnRafraichir_Click;
            this.btnVoirCours.Click += BtnVoirCours_Click;
        }

        private void BtnVoirCours_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex != -1)
            {
                User user = (User)this.lbUsers.SelectedItem;
                int id = user.Id;
                FVoir fVoir = new FVoir(daoCours.GetCoursByUser(id));
                fVoir.Show();
            }
        }

        private void BtnRafraichir_Click(object sender, EventArgs e)
        {
            this.load();
        }

        private void BtnAjouterUser_Click(object sender, EventArgs e)
        {
            FNewUser Fuser = new FNewUser();
            Fuser.Show();
            this.load();
        }

        private void BtnSuppimerUser_Click(object sender, EventArgs e)
        {
            if(lbUsers.SelectedIndex != -1)
            {
                User user = (User)this.lbUsers.SelectedItem;
                int id = user.Id;
                daoUser.delete(id);
            }
            this.load();
        }

        public void load()
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
