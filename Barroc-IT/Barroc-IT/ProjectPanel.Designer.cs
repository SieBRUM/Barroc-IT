namespace Barroc_IT
{
    partial class ProjectPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Project_Status = new System.Windows.Forms.Label();
            this.lbl_Project_Id = new System.Windows.Forms.Label();
            this.lbl_Project_Name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.lbl_Deadline = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Amount_Invoices = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Hardware = new System.Windows.Forms.Label();
            this.lbl_Maintenance_Contract = new System.Windows.Forms.Label();
            this.lbl_Operating_System = new System.Windows.Forms.Label();
            this.lbl_Internal_Contact_Person = new System.Windows.Forms.Label();
            this.lbl_Company_Name = new System.Windows.Forms.Label();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_Software = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Project_Ledger_Account_Number_Data = new System.Windows.Forms.Label();
            this.lbl_Project_Ledger_Account_Number = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lbl_Project_Status);
            this.panel1.Controls.Add(this.lbl_Project_Id);
            this.panel1.Controls.Add(this.lbl_Project_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 46);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.OpenMoreInfo);
            this.panel1.DoubleClick += new System.EventHandler(this.OpenMoreInfo);
            // 
            // lbl_Project_Status
            // 
            this.lbl_Project_Status.AutoSize = true;
            this.lbl_Project_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Project_Status.Location = new System.Drawing.Point(446, 17);
            this.lbl_Project_Status.Name = "lbl_Project_Status";
            this.lbl_Project_Status.Size = new System.Drawing.Size(43, 13);
            this.lbl_Project_Status.TabIndex = 2;
            this.lbl_Project_Status.Text = "Status";
            this.lbl_Project_Status.Click += new System.EventHandler(this.OpenMoreInfo);
            this.lbl_Project_Status.DoubleClick += new System.EventHandler(this.OpenMoreInfo);
            // 
            // lbl_Project_Id
            // 
            this.lbl_Project_Id.AutoSize = true;
            this.lbl_Project_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Project_Id.Location = new System.Drawing.Point(12, 17);
            this.lbl_Project_Id.Name = "lbl_Project_Id";
            this.lbl_Project_Id.Size = new System.Drawing.Size(64, 13);
            this.lbl_Project_Id.TabIndex = 1;
            this.lbl_Project_Id.Text = "Project ID";
            this.lbl_Project_Id.Click += new System.EventHandler(this.OpenMoreInfo);
            this.lbl_Project_Id.DoubleClick += new System.EventHandler(this.OpenMoreInfo);
            // 
            // lbl_Project_Name
            // 
            this.lbl_Project_Name.AutoSize = true;
            this.lbl_Project_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Project_Name.Location = new System.Drawing.Point(184, 17);
            this.lbl_Project_Name.Name = "lbl_Project_Name";
            this.lbl_Project_Name.Size = new System.Drawing.Size(83, 13);
            this.lbl_Project_Name.TabIndex = 0;
            this.lbl_Project_Name.Text = "Project Name";
            this.lbl_Project_Name.Click += new System.EventHandler(this.OpenMoreInfo);
            this.lbl_Project_Name.DoubleClick += new System.EventHandler(this.OpenMoreInfo);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.lbl_Project_Ledger_Account_Number_Data);
            this.panel2.Controls.Add(this.lbl_Project_Ledger_Account_Number);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.lbl_Deadline);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_Amount_Invoices);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_Hardware);
            this.panel2.Controls.Add(this.lbl_Maintenance_Contract);
            this.panel2.Controls.Add(this.lbl_Operating_System);
            this.panel2.Controls.Add(this.lbl_Internal_Contact_Person);
            this.panel2.Controls.Add(this.lbl_Company_Name);
            this.panel2.Controls.Add(this.lbl_Customer_Name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rtb_Software);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 221);
            this.panel2.TabIndex = 1;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(410, 192);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(122, 23);
            this.btn_Edit.TabIndex = 21;
            this.btn_Edit.Text = "Edit Project";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // lbl_Deadline
            // 
            this.lbl_Deadline.AutoSize = true;
            this.lbl_Deadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Deadline.Location = new System.Drawing.Point(184, 12);
            this.lbl_Deadline.Name = "lbl_Deadline";
            this.lbl_Deadline.Size = new System.Drawing.Size(74, 13);
            this.lbl_Deadline.TabIndex = 20;
            this.lbl_Deadline.Text = "Placeholder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Deadline date:";
            // 
            // lbl_Amount_Invoices
            // 
            this.lbl_Amount_Invoices.AutoSize = true;
            this.lbl_Amount_Invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount_Invoices.Location = new System.Drawing.Point(184, 150);
            this.lbl_Amount_Invoices.Name = "lbl_Amount_Invoices";
            this.lbl_Amount_Invoices.Size = new System.Drawing.Size(74, 13);
            this.lbl_Amount_Invoices.TabIndex = 18;
            this.lbl_Amount_Invoices.Text = "Placeholder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Amount of invoices:";
            // 
            // lbl_Hardware
            // 
            this.lbl_Hardware.AutoSize = true;
            this.lbl_Hardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hardware.Location = new System.Drawing.Point(184, 192);
            this.lbl_Hardware.Name = "lbl_Hardware";
            this.lbl_Hardware.Size = new System.Drawing.Size(74, 13);
            this.lbl_Hardware.TabIndex = 16;
            this.lbl_Hardware.Text = "Placeholder";
            // 
            // lbl_Maintenance_Contract
            // 
            this.lbl_Maintenance_Contract.AutoSize = true;
            this.lbl_Maintenance_Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Maintenance_Contract.Location = new System.Drawing.Point(184, 111);
            this.lbl_Maintenance_Contract.Name = "lbl_Maintenance_Contract";
            this.lbl_Maintenance_Contract.Size = new System.Drawing.Size(74, 13);
            this.lbl_Maintenance_Contract.TabIndex = 15;
            this.lbl_Maintenance_Contract.Text = "Placeholder";
            // 
            // lbl_Operating_System
            // 
            this.lbl_Operating_System.AutoSize = true;
            this.lbl_Operating_System.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Operating_System.Location = new System.Drawing.Point(184, 171);
            this.lbl_Operating_System.Name = "lbl_Operating_System";
            this.lbl_Operating_System.Size = new System.Drawing.Size(74, 13);
            this.lbl_Operating_System.TabIndex = 14;
            this.lbl_Operating_System.Text = "Placeholder";
            // 
            // lbl_Internal_Contact_Person
            // 
            this.lbl_Internal_Contact_Person.AutoSize = true;
            this.lbl_Internal_Contact_Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Internal_Contact_Person.Location = new System.Drawing.Point(184, 88);
            this.lbl_Internal_Contact_Person.Name = "lbl_Internal_Contact_Person";
            this.lbl_Internal_Contact_Person.Size = new System.Drawing.Size(74, 13);
            this.lbl_Internal_Contact_Person.TabIndex = 13;
            this.lbl_Internal_Contact_Person.Text = "Placeholder";
            // 
            // lbl_Company_Name
            // 
            this.lbl_Company_Name.AutoSize = true;
            this.lbl_Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Company_Name.Location = new System.Drawing.Point(184, 65);
            this.lbl_Company_Name.Name = "lbl_Company_Name";
            this.lbl_Company_Name.Size = new System.Drawing.Size(74, 13);
            this.lbl_Company_Name.TabIndex = 12;
            this.lbl_Company_Name.Text = "Placeholder";
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(184, 43);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(74, 13);
            this.lbl_Customer_Name.TabIndex = 11;
            this.lbl_Customer_Name.Text = "Placeholder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Software:";
            // 
            // rtb_Software
            // 
            this.rtb_Software.Location = new System.Drawing.Point(410, 28);
            this.rtb_Software.Name = "rtb_Software";
            this.rtb_Software.ReadOnly = true;
            this.rtb_Software.Size = new System.Drawing.Size(122, 156);
            this.rtb_Software.TabIndex = 9;
            this.rtb_Software.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Maintenance contract:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hardware:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Operating System:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Internal contact person:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Customer name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Company name:";
            // 
            // lbl_Project_Ledger_Account_Number_Data
            // 
            this.lbl_Project_Ledger_Account_Number_Data.AutoSize = true;
            this.lbl_Project_Ledger_Account_Number_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Project_Ledger_Account_Number_Data.Location = new System.Drawing.Point(184, 131);
            this.lbl_Project_Ledger_Account_Number_Data.Name = "lbl_Project_Ledger_Account_Number_Data";
            this.lbl_Project_Ledger_Account_Number_Data.Size = new System.Drawing.Size(74, 13);
            this.lbl_Project_Ledger_Account_Number_Data.TabIndex = 23;
            this.lbl_Project_Ledger_Account_Number_Data.Text = "Placeholder";
            // 
            // lbl_Project_Ledger_Account_Number
            // 
            this.lbl_Project_Ledger_Account_Number.AutoSize = true;
            this.lbl_Project_Ledger_Account_Number.Location = new System.Drawing.Point(12, 131);
            this.lbl_Project_Ledger_Account_Number.Name = "lbl_Project_Ledger_Account_Number";
            this.lbl_Project_Ledger_Account_Number.Size = new System.Drawing.Size(123, 13);
            this.lbl_Project_Ledger_Account_Number.TabIndex = 22;
            this.lbl_Project_Ledger_Account_Number.Text = "Ledger account number:";
            // 
            // ProjectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(538, 0);
            this.Name = "ProjectPanel";
            this.Size = new System.Drawing.Size(538, 267);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Project_Name;
        private System.Windows.Forms.Label lbl_Project_Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_Software;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Hardware;
        private System.Windows.Forms.Label lbl_Maintenance_Contract;
        private System.Windows.Forms.Label lbl_Internal_Contact_Person;
        private System.Windows.Forms.Label lbl_Company_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Amount_Invoices;
        private System.Windows.Forms.Label lbl_Deadline;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_Edit;
        public System.Windows.Forms.Label lbl_Operating_System;
        public System.Windows.Forms.Label lbl_Project_Id;
        public System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Project_Ledger_Account_Number_Data;
        private System.Windows.Forms.Label lbl_Project_Ledger_Account_Number;
    }
}
