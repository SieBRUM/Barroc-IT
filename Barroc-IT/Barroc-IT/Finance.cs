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

using Barroc_IT.Datalayer;

namespace Barroc_IT
{
    public partial class frm_Finance : Form
    {
        private FinanceMySQL mysql;
      
        public frm_Finance()
        {
            InitializeComponent();
            mysql = new FinanceMySQL();
            mysql.getFinances(); // List Finances
        }
       


    }
}
