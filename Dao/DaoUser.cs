using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;

namespace Dao
{
    public class DaoUser
    {
        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,prenom,mdp,administrator from user;", cnx))
                {
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        users.Add(new User(Convert.ToInt32(rdr["id"]), rdr["nom"].ToString(), rdr["prenom"].ToString(), rdr["mdp"].ToString(), Convert.ToBoolean(rdr["administrator"]) ));
                    }
                    rdr.Close();
                }
                cnx.Close();
            }
            return users;
        }

        public bool Authentification(string prenom,string mdp)
        {
            bool result=false;
            string vraiPrenom, vraiMdp;
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select prenom,mdp from user where prenom=@prenom", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@prenom", prenom));
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            vraiPrenom = rdr["prenom"].ToString();
                            vraiMdp = rdr["mdp"].ToString();
                            if (prenom == vraiPrenom && mdp == vraiMdp)
                            {
                                result = true;
                            }
                        }
                        rdr.Close();
                    }
                }
                cnx.Close();
            }
            return result;
        }

        public bool IsAdmin(string prenom,string mdp)
        {
            bool result = false;
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select administrator from user where prenom=@prenom and @mdp=@mdp", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@prenom", prenom));
                    cmd.Parameters.Add(new MySqlParameter("@mdp", mdp));
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            result = Convert.ToBoolean(rdr["administrator"]);
                        }
                        rdr.Close();
                    }
                }
                cnx.Close();
                return result;
            }
        }

        public void Add(User user)
        {
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("insert into user (nom,prenom,mdp,administrator) values (@nom,@prenom,@mdp,@administrator);", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@nom", user.Nom));
                    cmd.Parameters.Add(new MySqlParameter("@prenom", user.Prenom));
                    cmd.Parameters.Add(new MySqlParameter("@mdp", user.Mdp));
                    cmd.Parameters.Add(new MySqlParameter("@administrator", false));
                    cmd.ExecuteNonQuery();
                }
                cnx.Close();
            }
        }

        public User GetUserById(int id)
        {
            
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id,nom,prenom,mdp,administrator from user where id=@id;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", id));
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            User user;
                            user = new User(Convert.ToInt32(rdr["id"]), rdr["nom"].ToString(), rdr["prenom"].ToString(), rdr["mdp"].ToString(), Convert.ToBoolean(rdr["administrator"]));
                            return user;
                        }
                        rdr.Close();
                    }
                }
                cnx.Close();
            }
            throw new Exception("Aucun user dans la table");
        }

        public void Delete(int id)
        {
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from user where id=@id;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", id));
                    cmd.ExecuteNonQuery();
                }
                cnx.Close();
            }
        }

        public int GetIdByNom(string prenom,string mdp)
        {
            List<int> ids = new List<int>();
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select id from user where prenom=@prenom and mdp=@mdp;", cnx))
                { 
                    cmd.Parameters.Add(new MySqlParameter("@prenom", prenom));
                    cmd.Parameters.Add(new MySqlParameter("@mdp", mdp));
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read()) 
                        { 
                            ids.Add(Convert.ToInt32(rdr["id"])); 
                        }
                        rdr.Close();
                    }
                }
                cnx.Close();
            }
            return ids[0];
        }

        public User GetPerson(string prenom)
        {
            
            User user=null;
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("select nom,prenom from user where prenom=@prenom;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@prenom", prenom));
                    
                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        
                        while (rdr.Read())
                        {
                            user = new User(Convert.ToString(rdr["nom"]), Convert.ToString(rdr["prenom"]));
                        }
                        rdr.Close();
                    }
                }
                cnx.Close();
            }
            return user;
        }
    }
}
