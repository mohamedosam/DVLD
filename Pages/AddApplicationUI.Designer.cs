namespace DVLD_Project
{
    partial class AddApplicationUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddApplicationUI));
            this.label1 = new System.Windows.Forms.Label();
            this.ctrTransactionCardsAddInternationakLicense = new DVLD_Project.ctrTransactionCards();
            this.ctrTransactionCardsAddLocalLicense = new DVLD_Project.ctrTransactionCards();
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
            // ctrTransactionCardsAddInternationakLicense
            // 
            this.ctrTransactionCardsAddInternationakLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsAddInternationakLicense.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsAddInternationakLicense.CardImage")));
            this.ctrTransactionCardsAddInternationakLicense.Location = new System.Drawing.Point(47, 367);
            this.ctrTransactionCardsAddInternationakLicense.Name = "ctrTransactionCardsAddInternationakLicense";
            this.ctrTransactionCardsAddInternationakLicense.Size = new System.Drawing.Size(415, 88);
            this.ctrTransactionCardsAddInternationakLicense.SubTitle = "Add International Driver License Applications";
            this.ctrTransactionCardsAddInternationakLicense.TabIndex = 3;
            this.ctrTransactionCardsAddInternationakLicense.Title = "International Licenses Applications";
            // 
            // ctrTransactionCardsAddLocalLicense
            // 
            this.ctrTransactionCardsAddLocalLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsAddLocalLicense.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsAddLocalLicense.CardImage")));
            this.ctrTransactionCardsAddLocalLicense.Location = new System.Drawing.Point(47, 148);
            this.ctrTransactionCardsAddLocalLicense.Name = "ctrTransactionCardsAddLocalLicense";
            this.ctrTransactionCardsAddLocalLicense.Size = new System.Drawing.Size(364, 88);
            this.ctrTransactionCardsAddLocalLicense.SubTitle = "Add Local Driver License Applications";
            this.ctrTransactionCardsAddLocalLicense.TabIndex = 2;
            this.ctrTransactionCardsAddLocalLicense.Title = "Local Licenses Applications";
            this.ctrTransactionCardsAddLocalLicense.Click += new System.EventHandler(this.ctrTransactionCardsAddLocalLicense_Click);
            // 
            // AddApplicationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.ctrTransactionCardsAddInternationakLicense);
            this.Controls.Add(this.ctrTransactionCardsAddLocalLicense);
            this.Controls.Add(this.label1);
            this.Name = "AddApplicationUI";
            this.Size = new System.Drawing.Size(886, 625);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrTransactionCards ctrTransactionCardsAddLocalLicense;
        private ctrTransactionCards ctrTransactionCardsAddInternationakLicense;
    }
}
