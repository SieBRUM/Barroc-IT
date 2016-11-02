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
            HideFilters(true, false, false);
        }

        private void MenuHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem toolstrip;
            toolstrip = sender as ToolStripMenuItem;

            switch (toolstrip.Name)
            {
                case "mnitem_Overview":
                    tcp_Main.SelectedIndex = 0;
                    HideFilters(true, false, false);
                    break;
                case "mnitem_Projects":
                    tcp_Main.SelectedIndex = 1;
                    HideFilters(false, true, false);
                    break;
                case "mnitem_Appointments":
                    tcp_Main.SelectedIndex = 2;
                    HideFilters(false, false, true);
                    break;
                default:
                    tcp_Main.SelectedIndex = 0;
                    break;
            }
        }

        private void HideFilters(bool overview, bool projects, bool appointments)
        {
            Font bold = new Font(mnitem_Overview.Font, FontStyle.Bold);
            Font regular = new Font(mnitem_Overview.Font, FontStyle.Regular);

            if (overview)
                mnitem_Overview.Font = bold;
            else
                mnitem_Overview.Font = regular;
            if (projects)
                mnitem_Projects.Font = bold;
            else
                mnitem_Projects.Font = regular;
            if (appointments)
                mnitem_Appointments.Font = bold;
            else
                mnitem_Appointments.Font = regular;

            mnfltr_Overview_Department.Visible = overview;
            mnfltr_Overview_Type.Visible = overview;
            mnfltr_Overview_Date.Visible = overview;

            mnfltr_Projects_CuName.Visible = projects;
            mnfltr_Projects_ID.Visible = projects;
            mnfltr_Projects_Name.Visible = projects;

            mnfltr_Appointments_CuName.Visible = appointments;
            mnfltr_Appointments_CoName.Visible = appointments;
            mnfltr_Appointments_Residence.Visible = appointments;
            mnfltr_Appointments_Summary.Visible = appointments;
            mnfltr_Appointments_Date.Visible = appointments;
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
            txtbCustomerCompanyName.Text = dt.Rows[0]["company_name"].ToString();
            txtbCustomerFax.Text = dt.Rows[0]["fax"].ToString();
            txtbCustomerStreetName1.Text = dt.Rows[0]["street_name"].ToString();
            txtbCustomerHousenumber1.Text = dt.Rows[0]["house_number"].ToString();
            txtbCustomerResidence1.Text = dt.Rows[0]["residence"].ToString();
            txtbCustomerZipcode1.Text = dt.Rows[0]["zip_code"].ToString();
            txtbCustomerPhonenumber1.Text = dt.Rows[0]["phone_number"].ToString();
            txtbCustomerStreetName2.Text = dt.Rows[0]["street_name_2"].ToString();
            txtbCustomerHousenumber2.Text = dt.Rows[0]["house_number_2"].ToString();
            txtbCustomerResidence2.Text = dt.Rows[0]["residence_2"].ToString();
            txtbCustomerZipcode2.Text = dt.Rows[0]["zip_code_2"].ToString();
            txtbCustomerPhonenumber2.Text = dt.Rows[0]["phone_number_2"].ToString();
            dtpCustomerLastContact.Text = dt.Rows[0]["last_contact"].ToString();
            txtbCustomerLastAction.Text = dt.Rows[0]["last_action"].ToString();
            dtpCustomerNextContact.Text = dt.Rows[0]["next_contact"].ToString();
            txtbCustomerNextAction.Text = dt.Rows[0]["next_action"].ToString();
            lblCustomerNameCustomer.Text = dt.Rows[0]["customer_name"].ToString();

            tcp_Main.SelectedIndex = 3;
            dbh.CloseConnection();
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
