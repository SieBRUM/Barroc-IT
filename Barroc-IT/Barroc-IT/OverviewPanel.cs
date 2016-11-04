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
    public partial class OverviewPanel : UserControl
    {
        bool opened = false;
        DatabaseHandler dbh;

        public OverviewPanel(int rowNr, DataTable dt)
        {
            InitializeComponent();
            panel2.Hide();
            dbh = new DatabaseHandler();

            lbl_Notification_ID.Text = dt.Rows[rowNr]["notification_id"].ToString();
            lbl_Notification_Info_Data.Text = dt.Rows[rowNr]["notification_info"].ToString();
            lbl_Notification_Type.Text = dt.Rows[rowNr]["notification_type"].ToString();
            lbl_Notification_Added.Text = dt.Rows[rowNr]["notification_date"].ToString();
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
