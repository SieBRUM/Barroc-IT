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
    public partial class frm_Finance_2 : Form
    {
        bool showAllInvoices = false;
        DatabaseHandler dbh;

        public frm_Finance_2()
        {
            InitializeComponent();
            ShowInvoices();
        }

        private void MenuHandler(object sender, EventArgs e)
        {

        }

        private void ShowInvoices()
        {
            dbh = new DatabaseHandler();
            dbh.OpenConnection();
            DataTable dt = dbh.GetInvoices();
            int amount = dt.Rows.Count;
            if (!showAllInvoices && amount > 5)
                amount = 5;

            InvoicePanel[] invoiceInfoPanel = new InvoicePanel[amount];

            for (int i = 0; i < invoiceInfoPanel.Length; i++)
            {
                invoiceInfoPanel[i] = new InvoicePanel(i, dt);
                invoiceInfoPanel[i].BorderStyle = BorderStyle.FixedSingle;
                invoiceInfoPanel[i].Dock = DockStyle.Top;
                invoicesPanel.Controls.Add(invoiceInfoPanel[i]);
            }
            dbh.CloseConnection();
        }
    }
}
