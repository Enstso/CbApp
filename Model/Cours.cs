using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cours
    {
        private int id;
        private List<Eleve> eleves;
        private User user;
        private string nom;
        private DateTime date;

        public Cours(int id, List<Eleve> eleves, User user,string nom, DateTime date)
        {
            this.id = id;
            this.eleves = eleves;
            this.nom = nom;
            this.user = user;
            this.date = date;
        }

        public Cours(List<Eleve> eleves, User user, DateTime date, string nom)
        {
            this.eleves = eleves;
            this.user = user;
            this.date = date;
            this.nom = nom;
        }

        public int Id { get { return this.id; }  }
        public User User { get { return this.user; } set { this.user = value; } }
        public string Nom { get { return this.nom; } set { this.nom = value; } }
        public DateTime Date { get { return this.date; } set { this.date = value; } }
        public List<Eleve> Eleves { get { return this.eleves; } set { this.eleves = value; } }


        public void AddEleve(Eleve eleve)
        {
            this.Eleves.Add(eleve);
        }

        public void DeleteEleve(Eleve eleve)
        {
            this.eleves.Remove(eleve);
        }

        public override string ToString()
        {
            return string.Format("Cours : {0} de {1} le {2}",this.nom,this.user.Prenom,this.date);
        }
    }
}
