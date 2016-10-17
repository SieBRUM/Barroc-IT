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
    public partial class frm_Development : Form
    {
        DatabaseHandler dbh;
        public frm_Development()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();
            dbh.OpenConnection();
            
            MenuItems menuItemHandler = new MenuItems();
            ToolStripControlHost[] arrayControl = menuItemHandler.DTPGenerator();
            ToolStripControlHost[] arrayControl1 = menuItemHandler.DTPGenerator();
            HideFilters(true,false,false);

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
                    tc_Main.SelectedIndex = 0;
                    HideFilters(true, false, false);
                    break;
                case "mnitem_Projects":
                    tc_Main.SelectedIndex = 1;
                    HideFilters(false, true, false);
                    break;
                case "mnitem_Appointments":
                    tc_Main.SelectedIndex = 2;
                    HideFilters(false, false, true);
                    break;
                default:
                    tc_Main.SelectedIndex = 0;
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

        private void btn_Add_Project_Click(object sender, EventArgs e)
        {
            tc_Main.SelectedIndex = 4;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dbh.AddProject(txtb_Customer_Id.Text, txtb_Project_Name.Text, cbox_Project_Status.SelectedIndex + 1, txtb_Operating_System.Text, txtb_Software.Text, txtb_Amount_Invoices.Text, txtb_Contact_Person.Text, txtb_Maintenance_Contract.Text, txtb_Deadline.Text);
        }
    }
}
