namespace DVLD_Project
{
    partial class DetainLicenseUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetainLicenseUI));
            this.label1 = new System.Windows.Forms.Label();
            this.ctrTransactionCards1 = new DVLD_Project.ctrTransactionCards();
            this.ctrTransactionCards2 = new DVLD_Project.ctrTransactionCards();
            this.ctrTransactionCards4 = new DVLD_Project.ctrTransactionCards();
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
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the transaction you want to do :\r\n";
            // 
            // ctrTransactionCards1
            // 
            this.ctrTransactionCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCards1.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCards1.CardImage")));
            this.ctrTransactionCards1.Location = new System.Drawing.Point(47, 148);
            this.ctrTransactionCards1.Name = "ctrTransactionCards1";
            this.ctrTransactionCards1.Size = new System.Drawing.Size(309, 88);
            this.ctrTransactionCards1.SubTitle = "Detain a License Untill fee is paid";
            this.ctrTransactionCards1.TabIndex = 3;
            this.ctrTransactionCards1.Title = "Detain License";
            // 
            // ctrTransactionCards2
            // 
            this.ctrTransactionCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCards2.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCards2.CardImage")));
            this.ctrTransactionCards2.Location = new System.Drawing.Point(47, 348);
            this.ctrTransactionCards2.Name = "ctrTransactionCards2";
            this.ctrTransactionCards2.Size = new System.Drawing.Size(324, 88);
            this.ctrTransactionCards2.SubTitle = "Manage Detained Licenses";
            this.ctrTransactionCards2.TabIndex = 4;
            this.ctrTransactionCards2.Title = "Manage Detained Licenses";
            this.ctrTransactionCards2.Load += new System.EventHandler(this.ctrTransactionCards2_Load);
            // 
            // ctrTransactionCards4
            // 
            this.ctrTransactionCards4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCards4.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCards4.CardImage")));
            this.ctrTransactionCards4.Location = new System.Drawing.Point(524, 148);
            this.ctrTransactionCards4.Name = "ctrTransactionCards4";
            this.ctrTransactionCards4.Size = new System.Drawing.Size(329, 88);
            this.ctrTransactionCards4.SubTitle = "Release Detained License after paying the fee";
            this.ctrTransactionCards4.TabIndex = 6;
            this.ctrTransactionCards4.Title = "Release Detained License";
            // 
            // DetainLicenseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.ctrTransactionCards4);
            this.Controls.Add(this.ctrTransactionCards2);
            this.Controls.Add(this.ctrTransactionCards1);
            this.Controls.Add(this.label1);
            this.Name = "DetainLicenseUI";
            this.Size = new System.Drawing.Size(886, 625);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrTransactionCards ctrTransactionCards1;
        private ctrTransactionCards ctrTransactionCards2;
        private ctrTransactionCards ctrTransactionCards4;
    }
}
