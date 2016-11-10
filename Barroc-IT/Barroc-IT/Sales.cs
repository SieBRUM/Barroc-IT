using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class frm_Sales : Form
    {
        DatabaseHandler dbh;
        bool showallCustomers = false;
        bool showallAppointments = false;
        bool showallInvoices = false;
        bool showallNotifications = false;

        public frm_Sales()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();
            //ShowCustomers();
            //ShowAppointments();
            //ShowInvoices();
            ShowNotifications();

            ToolStripControlHost[] arrayControl = MenuItems.DTPGenerator(this);
            ToolStripControlHost[] arrayControl1 = MenuItems.DTPGenerator(this);
            HideFilters(true, false, false, false);

            for (int i = 0; i < arrayControl.Length; i++)
            {
                mnfltr_Overview_Date.DropDownItems.Add(arrayControl[i]);
                mnfltr_Appointments_date.DropDownItems.Add(arrayControl1[i]);
            }
        }

        public void SetDateFromLabel(object sender, EventArgs e)
        {
            if (tc_Main.SelectedIndex == 0)
            {
                DateTimePicker dtp = (DateTimePicker)sender;
                lbl_Date_From.Text = DateHandler.GetDateWithMinus(dtp).ToString();

            }
            else
            {
                DateTimePicker dtp = (DateTimePicker)sender;
                lbl_Appointment_DateFrom.Text = dtp.Value.ToString();
            }
        }

        public void SetDateTillLabel(object sender, EventArgs e)
        {
            if (tc_Main.SelectedIndex == 0)
            {
                DateTimePicker dtp = (DateTimePicker)sender;
                lbl_Date_Till.Text = DateHandler.GetDateWithMinus(dtp).ToString();
            }
            else
            {
                DateTimePicker dtp = (DateTimePicker)sender;
                lbl_Appointment_DateTill.Text = dtp.Value.ToString();
            }
        }

        public void Search(object sender, EventArgs e)
        {
            if (tc_Main.SelectedIndex == 0)
                SearchNotificationOnDate(sender, e);
            else
                SearchAppointmentOnDate(sender, e);
        }

        public void SearchNotificationOnDate(object sender, EventArgs e)
        {
            string fromDate = lbl_Date_From.Text;
            string tillDate = lbl_Date_Till.Text;

            dbh.OpenConnection();
            notificationsPanel.Controls.Clear();
            DataTable dt = dbh.FilterNotificationsBetweenDate(fromDate, tillDate, "notification_date");
            int amount = dt.Rows.Count;
            if (!showallNotifications && amount > 5)
                amount = 5;
            OverviewPanel[] overviewInfoPanel = new OverviewPanel[amount];

            for (int i = 0; i < overviewInfoPanel.Length; i++)
            {
                overviewInfoPanel[i] = new OverviewPanel(i, dt);
                overviewInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                overviewInfoPanel[i].Dock = DockStyle.Top;
                overviewInfoPanel[i].btn_Resolved.AccessibleName = dt.Rows[i]["notification_ID"].ToString();
                overviewInfoPanel[i].btn_Resolved.Click += new System.EventHandler(this.ResolveNotification);
                notificationsPanel.Controls.Add(overviewInfoPanel[i]);
            }
            dbh.CloseConnection();
        }

        private void SearchNotificationOnType(object sender, EventArgs e)
        {
            if (tscmb_Overview_Type.Text == "All")
            {
                dbh.OpenConnection();
                notificationsPanel.Controls.Clear();
                DataTable dt = dbh.GetNotifications();
                int amount = dt.Rows.Count;

                OverviewPanel[] overviewInfoPanel = new OverviewPanel[amount];

                for (int i = 0; i < overviewInfoPanel.Length; i++)
                {
                    overviewInfoPanel[i] = new OverviewPanel(i, dt);
                    overviewInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    overviewInfoPanel[i].Dock = DockStyle.Top;
                    overviewInfoPanel[i].btn_Resolved.AccessibleName = dt.Rows[i]["notification_ID"].ToString();
                    overviewInfoPanel[i].btn_Resolved.Click += new System.EventHandler(this.ResolveNotification);
                    notificationsPanel.Controls.Add(overviewInfoPanel[i]);
                }
                dbh.CloseConnection();
            }
            else
            {
                string filter = tscmb_Overview_Type.Text;
                dbh.OpenConnection();
                notificationsPanel.Controls.Clear();
                DataTable dt = dbh.FilterNotifications(filter, "notification_type");
                int amount = dt.Rows.Count;

                OverviewPanel[] overviewInfoPanel = new OverviewPanel[amount];

                for (int i = 0; i < overviewInfoPanel.Length; i++)
                {
                    overviewInfoPanel[i] = new OverviewPanel(i, dt);
                    overviewInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    overviewInfoPanel[i].Dock = DockStyle.Top;
                    overviewInfoPanel[i].btn_Resolved.AccessibleName = dt.Rows[i]["notification_ID"].ToString();
                    overviewInfoPanel[i].btn_Resolved.Click += new System.EventHandler(this.ResolveNotification);
                    notificationsPanel.Controls.Add(overviewInfoPanel[i]);
                }
                dbh.CloseConnection();
            }
        }

        private void tscmb_Overview_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = tscmb_Overview_Department.Text;

            dbh.OpenConnection();
            notificationsPanel.Controls.Clear();
            DataTable dt = dbh.FilterNotifications(filter, "notification_department");
            int amount = dt.Rows.Count;
            if (!showallNotifications && amount > 5)
                amount = 5;
            MessageBox.Show(amount.ToString() + dt.Rows.Count.ToString());
            OverviewPanel[] overviewInfoPanel = new OverviewPanel[amount];

            for (int i = 0; i < overviewInfoPanel.Length; i++)
            {
                overviewInfoPanel[i] = new OverviewPanel(i, dt);
                overviewInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                overviewInfoPanel[i].Dock = DockStyle.Top;
                overviewInfoPanel[i].btn_Resolved.AccessibleName = dt.Rows[i]["notification_ID"].ToString();
                overviewInfoPanel[i].btn_Resolved.Click += new System.EventHandler(this.ResolveNotification);
                notificationsPanel.Controls.Add(overviewInfoPanel[i]);
            }
            dbh.CloseConnection();
        }

        private void MenuHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem toolstrip;
            toolstrip = sender as ToolStripMenuItem;

            switch (toolstrip.Name)
            {
                case "mnitem_Overview":
                    tc_Main.SelectedIndex = 0;
                    HideFilters(true, false, false, false);
                    break;
                case "mnitem_Appointments":
                    lbl_Appointment_DateTill.Text = DateTime.Today.ToString();
                    lbl_Appointment_DateFrom.Text = DateTime.Today.ToString();
                    tc_Main.SelectedIndex = 1;
                    HideFilters(false, true, false, false);
                    break;
                case "mnitem_Invoices":
                    tc_Main.SelectedIndex = 2;
                    HideFilters(false, false, true, false);
                    break;
                case "mnitem_Customers":
                    tc_Main.SelectedIndex = 3;
                    HideFilters(false, false, false, true);
                    break;
                default:
                    tc_Main.SelectedIndex = 0;
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

        private void AddCustomer(object sender, EventArgs e)
        {
            int result;
            bool check = true;
            int optional = 0;
            foreach (Control a in tcp_AddCustomer.Controls)
            {
                if (a is TextBox)
                {
                    if (a.AccessibleName != "OptionalLocation" && a.AccessibleName != "VeryOptional")
                    {
                        if (a.Text == "")
                        {
                            check = false;
                        }
                    }
                    else if (a.AccessibleName == "OptionalLocation")
                    {
                        if (a.Text != "")
                        {
                            ++optional;
                        }
                    }
                }
            }

            string nextContact = DateHandler.GetDate(dtp_customer_nextcontact);
            string lastContact = DateHandler.GetDate(dtp_customer_lastcontact);

            if (!check)
            {
                MessageBox.Show("Please make sure all the neccesary fields are filled in.");
            }
            else if (optional != 0 && optional != 4)
            {
                MessageBox.Show("All address details have to be filled in!");
            }
            else if (!int.TryParse(txtb_customer_fax.Text, out result) && !int.TryParse(txtb_customer_phonenumber_1.Text, out result) && !int.TryParse(txtb_customer_phonenumber_2.Text, out result))
            {
                MessageBox.Show("fax or phonenumber are not numbers");
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

                dbh.AddNotification(txtb_customer_firstname.Text, "Creditworthy check", "Finance", " needs to be checked on creditworthyness.");
                dbh.AddNotification(txtb_customer_firstname.Text, "Add financial details", "Finance", " needs his financial details to be added");
                dbh.CloseConnection();
            }
        }

        private void ShowCustomers()
        {
            customersPanel.Controls.Clear();

            dbh.OpenConnection();
            DataTable dt = dbh.GetCustomers();
            int amount = dt.Rows.Count;
            if (!showallCustomers && amount > 5)
            {
                amount = 5;

                Button showAllCustomersButton = new Button();
                showAllCustomersButton.Text = "Show all customers";
                showAllCustomersButton.Dock = DockStyle.Bottom;
                showAllCustomersButton.Click += new System.EventHandler(this.ShowAllCustomers);
                customersPanel.Controls.Add(showAllCustomersButton);
            }

            CustomerPanel[] customerInfoPanel = new CustomerPanel[amount];

            for (int i = 0; i < customerInfoPanel.Length; i++)
            {
                customerInfoPanel[i] = new CustomerPanel(i, dt);
                customerInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                customerInfoPanel[i].Dock = DockStyle.Top;
                customersPanel.Controls.Add(customerInfoPanel[i]);
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

            tc_Main.SelectedIndex = 5;
            dbh.CloseConnection();
        }

        private void EditCustomer(object sender, EventArgs e)
        {
            int result;
            bool check = true;
            int optional = 0;
            foreach (Control a in tcp_EditCustomer.Controls)
            {
                if (a is TextBox)
                {
                    if (a.AccessibleName != "OptionalLocation" && a.AccessibleName != "VeryOptional")
                    {
                        if (a.Text == "")
                        {
                            check = false;
                        }
                    }
                    else if (a.AccessibleName == "OptionalLocation")
                    {
                        if (a.Text != "")
                        {
                            ++optional;
                        }
                    }
                }
            }

            if (!int.TryParse(txtbCustomerFax.Text, out result) && !int.TryParse(txtbCustomerPhonenumber1.Text, out result) && !int.TryParse(txtbCustomerPhonenumber2.Text, out result))
            {
                MessageBox.Show("fax or phonenumber are not numbers");
            }
            else if (!check)
            {
                MessageBox.Show("Not all fields are filled in.");
            }
            else if (optional != 0 && optional != 4)
            {
                MessageBox.Show("All address details have to be filled in!");
            }
            else if (dtpCustomerNextContact.Value < DateTime.Now)
            {
                MessageBox.Show("Next action date cannot be in the past!");
            }
            else
            {

                string nextContact = DateHandler.GetDate(dtpCustomerNextContact);
                string lastContact = DateHandler.GetDate(dtpCustomerLastContact);
                dbh.OpenConnection();

                if (dbh.EditCustomer(lblCustomerId.Text, txtbCustomerCompanyName.Text, txtbCustomerMail.Text, txtbCustomerFax.Text, txtbCustomerStreetName1.Text, txtbCustomerHousenumber1.Text, txtbCustomerResidence1.Text, txtbCustomerZipcode1.Text, txtbCustomerPhonenumber1.Text, txtbCustomerStreetName2.Text, txtbCustomerHousenumber2.Text, txtbCustomerResidence2.Text, txtbCustomerZipcode2.Text, txtbCustomerPhonenumber2.Text, txtbCustomerLastAction.Text, txtbCustomerNextAction.Text, lastContact, nextContact))
                {
                    MessageBox.Show("Succesfully edited customer!");
                }
                else
                {
                    MessageBox.Show("An error occcured while editing a customer!");
                }
                dbh.CloseConnection();
            }
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
            tc_Main.SelectedIndex = 4;
        }

        private void ShowAllAppointments(object sender, EventArgs e)
        {
            showallAppointments = true;
            appointmentsPanel.Controls.Clear();
            ShowAppointments();
        }

        private void ShowAppointments()
        {
            appointmentsPanel.Controls.Clear();

            dbh.OpenConnection();
            DataTable dt = dbh.GetAppointments();
            int amount = dt.Rows.Count;
            if (!showallAppointments && amount > 5)
            {
                amount = 5;

                Button btn_showAllAppointments = new Button();
                btn_showAllAppointments.Text = "Show all appointments";
                btn_showAllAppointments.Dock = DockStyle.Bottom;
                btn_showAllAppointments.Click += new System.EventHandler(this.ShowAllAppointments);
                appointmentsPanel.Controls.Add(btn_showAllAppointments);
            }

            AppointmentPanel[] appointmentInfoPanel = new AppointmentPanel[amount];

            for (int i = 0; i < appointmentInfoPanel.Length; i++)
            {
                appointmentInfoPanel[i] = new AppointmentPanel(i, dt);
                appointmentInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                appointmentInfoPanel[i].Dock = DockStyle.Top;
                appointmentsPanel.Controls.Add(appointmentInfoPanel[i]);
                appointmentInfoPanel[i].btn_Edit.AccessibleName = dt.Rows[i]["appointment_id"].ToString();
                appointmentInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditAppointmentItems);
            }
            dbh.CloseConnection();
        }

        private void ShowAllCustomers(object sender, EventArgs e)
        {
            showallCustomers = true;
            customersPanel.Controls.Clear();
            ShowCustomers();
        }

        private void ShowInvoices()
        {
            invoicesPanel.Controls.Clear();

            dbh = new DatabaseHandler();
            dbh.OpenConnection();
            DataTable dt = dbh.GetInvoices();
            int amount = dt.Rows.Count;
            if (!showallInvoices && amount > 5)
            {
                amount = 5;

                Button btn_showAllInvoices = new Button();
                btn_showAllInvoices.Text = "Show all invoices";
                btn_showAllInvoices.Dock = DockStyle.Bottom;
                btn_showAllInvoices.Click += new System.EventHandler(this.ShowAllAppointments);
                appointmentsPanel.Controls.Add(btn_showAllInvoices);
                dbh.CloseConnection();
            }

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

        private void ShowAllInvoices(object sender, EventArgs e)
        {
            showallInvoices = true;
            invoicesPanel.Controls.Clear();
            ShowInvoices();
        }

        private void SearchInvoiceOnCu_Name(object sender, KeyEventArgs e)
        {
            //WORK IN PROGRESS
        }

        private void SearchCustomerOnCu_Name(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Customers_CuName.Text;
            if (e.KeyCode == Keys.F5)
            {
                dbh.OpenConnection();
                customersPanel.Controls.Clear();
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
                    customersPanel.Controls.Add(customerInfoPanel[i]);
                    customerInfoPanel[i].btn_editCustomer.AccessibleName = dt.Rows[i]["customer_id"].ToString();
                    customerInfoPanel[i].btn_editCustomer.Click += new System.EventHandler(this.FillEditCustomer);
                }
                dbh.CloseConnection();
            }
        }

        private void SearchCustomerOnCo_Name(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Customers_CoName.Text;
            if (e.KeyCode == Keys.Return)
            {
                dbh.OpenConnection();
                customersPanel.Controls.Clear();
                DataTable dt = dbh.FilterCustomers(filter, "company_name");
                int amount = dt.Rows.Count;
                if (!showallCustomers && amount > 5)
                    amount = 5;

                CustomerPanel[] customerInfoPanel = new CustomerPanel[amount];

                for (int i = 0; i < customerInfoPanel.Length; i++)
                {
                    customerInfoPanel[i] = new CustomerPanel(i, dt);
                    customerInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    customerInfoPanel[i].Dock = DockStyle.Top;
                    customersPanel.Controls.Add(customerInfoPanel[i]);
                    customerInfoPanel[i].btn_editCustomer.AccessibleName = dt.Rows[i]["customer_id"].ToString();
                    customerInfoPanel[i].btn_editCustomer.Click += new System.EventHandler(this.FillEditCustomer);
                }
                dbh.CloseConnection();
            }
        }

        private void SearchCustomerOnResidence(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Customers_Residence.Text;
            if (e.KeyCode == Keys.Return)
            {
                dbh.OpenConnection();
                customersPanel.Controls.Clear();
                DataTable dt = dbh.FilterCustomers(filter, "tbl_customers.residence", "tbl_customers.residence_2");
                int amount = dt.Rows.Count;
                if (!showallCustomers && amount > 5)
                    amount = 5;

                CustomerPanel[] customerInfoPanel = new CustomerPanel[amount];

                for (int i = 0; i < customerInfoPanel.Length; i++)
                {
                    customerInfoPanel[i] = new CustomerPanel(i, dt);
                    customerInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    customerInfoPanel[i].Dock = DockStyle.Top;
                    customersPanel.Controls.Add(customerInfoPanel[i]);
                    customerInfoPanel[i].btn_editCustomer.AccessibleName = dt.Rows[i]["customer_id"].ToString();
                    customerInfoPanel[i].btn_editCustomer.Click += new System.EventHandler(this.FillEditCustomer);
                }
                dbh.CloseConnection();
            }
        }

        private void AddAppointment(object sender, EventArgs e)
        {
            if (txtb_A_Appointment_Housenumber.Text == "" || txtb_A_Appointment_Residence.Text == "" || txtb_A_Appointment_Streetname.Text == "" || txtb_A_Appointment_Zipcode.Text == "" || rtb_A_Appointment.Text == "")
            {
                MessageBox.Show("Make sure all fields are filled in correctly!");
            }
            else if (dtp_A_Appointment.Value < DateTime.Now)
            {
                MessageBox.Show("Date cannot be in the past!");
            }
            else
            {
                dbh.OpenConnection();
                if (dbh.AddAppointment(cb_Appointment_Select_Customer.SelectedValue.ToString(), dtp_A_Appointment.Value.ToString(), txtb_A_Appointment_Residence.Text, txtb_A_Appointment_Streetname.Text, txtb_A_Appointment_Housenumber.Text, txtb_A_Appointment_Zipcode.Text, rtb_A_Appointment.Text))
                    MessageBox.Show("Succesfully added an appointment!");
                else
                    MessageBox.Show("An error occcured while adding an appointment.");
                dbh.CloseConnection();
            }
        }

        private void tc_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_Main.SelectedIndex == 1)
            {
                try
                {
                    showallAppointments = false;
                    ShowAppointments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: \n" + ex);
                }
                finally
                {
                    dbh.CloseConnection();
                }
            }
            if (tc_Main.SelectedIndex == 2)
            {
                try
                {
                    showallInvoices = false;
                    ShowInvoices();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: \n" + ex);
                }
                finally
                {
                    dbh.CloseConnection();
                }
            }
            if (tc_Main.SelectedIndex == 3)
            {
                try
                {
                    showallCustomers = false;
                    ShowCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: \n" + ex);
                }
                finally
                {
                    dbh.CloseConnection();
                }
            }
            if (tc_Main.SelectedIndex == 7)
            {
                try
                {
                    dbh.OpenConnection();
                    DataTable dt = dbh.GetCustomerCB();
                    cb_Appointment_Select_Customer.ValueMember = "customer_id";
                    cb_Appointment_Select_Customer.DisplayMember = "full_name";

                    cb_Appointment_Select_Customer.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: \n" + ex);
                }
                finally
                {
                    dbh.CloseConnection();
                }
            }
        }

        private void GetLocation(object sender, EventArgs e)
        {
            if (checkb_Location.Checked)
            {
                dbh.OpenConnection();
                DataTable dt = dbh.GetCustomer(cb_Appointment_Select_Customer.SelectedValue.ToString());
                cb_Appointment_Select_Customer.Enabled = false;
                txtb_A_Appointment_Residence.Text = dt.Rows[0]["residence"].ToString();
                txtb_A_Appointment_Residence.Enabled = false;
                txtb_A_Appointment_Streetname.Text = dt.Rows[0]["street_name"].ToString();
                txtb_A_Appointment_Streetname.Enabled = false;
                txtb_A_Appointment_Housenumber.Text = dt.Rows[0]["house_number"].ToString();
                txtb_A_Appointment_Housenumber.Enabled = false;
                txtb_A_Appointment_Zipcode.Text = dt.Rows[0]["zip_code"].ToString();
                txtb_A_Appointment_Zipcode.Enabled = false;
                dbh.CloseConnection();
            }
            else
            {
                cb_Appointment_Select_Customer.Enabled = true;
                txtb_A_Appointment_Residence.Text = "";
                txtb_A_Appointment_Streetname.Text = "";
                txtb_A_Appointment_Housenumber.Text = "";
                txtb_A_Appointment_Zipcode.Text = "";
                txtb_A_Appointment_Residence.Enabled = true;
                txtb_A_Appointment_Streetname.Enabled = true;
                txtb_A_Appointment_Housenumber.Enabled = true;
                txtb_A_Appointment_Zipcode.Enabled = true;
            }
        }

        private void FillEditAppointmentItems(object sender, EventArgs e)
        {
            dbh.OpenConnection();
            Button button = (Button)sender;
            lbl_E_Appointment_Id.Text = button.AccessibleName;
            DataTable dt = dbh.GetAppointment(button.AccessibleName);
            txtb_E_Appointment_Residence.Text = dt.Rows[0]["appointment_residence"].ToString();
            txtb_E_Appointment_Streetname.Text = dt.Rows[0]["appointment_streetname"].ToString();
            txtb_E_Appointment_Housenumber.Text = dt.Rows[0]["appointment_housenumber"].ToString();
            txtb_E_Appointment_Zip_Code.Text = dt.Rows[0]["appointment_zipcode"].ToString();
            dtp_E_Appointment_Date.Value = Convert.ToDateTime(dt.Rows[0]["appointment_datetime"]);
            rtb_E_Appointment_Summary.Text = dt.Rows[0]["appointment_summary"].ToString();
            lbl_E_Appointment_Customer.Text = dt.Rows[0]["customer_data"].ToString();

            dbh.CloseConnection();
            tc_Main.SelectedIndex = 6;
        }

        private void EditAppointment(object sender, EventArgs e)
        {
            if (txtb_E_Appointment_Housenumber.Text == "" || txtb_E_Appointment_Residence.Text == "" || txtb_E_Appointment_Streetname.Text == "" || txtb_E_Appointment_Zip_Code.Text == "" || rtb_E_Appointment_Summary.Text == "")
            {
                MessageBox.Show("Make sure all fields are filled in correctly!");
            }
            else if (dtp_E_Appointment_Date.Value < DateTime.Now)
            {
                MessageBox.Show("Date cannot be in the past!");
            }
            else
            {
                dbh.OpenConnection();
                if (dbh.EditAppointment(lbl_E_Appointment_Id.Text, dtp_E_Appointment_Date.Value.ToString(), txtb_E_Appointment_Residence.Text, txtb_E_Appointment_Streetname.Text, txtb_E_Appointment_Housenumber.Text, txtb_E_Appointment_Zip_Code.Text, rtb_E_Appointment_Summary.Text))
                    MessageBox.Show("Succesfully editted the appointment!");
                else
                    MessageBox.Show("An error occcured while adding an appointment.");
                dbh.CloseConnection();
            }
        }

        private void btn_GoTo_Add_Appointment_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedIndex = 7;
        }

        private void ShowNotifications()
        {
            dbh.OpenConnection();
            DataTable dt = dbh.GetNotifications();
            int amount = dt.Rows.Count;
            if (!showallNotifications && amount > 5)
                amount = 5;

            OverviewPanel[] overviewInfoPanel = new OverviewPanel[amount];

            for (int i = 0; i < overviewInfoPanel.Length; i++)
            {
                overviewInfoPanel[i] = new OverviewPanel(i, dt);
                overviewInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                overviewInfoPanel[i].Dock = DockStyle.Top;
                overviewInfoPanel[i].btn_Resolved.AccessibleName = dt.Rows[i]["notification_ID"].ToString();
                overviewInfoPanel[i].btn_Resolved.Click += new System.EventHandler(this.ResolveNotification);
                notificationsPanel.Controls.Add(overviewInfoPanel[i]);
            }
            dbh.CloseConnection();
        }

        private void ResolveNotification(object sender, EventArgs e)
        {
            dbh.OpenConnection();
            Button button = (Button)sender;
            dbh.ResolveNotification(button.AccessibleName);
            dbh.CloseConnection();
        }

        private void btn_Show_All_Notifications_Click(object sender, EventArgs e)
        {
            notificationsPanel.Controls.Clear();
            showallNotifications = true;
            ShowNotifications();
        }

        private void mnitem_Help_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedIndex = 8;
        }

        private void SearchAppointmentOnCu_Name(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Appointments_CuName.Text;
            if (e.KeyCode == Keys.Return)
            {
                dbh.OpenConnection();
                appointmentsPanel.Controls.Clear();
                DataTable dt = dbh.FilterAppointments(filter, "tbl_customers.first_name", "tbl_customers.last_name");
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
                    appointmentInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditAppointmentItems);
                }
                dbh.CloseConnection();
            }
        }

        private void SearchAppointmentOnCo_Name(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Appointments_CoName.Text;
            if (e.KeyCode == Keys.Return)
            {
                dbh.OpenConnection();
                appointmentsPanel.Controls.Clear();
                DataTable dt = dbh.FilterAppointments(filter, "tbl_customers.company_name");
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
                    appointmentInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditAppointmentItems);
                }
                dbh.CloseConnection();
            }
        }

        private void SearchAppointmentOnResidence(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Appointments_Residence.Text;
            if (e.KeyCode == Keys.Return)
            {
                dbh.OpenConnection();
                appointmentsPanel.Controls.Clear();
                DataTable dt = dbh.FilterAppointments(filter, "tbl_customers.residence");
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
                    appointmentInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditAppointmentItems);
                }
                dbh.CloseConnection();
            }
        }

        private void SearchAppointmentsOnSummary(object sender, EventArgs e)
        {
            if (tscmb_Appointments_Summary.Text == "All")
            {
                appointmentsPanel.Controls.Clear();

                dbh.OpenConnection();
                DataTable dt = dbh.GetAppointments();
                int amount = dt.Rows.Count;

                AppointmentPanel[] appointmentInfoPanel = new AppointmentPanel[amount];

                for (int i = 0; i < appointmentInfoPanel.Length; i++)
                {
                    appointmentInfoPanel[i] = new AppointmentPanel(i, dt);
                    appointmentInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    appointmentInfoPanel[i].Dock = DockStyle.Top;
                    appointmentsPanel.Controls.Add(appointmentInfoPanel[i]);
                    appointmentInfoPanel[i].btn_Edit.AccessibleName = dt.Rows[i]["appointment_id"].ToString();
                    appointmentInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditAppointmentItems);
                }
                dbh.CloseConnection();
            }
            else if (tscmb_Appointments_Summary.Text == "Has summary")
            {
                dbh.OpenConnection();
                appointmentsPanel.Controls.Clear();
                DataTable dt = dbh.FilterAppointmentsHasSummary();
                int amount = dt.Rows.Count;

                AppointmentPanel[] appointmentInfoPanel = new AppointmentPanel[amount];

                for (int i = 0; i < appointmentInfoPanel.Length; i++)
                {
                    appointmentInfoPanel[i] = new AppointmentPanel(i, dt);
                    appointmentInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    appointmentInfoPanel[i].Dock = DockStyle.Top;
                    appointmentsPanel.Controls.Add(appointmentInfoPanel[i]);
                    appointmentInfoPanel[i].btn_Edit.AccessibleName = dt.Rows[i]["appointment_id"].ToString();
                    appointmentInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditAppointmentItems);
                }
                dbh.CloseConnection();
            }
            else
            {
                dbh.OpenConnection();
                appointmentsPanel.Controls.Clear();
                DataTable dt = dbh.FilterAppointmentsHasNoSummary();
                int amount = dt.Rows.Count;

                AppointmentPanel[] appointmentInfoPanel = new AppointmentPanel[amount];

                for (int i = 0; i < appointmentInfoPanel.Length; i++)
                {
                    appointmentInfoPanel[i] = new AppointmentPanel(i, dt);
                    appointmentInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    appointmentInfoPanel[i].Dock = DockStyle.Top;
                    appointmentsPanel.Controls.Add(appointmentInfoPanel[i]);
                    appointmentInfoPanel[i].btn_Edit.AccessibleName = dt.Rows[i]["appointment_id"].ToString();
                    appointmentInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditAppointmentItems);
                }
                dbh.CloseConnection();
            }
        }

        private void SearchAppointmentOnDate(object sender, EventArgs e)
        {
            string fromDate = lbl_Appointment_DateFrom.Text;
            string tillDate = lbl_Appointment_DateTill.Text;

            dbh.OpenConnection();
            appointmentsPanel.Controls.Clear();
            DataTable dt = dbh.FilterAppointmentsBetweenDate(fromDate, tillDate, "appointment_datetime");
            int amount = dt.Rows.Count;

            AppointmentPanel[] appointmentInfoPanel = new AppointmentPanel[amount];

            for (int i = 0; i < appointmentInfoPanel.Length; i++)
            {
                appointmentInfoPanel[i] = new AppointmentPanel(i, dt);
                appointmentInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                appointmentInfoPanel[i].Dock = DockStyle.Top;
                appointmentsPanel.Controls.Add(appointmentInfoPanel[i]);
                appointmentInfoPanel[i].btn_Edit.AccessibleName = dt.Rows[i]["appointment_id"].ToString();
                appointmentInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditAppointmentItems);
            }
            dbh.CloseConnection();
        }
    }
}
