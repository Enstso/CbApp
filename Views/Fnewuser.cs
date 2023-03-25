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
            if (this.tbNom.Text != "" && this.tbPrenom.Text != "" && this.tbMdp.Text != "")
            {
                if (this.tbMdp.Text == this.tbVerif.Text)
                {
                    string msg = "Whitehat";
                    msg = msg + this.tbMdp.Text;
                    msg = Security.GetHash(msg);
                    User user = new User(this.tbNom.Text, this.tbPrenom.Text, msg, false);
                    daoUser.Add(user);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Les mots de passes sont différents.");
                }
            }
        }

        private void FNewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
