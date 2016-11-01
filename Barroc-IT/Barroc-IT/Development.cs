using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Barroc_IT
{
    public partial class frm_Development : Form
    {
        bool showallProjects = false;
        bool showallAppointments = false;
        DatabaseHandler dbh;
        public frm_Development()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();
            cbox_Project_Status.SelectedIndex = 0;
            cbox_Maintenance_Contract.SelectedIndex = 0;
            ShowProjects();
            ShowAppointments();
            tcp_Add_Appointment.SelectedIndex = 0;

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
                    tcp_Add_Appointment.SelectedIndex = 0;
                    HideFilters(true, false, false);
                    break;
                case "mnitem_Projects":
                    tcp_Add_Appointment.SelectedIndex = 1;
                    HideFilters(false, true, false);
                    break;
                case "mnitem_Appointments":
                    tcp_Add_Appointment.SelectedIndex = 2;
                    HideFilters(false, false, true);
                    break;
                default:
                    tcp_Add_Appointment.SelectedIndex = 0;
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
            tcp_Add_Appointment.SelectedIndex = 4;
        }

        private void AddProject(object sender, EventArgs e)
        {
            int result;
            if (txtb_Amount_Invoices.Text == "" || txtb_Contact_Person.Text == "" || txtb_Operating_System.Text == "" || txtb_Project_Name.Text == "" || txtb_Software.Text == "" || txtb_Hardware.Text == "" || int.TryParse(txtb_Edit_Project_AOI.Text, out result))
            {
                MessageBox.Show("Please make sure all the fields are filled in correctly.");
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
            if (tcp_Add_Appointment.SelectedIndex == 4)
            {
                try
                {
                    dbh.OpenConnection();
                    DataTable dt = dbh.GetCustomerCB();
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
            }
            dbh.CloseConnection();
        }

        private void ShowProjects()
        {
            dbh.OpenConnection();
            DataTable dt = dbh.GetProjects();
            int amount = dt.Rows.Count;
            if (!showallProjects && amount > 5)
                amount = 5;

            ProjectPanel[] projectInfoPanel = new ProjectPanel[amount];

            for (int i = 0; i < projectInfoPanel.Length; i++ )
            {
                projectInfoPanel[i] = new ProjectPanel(i,dt);
                projectInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                projectInfoPanel[i].Dock = DockStyle.Top;
                projectInfoPanel[i].btn_Edit.Click += new System.EventHandler(this.FillEditProjectItems);
                projectInfoPanel[i].btn_Edit.AccessibleName = projectInfoPanel[i].lbl_Project_Id.Text;
                projectInfoPanel[i].lbl_Customer_Name.AccessibleName = dt.Rows[i]["customer_id"].ToString();
                projectInfoPanel[i].lbl_Customer_Name.Click += new System.EventHandler(this.FillCustomerData);
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

            tcp_Add_Appointment.SelectedIndex = 5;
        }

        private void FillCustomerData(object sender, EventArgs e)
        {
            dbh.OpenConnection();
            Label label = (Label)sender;
            DataTable dt = dbh.GetCustomer(label.AccessibleName);
            lbl_Customer_Name.Text = dt.Rows[0]["customer_name"].ToString();
            lbl_Residence.Text = dt.Rows[0]["residence"].ToString();
            lbl_Address.Text = dt.Rows[0]["address"].ToString();
            lbl_Zip_Code.Text = dt.Rows[0]["zip_code"].ToString();
            lbl_Email.Text = dt.Rows[0]["email"].ToString();
            lbl_Phonenumber.Text = dt.Rows[0]["phone_number"].ToString();
            lbl_Fax.Text = dt.Rows[0]["fax"].ToString();
            lbl_Company_Name.Text = dt.Rows[0]["company_name"].ToString();
            lbl_Residence2.Text = dt.Rows[0]["residence_2"].ToString();
            lbl_Address2.Text = dt.Rows[0]["address_2"].ToString();
            lbl_Zip_Code2.Text = dt.Rows[0]["zip_code_2"].ToString();
            lbl_Phonenumber2.Text = dt.Rows[0]["phone_number_2"].ToString();
            tcp_Add_Appointment.SelectedIndex = 7;
            dbh.CloseConnection();
        }

        private void frm_Development_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Project_Show_All_Click(object sender, EventArgs e)
        {
            tcp_Add_Appointment.SelectedIndex = 6;

            showallProjects = true;
            panel1.Controls.Clear();
            ShowProjects();
        }

        private void EditProject(object sender, EventArgs e)
        {
            string date = DateHandler.GetDate(dtp_Edit_Project_Deadline);
            int result;
            if (!int.TryParse(txtb_Edit_Project_AOI.Text, out result))
            {
                MessageBox.Show("Amount of Invoices not a number!");
            }
            else
            { 
                dbh.OpenConnection();
                if(dbh.EditProject(lbl_Edit_Project_P_Id.Text, txtb_Edit_Project_P_Name.Text, cb_Edit_Project_P_Status.SelectedIndex.ToString(), cb_Edit_Project_M_C.SelectedIndex.ToString(), txtb_Edit_Project_OS.Text, txtb_Edit_Project_Hardware.Text, txtb_Edit_Project_Software.Text, txtb_Edit_Project_AOI.Text, date))
                    MessageBox.Show("Succesfully added a project!");
                else
                    MessageBox.Show("An error occcured while adding a project.");

                dbh.CloseConnection();
            }
        }
    }
}
