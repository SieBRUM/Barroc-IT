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
        public static ToolStripControlHost[] DTPGenerator(frm_Sales form) 
        {
            DateTimePicker dtp_From = new DateTimePicker() { Width = 140};
            dtp_From.ValueChanged += new System.EventHandler(form.SetDateFromLabel);
            DateTimePicker dtp_Till = new DateTimePicker() { Width = 140 };
            dtp_Till.ValueChanged += new System.EventHandler(form.SetDateTillLabel);
            Label lbl_From = new Label() { Text = "From:", Width = 140 };
            Label lbl_Till = new Label() { Text = "Till:", Width = 140 };
            Button btn = new Button() { Text = "Search"};
            btn.Click += new System.EventHandler(form.SearchNotificationOnDate);
            dtp_From.Value = DateTime.Now.Date;
            dtp_Till.Value = DateTime.Now.Date;

            ToolStripControlHost lblch_From = new ToolStripControlHost(lbl_From);
            ToolStripControlHost lblch_Till = new ToolStripControlHost(lbl_Till);
            ToolStripControlHost tsch_From = new ToolStripControlHost(dtp_From);
            ToolStripControlHost tsch_Till = new ToolStripControlHost(dtp_Till);
            ToolStripControlHost tsch_btn = new ToolStripControlHost(btn);


            ToolStripControlHost[] arrayControl = new ToolStripControlHost[5];
            arrayControl[0] = new ToolStripControlHost(lbl_From);
            arrayControl[1] = new ToolStripControlHost(dtp_From);
            arrayControl[2] = new ToolStripControlHost(lbl_Till);
            arrayControl[3] = new ToolStripControlHost(dtp_Till);
            arrayControl[4] = new ToolStripControlHost(btn);

            return arrayControl;
        }

        public static ToolStripControlHost[] DTPGenerator(frm_Development form)
        {
            DateTimePicker dtp_From = new DateTimePicker() { Width = 140 };
            //dtp_From.ValueChanged += new System.EventHandler(form.SetDateFromLabel);
            DateTimePicker dtp_Till = new DateTimePicker() { Width = 140 };
            //dtp_Till.ValueChanged += new System.EventHandler(form.SetDateTillLabel);
            Label lbl_From = new Label() { Text = "From:", Width = 140 };
            Label lbl_Till = new Label() { Text = "Till:", Width = 140 };
            Button btn = new Button() { Text = "Search" };
            //btn.Click += new System.EventHandler(form.SearchNotificationOnDate);
            dtp_From.Value = DateTime.Now.Date;
            dtp_Till.Value = DateTime.Now.Date;

            ToolStripControlHost lblch_From = new ToolStripControlHost(lbl_From);
            ToolStripControlHost lblch_Till = new ToolStripControlHost(lbl_Till);
            ToolStripControlHost tsch_From = new ToolStripControlHost(dtp_From);
            ToolStripControlHost tsch_Till = new ToolStripControlHost(dtp_Till);
            ToolStripControlHost tsch_btn = new ToolStripControlHost(btn);


            ToolStripControlHost[] arrayControl = new ToolStripControlHost[5];
            arrayControl[0] = new ToolStripControlHost(lbl_From);
            arrayControl[1] = new ToolStripControlHost(dtp_From);
            arrayControl[2] = new ToolStripControlHost(lbl_Till);
            arrayControl[3] = new ToolStripControlHost(dtp_Till);
            arrayControl[4] = new ToolStripControlHost(btn);

            return arrayControl;
        }
        public static ToolStripControlHost[] DTPGenerator(frm_Finance_2 form)
        {
            DateTimePicker dtp_From = new DateTimePicker() { Width = 140 };
            //dtp_From.ValueChanged += new System.EventHandler(form.SetDateFromLabel);
            DateTimePicker dtp_Till = new DateTimePicker() { Width = 140 };
            //dtp_Till.ValueChanged += new System.EventHandler(form.SetDateTillLabel);
            Label lbl_From = new Label() { Text = "From:", Width = 140 };
            Label lbl_Till = new Label() { Text = "Till:", Width = 140 };
            Button btn = new Button() { Text = "Search" };
            //btn.Click += new System.EventHandler(form.SearchNotificationOnDate);
            dtp_From.Value = DateTime.Now.Date;
            dtp_Till.Value = DateTime.Now.Date;

            ToolStripControlHost lblch_From = new ToolStripControlHost(lbl_From);
            ToolStripControlHost lblch_Till = new ToolStripControlHost(lbl_Till);
            ToolStripControlHost tsch_From = new ToolStripControlHost(dtp_From);
            ToolStripControlHost tsch_Till = new ToolStripControlHost(dtp_Till);
            ToolStripControlHost tsch_btn = new ToolStripControlHost(btn);


            ToolStripControlHost[] arrayControl = new ToolStripControlHost[5];
            arrayControl[0] = new ToolStripControlHost(lbl_From);
            arrayControl[1] = new ToolStripControlHost(dtp_From);
            arrayControl[2] = new ToolStripControlHost(lbl_Till);
            arrayControl[3] = new ToolStripControlHost(dtp_Till);
            arrayControl[4] = new ToolStripControlHost(btn);

            return arrayControl;
        }

    }
}
