using System;
using System.Data;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class AppointmentPanel : UserControl
    {
        bool opened = false;

        public AppointmentPanel(int rowNr, DataTable dt)
        {
            InitializeComponent();
            panel2.Hide();

            lbl_Appointment_Date.Text = dt.Rows[rowNr]["appointment_datetime"].ToString();
            lbl_Appointment_Address_Data.Text = dt.Rows[rowNr]["appointment_address"].ToString();
            lbl_Appointment_Zipcode_Data.Text = dt.Rows[rowNr]["appointment_zipcode"].ToString();
            lbl_Appointment_Residence_Data.Text = dt.Rows[rowNr]["appointment_residence"].ToString();
            lbl_Appointment_Made_Data.Text = dt.Rows[rowNr]["appointment_made"].ToString();
            lbl_Appointment_Time_Data.Text = dt.Rows[rowNr]["appointment_datetime"].ToString();
            rtb_Summary.Text = dt.Rows[rowNr]["appointment_summary"].ToString();
            lbl_CustomerName.Text = dt.Rows[rowNr]["appointment_customer_id"].ToString();
            lbl_Customer_Company_Name_Data.Text = dt.Rows[rowNr]["company_name"].ToString();
            lbl_Customer_Residence_Data.Text = dt.Rows[rowNr]["customer_residence"].ToString();
            lbl_Customer_Address_Data.Text = dt.Rows[rowNr]["customer_address"].ToString();
            lbl_Customer_Zipcode_Data.Text = dt.Rows[rowNr]["customer_zip_code"].ToString();
            lbl_Customer_PhoneNumber_Data.Text = dt.Rows[rowNr]["customer_phone_number"].ToString();
            lbl_Customer_Email_Data.Text = dt.Rows[rowNr]["customer_email"].ToString();

            if (rtb_Summary.Text == "")
                lbl_hasSummary.Text = "No summary";
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
