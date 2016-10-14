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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();

            if (Properties.Settings.Default.RememberMe)
            { 
                cb_Remember.Checked = true;
                txtb_Username.Text = Properties.Settings.Default.Username;
            }
        }

        public void Login(object sender, EventArgs e)
        {
            DatabaseHandler dbh = new DatabaseHandler();
            dbh.OpenConnection();
            if (dbh.Login(txtb_Username.Text, txtb_Password.Text))
            {
                if (cb_Remember.Checked == true)
                {
                    Properties.Settings.Default["RememberMe"] = true;
                    Properties.Settings.Default["Username"] = txtb_Username.Text;
                    Properties.Settings.Default.Save();
                }

                switch (txtb_Username.Text.ToLower())
                { 
                    case "development":
                        frm_Development devForm = new frm_Development();
                        devForm.Show();
                        break;
                    case "sales":
                        frm_Sales salForm = new frm_Sales();
                        salForm.Show();
                        break;
                    case "finance":
                        frm_Finance finForm = new frm_Finance();
                        finForm.Show();
                        break;
                }
                this.Hide();
            }

            else
            { 
                MessageBox.Show("Login Failed! :(");
            }
        }


        private void cb_Remember_CheckedChanged(object sender, EventArgs e)
        {
            if(!cb_Remember.Checked)
            {
                Properties.Settings.Default["RememberMe"] = false;
                Properties.Settings.Default["Username"] = "";
                Properties.Settings.Default.Save();
            }
        }

        private void txtb_Password_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
                bt_Login.PerformClick();
        }
    }
}
