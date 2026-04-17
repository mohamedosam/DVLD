namespace DVLD_Project
{
    partial class frmIssueaDriverLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueaDriverLicense));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.ucApplicationDetails1 = new DVLD_Project.UcApplicationDetails();
            this.ucBtn1 = new DVLD_Project.UcBtn();
            this.ucBtn2 = new DVLD_Project.UcBtn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(957, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(35, 36);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 51;
            this.pbClose.TabStop = false;
            // 
            // ucApplicationDetails1
            // 
            this.ucApplicationDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ucApplicationDetails1.Location = new System.Drawing.Point(7, 69);
            this.ucApplicationDetails1.Name = "ucApplicationDetails1";
            this.ucApplicationDetails1.Size = new System.Drawing.Size(995, 411);
            this.ucApplicationDetails1.TabIndex = 52;
            // 
            // ucBtn1
            // 
            this.ucBtn1.BackColor = System.Drawing.Color.GreenYellow;
            this.ucBtn1.BtnImage = ((System.Drawing.Image)(resources.GetObject("ucBtn1.BtnImage")));
            this.ucBtn1.BtnTitle = "Issue";
            this.ucBtn1.Location = new System.Drawing.Point(868, 685);
            this.ucBtn1.Name = "ucBtn1";
            this.ucBtn1.Size = new System.Drawing.Size(115, 40);
            this.ucBtn1.TabIndex = 53;
            // 
            // ucBtn2
            // 
            this.ucBtn2.BackColor = System.Drawing.Color.Red;
            this.ucBtn2.BtnImage = ((System.Drawing.Image)(resources.GetObject("ucBtn2.BtnImage")));
            this.ucBtn2.BtnTitle = "Close";
            this.ucBtn2.Location = new System.Drawing.Point(729, 685);
            this.ucBtn2.Name = "ucBtn2";
            this.ucBtn2.Size = new System.Drawing.Size(115, 40);
            this.ucBtn2.TabIndex = 54;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(27, 517);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(956, 148);
            this.txtNotes.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TechnicBold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(65, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 35);
            this.label2.TabIndex = 61;
            this.label2.Text = "Notes :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TechnicBold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(316, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 35);
            this.label3.TabIndex = 65;
            this.label3.Text = "Issue A Driver License";
            // 
            // frmIssueaDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1004, 739);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucApplicationDetails1);
            this.Controls.Add(this.ucBtn2);
            this.Controls.Add(this.ucBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIssueaDriverLicense";
            this.Text = "frmIssueaDriverLicense";
            this.Load += new System.EventHandler(this.frmIssueaDriverLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private UcApplicationDetails ucApplicationDetails1;
        private UcBtn ucBtn1;
        private UcBtn ucBtn2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}