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
    public partial class InvoicePanel : UserControl
    {
        bool opened = false;
        DatabaseHandler dbh;

        enum invoiceStatus
        {
            Paid = 0,
            Unpaid = 1
        }

        public InvoicePanel(int rowNr, DataTable dt)
        {
            InitializeComponent();
            panel2.Hide();
            dbh = new DatabaseHandler();

            //int invoiceStatus = Convert.ToInt16(dt.Rows[rowNr]["status"]);

            lbl_Customer_Name.Text = dt.Rows[rowNr]["customer_id"].ToString();
            lbl_Invoice_ID.Text = dt.Rows[rowNr]["invoice_id"].ToString();
            //lbl_Unpaid_Invoice.Text = ((invoiceStatus)invoiceStatus).ToString();
            lbl_Price.Text = dt.Rows[rowNr]["total_price"].ToString();
            lbl_Customer_CompanyName.Text = dt.Rows[rowNr]["company_name"].ToString();
            lbl_Customer_Contact_Person.Text = dt.Rows[rowNr]["contact_person"].ToString();
            lbl_Customer_IBAN.Text = dt.Rows[rowNr]["IBAN"].ToString();
            lbl_Project_ProjectID.Text = dt.Rows[rowNr]["project_id"].ToString();
            lbl_Invoice_Tax_Percentage.Text = dt.Rows[rowNr]["VAT"].ToString();
            lbl_Customer_Discount.Text = dt.Rows[rowNr]["discount"].ToString();
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
