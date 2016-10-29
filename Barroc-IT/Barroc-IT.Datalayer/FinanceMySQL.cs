using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barroc_IT;
using Barroc_IT.Models;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Barroc_IT.Datalayer
{
    public class FinanceMySQL
    {
        private MySQLHandler mySqlHandler;


        public FinanceMySQL()
        {
            mySqlHandler = new MySQLHandler();            
        }

        public List<Finance> getFinances()
        {
            List<Finance> finances = new List<Finance>();
            try
            {
                string sqlQuery = "SELECT C.bankAccount, C.credit_balance as 'balance', I.count, P.profit, C.limit, P.maintenance_contract as 'contract' FROM tbl_customers C, tbl_invoices I, tbl_projects P WHERE P.customer_id = C.customer_id AND I.project_id = P.project_id";
                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, mySqlHandler.getConnection()))
                {
                    mySqlHandler.OpenMySqlConnection();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Finance finance = new Finance()
                                {
                                    bankAccount = reader.GetString("bankAccount"),
                                    saldo = reader.GetDouble("balance"),
                                    invoiceCount = reader.GetInt32("count"),
                                    profit = reader.GetDouble("profit"),
                                    limit = reader.GetDouble("limit"),
                                    maintenanceContract = reader.GetInt32("contract")
                                };
                                finances.Add(finance);
                            }
                        }
                    }
                    mySqlHandler.CloseMySqlConnection();
                }
                return finances;
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }
        }
    }
}

