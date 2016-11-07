using System.Windows.Forms;
namespace Barroc_IT
{
    partial class frm_Development
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Development));
            this.mstrp_Menu = new System.Windows.Forms.MenuStrip();
            this.mnitem_Overview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Overview_Department = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmb_Overview_Department = new System.Windows.Forms.ToolStripComboBox();
            this.mnfltr_Overview_Type = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmb_Overview_Type = new System.Windows.Forms.ToolStripComboBox();
            this.mnfltr_Overview_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitem_Projects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Projects_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Projects_PName = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Projects_ID = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Projects_PID = new System.Windows.Forms.ToolStripTextBox();
            this.mnfltr_Projects_CuName = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtb_Projects_CuName = new System.Windows.Forms.ToolStripTextBox();
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
            this.mnitem_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tcp_Main = new System.Windows.Forms.TabControl();
            this.tcp_Overview = new System.Windows.Forms.TabPage();
            this.notificationsPanel = new System.Windows.Forms.Panel();
            this.btn_Show_All_Notifications = new System.Windows.Forms.Button();
            this.tcp_Projects = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Project_Show_All = new System.Windows.Forms.Button();
            this.btn_Add_Project = new System.Windows.Forms.Button();
            this.tcp_Appointments = new System.Windows.Forms.TabPage();
            this.appointmentsPanel = new System.Windows.Forms.Panel();
            this.btn_showallAppointments = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tcp_Help = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tcp_Add_Project = new System.Windows.Forms.TabPage();
            this.txtb_Hardware = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Select_Customer = new System.Windows.Forms.ComboBox();
            this.txtb_Software = new System.Windows.Forms.TextBox();
            this.cbox_Maintenance_Contract = new System.Windows.Forms.ComboBox();
            this.dtp_Deadline = new System.Windows.Forms.DateTimePicker();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtb_Contact_Person = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbox_Project_Status = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Project_Name = new System.Windows.Forms.Label();
            this.lbl_Customer_Id = new System.Windows.Forms.Label();
            this.txtb_Operating_System = new System.Windows.Forms.TextBox();
            this.txtb_Amount_Invoices = new System.Windows.Forms.TextBox();
            this.txtb_Project_Name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcp_Edit_Project = new System.Windows.Forms.TabPage();
            this.lbl_Edit_Project_P_Id = new System.Windows.Forms.Label();
            this.lbl_Edit_Project_C_P = new System.Windows.Forms.Label();
            this.lbl_Edit_Project_C_ID = new System.Windows.Forms.Label();
            this.txtb_Edit_Project_Hardware = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_Edit_Project_Software = new System.Windows.Forms.TextBox();
            this.cb_Edit_Project_M_C = new System.Windows.Forms.ComboBox();
            this.dtp_Edit_Project_Deadline = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cb_Edit_Project_P_Status = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtb_Edit_Project_OS = new System.Windows.Forms.TextBox();
            this.txtb_Edit_Project_AOI = new System.Windows.Forms.TextBox();
            this.txtb_Edit_Project_P_Name = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tcp_Loading = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.tcp_Show_Customer = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lbl_Company_Name = new System.Windows.Forms.Label();
            this.lbl_Phonenumber2 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lbl_Zip_Code2 = new System.Windows.Forms.Label();
            this.lbl_Residence2 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lbl_Address2 = new System.Windows.Forms.Label();
            this.lbl_Fax = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lbl_Phonenumber = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Zip_Code = new System.Windows.Forms.Label();
            this.lbl_Residence = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.mstrp_Menu.SuspendLayout();
            this.tcp_Main.SuspendLayout();
            this.tcp_Overview.SuspendLayout();
            this.notificationsPanel.SuspendLayout();
            this.tcp_Projects.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcp_Appointments.SuspendLayout();
            this.appointmentsPanel.SuspendLayout();
            this.tcp_Help.SuspendLayout();
            this.tcp_Add_Project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcp_Edit_Project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tcp_Loading.SuspendLayout();
            this.tcp_Show_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.mnitem_Projects,
            this.mnfltr_Projects_Name,
            this.mnfltr_Projects_ID,
            this.mnfltr_Projects_CuName,
            this.mnitem_Appointments,
            this.mnfltr_Appointments_CuName,
            this.mnfltr_Appointments_CoName,
            this.mnfltr_Appointments_Residence,
            this.mnfltr_Appointments_Summary,
            this.mnfltr_Appointments_Date,
            this.mnitem_Logout});
            this.mstrp_Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mstrp_Menu.Location = new System.Drawing.Point(0, 0);
            this.mstrp_Menu.Name = "mstrp_Menu";
            this.mstrp_Menu.Size = new System.Drawing.Size(142, 450);
            this.mstrp_Menu.TabIndex = 1;
            // 
            // mnitem_Overview
            // 
            this.mnitem_Overview.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            // mnitem_Projects
            // 
            this.mnitem_Projects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnitem_Projects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Projects.Name = "mnitem_Projects";
            this.mnitem_Projects.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Projects.Text = "Projects";
            this.mnitem_Projects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Projects.Click += new System.EventHandler(this.MenuHandler);
            // 
            // mnfltr_Projects_Name
            // 
            this.mnfltr_Projects_Name.AccessibleName = "filter_projects";
            this.mnfltr_Projects_Name.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Projects_PName});
            this.mnfltr_Projects_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Projects_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Projects_Name.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Projects_Name.Name = "mnfltr_Projects_Name";
            this.mnfltr_Projects_Name.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Projects_Name.Text = "Project Name";
            this.mnfltr_Projects_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Projects_PName
            // 
            this.tstxtb_Projects_PName.Name = "tstxtb_Projects_PName";
            this.tstxtb_Projects_PName.Size = new System.Drawing.Size(100, 23);
            this.tstxtb_Projects_PName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchProjectOnP_Name);
            // 
            // mnfltr_Projects_ID
            // 
            this.mnfltr_Projects_ID.AccessibleName = "filter_projects";
            this.mnfltr_Projects_ID.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Projects_PID});
            this.mnfltr_Projects_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Projects_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Projects_ID.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Projects_ID.Name = "mnfltr_Projects_ID";
            this.mnfltr_Projects_ID.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Projects_ID.Text = "Project ID";
            this.mnfltr_Projects_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Projects_PID
            // 
            this.tstxtb_Projects_PID.Name = "tstxtb_Projects_PID";
            this.tstxtb_Projects_PID.Size = new System.Drawing.Size(100, 23);
            this.tstxtb_Projects_PID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchProjectOnP_ID);
            // 
            // mnfltr_Projects_CuName
            // 
            this.mnfltr_Projects_CuName.AccessibleName = "filter_projects";
            this.mnfltr_Projects_CuName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtb_Projects_CuName});
            this.mnfltr_Projects_CuName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Projects_CuName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Projects_CuName.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Projects_CuName.Name = "mnfltr_Projects_CuName";
            this.mnfltr_Projects_CuName.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Projects_CuName.Text = "Customer Name";
            this.mnfltr_Projects_CuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tstxtb_Projects_CuName
            // 
            this.tstxtb_Projects_CuName.Name = "tstxtb_Projects_CuName";
            this.tstxtb_Projects_CuName.Size = new System.Drawing.Size(100, 23);
            this.tstxtb_Projects_CuName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchProjectOnC_Name);
            // 
            // mnitem_Appointments
            // 
            this.mnitem_Appointments.AutoSize = false;
            this.mnitem_Appointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnitem_Appointments.Name = "mnitem_Appointments";
            this.mnitem_Appointments.Size = new System.Drawing.Size(135, 30);
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
            // tcp_Main
            // 
            this.tcp_Main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tcp_Main.Controls.Add(this.tcp_Overview);
            this.tcp_Main.Controls.Add(this.tcp_Projects);
            this.tcp_Main.Controls.Add(this.tcp_Appointments);
            this.tcp_Main.Controls.Add(this.tcp_Help);
            this.tcp_Main.Controls.Add(this.tcp_Add_Project);
            this.tcp_Main.Controls.Add(this.tcp_Edit_Project);
            this.tcp_Main.Controls.Add(this.tcp_Loading);
            this.tcp_Main.Controls.Add(this.tcp_Show_Customer);
            this.tcp_Main.Location = new System.Drawing.Point(142, 0);
            this.tcp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tcp_Main.Name = "tcp_Main";
            this.tcp_Main.SelectedIndex = 0;
            this.tcp_Main.Size = new System.Drawing.Size(574, 450);
            this.tcp_Main.TabIndex = 1;
            this.tcp_Main.TabStop = false;
            this.tcp_Main.SelectedIndexChanged += new System.EventHandler(this.tc_Main_SelectedIndexChanged);
            // 
            // tcp_Overview
            // 
            this.tcp_Overview.AutoScroll = true;
            this.tcp_Overview.Controls.Add(this.notificationsPanel);
            this.tcp_Overview.Location = new System.Drawing.Point(4, 22);
            this.tcp_Overview.Name = "tcp_Overview";
            this.tcp_Overview.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Overview.Size = new System.Drawing.Size(566, 424);
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
            this.notificationsPanel.TabIndex = 8;
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
            this.btn_Show_All_Notifications.Click += new System.EventHandler(this.btn_Show_All_Notifications_Click);
            // 
            // tcp_Projects
            // 
            this.tcp_Projects.AutoScroll = true;
            this.tcp_Projects.Controls.Add(this.panel1);
            this.tcp_Projects.Controls.Add(this.btn_Add_Project);
            this.tcp_Projects.Location = new System.Drawing.Point(4, 22);
            this.tcp_Projects.Name = "tcp_Projects";
            this.tcp_Projects.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Projects.Size = new System.Drawing.Size(566, 424);
            this.tcp_Projects.TabIndex = 1;
            this.tcp_Projects.Text = "Projects";
            this.tcp_Projects.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Project_Show_All);
            this.panel1.Location = new System.Drawing.Point(4, 35);
            this.panel1.MinimumSize = new System.Drawing.Size(540, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 25);
            this.panel1.TabIndex = 5;
            // 
            // btn_Project_Show_All
            // 
            this.btn_Project_Show_All.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Project_Show_All.Location = new System.Drawing.Point(0, 0);
            this.btn_Project_Show_All.Name = "btn_Project_Show_All";
            this.btn_Project_Show_All.Size = new System.Drawing.Size(538, 23);
            this.btn_Project_Show_All.TabIndex = 0;
            this.btn_Project_Show_All.Text = "Show All";
            this.btn_Project_Show_All.UseVisualStyleBackColor = true;
            this.btn_Project_Show_All.Click += new System.EventHandler(this.btn_Project_Show_All_Click);
            // 
            // btn_Add_Project
            // 
            this.btn_Add_Project.Location = new System.Drawing.Point(3, 6);
            this.btn_Add_Project.Name = "btn_Add_Project";
            this.btn_Add_Project.Size = new System.Drawing.Size(34, 23);
            this.btn_Add_Project.TabIndex = 2;
            this.btn_Add_Project.Text = "Add";
            this.btn_Add_Project.UseVisualStyleBackColor = true;
            this.btn_Add_Project.Click += new System.EventHandler(this.btn_Add_Project_Click);
            // 
            // tcp_Appointments
            // 
            this.tcp_Appointments.AutoScroll = true;
            this.tcp_Appointments.Controls.Add(this.appointmentsPanel);
            this.tcp_Appointments.Controls.Add(this.label6);
            this.tcp_Appointments.Location = new System.Drawing.Point(4, 22);
            this.tcp_Appointments.Name = "tcp_Appointments";
            this.tcp_Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Appointments.Size = new System.Drawing.Size(566, 424);
            this.tcp_Appointments.TabIndex = 2;
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
            this.appointmentsPanel.TabIndex = 6;
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
            this.btn_showallAppointments.Click += new System.EventHandler(this.btn_showallAppointments_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Appointments";
            // 
            // tcp_Help
            // 
            this.tcp_Help.AutoScroll = true;
            this.tcp_Help.Controls.Add(this.label8);
            this.tcp_Help.Controls.Add(this.label7);
            this.tcp_Help.Location = new System.Drawing.Point(4, 22);
            this.tcp_Help.Name = "tcp_Help";
            this.tcp_Help.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Help.Size = new System.Drawing.Size(566, 424);
            this.tcp_Help.TabIndex = 3;
            this.tcp_Help.Text = "Help";
            this.tcp_Help.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 526);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Help me alsjeblieft";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Help";
            // 
            // tcp_Add_Project
            // 
            this.tcp_Add_Project.Controls.Add(this.txtb_Hardware);
            this.tcp_Add_Project.Controls.Add(this.label4);
            this.tcp_Add_Project.Controls.Add(this.cb_Select_Customer);
            this.tcp_Add_Project.Controls.Add(this.txtb_Software);
            this.tcp_Add_Project.Controls.Add(this.cbox_Maintenance_Contract);
            this.tcp_Add_Project.Controls.Add(this.dtp_Deadline);
            this.tcp_Add_Project.Controls.Add(this.btn_Add);
            this.tcp_Add_Project.Controls.Add(this.label15);
            this.tcp_Add_Project.Controls.Add(this.label14);
            this.tcp_Add_Project.Controls.Add(this.label13);
            this.tcp_Add_Project.Controls.Add(this.txtb_Contact_Person);
            this.tcp_Add_Project.Controls.Add(this.label12);
            this.tcp_Add_Project.Controls.Add(this.label11);
            this.tcp_Add_Project.Controls.Add(this.label10);
            this.tcp_Add_Project.Controls.Add(this.cbox_Project_Status);
            this.tcp_Add_Project.Controls.Add(this.label9);
            this.tcp_Add_Project.Controls.Add(this.lbl_Project_Name);
            this.tcp_Add_Project.Controls.Add(this.lbl_Customer_Id);
            this.tcp_Add_Project.Controls.Add(this.txtb_Operating_System);
            this.tcp_Add_Project.Controls.Add(this.txtb_Amount_Invoices);
            this.tcp_Add_Project.Controls.Add(this.txtb_Project_Name);
            this.tcp_Add_Project.Controls.Add(this.pictureBox1);
            this.tcp_Add_Project.Location = new System.Drawing.Point(4, 22);
            this.tcp_Add_Project.Name = "tcp_Add_Project";
            this.tcp_Add_Project.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Add_Project.Size = new System.Drawing.Size(566, 424);
            this.tcp_Add_Project.TabIndex = 4;
            this.tcp_Add_Project.Text = "Add Project";
            this.tcp_Add_Project.UseVisualStyleBackColor = true;
            // 
            // txtb_Hardware
            // 
            this.txtb_Hardware.Location = new System.Drawing.Point(317, 337);
            this.txtb_Hardware.MaxLength = 255;
            this.txtb_Hardware.Multiline = true;
            this.txtb_Hardware.Name = "txtb_Hardware";
            this.txtb_Hardware.Size = new System.Drawing.Size(153, 46);
            this.txtb_Hardware.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hardware";
            // 
            // cb_Select_Customer
            // 
            this.cb_Select_Customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Select_Customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Select_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Select_Customer.FormattingEnabled = true;
            this.cb_Select_Customer.Location = new System.Drawing.Point(25, 135);
            this.cb_Select_Customer.MaxDropDownItems = 100;
            this.cb_Select_Customer.Name = "cb_Select_Customer";
            this.cb_Select_Customer.Size = new System.Drawing.Size(219, 21);
            this.cb_Select_Customer.TabIndex = 1;
            // 
            // txtb_Software
            // 
            this.txtb_Software.Location = new System.Drawing.Point(24, 337);
            this.txtb_Software.MaxLength = 255;
            this.txtb_Software.Multiline = true;
            this.txtb_Software.Name = "txtb_Software";
            this.txtb_Software.Size = new System.Drawing.Size(220, 46);
            this.txtb_Software.TabIndex = 10;
            // 
            // cbox_Maintenance_Contract
            // 
            this.cbox_Maintenance_Contract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Maintenance_Contract.FormattingEnabled = true;
            this.cbox_Maintenance_Contract.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cbox_Maintenance_Contract.Location = new System.Drawing.Point(317, 237);
            this.cbox_Maintenance_Contract.Name = "cbox_Maintenance_Contract";
            this.cbox_Maintenance_Contract.Size = new System.Drawing.Size(94, 21);
            this.cbox_Maintenance_Contract.TabIndex = 6;
            // 
            // dtp_Deadline
            // 
            this.dtp_Deadline.Location = new System.Drawing.Point(25, 287);
            this.dtp_Deadline.Name = "dtp_Deadline";
            this.dtp_Deadline.Size = new System.Drawing.Size(219, 20);
            this.dtp_Deadline.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(485, 395);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add Project";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.AddProject);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Deadline date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Maintenance Contract";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Contact Person";
            // 
            // txtb_Contact_Person
            // 
            this.txtb_Contact_Person.Location = new System.Drawing.Point(317, 136);
            this.txtb_Contact_Person.Name = "txtb_Contact_Person";
            this.txtb_Contact_Person.Size = new System.Drawing.Size(153, 20);
            this.txtb_Contact_Person.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(314, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Amount of invoices";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Software";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Operating System";
            // 
            // cbox_Project_Status
            // 
            this.cbox_Project_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Project_Status.Enabled = false;
            this.cbox_Project_Status.FormattingEnabled = true;
            this.cbox_Project_Status.Items.AddRange(new object[] {
            "New Project",
            "In Progress",
            "Halted",
            "Stopped",
            "Done"});
            this.cbox_Project_Status.Location = new System.Drawing.Point(317, 180);
            this.cbox_Project_Status.Name = "cbox_Project_Status";
            this.cbox_Project_Status.Size = new System.Drawing.Size(94, 21);
            this.cbox_Project_Status.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Project Status";
            // 
            // lbl_Project_Name
            // 
            this.lbl_Project_Name.AutoSize = true;
            this.lbl_Project_Name.Location = new System.Drawing.Point(22, 164);
            this.lbl_Project_Name.Name = "lbl_Project_Name";
            this.lbl_Project_Name.Size = new System.Drawing.Size(71, 13);
            this.lbl_Project_Name.TabIndex = 14;
            this.lbl_Project_Name.Text = "Project Name";
            // 
            // lbl_Customer_Id
            // 
            this.lbl_Customer_Id.AutoSize = true;
            this.lbl_Customer_Id.Location = new System.Drawing.Point(21, 119);
            this.lbl_Customer_Id.Name = "lbl_Customer_Id";
            this.lbl_Customer_Id.Size = new System.Drawing.Size(63, 13);
            this.lbl_Customer_Id.TabIndex = 13;
            this.lbl_Customer_Id.Text = "Customer Id";
            // 
            // txtb_Operating_System
            // 
            this.txtb_Operating_System.Location = new System.Drawing.Point(25, 237);
            this.txtb_Operating_System.Name = "txtb_Operating_System";
            this.txtb_Operating_System.Size = new System.Drawing.Size(219, 20);
            this.txtb_Operating_System.TabIndex = 5;
            // 
            // txtb_Amount_Invoices
            // 
            this.txtb_Amount_Invoices.Location = new System.Drawing.Point(317, 287);
            this.txtb_Amount_Invoices.MaxLength = 3;
            this.txtb_Amount_Invoices.Name = "txtb_Amount_Invoices";
            this.txtb_Amount_Invoices.Size = new System.Drawing.Size(153, 20);
            this.txtb_Amount_Invoices.TabIndex = 9;
            this.txtb_Amount_Invoices.Text = "0";
            this.txtb_Amount_Invoices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_Amount_Invoices_KeyPress);
            // 
            // txtb_Project_Name
            // 
            this.txtb_Project_Name.Location = new System.Drawing.Point(25, 177);
            this.txtb_Project_Name.MaxLength = 255;
            this.txtb_Project_Name.Multiline = true;
            this.txtb_Project_Name.Name = "txtb_Project_Name";
            this.txtb_Project_Name.Size = new System.Drawing.Size(219, 24);
            this.txtb_Project_Name.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // tcp_Edit_Project
            // 
            this.tcp_Edit_Project.Controls.Add(this.lbl_Edit_Project_P_Id);
            this.tcp_Edit_Project.Controls.Add(this.lbl_Edit_Project_C_P);
            this.tcp_Edit_Project.Controls.Add(this.lbl_Edit_Project_C_ID);
            this.tcp_Edit_Project.Controls.Add(this.txtb_Edit_Project_Hardware);
            this.tcp_Edit_Project.Controls.Add(this.label1);
            this.tcp_Edit_Project.Controls.Add(this.txtb_Edit_Project_Software);
            this.tcp_Edit_Project.Controls.Add(this.cb_Edit_Project_M_C);
            this.tcp_Edit_Project.Controls.Add(this.dtp_Edit_Project_Deadline);
            this.tcp_Edit_Project.Controls.Add(this.button1);
            this.tcp_Edit_Project.Controls.Add(this.label16);
            this.tcp_Edit_Project.Controls.Add(this.label17);
            this.tcp_Edit_Project.Controls.Add(this.label18);
            this.tcp_Edit_Project.Controls.Add(this.label19);
            this.tcp_Edit_Project.Controls.Add(this.label20);
            this.tcp_Edit_Project.Controls.Add(this.label21);
            this.tcp_Edit_Project.Controls.Add(this.cb_Edit_Project_P_Status);
            this.tcp_Edit_Project.Controls.Add(this.label22);
            this.tcp_Edit_Project.Controls.Add(this.label23);
            this.tcp_Edit_Project.Controls.Add(this.label24);
            this.tcp_Edit_Project.Controls.Add(this.txtb_Edit_Project_OS);
            this.tcp_Edit_Project.Controls.Add(this.txtb_Edit_Project_AOI);
            this.tcp_Edit_Project.Controls.Add(this.txtb_Edit_Project_P_Name);
            this.tcp_Edit_Project.Controls.Add(this.pictureBox2);
            this.tcp_Edit_Project.Location = new System.Drawing.Point(4, 22);
            this.tcp_Edit_Project.Name = "tcp_Edit_Project";
            this.tcp_Edit_Project.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Edit_Project.Size = new System.Drawing.Size(566, 424);
            this.tcp_Edit_Project.TabIndex = 5;
            this.tcp_Edit_Project.Text = "Edit Project";
            this.tcp_Edit_Project.UseVisualStyleBackColor = true;
            // 
            // lbl_Edit_Project_P_Id
            // 
            this.lbl_Edit_Project_P_Id.AutoSize = true;
            this.lbl_Edit_Project_P_Id.Location = new System.Drawing.Point(518, 104);
            this.lbl_Edit_Project_P_Id.Name = "lbl_Edit_Project_P_Id";
            this.lbl_Edit_Project_P_Id.Size = new System.Drawing.Size(41, 13);
            this.lbl_Edit_Project_P_Id.TabIndex = 52;
            this.lbl_Edit_Project_P_Id.Text = "label25";
            this.lbl_Edit_Project_P_Id.Visible = false;
            // 
            // lbl_Edit_Project_C_P
            // 
            this.lbl_Edit_Project_C_P.AutoSize = true;
            this.lbl_Edit_Project_C_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edit_Project_C_P.Location = new System.Drawing.Point(317, 136);
            this.lbl_Edit_Project_C_P.Name = "lbl_Edit_Project_C_P";
            this.lbl_Edit_Project_C_P.Size = new System.Drawing.Size(0, 13);
            this.lbl_Edit_Project_C_P.TabIndex = 51;
            // 
            // lbl_Edit_Project_C_ID
            // 
            this.lbl_Edit_Project_C_ID.AutoSize = true;
            this.lbl_Edit_Project_C_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edit_Project_C_ID.Location = new System.Drawing.Point(25, 136);
            this.lbl_Edit_Project_C_ID.Name = "lbl_Edit_Project_C_ID";
            this.lbl_Edit_Project_C_ID.Size = new System.Drawing.Size(0, 13);
            this.lbl_Edit_Project_C_ID.TabIndex = 50;
            // 
            // txtb_Edit_Project_Hardware
            // 
            this.txtb_Edit_Project_Hardware.Location = new System.Drawing.Point(317, 337);
            this.txtb_Edit_Project_Hardware.MaxLength = 255;
            this.txtb_Edit_Project_Hardware.Multiline = true;
            this.txtb_Edit_Project_Hardware.Name = "txtb_Edit_Project_Hardware";
            this.txtb_Edit_Project_Hardware.Size = new System.Drawing.Size(193, 46);
            this.txtb_Edit_Project_Hardware.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Hardware";
            // 
            // txtb_Edit_Project_Software
            // 
            this.txtb_Edit_Project_Software.Location = new System.Drawing.Point(24, 337);
            this.txtb_Edit_Project_Software.MaxLength = 255;
            this.txtb_Edit_Project_Software.Multiline = true;
            this.txtb_Edit_Project_Software.Name = "txtb_Edit_Project_Software";
            this.txtb_Edit_Project_Software.Size = new System.Drawing.Size(193, 46);
            this.txtb_Edit_Project_Software.TabIndex = 36;
            // 
            // cb_Edit_Project_M_C
            // 
            this.cb_Edit_Project_M_C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Edit_Project_M_C.FormattingEnabled = true;
            this.cb_Edit_Project_M_C.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cb_Edit_Project_M_C.Location = new System.Drawing.Point(317, 237);
            this.cb_Edit_Project_M_C.Name = "cb_Edit_Project_M_C";
            this.cb_Edit_Project_M_C.Size = new System.Drawing.Size(97, 21);
            this.cb_Edit_Project_M_C.TabIndex = 33;
            // 
            // dtp_Edit_Project_Deadline
            // 
            this.dtp_Edit_Project_Deadline.Location = new System.Drawing.Point(25, 287);
            this.dtp_Edit_Project_Deadline.Name = "dtp_Edit_Project_Deadline";
            this.dtp_Edit_Project_Deadline.Size = new System.Drawing.Size(171, 20);
            this.dtp_Edit_Project_Deadline.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Edit Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EditProject);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Deadline date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(314, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Maintenance Contract";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(314, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Contact Person";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(314, 271);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Amount of invoices";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 321);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Software";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 221);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Operating System";
            // 
            // cb_Edit_Project_P_Status
            // 
            this.cb_Edit_Project_P_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Edit_Project_P_Status.FormattingEnabled = true;
            this.cb_Edit_Project_P_Status.Items.AddRange(new object[] {
            "New Project",
            "In Progress",
            "Halted",
            "Stopped",
            "Done"});
            this.cb_Edit_Project_P_Status.Location = new System.Drawing.Point(317, 180);
            this.cb_Edit_Project_P_Status.Name = "cb_Edit_Project_P_Status";
            this.cb_Edit_Project_P_Status.Size = new System.Drawing.Size(97, 21);
            this.cb_Edit_Project_P_Status.TabIndex = 31;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(314, 164);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Project Status";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(22, 164);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "Project Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 119);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 13);
            this.label24.TabIndex = 39;
            this.label24.Text = "Customer Id";
            // 
            // txtb_Edit_Project_OS
            // 
            this.txtb_Edit_Project_OS.Location = new System.Drawing.Point(25, 237);
            this.txtb_Edit_Project_OS.Name = "txtb_Edit_Project_OS";
            this.txtb_Edit_Project_OS.Size = new System.Drawing.Size(100, 20);
            this.txtb_Edit_Project_OS.TabIndex = 32;
            // 
            // txtb_Edit_Project_AOI
            // 
            this.txtb_Edit_Project_AOI.Location = new System.Drawing.Point(317, 287);
            this.txtb_Edit_Project_AOI.MaxLength = 3;
            this.txtb_Edit_Project_AOI.Name = "txtb_Edit_Project_AOI";
            this.txtb_Edit_Project_AOI.Size = new System.Drawing.Size(100, 20);
            this.txtb_Edit_Project_AOI.TabIndex = 35;
            // 
            // txtb_Edit_Project_P_Name
            // 
            this.txtb_Edit_Project_P_Name.Location = new System.Drawing.Point(25, 177);
            this.txtb_Edit_Project_P_Name.MaxLength = 255;
            this.txtb_Edit_Project_P_Name.Multiline = true;
            this.txtb_Edit_Project_P_Name.Name = "txtb_Edit_Project_P_Name";
            this.txtb_Edit_Project_P_Name.Size = new System.Drawing.Size(219, 41);
            this.txtb_Edit_Project_P_Name.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(511, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // tcp_Loading
            // 
            this.tcp_Loading.Controls.Add(this.label25);
            this.tcp_Loading.Location = new System.Drawing.Point(4, 22);
            this.tcp_Loading.Name = "tcp_Loading";
            this.tcp_Loading.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Loading.Size = new System.Drawing.Size(566, 424);
            this.tcp_Loading.TabIndex = 6;
            this.tcp_Loading.Text = "Loading";
            this.tcp_Loading.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(211, 177);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Loading, please wait...";
            // 
            // tcp_Show_Customer
            // 
            this.tcp_Show_Customer.Controls.Add(this.pictureBox3);
            this.tcp_Show_Customer.Controls.Add(this.panel2);
            this.tcp_Show_Customer.Location = new System.Drawing.Point(4, 22);
            this.tcp_Show_Customer.Name = "tcp_Show_Customer";
            this.tcp_Show_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Show_Customer.Size = new System.Drawing.Size(566, 424);
            this.tcp_Show_Customer.TabIndex = 7;
            this.tcp_Show_Customer.Text = "Customer";
            this.tcp_Show_Customer.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(26, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(511, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AccessibleName = "";
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Controls.Add(this.lbl_Company_Name);
            this.panel2.Controls.Add(this.lbl_Phonenumber2);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.lbl_Zip_Code2);
            this.panel2.Controls.Add(this.lbl_Residence2);
            this.panel2.Controls.Add(this.label38);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.lbl_Address2);
            this.panel2.Controls.Add(this.lbl_Fax);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.lbl_Phonenumber);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.lbl_Email);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.lbl_Customer_Name);
            this.panel2.Controls.Add(this.lbl_Zip_Code);
            this.panel2.Controls.Add(this.lbl_Residence);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.lbl_Address);
            this.panel2.Location = new System.Drawing.Point(113, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 229);
            this.panel2.TabIndex = 10;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 135);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(109, 13);
            this.label27.TabIndex = 24;
            this.label27.Text = "Alternative details";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 22);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(83, 13);
            this.label37.TabIndex = 22;
            this.label37.Text = "Company name:";
            // 
            // lbl_Company_Name
            // 
            this.lbl_Company_Name.AccessibleName = "Controls";
            this.lbl_Company_Name.AutoSize = true;
            this.lbl_Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company_Name.Location = new System.Drawing.Point(120, 22);
            this.lbl_Company_Name.Name = "lbl_Company_Name";
            this.lbl_Company_Name.Size = new System.Drawing.Size(74, 13);
            this.lbl_Company_Name.TabIndex = 23;
            this.lbl_Company_Name.Text = "Placeholder";
            // 
            // lbl_Phonenumber2
            // 
            this.lbl_Phonenumber2.AccessibleName = "Controls";
            this.lbl_Phonenumber2.AutoSize = true;
            this.lbl_Phonenumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phonenumber2.Location = new System.Drawing.Point(120, 199);
            this.lbl_Phonenumber2.Name = "lbl_Phonenumber2";
            this.lbl_Phonenumber2.Size = new System.Drawing.Size(74, 13);
            this.lbl_Phonenumber2.TabIndex = 21;
            this.lbl_Phonenumber2.Text = "Placeholder";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 159);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(61, 13);
            this.label34.TabIndex = 14;
            this.label34.Text = "Residence:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 199);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(79, 13);
            this.label35.TabIndex = 20;
            this.label35.Text = "Phone number:";
            // 
            // lbl_Zip_Code2
            // 
            this.lbl_Zip_Code2.AccessibleName = "Controls";
            this.lbl_Zip_Code2.AutoSize = true;
            this.lbl_Zip_Code2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zip_Code2.Location = new System.Drawing.Point(120, 186);
            this.lbl_Zip_Code2.Name = "lbl_Zip_Code2";
            this.lbl_Zip_Code2.Size = new System.Drawing.Size(74, 13);
            this.lbl_Zip_Code2.TabIndex = 19;
            this.lbl_Zip_Code2.Text = "Placeholder";
            // 
            // lbl_Residence2
            // 
            this.lbl_Residence2.AccessibleName = "Controls";
            this.lbl_Residence2.AutoSize = true;
            this.lbl_Residence2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Residence2.Location = new System.Drawing.Point(120, 159);
            this.lbl_Residence2.Name = "lbl_Residence2";
            this.lbl_Residence2.Size = new System.Drawing.Size(74, 13);
            this.lbl_Residence2.TabIndex = 15;
            this.lbl_Residence2.Text = "Placeholder";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 186);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(53, 13);
            this.label38.TabIndex = 18;
            this.label38.Text = "Zip Code:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 173);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(48, 13);
            this.label39.TabIndex = 16;
            this.label39.Text = "Address:";
            // 
            // lbl_Address2
            // 
            this.lbl_Address2.AccessibleName = "Controls";
            this.lbl_Address2.AutoSize = true;
            this.lbl_Address2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address2.Location = new System.Drawing.Point(120, 173);
            this.lbl_Address2.Name = "lbl_Address2";
            this.lbl_Address2.Size = new System.Drawing.Size(74, 13);
            this.lbl_Address2.TabIndex = 17;
            this.lbl_Address2.Text = "Placeholder";
            // 
            // lbl_Fax
            // 
            this.lbl_Fax.AccessibleName = "Controls";
            this.lbl_Fax.AutoSize = true;
            this.lbl_Fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fax.Location = new System.Drawing.Point(120, 101);
            this.lbl_Fax.Name = "lbl_Fax";
            this.lbl_Fax.Size = new System.Drawing.Size(74, 13);
            this.lbl_Fax.TabIndex = 13;
            this.lbl_Fax.Text = "Placeholder";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 101);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(27, 13);
            this.label33.TabIndex = 12;
            this.label33.Text = "Fax:";
            // 
            // lbl_Phonenumber
            // 
            this.lbl_Phonenumber.AccessibleName = "Controls";
            this.lbl_Phonenumber.AutoSize = true;
            this.lbl_Phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phonenumber.Location = new System.Drawing.Point(120, 88);
            this.lbl_Phonenumber.Name = "lbl_Phonenumber";
            this.lbl_Phonenumber.Size = new System.Drawing.Size(74, 13);
            this.lbl_Phonenumber.TabIndex = 11;
            this.lbl_Phonenumber.Text = "Placeholder";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 88);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(79, 13);
            this.label32.TabIndex = 10;
            this.label32.Text = "Phone number:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Customer Name:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AccessibleName = "Controls";
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(120, 75);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(74, 13);
            this.lbl_Email.TabIndex = 9;
            this.lbl_Email.Text = "Placeholder";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 35);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Residence:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 75);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 13);
            this.label31.TabIndex = 8;
            this.label31.Text = "E-mail:";
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AccessibleName = "Controls";
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(120, 9);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(74, 13);
            this.lbl_Customer_Name.TabIndex = 2;
            this.lbl_Customer_Name.Text = "Placeholder";
            // 
            // lbl_Zip_Code
            // 
            this.lbl_Zip_Code.AccessibleName = "Controls";
            this.lbl_Zip_Code.AutoSize = true;
            this.lbl_Zip_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zip_Code.Location = new System.Drawing.Point(120, 62);
            this.lbl_Zip_Code.Name = "lbl_Zip_Code";
            this.lbl_Zip_Code.Size = new System.Drawing.Size(74, 13);
            this.lbl_Zip_Code.TabIndex = 7;
            this.lbl_Zip_Code.Text = "Placeholder";
            // 
            // lbl_Residence
            // 
            this.lbl_Residence.AccessibleName = "Controls";
            this.lbl_Residence.AutoSize = true;
            this.lbl_Residence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Residence.Location = new System.Drawing.Point(120, 35);
            this.lbl_Residence.Name = "lbl_Residence";
            this.lbl_Residence.Size = new System.Drawing.Size(74, 13);
            this.lbl_Residence.TabIndex = 3;
            this.lbl_Residence.Text = "Placeholder";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 62);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 13);
            this.label30.TabIndex = 6;
            this.label30.Text = "Zip Code:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 49);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(48, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Address:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AccessibleName = "Controls";
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(120, 49);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(74, 13);
            this.lbl_Address.TabIndex = 5;
            this.lbl_Address.Text = "Placeholder";
            // 
            // frm_Development
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 449);
            this.Controls.Add(this.mstrp_Menu);
            this.Controls.Add(this.tcp_Main);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 488);
            this.MinimumSize = new System.Drawing.Size(730, 488);
            this.Name = "frm_Development";
            this.Text = "Barroc-IT - Software for real - Development";
            this.mstrp_Menu.ResumeLayout(false);
            this.mstrp_Menu.PerformLayout();
            this.tcp_Main.ResumeLayout(false);
            this.tcp_Overview.ResumeLayout(false);
            this.tcp_Overview.PerformLayout();
            this.notificationsPanel.ResumeLayout(false);
            this.tcp_Projects.ResumeLayout(false);
            this.tcp_Projects.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tcp_Appointments.ResumeLayout(false);
            this.tcp_Appointments.PerformLayout();
            this.appointmentsPanel.ResumeLayout(false);
            this.tcp_Help.ResumeLayout(false);
            this.tcp_Help.PerformLayout();
            this.tcp_Add_Project.ResumeLayout(false);
            this.tcp_Add_Project.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcp_Edit_Project.ResumeLayout(false);
            this.tcp_Edit_Project.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tcp_Loading.ResumeLayout(false);
            this.tcp_Loading.PerformLayout();
            this.tcp_Show_Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrp_Menu;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Appointments;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Overview;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Projects;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Logout;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Overview_Date;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Overview_Department;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Overview_Type;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Projects_ID;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Projects_Name;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Projects_CuName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Projects_PName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Projects_PID;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Projects_CuName;
        private System.Windows.Forms.ToolStripComboBox tscmb_Overview_Department;
        private System.Windows.Forms.ToolStripComboBox tscmb_Overview_Type;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_CuName;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_CoName;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_Residence;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_Summary;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Appointments_Date;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Appointments_CuName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Appointments_CoName;
        private System.Windows.Forms.ToolStripTextBox tstxtb_Appointments_Residence;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private TabControl tcp_Main;
        private TabPage tcp_Overview;
        private TabPage tcp_Projects;
        private TabPage tcp_Appointments;
        private TabPage tcp_Help;
        private Label label6;
        private Label label7;
        private Label label8;
        private TabPage tcp_Add_Project;
        private Button btn_Add_Project;
        private Label lbl_Customer_Id;
        private TextBox txtb_Operating_System;
        private TextBox txtb_Amount_Invoices;
        private TextBox txtb_Project_Name;
        private Label lbl_Project_Name;
        private Label label9;
        private ComboBox cbox_Project_Status;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtb_Contact_Person;
        private Label label14;
        private Label label15;
        private Button btn_Add;
        private DateTimePicker dtp_Deadline;
        private ComboBox cbox_Maintenance_Contract;
        private TextBox txtb_Software;
        private ComboBox cb_Select_Customer;
        private PictureBox pictureBox1;
        private TextBox txtb_Hardware;
        private Label label4;
        private Panel panel1;
        private Button btn_Project_Show_All;
        private TabPage tcp_Edit_Project;
        private TextBox txtb_Edit_Project_Hardware;
        private Label label1;
        private TextBox txtb_Edit_Project_Software;
        private ComboBox cb_Edit_Project_M_C;
        private DateTimePicker dtp_Edit_Project_Deadline;
        private Button button1;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private ComboBox cb_Edit_Project_P_Status;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox txtb_Edit_Project_OS;
        private TextBox txtb_Edit_Project_AOI;
        private TextBox txtb_Edit_Project_P_Name;
        private PictureBox pictureBox2;
        private Label lbl_Edit_Project_C_ID;
        private Label lbl_Edit_Project_C_P;
        private Label lbl_Edit_Project_P_Id;
        private TabPage tcp_Loading;
        private Label label25;
        private TabPage tcp_Show_Customer;
        private Label label28;
        private Label label26;
        private Label lbl_Customer_Name;
        private Label lbl_Residence;
        private Label lbl_Address;
        private Label label29;
        private Label lbl_Zip_Code;
        private Label label30;
        private Label lbl_Email;
        private Label label31;
        private Panel panel2;
        private Label lbl_Phonenumber;
        private Label label32;
        private Label lbl_Fax;
        private Label label33;
        private Label lbl_Phonenumber2;
        private Label label34;
        private Label label35;
        private Label lbl_Zip_Code2;
        private Label lbl_Residence2;
        private Label label38;
        private Label label39;
        private Label lbl_Address2;
        private Label label37;
        private Label lbl_Company_Name;
        private Label label27;
        private PictureBox pictureBox3;
        private Panel appointmentsPanel;
        private Button btn_showallAppointments;
        private Panel notificationsPanel;
        private Button btn_Show_All_Notifications;



    }
}