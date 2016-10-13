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
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            frm_Finance financefrom = new frm_Finance();
            financefrom.Show();
            Frm_Login loginform = new Frm_Login();
            this.Hide(); 
            
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
