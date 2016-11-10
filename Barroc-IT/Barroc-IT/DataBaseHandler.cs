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

        public bool AddProject(string c_Id, string p_Name, int p_Status, string OS, string Software, string Invoices, string c_Person, int m_Contract, string deadline, string hardware)
        {
            bool done;
            using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO
                        tbl_projects(customer_id,project_name,project_status,operating_system,software,amount_invoice,contact_person,maintenance_contract,deadline_date,hardware)
                        VALUES (@customer_id,@project_name,@project_status,@operating_system,@software,@amount_invoice,@contact_person,@maintenance_contract,@deadline_date,@hardware)", this.GetConnection()))
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
                cmd.Parameters.AddWithValue("hardware", hardware);
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

        public DataTable GetCustomerCB()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT 
                        customer_id, CONCAT (customer_id,':', first_name, ' ', last_name, ',', zip_code) AS full_name 

                    FROM 
                        tbl_customers
                    WHERE
                        creditworthy = 1", this.GetConnection()))
            {
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("customer_id", typeof(string));
                dt.Columns.Add("full_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable GetProjectCB()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        project_id, CONCAT(project_id,':', project_name, ' ', tbl_customers.first_name, ' ', tbl_customers.last_name) AS project_and_name
                    FROM 
                        tbl_projects
                    INNER JOIN
                        tbl_customers
                    ON
                        tbl_projects.customer_id = tbl_customers.customer_id
                    ORDER BY
                        project_id",this.GetConnection()))
            {
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("project_id", typeof(string));
                dt.Columns.Add("project_and_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public bool AddNotification(string c_Name, string notification_type, string department, string notification_info)
        {
            bool done;
            using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO
                        tbl_notification(notification_type, notification_date, notification_info)
                        VALUES (@notification_type, @notification_date, @notification_info)", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("notification_type", notification_type);
                cmd.Parameters.AddWithValue("notification_date", DateTime.Today);
                cmd.Parameters.AddWithValue("notification_info", "Customer " + c_Name + notification_info);

                try
                {
                    done = (Int64)cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    done = false;
                    MessageBox.Show("An error occured. Details below: \n\n " + e);
                }
            }

            return done;
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
                    MessageBox.Show("An error occured. Details below: \n\n " + e);
                }
            }
            return done;
        }

        public bool AddInvoice(string p_ID, string i_VAT, int i_Status, string i_TotalPrice)
        {
            bool done;
            using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO
                        tbl_invoices(project_id, VAT, status, total_price)
                    VALUES (@project_id, @VAT, @status, @total_price)",this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("project_id", p_ID);
                cmd.Parameters.AddWithValue("VAT", i_VAT);
                cmd.Parameters.AddWithValue("status", i_Status);
                cmd.Parameters.AddWithValue("total_price", i_TotalPrice);
                try
                {
                    done = (Int64)cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    done = false;
                    MessageBox.Show("An error occured. Details below: \n\n " + e);
                }
            }
            return done;
        }

        public bool PayInvoice(string i_ID)
        {
            bool succes = false;

            using (MySqlCommand cmd = new MySqlCommand(@"
                    UPDATE
                        tbl_invoices
                    SET
                        status = 1
                    WHERE
                        invoice_id = @invoice_id", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("invoice_id", i_ID);
                try
                {
                    succes = (Int64)cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    succes = false;
                    MessageBox.Show("An error occured. Details below: \n\n " + e);
                }
            }
            return succes;
        }

        public DataTable GetInvoices()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_customers.customer_id AS customer_id, invoice_id, tbl_invoices.status AS status, total_price, tbl_customers.company_name AS company_name, tbl_projects.contact_person AS contact_person, ledger_account_number, tbl_customers.iban AS IBAN, VAT, tbl_customers.discount AS discount, tbl_invoices.project_id AS project_id, CONCAT (first_name, ' ', last_name) AS customer_name
                    FROM
                        tbl_invoices
                    INNER JOIN
                        tbl_projects
                    ON
                        tbl_invoices.project_id = tbl_projects.project_id
                    INNER JOIN
                        tbl_customers
                    ON
                        tbl_projects.customer_id = tbl_customers.customer_id
                    ORDER BY
                        invoice_id DESC", this.GetConnection()))
            {
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("customer_id");
                dt.Columns.Add("invoice_id");
                dt.Columns.Add("status");
                dt.Columns.Add("total_price");
                dt.Columns.Add("company_name");
                dt.Columns.Add("contact_person");
                dt.Columns.Add("ledger_account_number");
                dt.Columns.Add("IBAN");
                dt.Columns.Add("VAT");
                dt.Columns.Add("discount");
                dt.Columns.Add("project_id");
                dt.Columns.Add("customer_name");
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable GetCustomers()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_customers.customer_id, company_name, zip_code, zip_code_2, residence, residence_2, phone_number, phone_number_2, fax, email, prospect, last_contact, last_action, next_contact, next_action, credit_balance, creditworthy, discount, iban, tbl_customers.limit AS customer_limit, gross_revenue, CONCAT (first_name, ' ', last_name) AS customer_name, CONCAT (street_name, ' ', house_number) AS address, CONCAT (street_name_2, ' ', house_number_2) AS address_2, COUNT(tbl_projects.project_id) AS numOfProjects

                    FROM
                        tbl_customers

                    LEFT JOIN
                        tbl_projects

                    ON 
                        tbl_customers.customer_id = tbl_projects.customer_id

                    GROUP BY
                        tbl_customers.customer_id

                    ORDER BY
                        tbl_customers.customer_id ASC", this.GetConnection()))
            {

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("customer_id", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("zip_code", typeof(string));
                dt.Columns.Add("zip_code_2", typeof(string));
                dt.Columns.Add("residence", typeof(string));
                dt.Columns.Add("residence_2", typeof(string));
                dt.Columns.Add("phone_number", typeof(string));
                dt.Columns.Add("phone_number_2", typeof(string));
                dt.Columns.Add("fax", typeof(string));
                dt.Columns.Add("email", typeof(string));
                dt.Columns.Add("prospect", typeof(string));
                dt.Columns.Add("last_contact", typeof(string));
                dt.Columns.Add("last_action", typeof(string));
                dt.Columns.Add("next_contact", typeof(string));
                dt.Columns.Add("next_action", typeof(string));
                dt.Columns.Add("credit_balance", typeof(string));
                dt.Columns.Add("creditworthy", typeof(string));
                dt.Columns.Add("discount", typeof(string));
                dt.Columns.Add("iban", typeof(string));
                dt.Columns.Add("customer_limit", typeof(string));
                dt.Columns.Add("gross_revenue", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Columns.Add("address", typeof(string));
                dt.Columns.Add("address_2", typeof(string));
                dt.Columns.Add("numOfProjects", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable GetCustomer(string customerId)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        customer_id, company_name, zip_code, zip_code_2, residence, residence_2, phone_number, phone_number_2, fax, email, prospect, last_contact, last_action, next_contact, next_action, credit_balance, creditworthy, discount, iban, tbl_customers.limit AS customer_limit, gross_revenue, street_name, house_number, street_name_2, house_number_2, first_name, last_name, CONCAT (first_name, ' ', last_name) AS customer_name, CONCAT (street_name, ' ', house_number) AS address, CONCAT (street_name_2, ' ', house_number_2) AS address_2, CONCAT (customer_id, ':',first_name, ' ', last_name) AS customer_details
                    FROM
                        tbl_customers
                    WHERE
                        customer_id = @customer_id", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("customer_id", customerId);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("customer_id", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("zip_code", typeof(string));
                dt.Columns.Add("zip_code_2", typeof(string));
                dt.Columns.Add("residence", typeof(string));
                dt.Columns.Add("residence_2", typeof(string));
                dt.Columns.Add("phone_number", typeof(string));
                dt.Columns.Add("phone_number_2", typeof(string));
                dt.Columns.Add("fax", typeof(string));
                dt.Columns.Add("email", typeof(string));
                dt.Columns.Add("prospect", typeof(string));
                dt.Columns.Add("last_contact", typeof(string));
                dt.Columns.Add("last_action", typeof(string));
                dt.Columns.Add("next_contact", typeof(string));
                dt.Columns.Add("next_action", typeof(string));
                dt.Columns.Add("credit_balance", typeof(string));
                dt.Columns.Add("creditworthy", typeof(string));
                dt.Columns.Add("discount", typeof(string));
                dt.Columns.Add("iban", typeof(string));
                dt.Columns.Add("customer_limit", typeof(string));
                dt.Columns.Add("gross_revenue", typeof(string));
                dt.Columns.Add("street_name", typeof(string));
                dt.Columns.Add("house_number", typeof(string));
                dt.Columns.Add("street_name_2", typeof(string));
                dt.Columns.Add("house_number_2", typeof(string));
                dt.Columns.Add("first_name",typeof(string));
                dt.Columns.Add("last_name", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Columns.Add("address", typeof(string));
                dt.Columns.Add("address_2", typeof(string));
                dt.Columns.Add("customer_details", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public bool EditCustomer(string c_id, string c_companyName, string c_mail, string c_fax, string c_streetName1, string c_houseNumber1, string c_residence1, string c_zipCode1, string c_phoneNumber1, string c_streetname2, string c_housenumber2, string c_residence2,string c_zipcode2, string c_phonenumber2, string c_lastaction, string c_nextaction, string c_lastactiondate, string c_nextactiondate)
        {
            bool success = false;

            using (MySqlCommand cmd = new MySqlCommand(@"
                    UPDATE
                        tbl_customers
                    SET
                        company_name = @company_name, email = @email, fax = @fax, street_name = @street_name, house_number = @house_number, residence = @residence, zip_code = @zip_code, phone_number = @phone_number, street_name_2 = @street_name_2, house_number_2 = @house_number_2, residence_2 = @residence2, zip_code_2 = @zip_code_2, phone_number_2 = @phone_number_2, last_contact = @last_contact, last_action = @last_action, next_contact = @next_contact, next_action = @next_action
                    WHERE
                        customer_id = @customer_id",this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("customer_id", c_id);
                cmd.Parameters.AddWithValue("company_name", c_companyName);
                cmd.Parameters.AddWithValue("email", c_mail);
                cmd.Parameters.AddWithValue("fax", c_fax);
                cmd.Parameters.AddWithValue("street_name", c_streetName1);
                cmd.Parameters.AddWithValue("house_number", c_houseNumber1);
                cmd.Parameters.AddWithValue("residence", c_residence1);
                cmd.Parameters.AddWithValue("zip_code", c_zipCode1);
                cmd.Parameters.AddWithValue("phone_number", c_phoneNumber1);
                cmd.Parameters.AddWithValue("phone_number_2", c_phonenumber2);
                cmd.Parameters.AddWithValue("street_name_2", c_streetname2);
                cmd.Parameters.AddWithValue("house_number_2", c_housenumber2);
                cmd.Parameters.AddWithValue("residence2", c_residence2);
                cmd.Parameters.AddWithValue("zip_code_2", c_zipcode2);
                cmd.Parameters.AddWithValue("last_contact", c_lastactiondate);
                cmd.Parameters.AddWithValue("last_action", c_lastaction);
                cmd.Parameters.AddWithValue("next_contact", c_nextactiondate);
                cmd.Parameters.AddWithValue("next_action", c_nextaction);
                try
                {
                    success = (Int64)cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    success = false;
                    MessageBox.Show("An error occured. Detailes below: \n\n " + e);
                }
                return success;                
            }
        }

        public bool EditCustomerFinancial(string c_id, string iban, string creditbalance, string limit, string discount, string creditworthy, string grossrevenue, string prospect)
        {
            bool success = false;

            using (MySqlCommand cmd = new MySqlCommand(@"
                    UPDATE
                        tbl_customers
                    SET
                        iban = @iban, credit_balance = @creditbalance, tbl_customers.limit = @customer_limit, discount = @discount, creditworthy = @creditworthy, gross_revenue = @grossrevenue, prospect = @prospect
                    WHERE
                        customer_id = @customer_id", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("customer_id", c_id);
                cmd.Parameters.AddWithValue("iban", iban);
                cmd.Parameters.AddWithValue("creditbalance", creditbalance);
                cmd.Parameters.AddWithValue("customer_limit", limit);
                cmd.Parameters.AddWithValue("discount", discount);
                cmd.Parameters.AddWithValue("creditworthy", creditworthy);
                cmd.Parameters.AddWithValue("grossrevenue", grossrevenue);
                cmd.Parameters.AddWithValue("prospect", prospect);
                try
                {
                    success = (Int64)cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    success = false;
                    MessageBox.Show("An error occured. Detailes below: \n\n " + e);
                }
                return success;
            }
        }

        public DataTable FilterNotifications(string filter, string colName)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        notification_id, notification_type, notification_date, notification_info
                    FROM
                        tbl_notification
                    WHERE 
                        " + colName + " = @filter", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", filter);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("notification_id", typeof(string));
                dt.Columns.Add("notification_type", typeof(string));
                dt.Columns.Add("notification_date", typeof(string));
                dt.Columns.Add("notification_info", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterNotificationsBetweenDate(string filter, string filter2, string colName)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        notification_id, notification_type, notification_date, notification_info
                    FROM
                        tbl_notification
                    WHERE 
                        " + colName + "> @filter &&" + colName + " < @filter2", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", filter);
                cmd.Parameters.AddWithValue("filter2", filter2);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("notification_id", typeof(string));
                dt.Columns.Add("notification_type", typeof(string));
                dt.Columns.Add("notification_date", typeof(string));
                dt.Columns.Add("notification_info", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterCustomers(string filter, string colName)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_customers.customer_id, company_name, zip_code, zip_code_2, residence, residence_2, phone_number, phone_number_2, fax, email, prospect, last_contact, last_action, next_contact, next_action, credit_balance, creditworthy, discount, iban, tbl_customers.limit as customer_limit, gross_revenue, CONCAT (first_name, ' ', last_name) AS customer_name, CONCAT (street_name, ' ', house_number) AS address, CONCAT (street_name_2, ' ', house_number_2) AS address_2, Count(tbl_projects.project_id) AS numOfProjects
                    FROM 
                        tbl_customers
                    LEFT JOIN
                        tbl_projects
                    ON
                        tbl_customers.customer_id = tbl_projects.customer_id
                    GROUP BY
                        tbl_customers.customer_id
                    HAVING
                        " + colName + " LIKE @filter ", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", "%" + filter + "%");

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("customer_id", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("zip_code", typeof(string));
                dt.Columns.Add("zip_code_2", typeof(string));
                dt.Columns.Add("residence", typeof(string));
                dt.Columns.Add("residence_2", typeof(string));
                dt.Columns.Add("phone_number", typeof(string));
                dt.Columns.Add("phone_number_2", typeof(string));
                dt.Columns.Add("fax", typeof(string));
                dt.Columns.Add("email", typeof(string));
                dt.Columns.Add("prospect", typeof(string));
                dt.Columns.Add("last_contact", typeof(string));
                dt.Columns.Add("last_action", typeof(string));
                dt.Columns.Add("next_contact", typeof(string));
                dt.Columns.Add("next_action", typeof(string));
                dt.Columns.Add("credit_balance", typeof(string));
                dt.Columns.Add("creditworthy", typeof(string));
                dt.Columns.Add("discount", typeof(string));
                dt.Columns.Add("iban", typeof(string));
                dt.Columns.Add("customer_limit", typeof(string));
                dt.Columns.Add("gross_revenue", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Columns.Add("address", typeof(string));
                dt.Columns.Add("address_2", typeof(string));
                dt.Columns.Add("numOfProjects", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterCustomers(string filter, string colName, string colName_2)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_customers.customer_id, first_name, last_name, company_name, zip_code, zip_code_2, residence, residence_2, phone_number, phone_number_2, fax, email, prospect, last_contact, last_action, next_contact, next_action, credit_balance, creditworthy, discount, iban, tbl_customers.limit AS customer_limit, gross_revenue, CONCAT (first_name, ' ', last_name) AS customer_name, CONCAT (street_name, ' ', house_number) AS address, CONCAT (street_name_2, ' ', house_number_2) AS address_2, Count(tbl_projects.project_id) AS numOfProjects
                    FROM 
                        tbl_customers
                    LEFT JOIN
                        tbl_projects
                    ON
                        tbl_customers.customer_id = tbl_projects.customer_id
                    GROUP BY
                        tbl_customers.customer_id
                    HAVING 
                        " + colName + " LIKE @filter OR " + colName_2 + " LIKE @filter", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", "%" + filter + "%");

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("customer_id", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("zip_code", typeof(string));
                dt.Columns.Add("zip_code_2", typeof(string));
                dt.Columns.Add("residence", typeof(string));
                dt.Columns.Add("residence_2", typeof(string));
                dt.Columns.Add("phone_number", typeof(string));
                dt.Columns.Add("phone_number_2", typeof(string));
                dt.Columns.Add("fax", typeof(string));
                dt.Columns.Add("email", typeof(string));
                dt.Columns.Add("prospect", typeof(string));
                dt.Columns.Add("last_contact", typeof(string));
                dt.Columns.Add("last_action", typeof(string));
                dt.Columns.Add("next_contact", typeof(string));
                dt.Columns.Add("next_action", typeof(string));
                dt.Columns.Add("credit_balance", typeof(string));
                dt.Columns.Add("creditworthy", typeof(string));
                dt.Columns.Add("discount", typeof(string));
                dt.Columns.Add("iban", typeof(string));
                dt.Columns.Add("customer_limit", typeof(string));
                dt.Columns.Add("gross_revenue", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Columns.Add("address", typeof(string));
                dt.Columns.Add("address_2", typeof(string));
                dt.Columns.Add("numOfProjects", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterInvoices(string filter, string colName)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_customers.customer_id AS customer_id, invoice_id, tbl_invoices.status AS status, total_price, tbl_customers.company_name AS company_name, tbl_projects.contact_person AS contact_person, ledger_account_number, tbl_customers.iban AS IBAN, VAT, tbl_customers.discount AS discount, tbl_invoices.project_id AS project_id, CONCAT (first_name, ' ', last_name) AS customer_name
                    FROM
                        tbl_invoices
                    INNER JOIN
                        tbl_projects
                    ON
                        tbl_invoices.project_id = tbl_projects.project_id
                    INNER JOIN
                        tbl_customers
                    ON
                        tbl_projects.customer_id = tbl_customers.customer_id
                    WHERE
                        " + colName + " LIKE @filter ORDER BY invoice_id DESC", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", filter);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("customer_id");
                dt.Columns.Add("invoice_id");
                dt.Columns.Add("status");
                dt.Columns.Add("total_price");
                dt.Columns.Add("company_name");
                dt.Columns.Add("contact_person");
                dt.Columns.Add("ledger_account_number");
                dt.Columns.Add("IBAN");
                dt.Columns.Add("VAT");
                dt.Columns.Add("discount");
                dt.Columns.Add("project_id");
                dt.Columns.Add("customer_name");
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterInvoices(string filter, string colName, string colName_2)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_customers.customer_id AS customer_id, invoice_id, tbl_invoices.status AS status, total_price, tbl_customers.first_name, tbl_customers.last_name, tbl_customers.company_name AS company_name, tbl_projects.contact_person AS contact_person, ledger_account_number, tbl_customers.iban AS IBAN, VAT, tbl_customers.discount AS discount, tbl_invoices.project_id AS project_id, CONCAT (tbl_customers.first_name, ' ', tbl_customers.last_name) AS customer_name
                    FROM
                        tbl_invoices
                    INNER JOIN
                        tbl_projects
                    ON
                        tbl_invoices.project_id = tbl_projects.project_id
                    INNER JOIN
                        tbl_customers
                    ON
                        tbl_projects.customer_id = tbl_customers.customer_id
                    WHERE
                        " + colName + " LIKE @filter OR " + colName_2 + " LIKE @filter", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", "%" + filter + "%");

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("customer_id");
                dt.Columns.Add("invoice_id");
                dt.Columns.Add("status");
                dt.Columns.Add("total_price");
                dt.Columns.Add("company_name");
                dt.Columns.Add("contact_person");
                dt.Columns.Add("ledger_account_number");
                dt.Columns.Add("IBAN");
                dt.Columns.Add("VAT");
                dt.Columns.Add("discount");
                dt.Columns.Add("project_id");
                dt.Columns.Add("customer_name");
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterProjects(string filter, string colName)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        project_id, project_name, project_status, maintenance_contract, operating_system, hardware, software, amount_invoice, deadline_date, contact_person, tbl_projects.customer_id, tbl_customers.company_name AS company_name, CONCAT (tbl_customers.first_name, ' ', tbl_customers.last_name) AS customer_name
                    FROM
                        tbl_projects
                    INNER JOIN
                        tbl_customers
                    ON 
                        tbl_projects.customer_id = tbl_customers.customer_id
                    WHERE
                       " + colName + " LIKE @filter ", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", "%" + filter +"%");

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("project_id", typeof(string));
                dt.Columns.Add("project_name", typeof(string));
                dt.Columns.Add("project_status", typeof(string));
                dt.Columns.Add("maintenance_contact", typeof(string));
                dt.Columns.Add("operating_system", typeof(string));
                dt.Columns.Add("hardware", typeof(string));
                dt.Columns.Add("software", typeof(string));
                dt.Columns.Add("amount_invoice", typeof(string));
                dt.Columns.Add("deadline_date", typeof(string));
                dt.Columns.Add("contact_person", typeof(string));
                dt.Columns.Add("customer_id", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterProjects(string filter, string colName, string colName_2)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        project_id, project_name, project_status, maintenance_contract, operating_system, hardware, software, amount_invoice, deadline_date, contact_person, tbl_projects.customer_id, tbl_customers.company_name AS company_name, tbl_customers.first_name, tbl_customers.last_name, CONCAT (tbl_customers.first_name, ' ', tbl_customers.last_name) AS customer_name
                    FROM
                        tbl_projects
                    INNER JOIN
                        tbl_customers
                    ON 
                        tbl_projects.customer_id = tbl_customers.customer_id
                    WHERE
                        " + colName + " LIKE @filter OR " + colName_2 + " LIKE @filter", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", "%" + filter + "%");

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("project_id", typeof(string));
                dt.Columns.Add("project_name", typeof(string));
                dt.Columns.Add("project_status", typeof(string));
                dt.Columns.Add("maintenance_contact", typeof(string));
                dt.Columns.Add("operating_system", typeof(string));
                dt.Columns.Add("hardware", typeof(string));
                dt.Columns.Add("software", typeof(string));
                dt.Columns.Add("amount_invoice", typeof(string));
                dt.Columns.Add("deadline_date", typeof(string));
                dt.Columns.Add("contact_person", typeof(string));
                dt.Columns.Add("customer_id", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterAppointments(string filter, string colName)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_appointments.customer_id AS appointment_customer_id, appointment_id, appointment_datetime, appointment_residence, appointment_zipcode, appointment_made, appointment_summary, CONCAT (appointment_streetname, ' ', appointment_housenumber) AS appointment_address, tbl_customers.company_name as company_name, tbl_customers.residence AS customer_residence,CONCAT(tbl_customers.first_name, ' ', tbl_customers.last_name) AS customer_name ,CONCAT (tbl_customers.street_name, ' ', tbl_customers.house_number) AS customer_address, tbl_customers.zip_code AS customer_zip_code, tbl_customers.phone_number AS customer_phone_number, tbl_customers.email AS customer_email
                    
                    FROM
                        tbl_appointments

                    INNER JOIN
                        tbl_customers

                    ON
                        tbl_appointments.customer_id = tbl_customers.customer_id

                    WHERE
                        " + colName + " LIKE @filter ", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", "%" + filter + "%");

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("appointment_customer_id", typeof(string));
                dt.Columns.Add("appointment_id", typeof(string));
                dt.Columns.Add("appointment_datetime", typeof(string));
                dt.Columns.Add("appointment_address", typeof(string));
                dt.Columns.Add("appointment_housenumber", typeof(string));
                dt.Columns.Add("appointment_zipcode", typeof(string));
                dt.Columns.Add("appointment_made", typeof(string));
                dt.Columns.Add("appointment_summary", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("customer_residence", typeof(string));
                dt.Columns.Add("customer_address", typeof(string));
                dt.Columns.Add("customer_zip_code", typeof(string));
                dt.Columns.Add("customer_phone_number", typeof(string));
                dt.Columns.Add("customer_email", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterAppointments(string filter, string colName, string colName_2)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_appointments.customer_id AS appointment_customer_id, appointment_id, appointment_datetime, appointment_residence, appointment_zipcode, appointment_made, appointment_summary, CONCAT (appointment_streetname, ' ', appointment_housenumber) AS appointment_address, tbl_customers.company_name as company_name, tbl_customers.residence AS customer_residence,CONCAT(tbl_customers.first_name, ' ', tbl_customers.last_name) AS customer_name ,CONCAT (tbl_customers.street_name, ' ', tbl_customers.house_number) AS customer_address, tbl_customers.zip_code AS customer_zip_code, tbl_customers.phone_number AS customer_phone_number, tbl_customers.email AS customer_email
                    
                    FROM
                        tbl_appointments

                    INNER JOIN
                        tbl_customers

                    ON
                        tbl_appointments.customer_id = tbl_customers.customer_id

                    WHERE
                        " + colName + " LIKE @filter OR " + colName_2 + " LIKE @filter", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", "%" + filter + "%");

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("appointment_customer_id", typeof(string));
                dt.Columns.Add("appointment_id", typeof(string));
                dt.Columns.Add("appointment_datetime", typeof(string));
                dt.Columns.Add("appointment_address", typeof(string));
                dt.Columns.Add("appointment_housenumber", typeof(string));
                dt.Columns.Add("appointment_zipcode", typeof(string));
                dt.Columns.Add("appointment_made", typeof(string));
                dt.Columns.Add("appointment_summary", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("customer_residence", typeof(string));
                dt.Columns.Add("customer_address", typeof(string));
                dt.Columns.Add("customer_zip_code", typeof(string));
                dt.Columns.Add("customer_phone_number", typeof(string));
                dt.Columns.Add("customer_email", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterAppointmentsHasSummary()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_appointments.customer_id AS appointment_customer_id, appointment_id, appointment_datetime, appointment_residence, appointment_zipcode, appointment_made, appointment_summary, CONCAT (appointment_streetname, ' ', appointment_housenumber) AS appointment_address, tbl_customers.company_name as company_name, tbl_customers.residence AS customer_residence,CONCAT(tbl_customers.first_name, ' ', tbl_customers.last_name) AS customer_name ,CONCAT (tbl_customers.street_name, ' ', tbl_customers.house_number) AS customer_address, tbl_customers.zip_code AS customer_zip_code, tbl_customers.phone_number AS customer_phone_number, tbl_customers.email AS customer_email
                    
                    FROM
                        tbl_appointments

                    INNER JOIN
                        tbl_customers

                    ON
                        tbl_appointments.customer_id = tbl_customers.customer_id

                    WHERE
                        appointment_summary != ''", this.GetConnection()))
            {

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("appointment_customer_id", typeof(string));
                dt.Columns.Add("appointment_id", typeof(string));
                dt.Columns.Add("appointment_datetime", typeof(string));
                dt.Columns.Add("appointment_address", typeof(string));
                dt.Columns.Add("appointment_housenumber", typeof(string));
                dt.Columns.Add("appointment_zipcode", typeof(string));
                dt.Columns.Add("appointment_made", typeof(string));
                dt.Columns.Add("appointment_summary", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("customer_residence", typeof(string));
                dt.Columns.Add("customer_address", typeof(string));
                dt.Columns.Add("customer_zip_code", typeof(string));
                dt.Columns.Add("customer_phone_number", typeof(string));
                dt.Columns.Add("customer_email", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterAppointmentsHasNoSummary()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_appointments.customer_id AS appointment_customer_id, appointment_id, appointment_datetime, appointment_residence, appointment_zipcode, appointment_made, appointment_summary, CONCAT (appointment_streetname, ' ', appointment_housenumber) AS appointment_address, tbl_customers.company_name as company_name, tbl_customers.residence AS customer_residence,CONCAT(tbl_customers.first_name, ' ', tbl_customers.last_name) AS customer_name ,CONCAT (tbl_customers.street_name, ' ', tbl_customers.house_number) AS customer_address, tbl_customers.zip_code AS customer_zip_code, tbl_customers.phone_number AS customer_phone_number, tbl_customers.email AS customer_email
                    
                    FROM
                        tbl_appointments

                    INNER JOIN
                        tbl_customers

                    ON
                        tbl_appointments.customer_id = tbl_customers.customer_id

                    WHERE
                        appointment_summary = ''", this.GetConnection()))
            {
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("appointment_customer_id", typeof(string));
                dt.Columns.Add("appointment_id", typeof(string));
                dt.Columns.Add("appointment_datetime", typeof(string));
                dt.Columns.Add("appointment_address", typeof(string));
                dt.Columns.Add("appointment_housenumber", typeof(string));
                dt.Columns.Add("appointment_zipcode", typeof(string));
                dt.Columns.Add("appointment_made", typeof(string));
                dt.Columns.Add("appointment_summary", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("customer_residence", typeof(string));
                dt.Columns.Add("customer_address", typeof(string));
                dt.Columns.Add("customer_zip_code", typeof(string));
                dt.Columns.Add("customer_phone_number", typeof(string));
                dt.Columns.Add("customer_email", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable FilterAppointmentsBetweenDate(string filter, string filter2, string colName)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_appointments.customer_id AS appointment_customer_id, appointment_id, appointment_datetime, appointment_residence, appointment_zipcode, appointment_made, appointment_summary, CONCAT (appointment_streetname, ' ', appointment_housenumber) AS appointment_address, tbl_customers.company_name as company_name, tbl_customers.residence AS customer_residence,CONCAT(tbl_customers.first_name, ' ', tbl_customers.last_name) AS customer_name ,CONCAT (tbl_customers.street_name, ' ', tbl_customers.house_number) AS customer_address, tbl_customers.zip_code AS customer_zip_code, tbl_customers.phone_number AS customer_phone_number, tbl_customers.email AS customer_email
                    
                    FROM
                        tbl_appointments

                    INNER JOIN
                        tbl_customers

                    ON
                        tbl_appointments.customer_id = tbl_customers.customer_id

                    WHERE
                        appointment_datetime < 30-11-2016 09:34:50", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("filter", filter);
                cmd.Parameters.AddWithValue("filter2", filter2);

                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("appointment_customer_id", typeof(string));
                dt.Columns.Add("appointment_id", typeof(string));
                dt.Columns.Add("appointment_datetime", typeof(string));
                dt.Columns.Add("appointment_address", typeof(string));
                dt.Columns.Add("appointment_housenumber", typeof(string));
                dt.Columns.Add("appointment_zipcode", typeof(string));
                dt.Columns.Add("appointment_made", typeof(string));
                dt.Columns.Add("appointment_summary", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("customer_residence", typeof(string));
                dt.Columns.Add("customer_address", typeof(string));
                dt.Columns.Add("customer_zip_code", typeof(string));
                dt.Columns.Add("customer_phone_number", typeof(string));
                dt.Columns.Add("customer_email", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable GetAppointments()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_appointments.customer_id AS appointment_customer_id, appointment_datetime, appointment_id,appointment_residence, appointment_zipcode, appointment_made, appointment_summary, CONCAT (appointment_streetname, ' ', appointment_housenumber) AS appointment_address, tbl_customers.company_name as company_name, tbl_customers.residence AS customer_residence, CONCAT (tbl_customers.street_name, ' ', tbl_customers.house_number) AS customer_address, tbl_customers.zip_code AS customer_zip_code, tbl_customers.phone_number AS customer_phone_number, tbl_customers.email AS customer_email, CONCAT (tbl_customers.first_name, ' ', tbl_customers.last_name) AS customer_name
                    
                    FROM
                        tbl_appointments

                    INNER JOIN
                        tbl_customers

                    ON
                        tbl_appointments.customer_id = tbl_customers.customer_id

                    ORDER BY
                        appointment_customer_id DESC", this.GetConnection()))
            {
                
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("appointment_customer_id", typeof(string));
                dt.Columns.Add("appointment_datetime", typeof(string));
                dt.Columns.Add("appointment_id", typeof(string));
                dt.Columns.Add("appointment_address", typeof(string));
                dt.Columns.Add("appointment_housenumber", typeof(string));
                dt.Columns.Add("appointment_zipcode", typeof(string));
                dt.Columns.Add("appointment_made", typeof(string));
                dt.Columns.Add("appointment_summary", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("customer_residence", typeof(string));
                dt.Columns.Add("customer_address", typeof(string));
                dt.Columns.Add("customer_zip_code", typeof(string));
                dt.Columns.Add("customer_phone_number", typeof(string));
                dt.Columns.Add("customer_email", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable GetAppointment(string a_Id)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        tbl_appointments.customer_id AS appointment_customer_id, appointment_datetime, appointment_id,appointment_residence, appointment_zipcode, appointment_summary, appointment_streetname, appointment_housenumber, CONCAT (tbl_appointments.customer_id, ':',tbl_customers.first_name, ' ',tbl_customers.last_name, ',',tbl_customers.zip_code) AS customer_data
                     
                    FROM
                        tbl_appointments

                    INNER JOIN
                        tbl_customers

                    ON
                        tbl_appointments.customer_id = tbl_customers.customer_id

                    WHERE
                        appointment_id = @appointment_id

                    ORDER BY
                        appointment_customer_id DESC", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("appointment_id", a_Id);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("appointment_customer_id", typeof(string));
                dt.Columns.Add("appointment_datetime", typeof(string));
                dt.Columns.Add("appointment_id", typeof(string));
                dt.Columns.Add("appointment_housenumber", typeof(string));
                dt.Columns.Add("appointment_zipcode", typeof(string));
                dt.Columns.Add("appointment_summary", typeof(string));
                dt.Columns.Add("customer_data", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable GetNotifications()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        notification_id, notification_type, notification_date, notification_info
                    FROM
                        tbl_notification
                    WHERE
                        notification_resolved = 0", this.GetConnection()))
            {
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("notification_id", typeof(string));
                dt.Columns.Add("notification_type", typeof(string));
                dt.Columns.Add("notification_date", typeof(string));
                dt.Columns.Add("notification_info", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable GetProjects()
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT 
                        project_id, project_name, project_status, maintenance_contract, operating_system, hardware, software, amount_invoice, deadline_date, contact_person, tbl_projects.customer_id, tbl_customers.company_name AS company_name, CONCAT (tbl_customers.first_name, ' ', tbl_customers.last_name) AS customer_name

                    FROM 
                        tbl_projects
                    INNER JOIN 
                        tbl_customers
                    ON
                        tbl_projects.customer_id = tbl_customers.customer_id
                    ORDER BY
                        project_id DESC", this.GetConnection()))
            {
                
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("project_id", typeof(string));
                dt.Columns.Add("project_name", typeof(string));
                dt.Columns.Add("project_status", typeof(string));
                dt.Columns.Add("maintenance_contact", typeof(string));
                dt.Columns.Add("operating_system", typeof(string));
                dt.Columns.Add("hardware", typeof(string));
                dt.Columns.Add("software", typeof(string));
                dt.Columns.Add("amount_invoice", typeof(string));
                dt.Columns.Add("deadline_date", typeof(string));
                dt.Columns.Add("contact_person", typeof(string));
                dt.Columns.Add("customer_id", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("customer_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public DataTable GetProject(string p_Id)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(@"
                    SELECT 
                        project_id, project_name, project_status, maintenance_contract, operating_system, hardware, software, amount_invoice, deadline_date, contact_person, tbl_projects.customer_id, tbl_customers.company_name AS company_name, CONCAT (tbl_customers.customer_id,':', tbl_customers.first_name, ' ', tbl_customers.last_name, ',', tbl_customers.zip_code) AS full_name 
                    FROM 
                        tbl_projects
                    INNER JOIN 
                        tbl_customers
                    ON
                        tbl_projects.customer_id = tbl_customers.customer_id
                    WHERE
                        project_id = @project_id
                    ORDER BY
                        project_id DESC", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("project_id", p_Id);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt.Columns.Add("project_id", typeof(string));
                dt.Columns.Add("project_name", typeof(string));
                dt.Columns.Add("project_status", typeof(string));
                dt.Columns.Add("maintenance_contract", typeof(string));
                dt.Columns.Add("operating_system", typeof(string));
                dt.Columns.Add("hardware", typeof(string));
                dt.Columns.Add("software", typeof(string));
                dt.Columns.Add("amount_invoice", typeof(string));
                dt.Columns.Add("deadline_date", typeof(string));
                dt.Columns.Add("contact_person", typeof(string));
                dt.Columns.Add("customer_id", typeof(string));
                dt.Columns.Add("company_name", typeof(string));
                dt.Columns.Add("full_name", typeof(string));
                dt.Load(reader);
            }
            return dt;
        }

        public bool ResolveNotification(string n_ID)
        {
            bool succes = false;

            using (MySqlCommand cmd = new MySqlCommand(@"
                    UPDATE
                        tbl_notification
                    SET
                        notification_resolved = 1
                    WHERE
                        notification_id = @notification_id", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("notification_id", n_ID);
                try
                {
                    succes = (Int64)cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    succes = false;
                    MessageBox.Show("An error occured. Details below: \n\n " + e);
                }
            }
            return succes;
        }

        public bool EditProject(string p_Id, string p_Name, string p_status, string m_contract, string OS, string hardware, string software, string amount_invoice, string deadline_date)
        {
            bool success = false;

            using (MySqlCommand cmd = new MySqlCommand(@"
                    UPDATE 
                        tbl_projects
                    SET 
                        project_name = @project_name, project_status = @project_status, maintenance_contract = @maintenance_contract, operating_system = @operating_system, hardware = @hardware, software = @software, amount_invoice = @amount_invoice, deadline_date = @deadline_date 
                    WHERE
                        project_id = @project_id", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("project_id", p_Id);
                cmd.Parameters.AddWithValue("project_name", p_Name);
                cmd.Parameters.AddWithValue("project_status", p_status);
                cmd.Parameters.AddWithValue("maintenance_contract", m_contract);
                cmd.Parameters.AddWithValue("operating_system", OS);
                cmd.Parameters.AddWithValue("hardware", hardware);
                cmd.Parameters.AddWithValue("software", software);
                cmd.Parameters.AddWithValue("amount_invoice", amount_invoice);
                cmd.Parameters.AddWithValue("deadline_date", deadline_date);
                try
                {
                    success = (Int64)cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception e)
                {
                    success = false;
                    MessageBox.Show("An error occured. Details below: \n\n " + e);
                }
                return success;
            }
        }

        public bool EditAppointment(string a_Id, string a_Date, string a_Residence, string a_Streetname, string a_Housenumber, string a_Zipcode, string a_Summary)
        {
            bool done;
            using (MySqlCommand cmd = new MySqlCommand(@"
                    UPDATE
                        tbl_appointments
                    SET
                        appointment_residence = @appointment_residence, appointment_streetname = @appointment_streetname, appointment_housenumber = @appointment_housenumber,appointment_zipcode = @appointment_zipcode,appointment_datetime = @appointment_datetime,appointment_summary = @appointment_summary                                                                                                                         
                    WHERE
                        appointment_id = @appointment_id", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("appointment_id", a_Id);
                cmd.Parameters.AddWithValue("appointment_datetime", a_Date);
                cmd.Parameters.AddWithValue("appointment_residence", a_Residence);
                cmd.Parameters.AddWithValue("appointment_streetname", a_Streetname);
                cmd.Parameters.AddWithValue("appointment_housenumber", a_Housenumber);
                cmd.Parameters.AddWithValue("appointment_zipcode", a_Zipcode);
                cmd.Parameters.AddWithValue("appointment_summary", a_Summary);
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

        public bool AddAppointment(string c_Id, string a_Date, string a_Residence, string a_Streetname, string a_Housenumber, string a_Zipcode,string a_Summary)
        {
            bool done;
            using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO
                        tbl_appointments(customer_id, appointment_datetime, appointment_residence, appointment_streetname, appointment_housenumber, appointment_zipcode, appointment_made, appointment_summary)
                        VALUES (@customer_id, @appointment_datetime, @appointment_residence, @appointment_streetname, @appointment_housenumber, @appointment_zipcode, @appointment_made, @appointment_summary)", this.GetConnection()))
            {
                cmd.Parameters.AddWithValue("customer_id", c_Id);
                cmd.Parameters.AddWithValue("appointment_datetime", a_Date);
                cmd.Parameters.AddWithValue("appointment_residence", a_Residence);
                cmd.Parameters.AddWithValue("appointment_streetname", a_Streetname);
                cmd.Parameters.AddWithValue("appointment_housenumber", a_Housenumber);
                cmd.Parameters.AddWithValue("appointment_zipcode", a_Zipcode);
                cmd.Parameters.AddWithValue("appointment_made", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("appointment_summary", a_Summary);  
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
