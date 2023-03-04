using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace Dao
{
    public class DaoParticipe
    {
        
        public void AjouterParticipation(int idCours,int idEleve)
        {
            using(MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using(MySqlCommand cmd = new MySqlCommand("insert into participe(idCours,idEleve) values(@idCours,@idEleve);", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@idCours", idCours));
                    cmd.Parameters.Add(new MySqlParameter("@idEleve", idEleve));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SupprimerParticipation(int idCours,int idEleve)
        {
            using (MySqlConnection cnx = DaoConnection.getConnection())
            {
                cnx.Open();
                using (MySqlCommand cmd = new MySqlCommand("delete from participe where idCours=@idCours and idEleve=@idEleve;", cnx))
                {
                    cmd.Parameters.Add(new MySqlParameter("@idCours", idCours));
                    cmd.Parameters.Add(new MySqlParameter("@idEleve", idEleve));
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
