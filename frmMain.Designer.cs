namespace DVLD_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuItem5 = new DVLD_Project.CtrlMenuItem();
            this.menuItem4 = new DVLD_Project.CtrlMenuItem();
            this.menuItem2 = new DVLD_Project.CtrlMenuItem();
            this.menuItem1 = new DVLD_Project.CtrlMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addApplicationUI = new DVLD_Project.AddApplicationUI();
            this.manageApplicationsUI1 = new DVLD_Project.ManageApplicationsUI();
            this.detainLicenseUI1 = new DVLD_Project.DetainLicenseUI();
            this.peopleManagmentUI1 = new DVLD_Project.PeopleManagmentUI();
            this.defultUI1 = new DVLD_Project.DefultUI();
            this.ctrApplication1 = new DVLD_Project.ctrApplication();
            this.userMangmentUI1 = new DVLD_Project.UserMangmentUI();
            this.driverLicensesServicesUI1 = new DVLD_Project.DriverLicensesServicesUI();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.localDriverLicenseApplicationsUI = new DVLD_Project.Pages.LocalDriverLicenseApplicationsUI();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.menuItem5);
            this.panel1.Controls.Add(this.menuItem4);
            this.panel1.Controls.Add(this.menuItem2);
            this.panel1.Controls.Add(this.menuItem1);
            this.panel1.Location = new System.Drawing.Point(-8, -32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 652);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.pbSettings);
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 595);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 57);
            this.panel3.TabIndex = 3;
            // 
            // pbSettings
            // 
            this.pbSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbSettings.Image")));
            this.pbSettings.Location = new System.Drawing.Point(202, 0);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(65, 57);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettings.TabIndex = 7;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            this.pbSettings.MouseEnter += new System.EventHandler(this.pbSettings_MouseEnter);
            this.pbSettings.MouseLeave += new System.EventHandler(this.pbSettings_MouseLeave);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("TechnicBold", 14.25F);
            this.lblUsername.Location = new System.Drawing.Point(85, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuItem5
            // 
            this.menuItem5.CardImage = ((System.Drawing.Image)(resources.GetObject("menuItem5.CardImage")));
            this.menuItem5.Location = new System.Drawing.Point(3, 469);
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(263, 73);
            this.menuItem5.TabIndex = 4;
            this.menuItem5.Title = "Users";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.CardImage = ((System.Drawing.Image)(resources.GetObject("menuItem4.CardImage")));
            this.menuItem4.Location = new System.Drawing.Point(3, 371);
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(263, 73);
            this.menuItem4.TabIndex = 3;
            this.menuItem4.Title = "Drivers";
            // 
            // menuItem2
            // 
            this.menuItem2.CardImage = ((System.Drawing.Image)(resources.GetObject("menuItem2.CardImage")));
            this.menuItem2.Location = new System.Drawing.Point(3, 273);
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(263, 73);
            this.menuItem2.TabIndex = 1;
            this.menuItem2.Title = "People";
            this.menuItem2.Load += new System.EventHandler(this.menuItem2_Load);
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.CardImage = ((System.Drawing.Image)(resources.GetObject("menuItem1.CardImage")));
            this.menuItem1.Location = new System.Drawing.Point(3, 175);
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(263, 73);
            this.menuItem1.TabIndex = 0;
            this.menuItem1.Title = "Application";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.localDriverLicenseApplicationsUI);
            this.panel2.Controls.Add(this.addApplicationUI);
            this.panel2.Controls.Add(this.manageApplicationsUI1);
            this.panel2.Controls.Add(this.detainLicenseUI1);
            this.panel2.Controls.Add(this.peopleManagmentUI1);
            this.panel2.Controls.Add(this.defultUI1);
            this.panel2.Controls.Add(this.ctrApplication1);
            this.panel2.Controls.Add(this.userMangmentUI1);
            this.panel2.Controls.Add(this.driverLicensesServicesUI1);
            this.panel2.Location = new System.Drawing.Point(258, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 625);
            this.panel2.TabIndex = 1;
            // 
            // addApplicationUI
            // 
            this.addApplicationUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.addApplicationUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addApplicationUI.Location = new System.Drawing.Point(0, 0);
            this.addApplicationUI.Name = "addApplicationUI";
            this.addApplicationUI.Size = new System.Drawing.Size(886, 625);
            this.addApplicationUI.TabIndex = 7;
            this.addApplicationUI.Load += new System.EventHandler(this.addApplicationUI_Load);
            // 
            // manageApplicationsUI1
            // 
            this.manageApplicationsUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.manageApplicationsUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageApplicationsUI1.Location = new System.Drawing.Point(0, 0);
            this.manageApplicationsUI1.Name = "manageApplicationsUI1";
            this.manageApplicationsUI1.Size = new System.Drawing.Size(886, 625);
            this.manageApplicationsUI1.TabIndex = 2;
            this.manageApplicationsUI1.Visible = false;
            this.manageApplicationsUI1.Load += new System.EventHandler(this.manageApplicationsUI1_Load);
            // 
            // detainLicenseUI1
            // 
            this.detainLicenseUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.detainLicenseUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detainLicenseUI1.Location = new System.Drawing.Point(0, 0);
            this.detainLicenseUI1.Name = "detainLicenseUI1";
            this.detainLicenseUI1.Size = new System.Drawing.Size(886, 625);
            this.detainLicenseUI1.TabIndex = 4;
            this.detainLicenseUI1.Visible = false;
            // 
            // peopleManagmentUI1
            // 
            this.peopleManagmentUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.peopleManagmentUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peopleManagmentUI1.Location = new System.Drawing.Point(0, 0);
            this.peopleManagmentUI1.Name = "peopleManagmentUI1";
            this.peopleManagmentUI1.Size = new System.Drawing.Size(886, 625);
            this.peopleManagmentUI1.TabIndex = 5;
            // 
            // defultUI1
            // 
            this.defultUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.defultUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defultUI1.Location = new System.Drawing.Point(0, 0);
            this.defultUI1.Name = "defultUI1";
            this.defultUI1.Size = new System.Drawing.Size(886, 625);
            this.defultUI1.TabIndex = 3;
            // 
            // ctrApplication1
            // 
            this.ctrApplication1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrApplication1.Location = new System.Drawing.Point(0, 0);
            this.ctrApplication1.Name = "ctrApplication1";
            this.ctrApplication1.Size = new System.Drawing.Size(886, 625);
            this.ctrApplication1.TabIndex = 0;
            this.ctrApplication1.Visible = false;
            this.ctrApplication1.Load += new System.EventHandler(this.ctrApplication1_Load);
            // 
            // userMangmentUI1
            // 
            this.userMangmentUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.userMangmentUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userMangmentUI1.Location = new System.Drawing.Point(0, 0);
            this.userMangmentUI1.Name = "userMangmentUI1";
            this.userMangmentUI1.Size = new System.Drawing.Size(886, 625);
            this.userMangmentUI1.TabIndex = 6;
            // 
            // driverLicensesServicesUI1
            // 
            this.driverLicensesServicesUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.driverLicensesServicesUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driverLicensesServicesUI1.Location = new System.Drawing.Point(0, 0);
            this.driverLicensesServicesUI1.Name = "driverLicensesServicesUI1";
            this.driverLicensesServicesUI1.Size = new System.Drawing.Size(886, 625);
            this.driverLicensesServicesUI1.TabIndex = 1;
            this.driverLicensesServicesUI1.Visible = false;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1093, 23);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(35, 36);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 45;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // localDriverLicenseApplicationsUI
            // 
            this.localDriverLicenseApplicationsUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.localDriverLicenseApplicationsUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localDriverLicenseApplicationsUI.Location = new System.Drawing.Point(0, 0);
            this.localDriverLicenseApplicationsUI.Name = "localDriverLicenseApplicationsUI";
            this.localDriverLicenseApplicationsUI.Size = new System.Drawing.Size(886, 625);
            this.localDriverLicenseApplicationsUI.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1140, 619);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CtrlMenuItem menuItem2;
        private CtrlMenuItem menuItem1;
        private System.Windows.Forms.Panel panel3;
        private CtrlMenuItem menuItem5;
        private CtrlMenuItem menuItem4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ctrApplication ctrApplication1;
        private DriverLicensesServicesUI driverLicensesServicesUI1;
        private ManageApplicationsUI manageApplicationsUI1;
        private DefultUI defultUI1;
        private DetainLicenseUI detainLicenseUI1;
        private PeopleManagmentUI peopleManagmentUI1;
        private System.Windows.Forms.PictureBox pbClose;
        private UserMangmentUI userMangmentUI1;
        private System.Windows.Forms.PictureBox pbSettings;
        private AddApplicationUI addApplicationUI;
        private Pages.LocalDriverLicenseApplicationsUI localDriverLicenseApplicationsUI;
    }
}