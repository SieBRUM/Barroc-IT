using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Barroc_IT
{
    /// <summary>
    /// Class that handles all database connections
    /// </summary>
    public class DatabaseHandler
    {
        private MySqlConnection conn;

        /// <summary>
        /// Default constructor, creates new connection and sets default connectionstring.
        /// </summary>
        public DatabaseHandler()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=159.253.7.212;user id=bartdke98_sieb;password=test123;persistsecurityinfo=True;database=bartdke98_barrocitsieb";
        }


        /// <summary>
        /// Customer constructor, creates new connection and sets connectionstring from parameter.
        /// </summary>
        /// <param name="connectionString">The custom connectionstring for the database.</param>
        public DatabaseHandler(string connectionString)
        {
            conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
        }

        /// <summary>
        /// Opens and closes connection. If something wrong show error.
        /// </summary>
        public void TestConnection()
        {
            bool connOpen = false;

            try
            {
                OpenConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    connOpen = true;
                }
                CloseConnection();
            }

            if (!connOpen)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Opens connection to the database.
        /// </summary>
        public void OpenConnection()
        {
            conn.Open();
        }

        /// <summary>
        /// Closes connection to the database
        /// </summary>
        public void CloseConnection()
        {
            conn.Close();
        }

        /// <summary>
        /// Gets the current connection.
        /// </summary>
        /// <returns>Returns the current sqlconnection.</returns>
        public MySqlConnection GetConnection()
        {
            return this.conn;
        }

        public bool Login(string username, string password)
        {
            bool exist = false;
            //command.CommandText = query;
            //MySqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    MessageBox.Show(reader["username"].ToString());
            //}
            using (MySqlCommand cmd = new MySqlCommand(@"
                SELECT 
                    COUNT(*)
                FROM
                    tbl_users
                WHERE BINARY 
                    username = @username
                AND BINARY
                    password = @password", this.GetConnection()))
            {
                
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                exist = (Int64)cmd.ExecuteScalar() > 0;
            }
            return exist;
        }

        public bool AddProject(string c_Id, string p_Name, int p_Status, string OS, string Software, string Invoices, string c_Person, int m_Contract, string deadline)
        {
            bool done;
            using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO
                        tbl_projects(customer_id,project_name,project_status,operating_system,software,amount_invoice,contact_person,maintenance_contract,deadline_date)
                        VALUES (@customer_id,@project_name,@project_status,@operating_system,@software,@amount_invoice,@contact_person,@maintenance_contract,@deadline_date)", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("customer_id", c_Id);
                cmd.Parameters.AddWithValue("project_name", p_Name);
                cmd.Parameters.AddWithValue("project_status", p_Status);
                cmd.Parameters.AddWithValue("operating_system", OS);
                cmd.Parameters.AddWithValue("software", Software);
                cmd.Parameters.AddWithValue("amount_invoice",Invoices);
                cmd.Parameters.AddWithValue("contact_person", c_Person);
                cmd.Parameters.AddWithValue("maintenance_contract", m_Contract);
                cmd.Parameters.AddWithValue("deadline_date", deadline);
                try
                {
                    done = (Int64)cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    done = false;
                    MessageBox.Show("An error occured. Detailes below: \n\n " + e);
                }
            }
            return done;
        }

        public DataTable GetCustomers()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT customer_id, CONCAT (customer_id,':', first_name, ' ', last_name, ',', zip_code) AS full_name FROM tbl_customers",this.GetConnection()))
            {
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("customer_id", typeof(string));
                dt.Columns.Add("full_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public bool AddCustomer(string c_Firstname, string c_Lastname, string c_Company, string c_Email, string c_Fax, string c_Streetname1, string c_Housenumber1, string c_Residence1, string c_Zipcode1, string c_Phone1, string c_Streetname2, string c_Housenumber2, string c_Residence2, string c_Zipcode2, string c_Phone2, string c_Lastcontact, string c_Lastaction, string c_Nextcontact, string c_Nextaction)
        {
            bool done;
            using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO
                        tbl_customers(first_name, last_name, company_name, street_name, street_name_2, house_number, house_number_2, residence, residence_2, zip_code, zip_code_2, phone_number, phone_number_2, email, fax, last_contact, last_action, next_contact, next_action)
                        VALUES (@first_name, @last_name, @company_name, @street_name, @street_name_2, @house_number, @house_number_2, @residence, @residence_2, @zip_code, @zip_code_2, @phone_number, @phone_number_2, @email, @fax, @last_contact, @last_action, @next_contact, @next_action)", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("first_name", c_Firstname);
                cmd.Parameters.AddWithValue("last_name", c_Lastname);
                cmd.Parameters.AddWithValue("company_name", c_Company);
                cmd.Parameters.AddWithValue("street_name", c_Streetname1);
                cmd.Parameters.AddWithValue("street_name_2", c_Streetname2);
                cmd.Parameters.AddWithValue("house_number", c_Housenumber1);
                cmd.Parameters.AddWithValue("house_number_2", c_Housenumber2);
                cmd.Parameters.AddWithValue("residence", c_Residence1);
                cmd.Parameters.AddWithValue("residence_2", c_Residence2);
                cmd.Parameters.AddWithValue("zip_code", c_Zipcode1);
                cmd.Parameters.AddWithValue("zip_code_2", c_Zipcode2);
                cmd.Parameters.AddWithValue("phone_number", c_Phone1);
                cmd.Parameters.AddWithValue("phone_number_2", c_Phone2);
                cmd.Parameters.AddWithValue("email", c_Email);
                cmd.Parameters.AddWithValue("fax", c_Fax);
                cmd.Parameters.AddWithValue("last_contact", c_Lastcontact);
                cmd.Parameters.AddWithValue("last_action", c_Lastaction);
                cmd.Parameters.AddWithValue("next_contact", c_Nextcontact);
                cmd.Parameters.AddWithValue("next_action", c_Nextaction);
                try
                {
                    done = (Int64)cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    done = false;
                    MessageBox.Show("An error occured. Detailes below: \n\n " + e);
                }
            }
            return done;
        }
    }
}
