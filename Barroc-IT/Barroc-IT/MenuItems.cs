using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_IT
{
    static class MenuItems
    {

        public static ToolStripControlHost[] DTPGenerator() 
        {
            DateTimePicker dtp_From = new DateTimePicker() { Width = 140 };
            DateTimePicker dtp_Till = new DateTimePicker() { Width = 140 };
            Label lbl_From = new Label() { Text = "From:", Width = 140 };
            Label lbl_Till = new Label() { Text = "Till:", Width = 140 };

            ToolStripControlHost lblch_From = new ToolStripControlHost(lbl_From);
            ToolStripControlHost lblch_Till = new ToolStripControlHost(lbl_Till);
            ToolStripControlHost tsch_From = new ToolStripControlHost(dtp_From);
            ToolStripControlHost tsch_Till = new ToolStripControlHost(dtp_Till);

            ToolStripControlHost[] arrayControl = new ToolStripControlHost[4];
            arrayControl[0] = new ToolStripControlHost(lbl_From);
            arrayControl[1] = new ToolStripControlHost(dtp_From);
            arrayControl[2] = new ToolStripControlHost(lbl_Till);
            arrayControl[3] = new ToolStripControlHost(dtp_Till);

            return arrayControl;
        }
    }
}
