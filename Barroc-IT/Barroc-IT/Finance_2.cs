using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class frm_Finance_2 : Form
    {
        bool showAllInvoices = false;
        bool showallAppointments = false;
        bool showAllCustomers = false;
        bool showallNotifications = false;

        DatabaseHandler dbh;

        public frm_Finance_2()
        {
            InitializeComponent();
            HideFilters(true, false, false, false);
            ShowInvoices();
            ShowAppointments();
            ShowCustomers();
            ShowNotifications();
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
            mnfltr_Invoices_InvoiceID.Visible = Invoices;

            mnfltr_Customers_CuName.Visible = Customers;
            mnfltr_Customers_CoName.Visible = Customers;
            mnfltr_Customers_Residence.Visible = Customers;
            mnfltr_Customers_UnpaidInvoice.Visible = Customers;

        }

        private void ShowInvoices()
        {
            dbh = new DatabaseHandler();
            dbh.OpenConnection();
            DataTable dt = dbh.GetInvoices();
            int amount = dt.Rows.Count;
            if (!showAllInvoices && amount > 5)
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

        private void btn_Add_Invoice_Click(object sender, EventArgs e)
        {
            tcp_Main.SelectedIndex = 2;
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
            }
            dbh.CloseConnection();
        }

        private void ShowCustomers()
        {
            dbh.OpenConnection();
            DataTable dt = dbh.GetCustomers();
            int amount = dt.Rows.Count;
            if (!showAllCustomers && amount > 5)
                amount = 5;

            CustomerPanel[] customerInfoPanel = new CustomerPanel[amount];

            for (int i = 0; i < customerInfoPanel.Length; i++)
            {
                customerInfoPanel[i] = new CustomerPanel(i, dt);
                customerInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                customerInfoPanel[i].Dock = DockStyle.Top;
                panel1.Controls.Add(customerInfoPanel[i]);
                customerInfoPanel[i].btn_editCustomer.AccessibleName = dt.Rows[i]["customer_id"].ToString();
            }
            dbh.CloseConnection();
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
            //notificationsPanel.Controls.Clear();
            dbh.CloseConnection();
            //ShowNotifications();
        }

        private void btn_ShowAllCustomers_Click(object sender, EventArgs e)
        {
            showAllCustomers = true;
            panel1.Controls.Clear();
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
    }
}
