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
    public partial class frm_Development : Form
    {
        public frm_Development()
        {
            InitializeComponent();
            MenuItems menuItemHandler = new MenuItems();
            ToolStripControlHost[] arrayControl = menuItemHandler.DTPGenerator();

            for (int i = 0; i < 4; i++)
            {
                mnfltr_Overview_Date.DropDownItems.Add(arrayControl[i]);
                mnfltr_Appointments_Date.DropDownItems.Add(arrayControl[i]);
            }
        }
    }
}
