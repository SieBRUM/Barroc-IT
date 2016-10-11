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
            this.mnitem_Appointments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitem_Overview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitem_Projects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitem_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Date = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Department = new System.Windows.Forms.ToolStripMenuItem();
            this.mnfltr_Type = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrp_Menu.SuspendLayout();
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
            this.mnfltr_Department,
            this.mnfltr_Type,
            this.mnfltr_Date,
            this.mnitem_Projects,
            this.mnitem_Appointments,
            this.mnitem_Logout});
            this.mstrp_Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mstrp_Menu.Location = new System.Drawing.Point(0, 0);
            this.mstrp_Menu.Name = "mstrp_Menu";
            this.mstrp_Menu.Size = new System.Drawing.Size(142, 464);
            this.mstrp_Menu.TabIndex = 1;
            // 
            // mnitem_Appointments
            // 
            this.mnitem_Appointments.AutoSize = false;
            this.mnitem_Appointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnitem_Appointments.Name = "mnitem_Appointments";
            this.mnitem_Appointments.Size = new System.Drawing.Size(135, 30);
            this.mnitem_Appointments.Text = "Appointments";
            this.mnitem_Appointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnitem_Overview
            // 
            this.mnitem_Overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Overview.Name = "mnitem_Overview";
            this.mnitem_Overview.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Overview.Text = "Overview";
            this.mnitem_Overview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnitem_Projects
            // 
            this.mnitem_Projects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnitem_Projects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Projects.Name = "mnitem_Projects";
            this.mnitem_Projects.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Projects.Text = "Projects";
            this.mnitem_Projects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnitem_Logout
            // 
            this.mnitem_Logout.Image = ((System.Drawing.Image)(resources.GetObject("mnitem_Logout.Image")));
            this.mnitem_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnitem_Logout.Name = "mnitem_Logout";
            this.mnitem_Logout.Size = new System.Drawing.Size(135, 25);
            this.mnitem_Logout.Text = "Logout";
            this.mnitem_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnfltr_Date
            // 
            this.mnfltr_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Date.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Date.Name = "mnfltr_Date";
            this.mnfltr_Date.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Date.Text = "Select Date";
            this.mnfltr_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnfltr_Department
            // 
            this.mnfltr_Department.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Department.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Department.Name = "mnfltr_Department";
            this.mnfltr_Department.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Department.Text = "Select Department";
            this.mnfltr_Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnfltr_Type
            // 
            this.mnfltr_Type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnfltr_Type.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnfltr_Type.Margin = new System.Windows.Forms.Padding(10, 1, 1, 0);
            this.mnfltr_Type.Name = "mnfltr_Type";
            this.mnfltr_Type.Size = new System.Drawing.Size(124, 19);
            this.mnfltr_Type.Text = "Select Type";
            this.mnfltr_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_Development
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 449);
            this.Controls.Add(this.mstrp_Menu);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frm_Development";
            this.Text = "Barroc-IT - Software for real - Development";
            this.mstrp_Menu.ResumeLayout(false);
            this.mstrp_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrp_Menu;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Appointments;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Overview;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Projects;
        private System.Windows.Forms.ToolStripMenuItem mnitem_Logout;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Date;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Department;
        private System.Windows.Forms.ToolStripMenuItem mnfltr_Type;


    }
}