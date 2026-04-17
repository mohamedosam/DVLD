namespace DVLD_Project
{
    partial class DriverLicensesServicesUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverLicensesServicesUI));
            this.label1 = new System.Windows.Forms.Label();
            this.ctrTransactionCardsNDL = new DVLD_Project.ctrTransactionCards();
            this.ctrTransactionCardsRenDL = new DVLD_Project.ctrTransactionCards();
            this.ctrTransactionCardsRepDL = new DVLD_Project.ctrTransactionCards();
            this.ctrTransactionCardsRelDL = new DVLD_Project.ctrTransactionCards();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TechnicBold", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the transaction you want to do :\r\n";
            // 
            // ctrTransactionCardsNDL
            // 
            this.ctrTransactionCardsNDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsNDL.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsNDL.CardImage")));
            this.ctrTransactionCardsNDL.Location = new System.Drawing.Point(47, 148);
            this.ctrTransactionCardsNDL.Name = "ctrTransactionCardsNDL";
            this.ctrTransactionCardsNDL.Size = new System.Drawing.Size(335, 88);
            this.ctrTransactionCardsNDL.SubTitle = "issue a new driving license";
            this.ctrTransactionCardsNDL.TabIndex = 2;
            this.ctrTransactionCardsNDL.Title = "New Driving License";
            this.ctrTransactionCardsNDL.Load += new System.EventHandler(this.ctrTransactionCards1_Load);
            this.ctrTransactionCardsNDL.Click += new System.EventHandler(this.ctrTransactionCards1_Click);
            // 
            // ctrTransactionCardsRenDL
            // 
            this.ctrTransactionCardsRenDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsRenDL.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsRenDL.CardImage")));
            this.ctrTransactionCardsRenDL.Location = new System.Drawing.Point(47, 358);
            this.ctrTransactionCardsRenDL.Name = "ctrTransactionCardsRenDL";
            this.ctrTransactionCardsRenDL.Size = new System.Drawing.Size(335, 88);
            this.ctrTransactionCardsRenDL.SubTitle = "renew license after expiration";
            this.ctrTransactionCardsRenDL.TabIndex = 3;
            this.ctrTransactionCardsRenDL.Title = "Renew Driving License";
            // 
            // ctrTransactionCardsRepDL
            // 
            this.ctrTransactionCardsRepDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsRepDL.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsRepDL.CardImage")));
            this.ctrTransactionCardsRepDL.Location = new System.Drawing.Point(524, 148);
            this.ctrTransactionCardsRepDL.Name = "ctrTransactionCardsRepDL";
            this.ctrTransactionCardsRepDL.Size = new System.Drawing.Size(335, 88);
            this.ctrTransactionCardsRepDL.SubTitle = "Replacement for Lost or Damaged License";
            this.ctrTransactionCardsRepDL.TabIndex = 4;
            this.ctrTransactionCardsRepDL.Title = "Replace Driving License";
            // 
            // ctrTransactionCardsRelDL
            // 
            this.ctrTransactionCardsRelDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsRelDL.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsRelDL.CardImage")));
            this.ctrTransactionCardsRelDL.Location = new System.Drawing.Point(524, 358);
            this.ctrTransactionCardsRelDL.Name = "ctrTransactionCardsRelDL";
            this.ctrTransactionCardsRelDL.Size = new System.Drawing.Size(335, 88);
            this.ctrTransactionCardsRelDL.SubTitle = "Release Detained License";
            this.ctrTransactionCardsRelDL.TabIndex = 5;
            this.ctrTransactionCardsRelDL.Title = "Release Driving License";
            // 
            // DriverLicensesServicesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.ctrTransactionCardsRelDL);
            this.Controls.Add(this.ctrTransactionCardsRepDL);
            this.Controls.Add(this.ctrTransactionCardsRenDL);
            this.Controls.Add(this.ctrTransactionCardsNDL);
            this.Controls.Add(this.label1);
            this.Name = "DriverLicensesServicesUI";
            this.Size = new System.Drawing.Size(886, 625);
            this.Load += new System.EventHandler(this.DriverLicensesServicesUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrTransactionCards ctrTransactionCardsNDL;
        private ctrTransactionCards ctrTransactionCardsRenDL;
        private ctrTransactionCards ctrTransactionCardsRepDL;
        private ctrTransactionCards ctrTransactionCardsRelDL;
    }
}
