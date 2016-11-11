using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class frm_Finance_2 : Form
    {
        bool showAllInvoices = false;
        bool showallAppointments = false;
        bool showAllCustomers = false;
        bool showallNotifications = false;

        DatabaseHandler dbh = new DatabaseHandler();

        public frm_Finance_2()
        {
            InitializeComponent();
            cbox_Project_Status.SelectedIndex = 0;
            HideFilters(true, false, false, false);
            //ShowInvoices();
            //ShowAppointments();
            //ShowCustomers();
            ShowNotifications();

            ToolStripControlHost[] arrayControl = MenuItems.DTPGenerator(this);
            ToolStripControlHost[] arrayControl1 = MenuItems.DTPGenerator(this);

            for (int i = 0; i < arrayControl.Length; i++)
            {
                mnfltr_Overview_Date.DropDownItems.Add(arrayControl[i]);
                mnfltr_Appointments_Date.DropDownItems.Add(arrayControl1[i]);
            }
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
                    tcp_Main.SelectedIndex = 3;
                    HideFilters(false, true, false, false);
                    break;
                case "mnitem_Invoices":
                    tcp_Main.SelectedIndex = 1;
                    HideFilters(false, false, true, false);
                    break;
                case "mnitem_Customers":
                    tcp_Main.SelectedIndex = 4;
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

            mnfltr_Appointments_Residence.Visible = Appointments;
            mnfltr_Appointments_CoName.Visible = Appointments;
            mnfltr_Appointments_CuName.Visible = Appointments;
            mnfltr_Appointments_Date.Visible = Appointments;
            mnfltr_Appointments_Summary.Visible = Appointments;

            mnfltr_Invoices_CuName.Visible = Invoices;
            mnfltr_Invoices_CoName.Visible = Invoices;
            mnfltr_Invoices_Paid.Visible = Invoices;

            mnfltr_Customers_CuName.Visible = Customers;
            mnfltr_Customers_CoName.Visible = Customers;
            mnfltr_Customers_Residence.Visible = Customers;
            mnfltr_Customers_UnpaidInvoice.Visible = Customers;

        }

        private void tc_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcp_Main.SelectedIndex == 0)
            {
                try
                {
                    showallNotifications = false;
                    ShowNotifications();
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

            if(tcp_Main.SelectedIndex == 1)
            {
                try
                {
                    showAllInvoices = false;
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

            if (tcp_Main.SelectedIndex == 2)
            {
                try
                {
                    dbh.OpenConnection();
                    DataTable dt = dbh.GetProjectCB();
                    cb_Select_Project.ValueMember = "project_id";
                    cb_Select_Project.DisplayMember = "project_and_name";

                    cb_Select_Project.DataSource = dt;
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

            if (tcp_Main.SelectedIndex == 3)
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

            if(tcp_Main.SelectedIndex == 4)
            {
                try
                {
                    showAllCustomers = false;
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
        }

        private void ShowInvoices()
        {
            dbh = new DatabaseHandler();
            dbh.OpenConnection();
            invoicesPanel.Controls.Clear();
            DataTable dt = dbh.GetInvoices();
            int amount = dt.Rows.Count;
            if (!showAllInvoices && amount > 5)
            {
                amount = 5;

                Button btn_showAllInvoices = new Button();
                btn_showAllInvoices.Text = "Show all invoices";
                btn_showAllInvoices.Dock = DockStyle.Bottom;
                btn_showAllInvoices.Click += new System.EventHandler(this.ShowAllInvoices);
                invoicesPanel.Controls.Add(btn_showAllInvoices);
                dbh.CloseConnection();

            }

            InvoicePanel[] invoiceInfoPanel = new InvoicePanel[amount];

            for (int i = 0; i < invoiceInfoPanel.Length; i++)
            {
                invoiceInfoPanel[i] = new InvoicePanel(i, dt);
                invoiceInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                invoiceInfoPanel[i].Dock = DockStyle.Top;
                invoiceInfoPanel[i].btn_Paid.AccessibleName = dt.Rows[i]["invoice_id"].ToString();
                invoiceInfoPanel[i].btn_Paid.Click += new EventHandler(this.PayInvoice);
                invoicesPanel.Controls.Add(invoiceInfoPanel[i]);
            }
            dbh.CloseConnection();
        }

        private void ShowAllInvoices(object sender, EventArgs e)
        {
            showAllInvoices = true;
            invoicesPanel.Controls.Clear();
            ShowInvoices();
        }

        private void PayInvoice(object sender, EventArgs e)
        {
            dbh.OpenConnection();
            Button button = (Button)sender;
            dbh.PayInvoice(button.AccessibleName);
            button.Dispose();
            dbh.CloseConnection();
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

        private void btn_GoTo_Add_Invoice_Click(object sender, EventArgs e)
        {
            tcp_Main.SelectedIndex = 2;
        }

        private void ShowAppointments()
        {
            dbh.OpenConnection();
            DataTable dt = dbh.GetAppointments();
            appointmentsPanel.Controls.Clear();
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
                appointmentInfoPanel[i].btn_Edit.Dispose();
            }
            dbh.CloseConnection();
        }

        private void ShowAllAppointments(object sender, EventArgs e)
        {
            showallAppointments = true;
            appointmentsPanel.Controls.Clear();
            ShowAppointments();
        }

        private void ShowCustomers()
        {
            dbh.OpenConnection();
            DataTable dt = dbh.GetCustomers();
            customerPanel.Controls.Clear();
            int amount = dt.Rows.Count;
            if (!showAllCustomers && amount > 5)
            {
                amount = 5;

                Button showAllCustomersButton = new Button();
                showAllCustomersButton.Text = "Show all customers";
                showAllCustomersButton.Dock = DockStyle.Bottom;
                showAllCustomersButton.Click += new System.EventHandler(this.ShowAllCustomers);
                customerPanel.Controls.Add(showAllCustomersButton);
            }

            CustomerPanel[] customerInfoPanel = new CustomerPanel[amount];

            for (int i = 0; i < customerInfoPanel.Length; i++)
            {
                customerInfoPanel[i] = new CustomerPanel(i, dt);
                customerInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                customerInfoPanel[i].Dock = DockStyle.Top;
                customerPanel.Controls.Add(customerInfoPanel[i]);
                customerInfoPanel[i].btn_editCustomer.AccessibleName = dt.Rows[i]["customer_id"].ToString();
                customerInfoPanel[i].btn_editCustomer.Click += new EventHandler(this.EditCustomer);
            }
            dbh.CloseConnection();
        }
        private void ShowAllCustomers(object sender, EventArgs e)
        {
            showAllCustomers = true;
            customerPanel.Controls.Clear();
            ShowCustomers();
        }


        private void ShowNotifications()
        {
            dbh.OpenConnection();
            DataTable dt = dbh.GetNotifications();
            notificationsPanel.Controls.Clear();
            int amount = dt.Rows.Count;
            if (!showallNotifications && amount > 5)
            {
                amount = 5;

                Button btn_showAllNotifications = new Button();
                btn_showAllNotifications.Text = "Show all projects";
                btn_showAllNotifications.Dock = DockStyle.Bottom;
                btn_showAllNotifications.Click += new System.EventHandler(this.ShowAllNotifications);
                notificationsPanel.Controls.Add(btn_showAllNotifications);
                dbh.CloseConnection();
            }

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

        private void ShowAllNotifications(object sender, EventArgs e)
        {
            showallNotifications = true;
            notificationsPanel.Controls.Clear();
            ShowNotifications();
        }

        private void ResolveNotification(object sender, EventArgs e)
        {
            dbh.OpenConnection();
            Button button = (Button)sender;
            dbh.ResolveNotification(button.AccessibleName);
            dbh.CloseConnection();
        }

        private void btn_ShowAllCustomers_Click(object sender, EventArgs e)
        {
            showAllCustomers = true;
            customerPanel.Controls.Clear();
            ShowCustomers();
        }

        private void mnitem_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ShowAllInvoices_Click(object sender, EventArgs e)
        {
            showAllInvoices = true;
            invoicesPanel.Controls.Clear();
            ShowInvoices();
        }

        private void btn_Add_Invoice_Click(object sender, EventArgs e)
        {
            if(dtp_Payment_Deadline.Value < DateTime.Now)
            {
                MessageBox.Show("Date cannot be in the past!");
            }
            else if(txtb_VAT.Text == "")
            {
                MessageBox.Show("VAT must be filled in.");
            }
            else
            {
                dbh.OpenConnection();
                dbh.AddInvoice(cb_Select_Project.SelectedValue.ToString(), txtb_VAT.Text, cbox_Project_Status.SelectedIndex, dtp_Payment_Deadline.Value.ToString());
                txtb_VAT.Clear();
                MessageBox.Show("Added invoice");
                dbh.CloseConnection();
                tcp_Main.SelectedIndex = 2;
            }
        }

        private void EditCustomer(object sender, EventArgs e)
        {
            dbh.OpenConnection();
            Button button = (Button)sender;
            DataTable dt = dbh.GetCustomer(button.AccessibleName);
            dbh.CloseConnection();

            lbl_E_C_Customer.Text = dt.Rows[0]["customer_details"].ToString();
            txtb_E_C_IBAN.Text = dt.Rows[0]["iban"].ToString();
            txtb_E_C_Limit.Text = dt.Rows[0]["customer_limit"].ToString();
            txtb_E_C_GrossRevenue.Text = dt.Rows[0]["gross_revenue"].ToString();
            txtb_E_C_Credit_Balance.Text = dt.Rows[0]["credit_balance"].ToString();
            txtb_E_C_Discount.Text = dt.Rows[0]["discount"].ToString();
            cb_E_C_Creditworthy.SelectedIndex = int.Parse(dt.Rows[0]["creditworthy"].ToString());
            cb_E_C_Prospect.SelectedIndex = int.Parse(dt.Rows[0]["prospect"].ToString());
            lbl_E_C_Customer_ID.Text = dt.Rows[0]["customer_id"].ToString();
            tcp_Main.SelectedIndex = 5;
        }

        public static bool ValidateBankAccount(string bankAccount)
        {
            bankAccount = bankAccount.ToUpper();
            if (String.IsNullOrEmpty(bankAccount))
                return false;
            else if (System.Text.RegularExpressions.Regex.IsMatch(bankAccount, "^[A-Z0-9]"))
            {
                bankAccount = bankAccount.Replace(" ", String.Empty);
                if (bankAccount.Length < 4)
                {
                    return false;
                }
                string bank =
                bankAccount.Substring(4, bankAccount.Length - 4) + bankAccount.Substring(0, 4);
                int asciiShift = 55;
                StringBuilder sb = new StringBuilder();
                foreach (char c in bank)
                {
                    int v;
                    if (Char.IsLetter(c)) v = c - asciiShift;
                    else v = int.Parse(c.ToString());
                    sb.Append(v);
                }
                string checkSumString = sb.ToString();
                int checksum = int.Parse(checkSumString.Substring(0, 1));
                for (int i = 1; i < checkSumString.Length; i++)
                {
                    int v = int.Parse(checkSumString.Substring(i, 1));
                    checksum *= 10;
                    checksum += v;
                    checksum %= 97;
                }
                return checksum == 1;
            }
            else
                return false;
        }
            
        private void EditFinancialDetails(object sender, EventArgs e)
        {
            int result;
            dbh.OpenConnection();

            if (!ValidateBankAccount(txtb_E_C_IBAN.Text))
            {
                MessageBox.Show("Not a correct IBAN!");
            }
            else if(!int.TryParse(txtb_E_C_Credit_Balance.Text, out result) || !int.TryParse(txtb_E_C_Limit.Text,out result) || !int.TryParse(txtb_E_C_Discount.Text, out result) || !int.TryParse(txtb_E_C_GrossRevenue.Text,out result))
            {
                MessageBox.Show("Make sure all fields are filled in correctly");
            }
            else
            {
                if (dbh.EditCustomerFinancial(lbl_E_C_Customer_ID.Text, txtb_E_C_IBAN.Text, txtb_E_C_Credit_Balance.Text, txtb_E_C_GrossRevenue.Text, txtb_E_C_Discount.Text, cb_E_C_Creditworthy.SelectedIndex.ToString(), txtb_E_C_GrossRevenue.Text, cb_E_C_Prospect.SelectedIndex.ToString()))
                {
                    MessageBox.Show("Succesfully editted the customers financial details");
                }
                else
                {
                    MessageBox.Show("An unidentified error occured.");
                }
            }
            dbh.CloseConnection();
        }

        private void btn_Show_All_Notifications_Click(object sender, EventArgs e)
        {
            notificationsPanel.Controls.Clear();
            showallNotifications = true;
            ShowNotifications();
        }

        private void btn_showallAppointments_Click(object sender, EventArgs e)
        {
            appointmentsPanel.Controls.Clear();
            showallAppointments = true;
            ShowAppointments();
        }

        private void mnitem_Help_Click(object sender, EventArgs e)
        {
            tcp_Main.SelectedIndex = 6;
        }

        private void SearchCustomerOnCuName(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Customers_CuName.Text;
            if (e.KeyCode == Keys.Return)
            {
                dbh.OpenConnection();
                customerPanel.Controls.Clear();
                DataTable dt = dbh.FilterCustomers(filter, "first_name", "last_name");
                int amount = dt.Rows.Count;
                if (!showAllCustomers && amount > 5)
                    amount = 5;

                CustomerPanel[] customerInfoPanel = new CustomerPanel[amount];

                for (int i = 0; i < customerInfoPanel.Length; i++)
                {
                    customerInfoPanel[i] = new CustomerPanel(i, dt);
                    customerInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    customerInfoPanel[i].Dock = DockStyle.Top;
                    customerPanel.Controls.Add(customerInfoPanel[i]);
                    customerInfoPanel[i].btn_editCustomer.AccessibleName = dt.Rows[i]["customer_id"].ToString();
                    customerInfoPanel[i].btn_editCustomer.Click += new System.EventHandler(this.EditFinancialDetails);
                }
                dbh.CloseConnection();
            }
        }

        private void SearchCustomerOnCoName(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Customer_CoName.Text;
            if (e.KeyCode == Keys.Return)
            {
                dbh.OpenConnection();
                customerPanel.Controls.Clear();
                DataTable dt = dbh.FilterCustomers(filter, "company_name");
                int amount = dt.Rows.Count;
                if (!showAllCustomers && amount > 5)
                    amount = 5;

                CustomerPanel[] customerInfoPanel = new CustomerPanel[amount];

                for (int i = 0; i < customerInfoPanel.Length; i++)
                {
                    customerInfoPanel[i] = new CustomerPanel(i, dt);
                    customerInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    customerInfoPanel[i].Dock = DockStyle.Top;
                    customerPanel.Controls.Add(customerInfoPanel[i]);
                    customerInfoPanel[i].btn_editCustomer.AccessibleName = dt.Rows[i]["customer_id"].ToString();
                    customerInfoPanel[i].btn_editCustomer.Click += new System.EventHandler(this.EditFinancialDetails);
                }
                dbh.CloseConnection();
            }
        }
 
        private void SearchInvoiceOnCuName(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Invoices_CuName.Text;
            if (e.KeyCode == Keys.Return)
            {
                dbh.OpenConnection();
                invoicesPanel.Controls.Clear();
                DataTable dt = dbh.FilterInvoices(filter, "tbl_customers.first_name", "tbl_customers.last_name");
                int amount = dt.Rows.Count;
                if (!showAllInvoices && amount > 5)
                    amount = 5;

                InvoicePanel[] invoiceInfoPanel = new InvoicePanel[amount];

                for (int i = 0; i < invoiceInfoPanel.Length; i++)
                {
                    invoiceInfoPanel[i] = new InvoicePanel(i, dt);
                    invoiceInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    invoiceInfoPanel[i].Dock = DockStyle.Top;
                    invoiceInfoPanel[i].btn_Paid.AccessibleName = dt.Rows[i]["invoice_id"].ToString();
                    invoiceInfoPanel[i].btn_Paid.Click += new EventHandler(this.PayInvoice);
                    invoicesPanel.Controls.Add(invoiceInfoPanel[i]);
                }
                dbh.CloseConnection();
            }
        }

        private void SearchInvoiceOnCoName(object sender, KeyEventArgs e)
        {
            string filter = tstxtb_Invoices_CoName.Text;
            if (e.KeyCode == Keys.Return)
            {
                dbh.OpenConnection();
                invoicesPanel.Controls.Clear();
                DataTable dt = dbh.FilterInvoices(filter, "tbl_customers.company_name");
                int amount = dt.Rows.Count;
                if (!showAllInvoices && amount > 5)
                    amount = 5;

                InvoicePanel[] invoiceInfoPanel = new InvoicePanel[amount];

                for (int i = 0; i < invoiceInfoPanel.Length; i++)
                {
                    invoiceInfoPanel[i] = new InvoicePanel(i, dt);
                    invoiceInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                    invoiceInfoPanel[i].Dock = DockStyle.Top;
                    invoiceInfoPanel[i].btn_Paid.AccessibleName = dt.Rows[i]["invoice_id"].ToString();
                    invoiceInfoPanel[i].btn_Paid.Click += new EventHandler(this.PayInvoice);
                    invoicesPanel.Controls.Add(invoiceInfoPanel[i]);
                }
                dbh.CloseConnection();
            }
        }
    }
}
