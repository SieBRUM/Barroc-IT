using System;
using System.Data;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class OverviewPanel : UserControl
    {
        bool opened = false;

        public OverviewPanel(int rowNr, DataTable dt)
        {
            InitializeComponent();
            panel2.Hide();

            string notification_added_date = dt.Rows[rowNr]["notification_date"].ToString();
            string today = DateTime.Today.ToString();

            lbl_Notification_ID.Text = dt.Rows[rowNr]["notification_id"].ToString();
            lbl_Notification_Info_Data.Text = dt.Rows[rowNr]["notification_info"].ToString();
            lbl_Notification_Type.Text = dt.Rows[rowNr]["notification_type"].ToString();

            if ((((DateTime.Today) - Convert.ToDateTime(dt.Rows[rowNr]["notification_date"])).TotalDays) == 0)
            {
                lbl_Notification_Added.Text = "Today";
            }
            else
            {
                lbl_Notification_Added.Text = ((DateTime.Today) - Convert.ToDateTime(dt.Rows[rowNr]["notification_date"])).TotalDays + " days ago";
            }
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

        private void DeletePanel(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
