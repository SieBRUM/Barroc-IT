using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class frm_Sales : Form
    {
        DatabaseHandler dbh;
        bool showallCustomer = false;

        public frm_Sales()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();
            ShowCustomers();
        }

        private void mnitem_Logout_Click(object sender, EventArgs e)
        {
            frm_Logout lgfrm = new frm_Logout(this);
            lgfrm.Show();
        }

        private void frm_Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nextContact = DateHandler.GetDate(dtp_customer_nextcontact);
            string lastContact = DateHandler.GetDate(dtp_customer_lastcontact);

            if (txtb_customer_firstname.Text == "" || txtb_customer_lastname.Text == "" || txtb_customer_email.Text == "" || txtb_customer_streetname_1.Text == "" || txtb_customer_housenumber_1.Text == "" || txtb_customer_residence_1.Text == "" || txtb_customer_zipcode_1.Text == "" || txtb_customer_phonenumber_1.Text == "" || txtb_customer_last_action.Text == "" || txtb_customer_next_action.Text == "")
            {
                MessageBox.Show("Please make sure all the neccesary fields are filled in.");
            }
            else if (dtp_customer_nextcontact.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Date of next contact cannot be in the past.");
            }
            else
            {
                dbh.OpenConnection();

                if (dbh.AddCustomer(txtb_customer_firstname.Text, txtb_customer_lastname.Text, txtb_customer_company_name.Text, txtb_customer_email.Text, txtb_customer_fax.Text, txtb_customer_streetname_1.Text, txtb_customer_housenumber_1.Text, txtb_customer_residence_1.Text, txtb_customer_zipcode_1.Text, txtb_customer_phonenumber_1.Text, txtb_customer_streetname_2.Text, txtb_customer_housenumber_2.Text, txtb_customer_residence_2.Text, txtb_customer_zipcode_2.Text, txtb_customer_phonenumber_2.Text, lastContact, txtb_customer_last_action.Text, nextContact, txtb_customer_next_action.Text))
                    MessageBox.Show("Succesfully added a customer!");
                else
                    MessageBox.Show("An error occcured while adding a customer.");

                dbh.AddNotification(txtb_customer_firstname.Text, "Creditworthy check", "Finance");
                dbh.CloseConnection();
            }
        }

        private void ShowCustomers()
        {
            dbh.OpenConnection();
            DataTable dt = dbh.GetCustomers();
            int amount = dt.Rows.Count;
            if (!showallCustomer && amount > 5)
                amount = 5;

            CustomerPanel[] customerInfoPanel = new CustomerPanel[amount];

            for (int i = 0; i < customerInfoPanel.Length; i++)
            {
                customerInfoPanel[i] = new CustomerPanel(i, dt);
                customerInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                customerInfoPanel[i].Dock = DockStyle.Top;
                panel1.Controls.Add(customerInfoPanel[i]);
                customerInfoPanel[i].btn_editCustomer.AccessibleName = dt.Rows[i]["customer_id"].ToString();
                customerInfoPanel[i].btn_editCustomer.Click += new System.EventHandler(this.FillEditCustomer);
            }
            dbh.CloseConnection();            
        }

        private void FillEditCustomer (object sender, EventArgs e)
        {
            dbh.OpenConnection();
            Button button = (Button)sender;
            DataTable dt = dbh.GetCustomer(button.AccessibleName);
            txtbCustomerMail.Text = dt.Rows[0]["email"].ToString();
            

            tc_Main.SelectedIndex = 3;
        }

        private void btn_Project_Show_All_Click(object sender, EventArgs e)
        {

        }

        private void btn_Project_Show_All_Click_1(object sender, EventArgs e)
        {
            showallCustomer = true;
            panel1.Controls.Clear();
            ShowCustomers();
            
        }

        private struct Customer
        {
            private string first_name;
            private string last_name;
            private string company_name;
            private string email;
            private string fax;
            private string streetname_1;
            private string housenumber_1;
            private string residence_1;
            private string zipcode_1;
            private string phonenumber_1;
            private string streetname_2;
            private string housenumber_2;
            private string residence_2;
            private string zipcode_2;
            private string phonenumber_2;
            private string lastContact;
            private string lastAction;
            private string nextContact;
            private string nextAction;
        }
    }
}
