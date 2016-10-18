using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using Barroc_IT.Properties;

namespace Barroc_IT
{
    public class FormFunctions : Form
    {
        Point formlock, cursorlocation = new Point(0, 0);


        Image img_backgr = Resources.Backgroundovv;
        Image img_minimise = Resources.Minimise;
        Image img_Help = Resources.Help;
        Image img_Backgrlgn = Resources.login;

        PictureBox close = new PictureBox
        {
            Name = "Close",
            Size = new Size(30, 30),
            Location = new Point(695, 5),
            BackColor = System.Drawing.Color.Transparent
        };
        PictureBox Minimise = new PictureBox
        {
            Name = "Closing",
            Size = new Size(30, 30),
            Location = new Point(665, 4),
            BackColor = System.Drawing.Color.Transparent
        };
        PictureBox Help = new PictureBox
        {
            Name = "Help",
            Size = new Size(30,30),
            Location = new Point (635, 4),
            BackColor = System.Drawing.Color.Transparent
        };
        MenuStrip mnstrp_Menu = new MenuStrip()
            {
                Name = "Menustrip",
                Anchor = System.Windows.Forms.AnchorStyles.Left,
                Location = new Point(9, 38),
                Size = new System.Drawing.Size(300,700),
                BackColor = System.Drawing.Color.Silver
                
            };
        
        #region Timer

        Timer timer1 = new Timer();
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
        

        public void CreateForm()
        {
            

            using (Form form = new Form())
            {
                form.Text = "Barroc-IT - Software for fun";

                // form.Controls.Add(...);
                form.BackgroundImage = img_backgr;
                form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

                form.Location = new Point(100,100);
                form.ClientSize = new System.Drawing.Size(730, 500);

                
                form.Controls.Add(close);        close.Image = Resources.Close;
                form.Controls.Add(Minimise);     Minimise.Image = Resources.Minimise;
                form.Controls.Add(Help);         Help.Image = Resources.Help;
                form.Controls.Add(mnstrp_Menu);

                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 10, 10, 30, 30));
                form.ShowDialog();
                
            }

            

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
