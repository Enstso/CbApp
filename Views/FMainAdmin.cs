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
namespace Views
{
    public partial class FMainAdmin : Form
    {
        private string identity;
        public FMainAdmin(string identity)
        {
            InitializeComponent();
            this.identity = identity;
            this.lbluser.Text =this.identity;
            this.FormClosed += FMainAdmin_FormClosed;
            this.btnUser.Click += BtnUser_Click;
            this.btnVoirEleves.Click += BtnVoirEleves_Click;
            this.btnVoirCours.Click += BtnVoirCours_Click;
            
        }

        private void BtnVoirCours_Click(object sender, EventArgs e)
        {
            
            FCours fCours = new FCours(true,0,this.identity);
            fCours.Show();
        }

        private void BtnVoirEleves_Click(object sender, EventArgs e)
        {
            FEleves fEleves = new FEleves(this.identity);
            fEleves.Show();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            FUser fUser = new FUser(this.identity);
            fUser.ShowDialog();
        }

        private void FMainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
