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
    public partial class FConnection : Form
    {
        private DaoUser daoUser = new DaoUser();
        private User user;
        private string identity;

        public FConnection()
        {
            InitializeComponent();
            this.btnConnect.Click += BtnConnect_Click;


        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            this.user = daoUser.GetPerson(this.tbPrenom.Text);


            if (this.tbMdp.Text != "" && this.tbPrenom.Text != "")
            {
                string mdp = "Whitehat";
                mdp = mdp + this.tbMdp.Text;
                mdp = Security.GetHash(mdp);
                if (daoUser.Authentification(this.tbPrenom.Text, mdp))
                {
                    this.identity = this.user.Identity();
                    if (daoUser.IsAdmin(this.tbPrenom.Text, mdp))
                    {
                        FMainAdmin fmainAdmin = new FMainAdmin(this.identity);

                        fmainAdmin.Show();
                        this.Opacity = 0;
                    }
                    else
                    {
                        int id = daoUser.GetIdByNom(this.tbPrenom.Text, mdp);
                        FCours fmain = new FCours(false, id, this.identity);
                        this.user = daoUser.GetPerson(this.tbPrenom.Text);
                        fmain.Show();
                        this.Opacity = 0;
                    }
                }
                else
                {
                    
                    this.lblErreurConnection.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
        }
        public User GetUser
        {
            get
            {
                return this.user;
            }
        }

        private void cbmdp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmdp.Checked)
            {
                this.tbMdp.PasswordChar = '\0';
            }
            else
            {
                this.tbMdp.PasswordChar = '*';
            }
        }
    }


}
