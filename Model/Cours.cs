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
        private DateTime date;

        public Cours(int id, List<Eleve> eleves, User user, DateTime date)
        {
            this.id = id;
            this.eleves = eleves;
            this.user = user;
            this.date = date;
        }

        public Cours(List<Eleve> eleves, User user, DateTime date)
        {
            this.eleves = eleves;
            this.user = user;
            this.date = date;
        }

        public int Id { get { return this.id; }  }
        public User User { get { return this.user; } }
        public DateTime Date { get { return this.date; } }
        public List<Eleve> Eleves { get { return this.eleves; } }


    }
}
