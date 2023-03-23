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
    public partial class FNewUser : Form
    {
        private DaoUser daoUser = new DaoUser();
        public FNewUser()
        {
            InitializeComponent();
            this.btnValider.Click += BtnValider_Click;
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if(this.tbNom.Text!="" && this.tbPrenom.Text!="" && this.tbMdp.Text != "")
            {
                User user = new User(this.tbNom.Text,this.tbPrenom.Text,this.tbMdp.Text,false);
                daoUser.Add(user);
                this.Close();
            }
        }
    }
}
