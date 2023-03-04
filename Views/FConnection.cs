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
        DaoUser daoUser = new DaoUser();
        public FConnection()
        {
            InitializeComponent();
            this.btnConnect.Click += BtnConnect_Click;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if(this.tbMdp.Text != "" && this.tbPrenom.Text != "")
            {
                if (daoUser.Authentification(this.tbPrenom.Text,this.tbMdp.Text)) {
                    if (daoUser.isAdmin(this.tbPrenom.Text, this.tbMdp.Text))
                    {
                        FMainAdmin fmainAdmin = new FMainAdmin();
                        fmainAdmin.Show();
                        this.Opacity = 0;
                    }
                    else
                    {
                        int id = daoUser.GetIdByNom(this.tbPrenom.Text, this.tbMdp.Text);
                        FCours fmain = new FCours(false,id);
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
    }
}
