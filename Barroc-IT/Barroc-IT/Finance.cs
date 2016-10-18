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
    public partial class frm_Finance : FormFunctions
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );


        public frm_Finance()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        Point formlock, cursorlocation = new Point(0, 0);

        private void setpositions()
        {
            formlock = this.Location;
            cursorlocation = Cursor.Position;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int ex = formlock.X - cursorlocation.X + Cursor.Position.X;
            int ey = formlock.Y - cursorlocation.Y + Cursor.Position.Y;
            this.Location = new Point(ex, ey);
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer_tick();
        }

    }
}
