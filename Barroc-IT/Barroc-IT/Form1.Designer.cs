namespace Barroc_IT
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Login = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtb_Username = new System.Windows.Forms.TextBox();
            this.txtb_Password = new System.Windows.Forms.TextBox();
            this.cb_Remember = new System.Windows.Forms.CheckBox();
            this.pb_Banner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(246, 225);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(75, 23);
            this.bt_Login.TabIndex = 0;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(204, 121);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(204, 160);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // txtb_Username
            // 
            this.txtb_Username.Location = new System.Drawing.Point(205, 137);
            this.txtb_Username.Name = "txtb_Username";
            this.txtb_Username.Size = new System.Drawing.Size(178, 20);
            this.txtb_Username.TabIndex = 4;
            // 
            // txtb_Password
            // 
            this.txtb_Password.Location = new System.Drawing.Point(205, 176);
            this.txtb_Password.Name = "txtb_Password";
            this.txtb_Password.Size = new System.Drawing.Size(178, 20);
            this.txtb_Password.TabIndex = 5;
            // 
            // cb_Remember
            // 
            this.cb_Remember.AutoSize = true;
            this.cb_Remember.Location = new System.Drawing.Point(207, 202);
            this.cb_Remember.Name = "cb_Remember";
            this.cb_Remember.Size = new System.Drawing.Size(94, 17);
            this.cb_Remember.TabIndex = 6;
            this.cb_Remember.Text = "Remember me";
            this.cb_Remember.UseVisualStyleBackColor = true;
            // 
            // pb_Banner
            // 
            this.pb_Banner.Location = new System.Drawing.Point(25, 13);
            this.pb_Banner.Name = "pb_Banner";
            this.pb_Banner.Size = new System.Drawing.Size(502, 86);
            this.pb_Banner.TabIndex = 7;
            this.pb_Banner.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 281);
            this.Controls.Add(this.pb_Banner);
            this.Controls.Add(this.cb_Remember);
            this.Controls.Add(this.txtb_Password);
            this.Controls.Add(this.txtb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.bt_Login);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 320);
            this.MinimumSize = new System.Drawing.Size(566, 320);
            this.Name = "Frm_Login";
            this.Text = "Barroc-IT - Software for real.";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtb_Username;
        private System.Windows.Forms.TextBox txtb_Password;
        private System.Windows.Forms.CheckBox cb_Remember;
        private System.Windows.Forms.PictureBox pb_Banner;
    }
}

