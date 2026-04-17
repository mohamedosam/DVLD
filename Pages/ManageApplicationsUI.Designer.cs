namespace DVLD_Project
{
    partial class ManageApplicationsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageApplicationsUI));
            this.label1 = new System.Windows.Forms.Label();
            this.ctrbtnMangeLLA = new DVLD_Project.ctrTransactionCards();
            this.ctrbtnMangeILA = new DVLD_Project.ctrTransactionCards();
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
            // ctrbtnMangeLLA
            // 
            this.ctrbtnMangeLLA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrbtnMangeLLA.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrbtnMangeLLA.CardImage")));
            this.ctrbtnMangeLLA.Location = new System.Drawing.Point(47, 148);
            this.ctrbtnMangeLLA.Name = "ctrbtnMangeLLA";
            this.ctrbtnMangeLLA.Size = new System.Drawing.Size(364, 88);
            this.ctrbtnMangeLLA.SubTitle = "Manage Local Driver License Applications";
            this.ctrbtnMangeLLA.TabIndex = 2;
            this.ctrbtnMangeLLA.Title = "Local Licenses Applications";
            this.ctrbtnMangeLLA.Click += new System.EventHandler(this.ctrTransactionCards1_Click);
            // 
            // ctrbtnMangeILA
            // 
            this.ctrbtnMangeILA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrbtnMangeILA.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrbtnMangeILA.CardImage")));
            this.ctrbtnMangeILA.Location = new System.Drawing.Point(47, 365);
            this.ctrbtnMangeILA.Name = "ctrbtnMangeILA";
            this.ctrbtnMangeILA.Size = new System.Drawing.Size(415, 88);
            this.ctrbtnMangeILA.SubTitle = "Manage International Driver License Applications";
            this.ctrbtnMangeILA.TabIndex = 3;
            this.ctrbtnMangeILA.Title = "International Licenses Applications";
            // 
            // ManageApplicationsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.ctrbtnMangeILA);
            this.Controls.Add(this.ctrbtnMangeLLA);
            this.Controls.Add(this.label1);
            this.Name = "ManageApplicationsUI";
            this.Size = new System.Drawing.Size(886, 625);
            this.Load += new System.EventHandler(this.ManageApplicationsUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrTransactionCards ctrbtnMangeLLA;
        private ctrTransactionCards ctrbtnMangeILA;
    }
}
