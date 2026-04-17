namespace DVLD_Project
{
    partial class ctrApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrApplication));
            this.label1 = new System.Windows.Forms.Label();
            this.ctrTransactionCardsMTT = new DVLD_Project.ctrTransactionCards();
            this.ctrTransactionCardsDL = new DVLD_Project.ctrTransactionCards();
            this.ctrTransactionCardsMA = new DVLD_Project.ctrTransactionCards();
            this.ctrTransactionCardsMAT = new DVLD_Project.ctrTransactionCards();
            this.ctrTransactionCardsDLS = new DVLD_Project.ctrTransactionCards();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the transaction you want to do :\r\n";
            // 
            // ctrTransactionCardsMTT
            // 
            this.ctrTransactionCardsMTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsMTT.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsMTT.CardImage")));
            this.ctrTransactionCardsMTT.Location = new System.Drawing.Point(530, 292);
            this.ctrTransactionCardsMTT.Name = "ctrTransactionCardsMTT";
            this.ctrTransactionCardsMTT.Size = new System.Drawing.Size(335, 88);
            this.ctrTransactionCardsMTT.SubTitle = "Manage Titles and fees of Tests";
            this.ctrTransactionCardsMTT.TabIndex = 5;
            this.ctrTransactionCardsMTT.Title = "Mange Test Types";
            // 
            // ctrTransactionCardsDL
            // 
            this.ctrTransactionCardsDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsDL.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsDL.CardImage")));
            this.ctrTransactionCardsDL.Location = new System.Drawing.Point(47, 436);
            this.ctrTransactionCardsDL.Name = "ctrTransactionCardsDL";
            this.ctrTransactionCardsDL.Size = new System.Drawing.Size(335, 88);
            this.ctrTransactionCardsDL.SubTitle = "datain and release licenses";
            this.ctrTransactionCardsDL.TabIndex = 4;
            this.ctrTransactionCardsDL.Title = "Detain Licenses";
            this.ctrTransactionCardsDL.Load += new System.EventHandler(this.ctrTransactionCardsDL_Load);
            // 
            // ctrTransactionCardsMA
            // 
            this.ctrTransactionCardsMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsMA.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsMA.CardImage")));
            this.ctrTransactionCardsMA.Location = new System.Drawing.Point(47, 292);
            this.ctrTransactionCardsMA.Name = "ctrTransactionCardsMA";
            this.ctrTransactionCardsMA.Size = new System.Drawing.Size(335, 88);
            this.ctrTransactionCardsMA.SubTitle = "Manage local and international licenses applications";
            this.ctrTransactionCardsMA.TabIndex = 3;
            this.ctrTransactionCardsMA.Title = "Manage Applications";
            // 
            // ctrTransactionCardsMAT
            // 
            this.ctrTransactionCardsMAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsMAT.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsMAT.CardImage")));
            this.ctrTransactionCardsMAT.Location = new System.Drawing.Point(530, 148);
            this.ctrTransactionCardsMAT.Name = "ctrTransactionCardsMAT";
            this.ctrTransactionCardsMAT.Size = new System.Drawing.Size(335, 88);
            this.ctrTransactionCardsMAT.SubTitle = "Manage Titles and fees of applications";
            this.ctrTransactionCardsMAT.TabIndex = 2;
            this.ctrTransactionCardsMAT.Title = "Manage Application Types";
            // 
            // ctrTransactionCardsDLS
            // 
            this.ctrTransactionCardsDLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ctrTransactionCardsDLS.CardImage = ((System.Drawing.Image)(resources.GetObject("ctrTransactionCardsDLS.CardImage")));
            this.ctrTransactionCardsDLS.Location = new System.Drawing.Point(47, 148);
            this.ctrTransactionCardsDLS.Name = "ctrTransactionCardsDLS";
            this.ctrTransactionCardsDLS.Size = new System.Drawing.Size(335, 88);
            this.ctrTransactionCardsDLS.SubTitle = "issue and manage licenses ";
            this.ctrTransactionCardsDLS.TabIndex = 1;
            this.ctrTransactionCardsDLS.Title = "Driving Licenses Services";
            this.ctrTransactionCardsDLS.Load += new System.EventHandler(this.ctrTransactionCardsDLS_Load);
            // 
            // ctrApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.ctrTransactionCardsMTT);
            this.Controls.Add(this.ctrTransactionCardsDL);
            this.Controls.Add(this.ctrTransactionCardsMA);
            this.Controls.Add(this.ctrTransactionCardsMAT);
            this.Controls.Add(this.ctrTransactionCardsDLS);
            this.Controls.Add(this.label1);
            this.Name = "ctrApplication";
            this.Size = new System.Drawing.Size(886, 625);
            this.Load += new System.EventHandler(this.ctrApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrTransactionCards ctrTransactionCardsDLS;
        private ctrTransactionCards ctrTransactionCardsMAT;
        private ctrTransactionCards ctrTransactionCardsMA;
        private ctrTransactionCards ctrTransactionCardsDL;
        private ctrTransactionCards ctrTransactionCardsMTT;
    }
}
