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
        bool showallCustomers = false;
        bool showallAppointments = false;
        bool showallInvoices = false;

        public frm_Sales()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();
            ShowCustomers();
            ShowAppointments();
            ShowInvoices();
            HideFilters(true, false, false, false);
        }

        private void MenuHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem toolstrip;
            toolstrip = sender as ToolStripMenuItem;

            switch (toolstrip.Name)
            {
                case "mnitem_Overview":
                    tcp_Main.SelectedIndex = 0;
                    HideFilters(true, false, false, false);
                    break;
                case "mnitem_Appointments":
                    tcp_Main.SelectedIndex = 1;
                    HideFilters(false, true, false, false);
                    break;
                case "mnitem_Invoices":
                    tcp_Main.SelectedIndex = 2;
                    HideFilters(false, false, true,false);
                    break;
                case "mnitem_Customers":
                    tcp_Main.SelectedIndex = 3;
                    HideFilters(false, false, false, true);
                    break;
                default:
                    tcp_Main.SelectedIndex = 0;
                    break;
            }
        }

        private void HideFilters(bool overview, bool Appointments, bool Invoices, bool Customers)
        {
            Font bold = new Font(mnitem_Overview.Font, FontStyle.Bold);
            Font regular = new Font(mnitem_Overview.Font, FontStyle.Regular);

            if (overview)
                mnitem_Overview.Font = bold;
            else
                mnitem_Overview.Font = regular;
            if (Appointments)
                mnitem_Appointments.Font = bold;
            else
                mnitem_Appointments.Font = regular;
            if (Invoices)
                mnitem_Invoices.Font = bold;
            else
                mnitem_Invoices.Font = regular;
            if (Customers)
                mnitem_Customers.Font = bold;
            else
                mnitem_Customers.Font = regular;

            mnfltr_Overview_Department.Visible = overview;
            mnfltr_Overview_Type.Visible = overview;
            mnfltr_Overview_Date.Visible = overview;

            mnfltr_Apointments_Residence.Visible = Appointments;
            mnfltr_Appontments_CoName.Visible = Appointments;
            mnfltr_Appointments_CuName.Visible = Appointments;
            mnfltr_Appointments_date.Visible = Appointments;
            mnfltr_Appointments_Summary.Visible = Appointments;

            mnfltr_Invoices_CuName.Visible = Invoices;
            mnfltr_Invoices_CoName.Visible = Invoices;
            mnfltr_Invoices_Paid.Visible = Invoices;
            mnfltr_Invoices_Number.Visible = Invoices;

            mnfltr_Customers_CuName.Visible = Customers;
            mnfltr_Customers_CoName.Visible = Customers;
            mnfltr_Customers_Residence.Visible = Customers;
            mnfltr_Customers_UnpaidInvoice.Visible = Customers;

        }

        //private void mnitem_Logout_Click(object sender, EventArgs e)
        //{
        //    frm_Logout lgfrm = new frm_Logout(this);
        //    lgfrm.Show();
        //}

        //private void frm_Sales_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}

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
            if (!showallCustomers && amount > 5)
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

        private void FillEditCustomer(object sender, EventArgs e)
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
            lblCustomerId.Text = dt.Rows[0]["customer_id"].ToString();
            lblCustomer_FirstName.Text = dt.Rows[0]["first_name"].ToString();
            lblCustomer_LastName.Text = dt.Rows[0]["last_name"].ToString();

            tcp_Main.SelectedIndex = 5;
            dbh.CloseConnection();
        }

        private void EditCustomer(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(txtbCustomerFax.Text, out result) && !int.TryParse(txtbCustomerPhonenumber1.Text,out result))
            {
                MessageBox.Show("fax of phonenumber are not numbers");
            }
            else
            {
                dbh.OpenConnection();
                if (dbh.EditCustomer(lblCustomerId.Text, lblCustomer_FirstName.Text, lblCustomer_LastName.Text, txtbCustomerCompanyName.Text, txtbCustomerMail.Text, txtbCustomerFax.Text, txtbCustomerStreetName1.Text, txtbCustomerHousenumber1.Text, txtbCustomerResidence1.Text, txtbCustomerZipcode1.Text, txtbCustomerPhonenumber1.Text))
                {
                    MessageBox.Show("Succesfully added customer!");
                }
                else
                {
                    MessageBox.Show("An error occcured while adding a project.");
                }
                dbh.CloseConnection();
            }
        }

        private void btn_Project_Show_All_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "Are you sure you want to exit? Any unsaved changes will be lost.", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Frm_Login frmlogin = new Frm_Login();
                    frmlogin.Show();
                    break;
            }
        }

        private void mnitem_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            tcp_Main.SelectedIndex = 4;
        }

        private void btn_showallAppointments_Click(object sender, EventArgs e)
        {

        }

        private void ShowAppointments()
        {
            dbh.OpenConnection();
            DataTable dt = dbh.GetAppointments();
            int amount = dt.Rows.Count;
            if (!showallAppointments && amount > 5)
                amount = 5;

            AppointmentPanel[] appointmentInfoPanel = new AppointmentPanel[amount];

            for (int i = 0; i < appointmentInfoPanel.Length; i++)
            {
                appointmentInfoPanel[i] = new AppointmentPanel(i, dt);
                appointmentInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                appointmentInfoPanel[i].Dock = DockStyle.Top;
                appointmentsPanel.Controls.Add(appointmentInfoPanel[i]);
                appointmentInfoPanel[i].btn_Edit.AccessibleName = dt.Rows[i]["appointment_id"].ToString();
                //appointmentInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditAppointmentItems);
            }
            dbh.CloseConnection();
        }

        private void btn_ShowAllCustomers_Click(object sender, EventArgs e)
        {
            showallCustomers = true;
            panel1.Controls.Clear();
            ShowCustomers();
        }

        private void ShowInvoices()
        {
            dbh = new DatabaseHandler();
            dbh.OpenConnection();
            DataTable dt = dbh.GetInvoices();
            int amount = dt.Rows.Count;
            if (!showallInvoices && amount > 5)
                amount = 5;

            InvoicePanel[] invoiceInfoPanel = new InvoicePanel[amount];

            for (int i = 0; i < invoiceInfoPanel.Length; i++)
            {
                invoiceInfoPanel[i] = new InvoicePanel(i, dt);
                invoiceInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                invoiceInfoPanel[i].Dock = DockStyle.Top;
                invoicesPanel.Controls.Add(invoiceInfoPanel[i]);
            }
            dbh.CloseConnection();
        }

        private void btn_ShowAllInvoices_Click(object sender, EventArgs e)
        {
            showallInvoices = true;
            invoicesPanel.Controls.Clear();
            ShowInvoices();
        }

        private void SearchCustomerOnCu_Name(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Customers_CuName.Text;
            if (e.KeyCode == Keys.Return)
            {
                dbh.OpenConnection();
                panel1.Controls.Clear();
                DataTable dt = dbh.FilterCustomers(filter, "first_name", "last_name");
                int amount = dt.Rows.Count;
                if (!showallCustomers && amount > 5)
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
        }
    }
}
