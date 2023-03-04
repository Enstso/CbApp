using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;


namespace Dao
{
    public class DaoCours
    {
        DaoUser daoUser = new DaoUser();
        public List<Cours> GetAll()
        {
            List<Cours> cours = new List<Cours>();
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,idUser,ladate from cours;", cnx))
                {
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        int id = Convert.ToInt32(rdr["idUser"]);
                        User user = daoUser.GetUserById(id);
                        cours.Add(new Cours(Convert.ToInt32(rdr["id"]), user,rdr["nom"].ToString(), Convert.ToDateTime(rdr["ladate"]) ));
                    }
                    rdr.Close();
                }
                cnx.Close();
            }
            return cours;
        }

        public List<Cours> GetCoursByUser(int idUser)
        {
            List<Cours> cours = new List<Cours>();
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,idUser,ladate from cours where idUser=@idUser;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@idUser", idUser));
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        int id = Convert.ToInt32(rdr["idUser"]);
                        User user = daoUser.GetUserById(id);
                        cours.Add(new Cours(Convert.ToInt32(rdr["id"]), user, rdr["nom"].ToString(), Convert.ToDateTime(rdr["ladate"])));
                    }
                    rdr.Close();
                }
                cnx.Close();
            }
            return cours;
        }

        public Cours GetCoursById(int id)
        {
            Cours cours;
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,idUser,ladate from cours where id=@id;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", id));
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        int idU = Convert.ToInt32(rdr["idUser"]);
                        User user = daoUser.GetUserById(idU);
                        cours = new Cours(Convert.ToInt32(rdr["id"]), user, rdr["nom"].ToString(), Convert.ToDateTime(rdr["ladate"]));
                        return cours;
                    }
                    rdr.Close();
                }
                cnx.Close();
            }
            throw new Exception("Aucun Cours dans la table");
        }

        public List<Cours> GetCoursByEleve(int id)
        {
            List<int> ids = new List<int>();
            List<Cours> cours = new List<Cours>();
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select idCours,idEleve from participe where idEleve=@idEleve", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@idEleve", id));
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        ids.Add(Convert.ToInt32(rdr["idCours"]));
                    }
                }
                for(int i = 0; i < ids.Count; i++)
                {
                    Cours courss = GetCoursById(ids[i]);
                    cours.Add(courss);

                }
                cnx.Close();
            }
            return cours;
        }


        public void Add(Cours cours)
        {
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into cours (nom,idUser,ladate) values (@nom,@idUser,@ladate);", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@nom", cours.Nom));
                    cmd.Parameters.Add(new MySqlParameter("@idUser", cours.User.Id));
                    cmd.Parameters.Add(new MySqlParameter("@ladate", cours.Date));
                    cmd.ExecuteNonQuery();
                }
                cnx.Close();
            }
        }

        public void Update(Cours cours)
        {
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("update cours set nom=@nom,ladate=@ladate where id=@id;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@nom", cours.Nom));
                    cmd.Parameters.Add(new MySqlParameter("@ladate", cours.Date));
                    cmd.Parameters.Add(new MySqlParameter("@id", cours.Id));
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
                using (MySqlCommand cmd = new MySqlCommand("delete from cours where id=@id;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", id));
                    cmd.ExecuteNonQuery();
                }
                cnx.Close();
            }
        }
    }
}
