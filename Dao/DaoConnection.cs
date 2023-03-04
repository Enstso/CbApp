using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dao
{
    static public class DaoConnection
    {
        static public MySqlConnection getConnection()
        {
            return new MySqlConnection("user=root;password=;server=localhost;database=dbappcb");
        }
    }

}
