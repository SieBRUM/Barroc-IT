﻿using System;
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
            int nLeftRect,  // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );

        public frm_Finance()
        {
            InitializeComponent();

           
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
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

    }
}
