using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private int id;
        private string nom;
        private string prenom;
        private string mdp;
        private bool admin;

        public User(int id, string nom,string prenom, string mdp, bool admin)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mdp = mdp;
            this.admin = admin;
        }

        public User(string nom,string prenom, string mdp, bool admin)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mdp = mdp;
            this.admin = admin;
        }

        public int Id { get { return this.id; } }
        public string Nom { get { return this.nom; } set { this.nom = value; } }
        public string Prenom { get { return this.prenom; } set { this.prenom = value; } }
        public string Mdp { get { return this.mdp; } set { this.mdp = value; } }
        public bool Admin { get { return this.admin; } set { this.Admin = value; } }

        public override string ToString()
        {
            return string.Format("User {0} {1}", this.nom,this.prenom);
        }

    }
}
