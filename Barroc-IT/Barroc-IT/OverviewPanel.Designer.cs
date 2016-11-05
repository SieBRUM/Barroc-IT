namespace Barroc_IT
{
    partial class OverviewPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Notification_Added = new System.Windows.Forms.Label();
            this.lbl_Notification_Type = new System.Windows.Forms.Label();
            this.lbl_Notification_ID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Resolved = new System.Windows.Forms.Button();
            this.lbl_Notification_Info_Data = new System.Windows.Forms.Label();
            this.lbl_Notification_Info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Notification_Added
            // 
            this.lbl_Notification_Added.AutoSize = true;
            this.lbl_Notification_Added.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notification_Added.Location = new System.Drawing.Point(378, 17);
            this.lbl_Notification_Added.Name = "lbl_Notification_Added";
            this.lbl_Notification_Added.Size = new System.Drawing.Size(73, 13);
            this.lbl_Notification_Added.TabIndex = 4;
            this.lbl_Notification_Added.Text = "Date added";
            // 
            // lbl_Notification_Type
            // 
            this.lbl_Notification_Type.AutoSize = true;
            this.lbl_Notification_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notification_Type.Location = new System.Drawing.Point(219, 17);
            this.lbl_Notification_Type.Name = "lbl_Notification_Type";
            this.lbl_Notification_Type.Size = new System.Drawing.Size(100, 13);
            this.lbl_Notification_Type.TabIndex = 3;
            this.lbl_Notification_Type.Text = "Notification type";
            // 
            // lbl_Notification_ID
            // 
            this.lbl_Notification_ID.AutoSize = true;
            this.lbl_Notification_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notification_ID.Location = new System.Drawing.Point(12, 17);
            this.lbl_Notification_ID.Name = "lbl_Notification_ID";
            this.lbl_Notification_ID.Size = new System.Drawing.Size(89, 13);
            this.lbl_Notification_ID.TabIndex = 0;
            this.lbl_Notification_ID.Text = "Notification ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btn_Resolved);
            this.panel2.Controls.Add(this.lbl_Notification_Info_Data);
            this.panel2.Controls.Add(this.lbl_Notification_Info);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 84);
            this.panel2.TabIndex = 7;
            // 
            // btn_Resolved
            // 
            this.btn_Resolved.Location = new System.Drawing.Point(456, 55);
            this.btn_Resolved.Name = "btn_Resolved";
            this.btn_Resolved.Size = new System.Drawing.Size(75, 23);
            this.btn_Resolved.TabIndex = 39;
            this.btn_Resolved.Text = "Resolved";
            this.btn_Resolved.UseVisualStyleBackColor = true;
            this.btn_Resolved.Click += new System.EventHandler(this.DeletePanel);
            // 
            // lbl_Notification_Info_Data
            // 
            this.lbl_Notification_Info_Data.AutoSize = true;
            this.lbl_Notification_Info_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Notification_Info_Data.Location = new System.Drawing.Point(123, 15);
            this.lbl_Notification_Info_Data.Name = "lbl_Notification_Info_Data";
            this.lbl_Notification_Info_Data.Size = new System.Drawing.Size(74, 13);
            this.lbl_Notification_Info_Data.TabIndex = 38;
            this.lbl_Notification_Info_Data.Text = "Placeholder";
            // 
            // lbl_Notification_Info
            // 
            this.lbl_Notification_Info.AutoSize = true;
            this.lbl_Notification_Info.Location = new System.Drawing.Point(12, 15);
            this.lbl_Notification_Info.Name = "lbl_Notification_Info";
            this.lbl_Notification_Info.Size = new System.Drawing.Size(83, 13);
            this.lbl_Notification_Info.TabIndex = 37;
            this.lbl_Notification_Info.Text = "Notification info:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lbl_Notification_Added);
            this.panel1.Controls.Add(this.lbl_Notification_Type);
            this.panel1.Controls.Add(this.lbl_Notification_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 46);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.OpenMoreInfo);
            // 
            // OverviewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(538, 0);
            this.Name = "OverviewPanel";
            this.Size = new System.Drawing.Size(538, 130);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Notification_Added;
        private System.Windows.Forms.Label lbl_Notification_Type;
        private System.Windows.Forms.Label lbl_Notification_ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Notification_Info_Data;
        private System.Windows.Forms.Label lbl_Notification_Info;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_Resolved;
    }
}
