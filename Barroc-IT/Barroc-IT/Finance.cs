using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Barroc_IT
{
    public partial class frm_Finance : Form
    {
      
        public frm_Finance()
        {
            InitializeComponent();
            
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login formlogin = new Frm_Login();
            formlogin.Show();
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void help_Click(object sender, EventArgs e)
        {

        }


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        

    }
}
