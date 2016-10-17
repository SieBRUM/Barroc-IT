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

        const int WS_CLIPCHILDREN = 0x2000000;
        const int minimisebox = 0x20000;
        const int sysmen = 0x80000;
        const int dbblcl = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {

                CreateParams cp = base.CreateParams;
                cp.Style = WS_CLIPCHILDREN | minimisebox | sysmen;
                cp.ClassStyle = dbblcl;

                return cp;
            }
        }

        Point formlock, cursorlocation = new Point(0, 0);

        private void setpositions()
        {
            formlock = this.Location;
            cursorlocation = Cursor.Position;
        }

        private void Finance_Load(object sender, EventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ex = formlock.X - cursorlocation.X + Cursor.Position.X;
            int ey = formlock.Y - cursorlocation.Y + Cursor.Position.Y;
            this.Location = new Point(ex, ey);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            setpositions();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            setpositions();
        }

        private void frm_Finance_Window_Name_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            setpositions();
        }

        private void frm_Finance_Window_Name_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            setpositions();
        }

        private void frm_Finance_Load(object sender, EventArgs e)
        {

        }
    }
}
