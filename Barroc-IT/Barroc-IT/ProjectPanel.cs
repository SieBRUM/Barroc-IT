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
        bool opened = false;
        DatabaseHandler dbh;
        enum projectStatusCode
        {
            New_Project=0, 
            In_Progress=1, 
            Halted=2, 
            Stopped=3, 
            Done=4
        };

        public ProjectPanel(int rowNr, DataTable dt)
        {
            InitializeComponent();
            panel2.Hide();
            dbh = new DatabaseHandler();

            int projectStatus = Convert.ToInt16(dt.Rows[rowNr]["project_status"]);

            foreach (string s in dt.Rows[rowNr]["software"].ToString().Split(','))
            {
                rtb_Software.Text += s + "\n";
            }

            lbl_Project_Id.Text = dt.Rows[rowNr]["project_id"].ToString();
            lbl_Project_Name.Text = dt.Rows[rowNr]["project_name"].ToString();
            lbl_Project_Status.Text = ((projectStatusCode)projectStatus).ToString();
            lbl_Deadline.Text = dt.Rows[rowNr]["deadline_date"].ToString();
            lbl_Internal_Contact_Person.Text = dt.Rows[rowNr]["contact_person"].ToString();
            lbl_Maintenance_Contract.Text = dt.Rows[rowNr]["maintenance_contract"].ToString();
            lbl_Operating_System.Text = dt.Rows[rowNr]["operating_system"].ToString();
            lbl_Hardware.Text = dt.Rows[rowNr]["hardware"].ToString();
            lbl_Amount_Invoices.Text = dt.Rows[rowNr]["amount_invoice"].ToString();

            lbl_Customer_Name.Text = dt.Rows[rowNr]["customer_name"].ToString();
            lbl_Company_Name.Text = dt.Rows[rowNr]["company_name"].ToString();
        }

        private void OpenMoreInfo(object sender, EventArgs e)
        {
            if (opened)
            {
                panel2.Hide();
                opened = false;
            }
            else
            {
                panel2.Show();
                opened = true;
            }
        }
    }
}
