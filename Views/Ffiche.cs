using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class Ffiche : Form
    {
        private string identity;
        private Eleve eleve;
        public Ffiche(string identity, Eleve eleve)
        {
            InitializeComponent();
            this.identity = identity;
            this.lbluser.Text = this.identity;
            this.eleve = eleve;
            this.nom.Text = eleve.Nom;
            this.prenom.Text = eleve.Prenom;
            this.mail.Text = eleve.Mail;
            this.tel.Text = eleve.Telephone;


        }
    }
}
