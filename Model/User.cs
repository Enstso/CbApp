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
        private string identifiant;
        private string mdp;
        private bool admin;

        public User(int id, string nom,string identifiant, string mdp, bool admin)
        {
            this.id = id;
            this.nom = nom;
            this.identifiant = identifiant;
            this.mdp = mdp;
            this.admin = admin;
        }

        public User(string nom,string identifiant, string mdp, bool admin)
        {
            this.nom = nom;
            this.identifiant = identifiant;
            this.mdp = mdp;
            this.admin = admin;
        }

        public int Id { get { return this.id; } }
        public string Nom { get { return this.nom; } set { this.nom = value; } }
        public string Identifiant { get { return this.identifiant; } set { this.identifiant = value; } }
        public string Mdp { get { return this.mdp; } set { this.mdp = value; } }
        public bool Admin { get { return this.admin; } }

        public override string ToString()
        {
            return string.Format("{0}", this.nom);
        }

    }
}
