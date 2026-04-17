namespace DVLD_Project
{
    partial class frmSettingMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.tmChangePassword = new DVLD_Project.Buttons.TaskMenuItem();
            this.tmAccountInfo = new DVLD_Project.Buttons.TaskMenuItem();
            this.TMsignout = new DVLD_Project.Buttons.TaskMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.TMsignout);
            this.panel1.Controls.Add(this.tmChangePassword);
            this.panel1.Controls.Add(this.tmAccountInfo);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 59);
            this.panel1.TabIndex = 48;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(858, 10);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(35, 36);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 47;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // tmChangePassword
            // 
            this.tmChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.tmChangePassword.CardImage = ((System.Drawing.Image)(resources.GetObject("tmChangePassword.CardImage")));
            this.tmChangePassword.Location = new System.Drawing.Point(186, 3);
            this.tmChangePassword.Name = "tmChangePassword";
            this.tmChangePassword.Size = new System.Drawing.Size(225, 56);
            this.tmChangePassword.TabIndex = 50;
            this.tmChangePassword.Title = "Change  Password";
            this.tmChangePassword.Load += new System.EventHandler(this.taskMenuItem2_Load);
            this.tmChangePassword.Click += new System.EventHandler(this.tmChangePassword_Click_1);
            // 
            // tmAccountInfo
            // 
            this.tmAccountInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.tmAccountInfo.CardImage = ((System.Drawing.Image)(resources.GetObject("tmAccountInfo.CardImage")));
            this.tmAccountInfo.Location = new System.Drawing.Point(0, 3);
            this.tmAccountInfo.Name = "tmAccountInfo";
            this.tmAccountInfo.Size = new System.Drawing.Size(191, 56);
            this.tmAccountInfo.TabIndex = 49;
            this.tmAccountInfo.Title = "Account Info";
            this.tmAccountInfo.Click += new System.EventHandler(this.tmAccountInfo_Click);
            // 
            // TMsignout
            // 
            this.TMsignout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.TMsignout.CardImage = ((System.Drawing.Image)(resources.GetObject("TMsignout.CardImage")));
            this.TMsignout.Location = new System.Drawing.Point(417, 3);
            this.TMsignout.Name = "TMsignout";
            this.TMsignout.Size = new System.Drawing.Size(142, 56);
            this.TMsignout.TabIndex = 51;
            this.TMsignout.Title = "Signout";
            this.TMsignout.Click += new System.EventHandler(this.TMsignout_Click);
            // 
            // frmSettingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(905, 470);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettingMenu";
            this.Text = "frmSettingMenu";
            this.Load += new System.EventHandler(this.frmSettingMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSettingMenu_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel1;
        private Buttons.TaskMenuItem tmChangePassword;
        private Buttons.TaskMenuItem tmAccountInfo;
        private Buttons.TaskMenuItem TMsignout;
    }
}