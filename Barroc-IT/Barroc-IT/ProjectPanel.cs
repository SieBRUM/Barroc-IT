using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class ProjectPanel : UserControl
    {
        bool aap = false;
        DatabaseHandler dbh;
        public ProjectPanel()
        {
            InitializeComponent();
            panel2.Hide();
            dbh = new DatabaseHandler();

            dbh.OpenConnection();

            DataTable dt = dbh.GetProject();

            lbl_Project_Id.Text = dt.Rows[0]["project_id"].ToString();
            lbl_Project_Name.Text = dt.Rows[0]["project_name"].ToString();
            lbl_Project_Status.Text = dt.Rows[0]["project_status"].ToString();
            lbl_Deadline.Text = dt.Rows[0]["deadline_date"].ToString();
            lbl_Internal_Contact_Person.Text = dt.Rows[0]["contact_person"].ToString();
            lbl_Maintenance_Contract.Text = dt.Rows[0]["maintenance_contract"].ToString();
            lbl_Amount_Invoices.Text = dt.Rows[0]["project_status"].ToString();
            lbl_Operating_System.Text = dt.Rows[0]["operating_system"].ToString();
            lbl_Hardware.Text = dt.Rows[0]["hardware"].ToString();
            lbl_Amount_Invoices.Text = dt.Rows[0]["amount_invoice"].ToString();
            rtb_Software.Text = dt.Rows[0]["software"].ToString();
            lbl_Customer_Name.Text = dt.Rows[0]["customer_name"].ToString();
            lbl_Company_Name.Text = dt.Rows[0]["company_name"].ToString();

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (aap)
            {
                panel2.Hide();
                aap = false;
            }
            else 
            {
                panel2.Show();
                aap = true;
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (aap)
            {
                panel2.Hide();
                aap = false;
            }
            else
            {
                panel2.Show();
                aap = true;
            }
        }
    }
}
