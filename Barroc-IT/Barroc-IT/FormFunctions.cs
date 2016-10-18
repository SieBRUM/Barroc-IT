using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Barroc_IT
{
    public class FormFunctions : Form
    {

        #region Timer

        Timer timer1 = new Timer();
        Point formlock, cursorlocation = new Point(0, 0);
        

        PictureBox btn_close = new PictureBox();
        PictureBox btn_minimise = new PictureBox();
        PictureBox btn_help = new PictureBox();

        PictureBox background = new PictureBox();
        


        public void timer_tick()
        {
            int ex = formlock.X - cursorlocation.X + Cursor.Position.X;
            int ey = formlock.Y - cursorlocation.Y + Cursor.Position.Y;
            this.Location = new Point(ex, ey);     
        }


        private void setpositions()
        {
            formlock = this.Location;
            cursorlocation = Cursor.Position;
        }

        public void Timer_Start()
        {
            timer1.Start();
            setpositions();
        }
        public void Timer_Stop()
        {
            timer1.Stop();
            setpositions();
        }

        #endregion







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

        public void setform()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        public void closing()
        {

            this.Close();
            Frm_Login formlogin = new Frm_Login();
            formlogin.Show();
        }

        public void minimise()
        {
            this.WindowState = FormWindowState.Minimized;

        }


        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    int ex = formlock.X - cursorlocation.X + Cursor.Position.X;
        //    int ey = formlock.Y - cursorlocation.Y + Cursor.Position.Y;
        //    this.Location = new Point(ex, ey);
        //}



        //private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Timer_Start();
        //}

        //private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    Timer_Stop();
        //}

        //private void frm_Finance_Window_Name_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Timer_Start();
        //}

        //private void frm_Finance_Window_Name_MouseUp(object sender, MouseEventArgs e)
        //{
        //    Timer_Stop();
        //}






    }
}
