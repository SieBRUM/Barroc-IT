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
        Point formlock, cursorlocation = new Point(0, 0);

        //PictureBox btn_close = new PictureBox();
        //PictureBox btn_minimise = new PictureBox();
        //PictureBox btn_help = new PictureBox();
        //PictureBox background = new PictureBox();

        Image img_backgr = Image.FromFile("BackgroundOverview.png");
        Image img_close = Image.FromFile("Close.png");
        Image img_minimise = Image.FromFile("Minimise.png");
        Image img_Help = Image.FromFile("Help.png");
        Image img_BackgrLogin = Image.FromFile("BackgrLogin.png");

        
        #region Timer

        Timer timer1 = new Timer();
        
        public void CreateForm()
        {
            //background.Image = img_backgr;
            //background.Height = 700;
            //background.Width = 900;

            using (Form form = new Form())
            {
                form.Text = "About Us";

                // form.Controls.Add(...);
                this.BackgroundImage = img_backgr;

                form.ShowDialog();
            }

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

        }

        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;

        //[DllImportAttribute("user32.dll")]
        
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //public static extern bool ReleaseCapture();

//private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
//{     
//    if (e.Button == MouseButtons.Left)
//    {
//        ReleaseCapture();
//        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
//    }
//}
        
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
