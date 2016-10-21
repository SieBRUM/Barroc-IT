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
        bool showall = false;
        DatabaseHandler dbh;
        public frm_Development()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();
            cbox_Project_Status.SelectedIndex = 0;
            cbox_Maintenance_Contract.SelectedIndex = 0;
            ShowProjects();

            ToolStripControlHost[] arrayControl = MenuItems.DTPGenerator();
            ToolStripControlHost[] arrayControl1 = MenuItems.DTPGenerator();
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

        private void AddProject(object sender, EventArgs e)
        {
            if(txtb_Amount_Invoices.Text == "" || txtb_Contact_Person.Text == "" || txtb_Operating_System.Text == "" || txtb_Project_Name.Text == "" || txtb_Software.Text == "" || txtb_Hardware.Text == "")
            {
                MessageBox.Show("Please make sure all the fields are filled in.");
            }
            else if(dtp_Deadline.Value <= DateTime.Now)
            {
                MessageBox.Show("Date cannot be today or in the past.");
            }
            else
            {
                dbh.OpenConnection();
                string date = DateHandler.GetDate(dtp_Deadline);

                if (dbh.AddProject(cb_Select_Customer.SelectedValue.ToString(), txtb_Project_Name.Text, cbox_Project_Status.SelectedIndex, txtb_Operating_System.Text, txtb_Software.Text, txtb_Amount_Invoices.Text, txtb_Contact_Person.Text, cbox_Maintenance_Contract.SelectedIndex, date,txtb_Hardware.Text))
                    MessageBox.Show("Succesfully added a project!");
                else 
                    MessageBox.Show("An error occcured while adding a project.");

                dbh.CloseConnection();
            }
        }

        private void txtb_Amount_Invoices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tc_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_Main.SelectedIndex == 4)
            {
                try
                {
                    dbh.OpenConnection();
                    DataTable dt = dbh.GetCustomers();
                    cb_Select_Customer.ValueMember = "customer_id";
                    cb_Select_Customer.DisplayMember = "full_name";

                    cb_Select_Customer.DataSource = dt;
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

        private void ShowProjects()
        {
            dbh.OpenConnection();
            DataTable dt = dbh.GetProjects();
            int amount = dt.Rows.Count;
            if (!showall && amount > 5)
                amount = 5;

            ProjectPanel[] projectInfoPanel = new ProjectPanel[amount];

            for (int i = 0; i < projectInfoPanel.Length; i++ )
            {
                projectInfoPanel[i] = new ProjectPanel(i,dt);
                projectInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                projectInfoPanel[i].Dock = DockStyle.Top;
                projectInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditProjectItems);
                projectInfoPanel[i].btn_Edit.AccessibleName = projectInfoPanel[i].lbl_Project_Id.Text;
                panel1.Controls.Add(projectInfoPanel[i]);
            }

            dbh.CloseConnection();
        }

        private void FillEditProjectItems(object sender, EventArgs e)
        {
            dbh.OpenConnection();
            Button button = (Button)sender;
            DataTable dt = dbh.GetProject(button.AccessibleName);
            txtb_Edit_Project_P_Name.Text = dt.Rows[0]["project_name"].ToString();
            txtb_Edit_Project_OS.Text = dt.Rows[0]["operating_system"].ToString();
            txtb_Edit_Project_Software.Text = dt.Rows[0]["software"].ToString();
            txtb_Edit_Project_Hardware.Text = dt.Rows[0]["hardware"].ToString();
            lbl_Edit_Project_C_P.Text = dt.Rows[0]["contact_person"].ToString();
            txtb_Edit_Project_AOI.Text = dt.Rows[0]["amount_invoice"].ToString();
            cb_Edit_Project_M_C.SelectedIndex = Convert.ToInt32(dt.Rows[0]["maintenance_contract"].ToString());
            cb_Edit_Project_P_Status.SelectedIndex = Convert.ToInt32(dt.Rows[0]["project_status"].ToString());
            lbl_Edit_Project_C_ID.Text = dt.Rows[0]["full_name"].ToString();
            dtp_Edit_Project_Deadline.Value = Convert.ToDateTime(dt.Rows[0]["deadline_date"]);
            lbl_Edit_Project_P_Id.Text = button.AccessibleName;
            dbh.CloseConnection();

            tc_Main.SelectedIndex = 5;
        }

        private void frm_Development_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Project_Show_All_Click(object sender, EventArgs e)
        {
            showall = true;
            panel1.Controls.Clear();
            ShowProjects();
        }

        private void EditProject(object sender, EventArgs e)
        {
            string date = DateHandler.GetDate(dtp_Edit_Project_Deadline);
            dbh.OpenConnection();
            if(dbh.EditProject(lbl_Edit_Project_P_Id.Text, txtb_Edit_Project_P_Name.Text, cb_Edit_Project_P_Status.SelectedIndex.ToString(), cb_Edit_Project_M_C.SelectedIndex.ToString(), txtb_Edit_Project_OS.Text, txtb_Edit_Project_Hardware.Text, txtb_Edit_Project_Software.Text, txtb_Edit_Project_AOI.Text, date))
                MessageBox.Show("Succesfully added a project!");
            else
                MessageBox.Show("An error occcured while adding a project.");

            dbh.CloseConnection();
        }
    }
}
