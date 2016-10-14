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
    public partial class frm_Logout : Form
    {
        Form form;
        public frm_Logout(Form currentForm)
        {
            InitializeComponent();
            form = currentForm;
            form.Enabled = false;
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            form.Close();
            Frm_Login login = new Frm_Login();
            login.Show();
            this.Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            form.Enabled = true;
            this.Close();
        }
    }
}
