namespace Barroc_IT
{
    partial class frm_Finance_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Finance_2));
            this.mstrp_Menu = new System.Windows.Forms.MenuStrip();
            this.mnitem_Overview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Overview_Department = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmb_Overview_Department = new System.Windows.Forms.ToolStripComboBox();
            this.mnfltr_Overview_Type = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmb_Overview_Type = new System.Windows.Forms.ToolStripComboBox();
            this.mnfltr_Overview_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitem_Appointments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Appointments_CuName = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Appointments_CuName = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Appointments_CoName = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Appointments_CoName = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Appointments_Residence = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Appointments_Residence = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Appointments_Summary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.mnfltr_Appointments_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitem_Invoices = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Invoices_CuName = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Projects_PName = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Invoices_CoName = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Projects_PID = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Invoices_Paid = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Projects_CuName = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Invoices_InvoiceID = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitem_Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Customers_CuName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Customers_CoName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Customers_Residence = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Customers_UnpaidInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitem_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tcp_Overview = new System.Windows.Forms.TabPage();
            this.notificationsPanel = new System.Windows.Forms.Panel();
            this.btn_Show_All_Notifications = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcp_Main = new System.Windows.Forms.TabControl();
            this.tcp_Invoices = new System.Windows.Forms.TabPage();
            this.btn_GoTo_Add_Invoice = new System.Windows.Forms.Button();
            this.invoicesPanel = new System.Windows.Forms.Panel();
            this.btn_ShowAllInvoices = new System.Windows.Forms.Button();
            this.tcp_AddInvoice = new System.Windows.Forms.TabPage();
            this.btn_Add_Invoice = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txtb_Price = new System.Windows.Forms.TextBox();
            this.cbox_Project_Status = new System.Windows.Forms.ComboBox();
            this.lbl_Invoice_Status = new System.Windows.Forms.Label();
            this.lbl_VAT = new System.Windows.Forms.Label();
            this.txtb_VAT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_Select_Project = new System.Windows.Forms.ComboBox();
            this.lbl_Project_id = new System.Windows.Forms.Label();
            this.tcp_Appointments = new System.Windows.Forms.TabPage();
            this.appointmentsPanel = new System.Windows.Forms.Panel();
            this.btn_showallAppointments = new System.Windows.Forms.Button();
            this.tcp_Customers = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ShowAllCustomers = new System.Windows.Forms.Button();
            this.mstrp_Menu.SuspendLayout();
            this.tcp_Overview.SuspendLayout();
            this.notificationsPanel.SuspendLayout();
            this.tcp_Main.SuspendLayout();
            this.tcp_Invoices.SuspendLayout();
            this.invoicesPanel.SuspendLayout();
            this.tcp_AddInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcp_Appointments.SuspendLayout();
            this.appointmentsPanel.SuspendLayout();
            this.tcp_Customers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrp_Menu
            // 
            this.mstrp_Menu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mstrp_Menu.AutoSize = false;
            this.mstrp_Menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mstrp_Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.mstrp_Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstrp_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitem_Overview,
            this.mnfltr_Overview_Department,
            this.mnfltr_Overview_Type,
            this.mnfltr_Overview_Date,
            this.mnitem_Appointments,
            this.mnfltr_Appointments_CuName,
            this.mnfltr_Appointments_CoName,
            this.mnfltr_Appointments_Residence,
            this.mnfltr_Appointments_Summary,
            this.mnfltr_Appointments_Date,
            this.mnitem_Invoices,
            this.mnfltr_Invoices_CuName,
            this.mnfltr_Invoices_CoName,
            this.mnfltr_Invoices_Paid,
            this.mnfltr_Invoices_InvoiceID,
            this.mnitem_Customers,
            this.mnfltr_Customers_CuName,
            this.mnfltr_Customers_CoName,
            this.mnfltr_Customers_Residence,
            this.mnfltr_Customers_UnpaidInvoice,
            this.mnitem_Logout});
            this.mstrp_Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mstrp_Menu.Location = new System.Drawing.Point(0, 1);
            this.mstrp_Menu.Name = "mstrp_Menu";
            this.mstrp_Menu.Size = new System.Drawing.Size(142, 464);
            this.mstrp_Menu.TabIndex = 2;
            // 
            // mnitem_Overview
            // 
            this.mnitem_Overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Overview.Name = "mnitem_Overview";
            this.mnitem_Overview.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Overview.Text = "Overview";
            this.mnitem_Overview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Overview.Click += new System.EventHandler(this.MenuHandler);
            // 
            // mnfltr_Overview_Department
            // 
            this.mnfltr_Overview_Department.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmb_Overview_Department});
            this.mnfltr_Overview_Department.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Overview_Department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Overview_Department.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Overview_Department.Name = "mnfltr_Overview_Department";
            this.mnfltr_Overview_Department.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Overview_Department.Text = "Department";
            this.mnfltr_Overview_Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tscmb_Overview_Department
            // 
            this.tscmb_Overview_Department.BackColor = System.Drawing.SystemColors.Window;
            this.tscmb_Overview_Department.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tscmb_Overview_Department.Items.AddRange(new object[] {
            "All",
            "Developement",
            "Finance",
            "Sales"});
            this.tscmb_Overview_Department.Name = "tscmb_Overview_Department";
            this.tscmb_Overview_Department.Size = new System.Drawing.Size(121, 23);
            this.tscmb_Overview_Department.Text = "All";
            // 
            // mnfltr_Overview_Type
            // 
            this.mnfltr_Overview_Type.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmb_Overview_Type});
            this.mnfltr_Overview_Type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Overview_Type.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Overview_Type.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Overview_Type.Name = "mnfltr_Overview_Type";
            this.mnfltr_Overview_Type.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Overview_Type.Text = "Type";
            this.mnfltr_Overview_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tscmb_Overview_Type
            // 
            this.tscmb_Overview_Type.Items.AddRange(new object[] {
            "All",
            "Type1",
            "Type2",
            "Type3"});
            this.tscmb_Overview_Type.Name = "tscmb_Overview_Type";
            this.tscmb_Overview_Type.Size = new System.Drawing.Size(121, 23);
            this.tscmb_Overview_Type.Text = "All";
            // 
            // mnfltr_Overview_Date
            // 
            this.mnfltr_Overview_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Overview_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Overview_Date.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Overview_Date.Name = "mnfltr_Overview_Date";
            this.mnfltr_Overview_Date.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Overview_Date.Text = "Date";
            this.mnfltr_Overview_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnitem_Appointments
            // 
            this.mnitem_Appointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnitem_Appointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Appointments.Name = "mnitem_Appointments";
            this.mnitem_Appointments.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Appointments.Text = "Appointments";
            this.mnitem_Appointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Appointments.Click += new System.EventHandler(this.MenuHandler);
            // 
            // mnfltr_Appointments_CuName
            // 
            this.mnfltr_Appointments_CuName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Appointments_CuName});
            this.mnfltr_Appointments_CuName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Appointments_CuName.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Appointments_CuName.Name = "mnfltr_Appointments_CuName";
            this.mnfltr_Appointments_CuName.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Appointments_CuName.Text = "Customer Name";
            this.mnfltr_Appointments_CuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Appointments_CuName
            // 
            this.tstxtb_Appointments_CuName.Name = "tstxtb_Appointments_CuName";
            this.tstxtb_Appointments_CuName.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Appointments_CoName
            // 
            this.mnfltr_Appointments_CoName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Appointments_CoName});
            this.mnfltr_Appointments_CoName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Appointments_CoName.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Appointments_CoName.Name = "mnfltr_Appointments_CoName";
            this.mnfltr_Appointments_CoName.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Appointments_CoName.Text = "Company Name";
            this.mnfltr_Appointments_CoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Appointments_CoName
            // 
            this.tstxtb_Appointments_CoName.Name = "tstxtb_Appointments_CoName";
            this.tstxtb_Appointments_CoName.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Appointments_Residence
            // 
            this.mnfltr_Appointments_Residence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Appointments_Residence});
            this.mnfltr_Appointments_Residence.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Appointments_Residence.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Appointments_Residence.Name = "mnfltr_Appointments_Residence";
            this.mnfltr_Appointments_Residence.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Appointments_Residence.Text = "Residence";
            this.mnfltr_Appointments_Residence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Appointments_Residence
            // 
            this.tstxtb_Appointments_Residence.Name = "tstxtb_Appointments_Residence";
            this.tstxtb_Appointments_Residence.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Appointments_Summary
            // 
            this.mnfltr_Appointments_Summary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.mnfltr_Appointments_Summary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Appointments_Summary.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Appointments_Summary.Name = "mnfltr_Appointments_Summary";
            this.mnfltr_Appointments_Summary.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Appointments_Summary.Text = "Summary";
            this.mnfltr_Appointments_Summary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox3.Text = "All";
            // 
            // mnfltr_Appointments_Date
            // 
            this.mnfltr_Appointments_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Appointments_Date.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Appointments_Date.Name = "mnfltr_Appointments_Date";
            this.mnfltr_Appointments_Date.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Appointments_Date.Text = "Date";
            this.mnfltr_Appointments_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnitem_Invoices
            // 
            this.mnitem_Invoices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnitem_Invoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Invoices.Name = "mnitem_Invoices";
            this.mnitem_Invoices.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Invoices.Text = "Invoices";
            this.mnitem_Invoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Invoices.Click += new System.EventHandler(this.MenuHandler);
            // 
            // mnfltr_Invoices_CuName
            // 
            this.mnfltr_Invoices_CuName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Projects_PName});
            this.mnfltr_Invoices_CuName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Invoices_CuName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Invoices_CuName.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Invoices_CuName.Name = "mnfltr_Invoices_CuName";
            this.mnfltr_Invoices_CuName.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Invoices_CuName.Text = "Customer name";
            this.mnfltr_Invoices_CuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Projects_PName
            // 
            this.tstxtb_Projects_PName.Name = "tstxtb_Projects_PName";
            this.tstxtb_Projects_PName.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Invoices_CoName
            // 
            this.mnfltr_Invoices_CoName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Projects_PID});
            this.mnfltr_Invoices_CoName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Invoices_CoName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Invoices_CoName.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Invoices_CoName.Name = "mnfltr_Invoices_CoName";
            this.mnfltr_Invoices_CoName.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Invoices_CoName.Text = "Company name";
            this.mnfltr_Invoices_CoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Projects_PID
            // 
            this.tstxtb_Projects_PID.Name = "tstxtb_Projects_PID";
            this.tstxtb_Projects_PID.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Invoices_Paid
            // 
            this.mnfltr_Invoices_Paid.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Projects_CuName});
            this.mnfltr_Invoices_Paid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Invoices_Paid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Invoices_Paid.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Invoices_Paid.Name = "mnfltr_Invoices_Paid";
            this.mnfltr_Invoices_Paid.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Invoices_Paid.Text = "Paid/Unpaid";
            this.mnfltr_Invoices_Paid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Projects_CuName
            // 
            this.tstxtb_Projects_CuName.Name = "tstxtb_Projects_CuName";
            this.tstxtb_Projects_CuName.Size = new System.Drawing.Size(100, 23);
            // 
            // mnfltr_Invoices_InvoiceID
            // 
            this.mnfltr_Invoices_InvoiceID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Invoices_InvoiceID.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Invoices_InvoiceID.Name = "mnfltr_Invoices_InvoiceID";
            this.mnfltr_Invoices_InvoiceID.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Invoices_InvoiceID.Text = "Invoice ID";
            this.mnfltr_Invoices_InvoiceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnitem_Customers
            // 
            this.mnitem_Customers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnitem_Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Customers.Name = "mnitem_Customers";
            this.mnitem_Customers.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Customers.Text = "Customers";
            this.mnitem_Customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Customers.Click += new System.EventHandler(this.MenuHandler);
            // 
            // mnfltr_Customers_CuName
            // 
            this.mnfltr_Customers_CuName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Customers_CuName.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Customers_CuName.Name = "mnfltr_Customers_CuName";
            this.mnfltr_Customers_CuName.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Customers_CuName.Text = "Customer name";
            this.mnfltr_Customers_CuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnfltr_Customers_CoName
            // 
            this.mnfltr_Customers_CoName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Customers_CoName.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Customers_CoName.Name = "mnfltr_Customers_CoName";
            this.mnfltr_Customers_CoName.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Customers_CoName.Text = "Company name";
            this.mnfltr_Customers_CoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnfltr_Customers_Residence
            // 
            this.mnfltr_Customers_Residence.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Customers_Residence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Customers_Residence.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Customers_Residence.Name = "mnfltr_Customers_Residence";
            this.mnfltr_Customers_Residence.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Customers_Residence.Text = "Residence";
            this.mnfltr_Customers_Residence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnfltr_Customers_UnpaidInvoice
            // 
            this.mnfltr_Customers_UnpaidInvoice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Customers_UnpaidInvoice.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Customers_UnpaidInvoice.Name = "mnfltr_Customers_UnpaidInvoice";
            this.mnfltr_Customers_UnpaidInvoice.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Customers_UnpaidInvoice.Text = "Unpaid invoice";
            this.mnfltr_Customers_UnpaidInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnitem_Logout
            // 
            this.mnitem_Logout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnitem_Logout.Checked = true;
            this.mnitem_Logout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnitem_Logout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnitem_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Logout.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.mnitem_Logout.Name = "mnitem_Logout";
            this.mnitem_Logout.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Logout.Text = "Logout";
            this.mnitem_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Logout.Click += new System.EventHandler(this.mnitem_Logout_Click);
            // 
            // tcp_Overview
            // 
            this.tcp_Overview.AutoScroll = true;
            this.tcp_Overview.Controls.Add(this.notificationsPanel);
            this.tcp_Overview.Controls.Add(this.label3);
            this.tcp_Overview.Controls.Add(this.label2);
            this.tcp_Overview.Location = new System.Drawing.Point(4, 22);
            this.tcp_Overview.Name = "tcp_Overview";
            this.tcp_Overview.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Overview.Size = new System.Drawing.Size(566, 438);
            this.tcp_Overview.TabIndex = 0;
            this.tcp_Overview.Text = "Overview";
            this.tcp_Overview.UseVisualStyleBackColor = true;
            // 
            // notificationsPanel
            // 
            this.notificationsPanel.AutoSize = true;
            this.notificationsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.notificationsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationsPanel.Controls.Add(this.btn_Show_All_Notifications);
            this.notificationsPanel.Location = new System.Drawing.Point(4, 35);
            this.notificationsPanel.MinimumSize = new System.Drawing.Size(540, 2);
            this.notificationsPanel.Name = "notificationsPanel";
            this.notificationsPanel.Size = new System.Drawing.Size(540, 25);
            this.notificationsPanel.TabIndex = 7;
            // 
            // btn_Show_All_Notifications
            // 
            this.btn_Show_All_Notifications.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Show_All_Notifications.Location = new System.Drawing.Point(0, 0);
            this.btn_Show_All_Notifications.Name = "btn_Show_All_Notifications";
            this.btn_Show_All_Notifications.Size = new System.Drawing.Size(538, 23);
            this.btn_Show_All_Notifications.TabIndex = 0;
            this.btn_Show_All_Notifications.Text = "Show All";
            this.btn_Show_All_Notifications.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // tcp_Main
            // 
            this.tcp_Main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tcp_Main.Controls.Add(this.tcp_Overview);
            this.tcp_Main.Controls.Add(this.tcp_Invoices);
            this.tcp_Main.Controls.Add(this.tcp_AddInvoice);
            this.tcp_Main.Controls.Add(this.tcp_Appointments);
            this.tcp_Main.Controls.Add(this.tcp_Customers);
            this.tcp_Main.Location = new System.Drawing.Point(142, 1);
            this.tcp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tcp_Main.Name = "tcp_Main";
            this.tcp_Main.SelectedIndex = 0;
            this.tcp_Main.Size = new System.Drawing.Size(574, 464);
            this.tcp_Main.TabIndex = 4;
            this.tcp_Main.TabStop = false;
            this.tcp_Main.SelectedIndexChanged += new System.EventHandler(this.tc_Main_SelectedIndexChanged);
            // 
            // tcp_Invoices
            // 
            this.tcp_Invoices.Controls.Add(this.btn_GoTo_Add_Invoice);
            this.tcp_Invoices.Controls.Add(this.invoicesPanel);
            this.tcp_Invoices.Location = new System.Drawing.Point(4, 22);
            this.tcp_Invoices.Name = "tcp_Invoices";
            this.tcp_Invoices.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Invoices.Size = new System.Drawing.Size(566, 438);
            this.tcp_Invoices.TabIndex = 1;
            this.tcp_Invoices.Text = "Invoices";
            this.tcp_Invoices.UseVisualStyleBackColor = true;
            // 
            // btn_GoTo_Add_Invoice
            // 
            this.btn_GoTo_Add_Invoice.Location = new System.Drawing.Point(3, 6);
            this.btn_GoTo_Add_Invoice.Name = "btn_GoTo_Add_Invoice";
            this.btn_GoTo_Add_Invoice.Size = new System.Drawing.Size(34, 23);
            this.btn_GoTo_Add_Invoice.TabIndex = 7;
            this.btn_GoTo_Add_Invoice.Text = "Add";
            this.btn_GoTo_Add_Invoice.UseVisualStyleBackColor = true;
            this.btn_GoTo_Add_Invoice.Click += new System.EventHandler(this.btn_GoTo_Add_Invoice_Click);
            // 
            // invoicesPanel
            // 
            this.invoicesPanel.AutoSize = true;
            this.invoicesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.invoicesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoicesPanel.Controls.Add(this.btn_ShowAllInvoices);
            this.invoicesPanel.Location = new System.Drawing.Point(4, 35);
            this.invoicesPanel.MinimumSize = new System.Drawing.Size(540, 2);
            this.invoicesPanel.Name = "invoicesPanel";
            this.invoicesPanel.Size = new System.Drawing.Size(540, 25);
            this.invoicesPanel.TabIndex = 6;
            // 
            // btn_ShowAllInvoices
            // 
            this.btn_ShowAllInvoices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ShowAllInvoices.Location = new System.Drawing.Point(0, 0);
            this.btn_ShowAllInvoices.Name = "btn_ShowAllInvoices";
            this.btn_ShowAllInvoices.Size = new System.Drawing.Size(538, 23);
            this.btn_ShowAllInvoices.TabIndex = 0;
            this.btn_ShowAllInvoices.Text = "Show All";
            this.btn_ShowAllInvoices.UseVisualStyleBackColor = true;
            this.btn_ShowAllInvoices.Click += new System.EventHandler(this.btn_ShowAllInvoices_Click);
            // 
            // tcp_AddInvoice
            // 
            this.tcp_AddInvoice.Controls.Add(this.btn_Add_Invoice);
            this.tcp_AddInvoice.Controls.Add(this.lbl_Price);
            this.tcp_AddInvoice.Controls.Add(this.txtb_Price);
            this.tcp_AddInvoice.Controls.Add(this.cbox_Project_Status);
            this.tcp_AddInvoice.Controls.Add(this.lbl_Invoice_Status);
            this.tcp_AddInvoice.Controls.Add(this.lbl_VAT);
            this.tcp_AddInvoice.Controls.Add(this.txtb_VAT);
            this.tcp_AddInvoice.Controls.Add(this.pictureBox1);
            this.tcp_AddInvoice.Controls.Add(this.cb_Select_Project);
            this.tcp_AddInvoice.Controls.Add(this.lbl_Project_id);
            this.tcp_AddInvoice.Location = new System.Drawing.Point(4, 22);
            this.tcp_AddInvoice.Name = "tcp_AddInvoice";
            this.tcp_AddInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_AddInvoice.Size = new System.Drawing.Size(566, 438);
            this.tcp_AddInvoice.TabIndex = 2;
            this.tcp_AddInvoice.Text = "Add Invoice";
            this.tcp_AddInvoice.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Invoice
            // 
            this.btn_Add_Invoice.Location = new System.Drawing.Point(485, 403);
            this.btn_Add_Invoice.Name = "btn_Add_Invoice";
            this.btn_Add_Invoice.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_Invoice.TabIndex = 34;
            this.btn_Add_Invoice.Text = "Add invoice";
            this.btn_Add_Invoice.UseVisualStyleBackColor = true;
            this.btn_Add_Invoice.Click += new System.EventHandler(this.btn_Add_Invoice_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(316, 225);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(31, 13);
            this.lbl_Price.TabIndex = 33;
            this.lbl_Price.Text = "Price";
            // 
            // txtb_Price
            // 
            this.txtb_Price.Location = new System.Drawing.Point(319, 241);
            this.txtb_Price.MaxLength = 3;
            this.txtb_Price.Name = "txtb_Price";
            this.txtb_Price.Size = new System.Drawing.Size(100, 20);
            this.txtb_Price.TabIndex = 32;
            // 
            // cbox_Project_Status
            // 
            this.cbox_Project_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Project_Status.Enabled = false;
            this.cbox_Project_Status.FormattingEnabled = true;
            this.cbox_Project_Status.Items.AddRange(new object[] {
            "Unpaid",
            "Paid"});
            this.cbox_Project_Status.Location = new System.Drawing.Point(27, 241);
            this.cbox_Project_Status.Name = "cbox_Project_Status";
            this.cbox_Project_Status.Size = new System.Drawing.Size(97, 21);
            this.cbox_Project_Status.TabIndex = 30;
            // 
            // lbl_Invoice_Status
            // 
            this.lbl_Invoice_Status.AutoSize = true;
            this.lbl_Invoice_Status.Location = new System.Drawing.Point(24, 225);
            this.lbl_Invoice_Status.Name = "lbl_Invoice_Status";
            this.lbl_Invoice_Status.Size = new System.Drawing.Size(75, 13);
            this.lbl_Invoice_Status.TabIndex = 31;
            this.lbl_Invoice_Status.Text = "Invoice Status";
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.AutoSize = true;
            this.lbl_VAT.Location = new System.Drawing.Point(316, 180);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(28, 13);
            this.lbl_VAT.TabIndex = 29;
            this.lbl_VAT.Text = "VAT";
            // 
            // txtb_VAT
            // 
            this.txtb_VAT.Location = new System.Drawing.Point(319, 196);
            this.txtb_VAT.Name = "txtb_VAT";
            this.txtb_VAT.Size = new System.Drawing.Size(100, 20);
            this.txtb_VAT.TabIndex = 28;
            this.txtb_VAT.Text = "21";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // cb_Select_Project
            // 
            this.cb_Select_Project.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Select_Project.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Select_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Select_Project.FormattingEnabled = true;
            this.cb_Select_Project.Location = new System.Drawing.Point(27, 196);
            this.cb_Select_Project.MaxDropDownItems = 100;
            this.cb_Select_Project.Name = "cb_Select_Project";
            this.cb_Select_Project.Size = new System.Drawing.Size(286, 21);
            this.cb_Select_Project.TabIndex = 14;
            // 
            // lbl_Project_id
            // 
            this.lbl_Project_id.AutoSize = true;
            this.lbl_Project_id.Location = new System.Drawing.Point(23, 180);
            this.lbl_Project_id.Name = "lbl_Project_id";
            this.lbl_Project_id.Size = new System.Drawing.Size(52, 13);
            this.lbl_Project_id.TabIndex = 15;
            this.lbl_Project_id.Text = "Project Id";
            // 
            // tcp_Appointments
            // 
            this.tcp_Appointments.AutoScroll = true;
            this.tcp_Appointments.Controls.Add(this.appointmentsPanel);
            this.tcp_Appointments.Location = new System.Drawing.Point(4, 22);
            this.tcp_Appointments.Name = "tcp_Appointments";
            this.tcp_Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Appointments.Size = new System.Drawing.Size(566, 438);
            this.tcp_Appointments.TabIndex = 3;
            this.tcp_Appointments.Text = "Appointments";
            this.tcp_Appointments.UseVisualStyleBackColor = true;
            // 
            // appointmentsPanel
            // 
            this.appointmentsPanel.AutoSize = true;
            this.appointmentsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appointmentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appointmentsPanel.Controls.Add(this.btn_showallAppointments);
            this.appointmentsPanel.Location = new System.Drawing.Point(4, 35);
            this.appointmentsPanel.MinimumSize = new System.Drawing.Size(540, 2);
            this.appointmentsPanel.Name = "appointmentsPanel";
            this.appointmentsPanel.Size = new System.Drawing.Size(540, 25);
            this.appointmentsPanel.TabIndex = 7;
            // 
            // btn_showallAppointments
            // 
            this.btn_showallAppointments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_showallAppointments.Location = new System.Drawing.Point(0, 0);
            this.btn_showallAppointments.Name = "btn_showallAppointments";
            this.btn_showallAppointments.Size = new System.Drawing.Size(538, 23);
            this.btn_showallAppointments.TabIndex = 0;
            this.btn_showallAppointments.Text = "Show All";
            this.btn_showallAppointments.UseVisualStyleBackColor = true;
            // 
            // tcp_Customers
            // 
            this.tcp_Customers.AutoScroll = true;
            this.tcp_Customers.Controls.Add(this.panel1);
            this.tcp_Customers.Location = new System.Drawing.Point(4, 22);
            this.tcp_Customers.Name = "tcp_Customers";
            this.tcp_Customers.Size = new System.Drawing.Size(566, 438);
            this.tcp_Customers.TabIndex = 4;
            this.tcp_Customers.Text = "Customers";
            this.tcp_Customers.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ShowAllCustomers);
            this.panel1.Location = new System.Drawing.Point(4, 35);
            this.panel1.MinimumSize = new System.Drawing.Size(540, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 25);
            this.panel1.TabIndex = 7;
            // 
            // btn_ShowAllCustomers
            // 
            this.btn_ShowAllCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ShowAllCustomers.Location = new System.Drawing.Point(0, 0);
            this.btn_ShowAllCustomers.Name = "btn_ShowAllCustomers";
            this.btn_ShowAllCustomers.Size = new System.Drawing.Size(538, 23);
            this.btn_ShowAllCustomers.TabIndex = 0;
            this.btn_ShowAllCustomers.Text = "Show All";
            this.btn_ShowAllCustomers.UseVisualStyleBackColor = true;
            this.btn_ShowAllCustomers.Click += new System.EventHandler(this.btn_ShowAllCustomers_Click);
            // 
            // frm_Finance_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.tcp_Main);
            this.Controls.Add(this.mstrp_Menu);
            this.Name = "frm_Finance_2";
            this.Text = "Finance_2";
            this.mstrp_Menu.ResumeLayout(false);
            this.mstrp_Menu.PerformLayout();
            this.tcp_Overview.ResumeLayout(false);
            this.tcp_Overview.PerformLayout();
            this.notificationsPanel.ResumeLayout(false);
            this.tcp_Main.ResumeLayout(false);
            this.tcp_Invoices.ResumeLayout(false);
            this.tcp_Invoices.PerformLayout();
            this.invoicesPanel.ResumeLayout(false);
            this.tcp_AddInvoice.ResumeLayout(false);
            this.tcp_AddInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcp_Appointments.ResumeLayout(false);
            this.tcp_Appointments.PerformLayout();
            this.appointmentsPanel.ResumeLayout(false);
            this.tcp_Customers.ResumeLayout(false);
            this.tcp_Customers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrp_Menu;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Overview;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Overview_Department;
        private System.Windows.Forms.ToolStripComboBox tscmb_Overview_Department;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Overview_Type;
        private System.Windows.Forms.ToolStripComboBox tscmb_Overview_Type;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Overview_Date;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Invoices;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Invoices_CuName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Projects_PName;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Invoices_CoName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Projects_PID;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Invoices_Paid;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Projects_CuName;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Appointments;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_CuName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Appointments_CuName;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_CoName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Appointments_CoName;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_Residence;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Appointments_Residence;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_Summary;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_Date;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Logout;
        private System.Windows.Forms.TabPage tcp_Overview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tcp_Main;
        private System.Windows.Forms.TabPage tcp_Invoices;
        private System.Windows.Forms.TabPage tcp_AddInvoice;
        private System.Windows.Forms.Panel invoicesPanel;
        private System.Windows.Forms.Button btn_ShowAllInvoices;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Invoices_InvoiceID;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Customers;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Customers_CuName;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Customers_CoName;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Customers_Residence;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Customers_UnpaidInvoice;
        private System.Windows.Forms.Button btn_GoTo_Add_Invoice;
        private System.Windows.Forms.TabPage tcp_Appointments;
        private System.Windows.Forms.Panel appointmentsPanel;
        private System.Windows.Forms.Button btn_showallAppointments;
        private System.Windows.Forms.TabPage tcp_Customers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ShowAllCustomers;
        private System.Windows.Forms.Panel notificationsPanel;
        private System.Windows.Forms.Button btn_Show_All_Notifications;
        private System.Windows.Forms.ComboBox cb_Select_Project;
        private System.Windows.Forms.Label lbl_Project_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_VAT;
        private System.Windows.Forms.TextBox txtb_VAT;
        private System.Windows.Forms.ComboBox cbox_Project_Status;
        private System.Windows.Forms.Label lbl_Invoice_Status;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txtb_Price;
        private System.Windows.Forms.Button btn_Add_Invoice;
    }
}