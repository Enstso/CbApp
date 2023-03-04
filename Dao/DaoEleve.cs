using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace Dao
{
    public class DaoEleve
    {
        public List<Eleve> GetAll()
        {
            List<Eleve> eleves = new List<Eleve>();
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,prenom,mail,telephone from Eleve;", cnx))
                {
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        eleves.Add(new Eleve(Convert.ToInt32(rdr["id"]), rdr["nom"].ToString(), rdr["prenom"].ToString(), rdr["mail"].ToString(), rdr["telephone"].ToString()));
                    }
                    rdr.Close();
                }
                cnx.Close();
            }
            return eleves;
        }

        public Eleve GetEleveById(int id)
        {
            Eleve eleve;
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,prenom,mail,telephone from Eleve where id=@id;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id",id));
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        eleve = new Eleve(Convert.ToInt32(rdr["id"]), rdr["nom"].ToString(), rdr["prenom"].ToString(), rdr["mail"].ToString(), rdr["telephone"].ToString());
                        return eleve;
                    }
                    rdr.Close();
                }
                cnx.Close();
            }
            throw new Exception("Aucun Eleve dans la table");
        }

        public List<Eleve> GetElevesByCours(int idCours)
        {
            List<Eleve> eleves = new List<Eleve>();
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select idEleve from participe where idCours=@idCours;", cnx)) 
                {
                    cmd.Parameters.Add(new MySqlParameter("@idCours", idCours));
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Eleve eleve = GetEleveById(Convert.ToInt32(rdr["idEleve"]));
                        eleves.Add(eleve);
                    }
                    rdr.Close();
                }
                cnx.Close();
            }
            return eleves;
        }

        public List<Eleve> GetElevesNeParticipantPasAuCours(int idCours)
        {
            List<Eleve> presents = GetElevesByCours(idCours);
            List<Eleve> tous = GetAll();
            List<Eleve> result=new List<Eleve>();
            for(int i = 0; i < tous.Count; i++ )
            {
                Eleve e = tous[i];
                if (presents.Contains(e)) {
                }
                else
                {
                    result.Add(e);
                }

            }
            return result;
        }

        public void Add(Eleve eleve)
        {
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into eleve (nom,prenom,mail,telephone) values (@nom,@prenom,@mail,@telephone);", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@nom", eleve.Nom));
                    cmd.Parameters.Add(new MySqlParameter("@prenom", eleve.Prenom));
                    cmd.Parameters.Add(new MySqlParameter("@mail", eleve.Mail));
                    cmd.Parameters.Add(new MySqlParameter("@telephone", eleve.Telephone));
                    cmd.ExecuteNonQuery();
                }
                cnx.Close();
            }
        }

        public void Update(Eleve eleve)
        {
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("update eleve set nom=@nom,prenom=@prenom,mail=@mail,telephone=@telephone where id=@id;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", eleve.Id));
                    cmd.Parameters.Add(new MySqlParameter("@nom", eleve.Nom));
                    cmd.Parameters.Add(new MySqlParameter("@prenom", eleve.Prenom));
                    cmd.Parameters.Add(new MySqlParameter("@mail", eleve.Mail));
                    cmd.Parameters.Add(new MySqlParameter("@telephone", eleve.Telephone));
                    cmd.ExecuteNonQuery();
                }
                cnx.Close();
            }
        }

        public void delete(int id)
        {
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from eleve where id=@id;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", id));
                    cmd.ExecuteNonQuery();
                }
                cnx.Close();
            }
        }


    }
}
