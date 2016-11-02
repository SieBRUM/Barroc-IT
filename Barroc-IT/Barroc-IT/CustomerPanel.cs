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
    public partial class CustomerPanel : UserControl
    {
        bool opened = false;
        DatabaseHandler dbh;

        enum prospect
        {
            No = 0,
            Yes = 1
        }

        enum creditworthy
        {
            No = 0,
            Not_Checked = 1,
            Yes = 1
        }

        public CustomerPanel(int rowNr, DataTable dt)
        {
            InitializeComponent();
            panel2.Hide();

            dbh = new DatabaseHandler();

            //int prospect = Convert.ToInt16(dt.Rows[rowNr]["prospect"]);
            int creditworthy = Convert.ToInt16(dt.Rows[rowNr]["creditworthy"]);

            lbl_Customer_ID.Text = dt.Rows[rowNr]["customer_id"].ToString();
            lbl_Customer_Name.Text = dt.Rows[rowNr]["customer_name"].ToString();
            lbl_Customer_CompanyName.Text = dt.Rows[rowNr]["company_name"].ToString();
            lbl_Customer_Address_1.Text = dt.Rows[rowNr]["address"].ToString();
            lbl_Customer_Address_2.Text = dt.Rows[rowNr]["address_2"].ToString();
            lbl_Customer_Zipcode_1.Text = dt.Rows[rowNr]["zip_code"].ToString();
            lbl_Customer_Zipcode_2.Text = dt.Rows[rowNr]["zip_code_2"].ToString();
            lbl_Customer_Residence_1.Text = dt.Rows[rowNr]["residence"].ToString();
            lbl_Customer_Residence_2.Text = dt.Rows[rowNr]["residence_2"].ToString();
            lbl_Customer_Phonenumber_1.Text = dt.Rows[rowNr]["phone_number"].ToString();
            lbl_Customer_Phonenumber_2.Text = dt.Rows[rowNr]["phone_number_2"].ToString();
            lbl_Customer_Faxnumber.Text = dt.Rows[rowNr]["fax"].ToString();
            lbl_Customer_Email.Text = dt.Rows[rowNr]["email"].ToString();
            //lbl_Customer_Prospect.Text = ((prospect)prospect).ToString();
            lbl_Customer_Last_Contact.Text = dt.Rows[rowNr]["last_contact"].ToString();
            lbl_Customer_Last_Action.Text = dt.Rows[rowNr]["last_action"].ToString();
            lbl_Customer_Next_Contact.Text = dt.Rows[rowNr]["next_contact"].ToString();
            lbl_Customer_Next_Action.Text = dt.Rows[rowNr]["next_action"].ToString();
            lbl_Customer_Credit_Balance.Text = dt.Rows[rowNr]["credit_balance"].ToString();
            lbl_Customer_Creditworthy.Text = ((creditworthy)creditworthy).ToString();
            lbl_Customer_Discount.Text = dt.Rows[rowNr]["discount"].ToString();
            lbl_Customer_Iban.Text = dt.Rows[rowNr]["iban"].ToString();
            lbl_Customer_Limit.Text = dt.Rows[rowNr]["limit"].ToString();
            lbl_Customer_Gross_Revenue.Text = dt.Rows[rowNr]["gross_revenue"].ToString();
        }

        private void ShowMoreInfo(object sender, EventArgs e)
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
