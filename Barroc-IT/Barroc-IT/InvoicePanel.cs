using System;
using System.Data;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class InvoicePanel : UserControl
    {
        bool opened = false;

        enum invoiceStatus
        {
            Paid = 0,
            Unpaid = 1
        }

        public InvoicePanel(int rowNr, DataTable dt)
        {
            InitializeComponent();
            panel2.Hide();

            if (dt.Rows[rowNr]["status"].ToString() == "True")
            {
                lbl_Invoice_Status.Text = "Paid invoice";
                btn_Paid.Dispose();
            }

            lbl_Customer_Name.Text = dt.Rows[rowNr]["customer_id"].ToString() + ": " + dt.Rows[rowNr]["customer_name"].ToString();
            lbl_Invoice_ID.Text = dt.Rows[rowNr]["invoice_id"].ToString();
            lbl_Price.Text = "\u20AC " + dt.Rows[rowNr]["total_price"].ToString();
            lbl_Customer_CompanyName.Text = dt.Rows[rowNr]["company_name"].ToString();
            lbl_Customer_Contact_Person.Text = dt.Rows[rowNr]["contact_person"].ToString();
            lbl_Customer_IBAN.Text = dt.Rows[rowNr]["IBAN"].ToString();
            lbl_Project_ProjectID.Text = dt.Rows[rowNr]["project_id"].ToString();
            lbl_Invoice_Tax_Percentage.Text = dt.Rows[rowNr]["VAT"].ToString() + "%";
            lbl_Customer_Discount.Text = dt.Rows[rowNr]["discount"].ToString() + "%";
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

        private void PayInvoice(object sender, EventArgs e)
        {
            lbl_Invoice_Status.Text = "Paid invoice";
            btn_Paid.Dispose();
        }
    }
}
