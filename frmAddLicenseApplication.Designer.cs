namespace DVLD_Project
{
    partial class frmAddLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLicenseApplication));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.personSearchBar1 = new DVLD_Project.PersonSearchBar();
            this.ucBtnCancel = new DVLD_Project.UcBtn();
            this.ucBtnBack = new DVLD_Project.UcBtn();
            this.ucBtnNext = new DVLD_Project.UcBtn();
            this.ucBtnSave = new DVLD_Project.UcBtn();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(889, 11);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(35, 36);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 46;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.personSearchBar1);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 406);
            this.panel1.TabIndex = 48;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // personSearchBar1
            // 
            this.personSearchBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.personSearchBar1.Location = new System.Drawing.Point(3, 3);
            this.personSearchBar1.Name = "personSearchBar1";
            this.personSearchBar1.Size = new System.Drawing.Size(880, 57);
            this.personSearchBar1.TabIndex = 5;
            this.personSearchBar1.Load += new System.EventHandler(this.personSearchBar1_Load);
            // 
            // ucBtnCancel
            // 
            this.ucBtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.ucBtnCancel.BtnImage = ((System.Drawing.Image)(resources.GetObject("ucBtnCancel.BtnImage")));
            this.ucBtnCancel.BtnTitle = "Cancel";
            this.ucBtnCancel.Location = new System.Drawing.Point(633, 465);
            this.ucBtnCancel.Name = "ucBtnCancel";
            this.ucBtnCancel.Size = new System.Drawing.Size(133, 40);
            this.ucBtnCancel.TabIndex = 2;
            this.ucBtnCancel.Load += new System.EventHandler(this.ucBtnCancel_Load);
            this.ucBtnCancel.Click += new System.EventHandler(this.ucBtnCancel_Click);
            // 
            // ucBtnBack
            // 
            this.ucBtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.ucBtnBack.BtnImage = ((System.Drawing.Image)(resources.GetObject("ucBtnBack.BtnImage")));
            this.ucBtnBack.BtnTitle = "Back";
            this.ucBtnBack.Location = new System.Drawing.Point(633, 465);
            this.ucBtnBack.Name = "ucBtnBack";
            this.ucBtnBack.Size = new System.Drawing.Size(133, 40);
            this.ucBtnBack.TabIndex = 47;
            this.ucBtnBack.Click += new System.EventHandler(this.ucBtnBack_Click);
            // 
            // ucBtnNext
            // 
            this.ucBtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.ucBtnNext.BtnImage = ((System.Drawing.Image)(resources.GetObject("ucBtnNext.BtnImage")));
            this.ucBtnNext.BtnTitle = "Next";
            this.ucBtnNext.Location = new System.Drawing.Point(783, 465);
            this.ucBtnNext.Name = "ucBtnNext";
            this.ucBtnNext.Size = new System.Drawing.Size(133, 40);
            this.ucBtnNext.TabIndex = 3;
            this.ucBtnNext.Click += new System.EventHandler(this.ucBtnNext_Click);
            // 
            // ucBtnSave
            // 
            this.ucBtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.ucBtnSave.BtnImage = ((System.Drawing.Image)(resources.GetObject("ucBtnSave.BtnImage")));
            this.ucBtnSave.BtnTitle = "Save";
            this.ucBtnSave.Location = new System.Drawing.Point(783, 465);
            this.ucBtnSave.Name = "ucBtnSave";
            this.ucBtnSave.Size = new System.Drawing.Size(133, 40);
            this.ucBtnSave.TabIndex = 1;
            this.ucBtnSave.Click += new System.EventHandler(this.ucBtnSave_Click);
            // 
            // frmAddLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(936, 517);
            this.Controls.Add(this.ucBtnNext);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucBtnSave);
            this.Controls.Add(this.ucBtnCancel);
            this.Controls.Add(this.ucBtnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddLicense";
            this.Text = "frmAddNewUser";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddNewUser_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UcBtn ucBtnSave;
        private UcBtn ucBtnCancel;
        private UcBtn ucBtnNext;
        private PersonSearchBar personSearchBar1;
        private System.Windows.Forms.PictureBox pbClose;
        private UcBtn ucBtnBack;
        private System.Windows.Forms.Panel panel1;
    }
}