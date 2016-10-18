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
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tcp_Overview = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcp_Projects = new System.Windows.Forms.TabPage();
            this.btn_Add_Project = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcp_Appointments = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcp_Help = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tcp_Add_Project = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.txtb_Customer_Id = new System.Windows.Forms.TextBox();
            this.mstrp_Menu.SuspendLayout();
            this.tc_Main.SuspendLayout();
            this.tcp_Overview.SuspendLayout();
            this.tcp_Projects.SuspendLayout();
            this.tcp_Appointments.SuspendLayout();
            this.tcp_Help.SuspendLayout();
            this.tcp_Add_Project.SuspendLayout();
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
            this.mnitem_Logout.Image = ((System.Drawing.Image)(resources.GetObject("mnitem_Logout.Image")));
            this.mnitem_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Logout.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.mnitem_Logout.Name = "mnitem_Logout";
            this.mnitem_Logout.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Logout.Text = "Logout";
            this.mnitem_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Logout.Click += new System.EventHandler(this.mnitem_Logout_Click);
            // 
            // tc_Main
            // 
            this.tc_Main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tc_Main.Controls.Add(this.tcp_Overview);
            this.tc_Main.Controls.Add(this.tcp_Projects);
            this.tc_Main.Controls.Add(this.tcp_Appointments);
            this.tc_Main.Controls.Add(this.tcp_Help);
            this.tc_Main.Controls.Add(this.tcp_Add_Project);
            this.tc_Main.Location = new System.Drawing.Point(142, 0);
            this.tc_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(574, 450);
            this.tc_Main.TabIndex = 2;
            this.tc_Main.TabStop = false;
            // 
            // tcp_Overview
            // 
            this.tcp_Overview.AutoScroll = true;
            this.tcp_Overview.Controls.Add(this.label3);
            this.tcp_Overview.Controls.Add(this.label2);
            this.tcp_Overview.Location = new System.Drawing.Point(4, 22);
            this.tcp_Overview.Name = "tcp_Overview";
            this.tcp_Overview.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Overview.Size = new System.Drawing.Size(566, 424);
            this.tcp_Overview.TabIndex = 0;
            this.tcp_Overview.Text = "Overview";
            this.tcp_Overview.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Overview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Overview";
            // 
            // tcp_Projects
            // 
            this.tcp_Projects.AutoScroll = true;
            this.tcp_Projects.Controls.Add(this.btn_Add_Project);
            this.tcp_Projects.Controls.Add(this.label4);
            this.tcp_Projects.Controls.Add(this.label1);
            this.tcp_Projects.Location = new System.Drawing.Point(4, 22);
            this.tcp_Projects.Name = "tcp_Projects";
            this.tcp_Projects.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Projects.Size = new System.Drawing.Size(566, 424);
            this.tcp_Projects.TabIndex = 1;
            this.tcp_Projects.Text = "Projects";
            this.tcp_Projects.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Project
            // 
            this.btn_Add_Project.Location = new System.Drawing.Point(106, 184);
            this.btn_Add_Project.Name = "btn_Add_Project";
            this.btn_Add_Project.Size = new System.Drawing.Size(207, 23);
            this.btn_Add_Project.TabIndex = 2;
            this.btn_Add_Project.Text = "ADD LE PROJECT EKSDEE LMAO";
            this.btn_Add_Project.UseVisualStyleBackColor = true;
            this.btn_Add_Project.Click += new System.EventHandler(this.btn_Add_Project_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Projects";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            // 
            // tcp_Appointments
            // 
            this.tcp_Appointments.AutoScroll = true;
            this.tcp_Appointments.Controls.Add(this.label6);
            this.tcp_Appointments.Controls.Add(this.label5);
            this.tcp_Appointments.Location = new System.Drawing.Point(4, 22);
            this.tcp_Appointments.Name = "tcp_Appointments";
            this.tcp_Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Appointments.Size = new System.Drawing.Size(566, 424);
            this.tcp_Appointments.TabIndex = 2;
            this.tcp_Appointments.Text = "Appointments";
            this.tcp_Appointments.UseVisualStyleBackColor = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Appointments";
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
            this.tcp_Add_Project.Controls.Add(this.comboBox1);
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
            this.tcp_Add_Project.Controls.Add(this.txtb_Customer_Id);
            this.tcp_Add_Project.Location = new System.Drawing.Point(4, 22);
            this.tcp_Add_Project.Name = "tcp_Add_Project";
            this.tcp_Add_Project.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Add_Project.Size = new System.Drawing.Size(566, 424);
            this.tcp_Add_Project.TabIndex = 4;
            this.tcp_Add_Project.Text = "Add Project";
            this.tcp_Add_Project.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(363, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // txtb_Software
            // 
            this.txtb_Software.Location = new System.Drawing.Point(21, 335);
            this.txtb_Software.MaxLength = 255;
            this.txtb_Software.Multiline = true;
            this.txtb_Software.Name = "txtb_Software";
            this.txtb_Software.Size = new System.Drawing.Size(254, 66);
            this.txtb_Software.TabIndex = 29;
            this.txtb_Software.Text = "J. R. van Laars";
            // 
            // cbox_Maintenance_Contract
            // 
            this.cbox_Maintenance_Contract.FormattingEnabled = true;
            this.cbox_Maintenance_Contract.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cbox_Maintenance_Contract.Location = new System.Drawing.Point(320, 222);
            this.cbox_Maintenance_Contract.Name = "cbox_Maintenance_Contract";
            this.cbox_Maintenance_Contract.Size = new System.Drawing.Size(97, 21);
            this.cbox_Maintenance_Contract.TabIndex = 27;
            this.cbox_Maintenance_Contract.Text = "No";
            // 
            // dtp_Deadline
            // 
            this.dtp_Deadline.Location = new System.Drawing.Point(320, 270);
            this.dtp_Deadline.Name = "dtp_Deadline";
            this.dtp_Deadline.Size = new System.Drawing.Size(200, 20);
            this.dtp_Deadline.TabIndex = 26;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(460, 392);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "LETSGOOO";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.AddProject);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Deadline date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Maintenance Contract";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(317, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Contact Person";
            // 
            // txtb_Contact_Person
            // 
            this.txtb_Contact_Person.Location = new System.Drawing.Point(320, 166);
            this.txtb_Contact_Person.Name = "txtb_Contact_Person";
            this.txtb_Contact_Person.Size = new System.Drawing.Size(100, 20);
            this.txtb_Contact_Person.TabIndex = 4;
            this.txtb_Contact_Person.Text = "J. R. van Laars";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Amount of invoices";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Software";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Operating System";
            // 
            // cbox_Project_Status
            // 
            this.cbox_Project_Status.FormattingEnabled = true;
            this.cbox_Project_Status.Items.AddRange(new object[] {
            "New Project",
            "In Progress",
            "Halted",
            "Stopped",
            "Done"});
            this.cbox_Project_Status.Location = new System.Drawing.Point(25, 165);
            this.cbox_Project_Status.Name = "cbox_Project_Status";
            this.cbox_Project_Status.Size = new System.Drawing.Size(97, 21);
            this.cbox_Project_Status.TabIndex = 3;
            this.cbox_Project_Status.Text = "New Project";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Project Status";
            // 
            // lbl_Project_Name
            // 
            this.lbl_Project_Name.AutoSize = true;
            this.lbl_Project_Name.Location = new System.Drawing.Point(22, 93);
            this.lbl_Project_Name.Name = "lbl_Project_Name";
            this.lbl_Project_Name.Size = new System.Drawing.Size(71, 13);
            this.lbl_Project_Name.TabIndex = 14;
            this.lbl_Project_Name.Text = "Project Name";
            // 
            // lbl_Customer_Id
            // 
            this.lbl_Customer_Id.AutoSize = true;
            this.lbl_Customer_Id.Location = new System.Drawing.Point(22, 43);
            this.lbl_Customer_Id.Name = "lbl_Customer_Id";
            this.lbl_Customer_Id.Size = new System.Drawing.Size(63, 13);
            this.lbl_Customer_Id.TabIndex = 13;
            this.lbl_Customer_Id.Text = "Customer Id";
            // 
            // txtb_Operating_System
            // 
            this.txtb_Operating_System.Location = new System.Drawing.Point(22, 222);
            this.txtb_Operating_System.Name = "txtb_Operating_System";
            this.txtb_Operating_System.Size = new System.Drawing.Size(100, 20);
            this.txtb_Operating_System.TabIndex = 5;
            this.txtb_Operating_System.Text = "Windows 10";
            // 
            // txtb_Amount_Invoices
            // 
            this.txtb_Amount_Invoices.Location = new System.Drawing.Point(21, 280);
            this.txtb_Amount_Invoices.Name = "txtb_Amount_Invoices";
            this.txtb_Amount_Invoices.Size = new System.Drawing.Size(100, 20);
            this.txtb_Amount_Invoices.TabIndex = 9;
            this.txtb_Amount_Invoices.Text = "12";
            // 
            // txtb_Project_Name
            // 
            this.txtb_Project_Name.Location = new System.Drawing.Point(22, 109);
            this.txtb_Project_Name.MaxLength = 255;
            this.txtb_Project_Name.Name = "txtb_Project_Name";
            this.txtb_Project_Name.Size = new System.Drawing.Size(472, 20);
            this.txtb_Project_Name.TabIndex = 2;
            this.txtb_Project_Name.Text = "AUTO GENERATED TEST DATA";
            // 
            // txtb_Customer_Id
            // 
            this.txtb_Customer_Id.Location = new System.Drawing.Point(22, 62);
            this.txtb_Customer_Id.Name = "txtb_Customer_Id";
            this.txtb_Customer_Id.Size = new System.Drawing.Size(100, 20);
            this.txtb_Customer_Id.TabIndex = 1;
            this.txtb_Customer_Id.Text = "4";
            // 
            // frm_Development
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 449);
            this.Controls.Add(this.mstrp_Menu);
            this.Controls.Add(this.tc_Main);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 488);
            this.MinimumSize = new System.Drawing.Size(730, 488);
            this.Name = "frm_Development";
            this.Text = "Barroc-IT - Software for real - Development";
            this.mstrp_Menu.ResumeLayout(false);
            this.mstrp_Menu.PerformLayout();
            this.tc_Main.ResumeLayout(false);
            this.tcp_Overview.ResumeLayout(false);
            this.tcp_Overview.PerformLayout();
            this.tcp_Projects.ResumeLayout(false);
            this.tcp_Projects.PerformLayout();
            this.tcp_Appointments.ResumeLayout(false);
            this.tcp_Appointments.PerformLayout();
            this.tcp_Help.ResumeLayout(false);
            this.tcp_Help.PerformLayout();
            this.tcp_Add_Project.ResumeLayout(false);
            this.tcp_Add_Project.PerformLayout();
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
        private TabControl tc_Main;
        private TabPage tcp_Overview;
        private TabPage tcp_Projects;
        private Label label1;
        private Label label2;
        private TabPage tcp_Appointments;
        private TabPage tcp_Help;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TabPage tcp_Add_Project;
        private Button btn_Add_Project;
        private Label lbl_Customer_Id;
        private TextBox txtb_Operating_System;
        private TextBox txtb_Amount_Invoices;
        private TextBox txtb_Project_Name;
        private TextBox txtb_Customer_Id;
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
        private ComboBox comboBox1;



    }
}