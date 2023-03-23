using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Eleve
    {
        private int id;
        private string nom;
        private string prenom;
        private string mail;
        private string telephone;

        public Eleve(int id, string nom, string prenom, string mail, string telephone)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.telephone = telephone;
        }

        public Eleve(string nom, string prenom, string mail, string telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.telephone = telephone;
        }

        public int Id { get { return this.id; } }
        public string Nom { get { return this.nom; } set { this.nom = value; } }
        public string Prenom { get { return this.prenom; } set { this.prenom = value; } }
        public string Mail { get { return this.mail; } set { this.mail = value; } }
        public string Telephone { get { return this.telephone; } set { this.telephone = value; } }

        public override string ToString()
        {
            return string.Format(" Elève {0} {1} mail : {2} num : {3}", this.nom,this.prenom,this.mail,this.telephone);
        }
    }
}
