using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Barroc_IT.Datalayer
{
    public class MySQLHandler
    {
        private MySqlConnection conn;

        public MySQLHandler()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=159.253.7.212;user id=bartdke98_sieb;password=test123;persistsecurityinfo=True;database=bartdke98_barrocitsieb";
        }

        public MySqlConnection getConnection()
        {
            return conn;
        }

        public bool OpenMySqlConnection()
        {
            bool isOpen = false;
            try
            {
                conn.Open();
                isOpen = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isOpen;
        }

        public void CloseMySqlConnection()
        {
            conn.Close();
        }

    }
}
