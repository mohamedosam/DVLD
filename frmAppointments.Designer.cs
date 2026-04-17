namespace DVLD_Project
{
    partial class frmAppointment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvAppoinmentsTable = new System.Windows.Forms.DataGridView();
            this.CMSAppointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pbAddTestAppointment = new System.Windows.Forms.PictureBox();
            this.scTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.scEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoinmentsTable)).BeginInit();
            this.CMSAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddTestAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("TechnicBold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(259, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 41);
            this.lblTitle.TabIndex = 51;
            this.lblTitle.Text = "Vision Test Appointments";
            // 
            // dgvAppoinmentsTable
            // 
            this.dgvAppoinmentsTable.AllowUserToAddRows = false;
            this.dgvAppoinmentsTable.AllowUserToDeleteRows = false;
            this.dgvAppoinmentsTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("TechnicBold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.dgvAppoinmentsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppoinmentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppoinmentsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.dgvAppoinmentsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppoinmentsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("TechnicBold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppoinmentsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppoinmentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppoinmentsTable.ContextMenuStrip = this.CMSAppointment;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("TechnicBold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppoinmentsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppoinmentsTable.EnableHeadersVisualStyles = false;
            this.dgvAppoinmentsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.dgvAppoinmentsTable.Location = new System.Drawing.Point(22, 570);
            this.dgvAppoinmentsTable.Name = "dgvAppoinmentsTable";
            this.dgvAppoinmentsTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("TechnicBold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppoinmentsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppoinmentsTable.RowHeadersVisible = false;
            this.dgvAppoinmentsTable.Size = new System.Drawing.Size(948, 287);
            this.dgvAppoinmentsTable.TabIndex = 53;
            this.dgvAppoinmentsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppoinmentsTable_CellContentClick);
            // 
            // CMSAppointment
            // 
            this.CMSAppointment.Font = new System.Drawing.Font("TechnicBold", 12F);
            this.CMSAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scTakeTest,
            this.scEdit});
            this.CMSAppointment.Name = "CMSAppointment";
            this.CMSAppointment.Size = new System.Drawing.Size(181, 70);
            this.CMSAppointment.Opening += new System.ComponentModel.CancelEventHandler(this.CMSAppointment_Opening);
            // 
            // pbAddTestAppointment
            // 
            this.pbAddTestAppointment.Image = ((System.Drawing.Image)(resources.GetObject("pbAddTestAppointment.Image")));
            this.pbAddTestAppointment.Location = new System.Drawing.Point(932, 520);
            this.pbAddTestAppointment.Name = "pbAddTestAppointment";
            this.pbAddTestAppointment.Size = new System.Drawing.Size(38, 44);
            this.pbAddTestAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddTestAppointment.TabIndex = 54;
            this.pbAddTestAppointment.TabStop = false;
            this.pbAddTestAppointment.Click += new System.EventHandler(this.pbAddTestAppointment_Click);
            // 
            // scTakeTest
            // 
            this.scTakeTest.Image = ((System.Drawing.Image)(resources.GetObject("scTakeTest.Image")));
            this.scTakeTest.Name = "scTakeTest";
            this.scTakeTest.Size = new System.Drawing.Size(180, 22);
            this.scTakeTest.Text = "Take Test";
            this.scTakeTest.Click += new System.EventHandler(this.scTakeTest_Click);
            // 
            // scEdit
            // 
            this.scEdit.Image = ((System.Drawing.Image)(resources.GetObject("scEdit.Image")));
            this.scEdit.Name = "scEdit";
            this.scEdit.Size = new System.Drawing.Size(180, 22);
            this.scEdit.Text = "Edit";
            this.scEdit.Click += new System.EventHandler(this.scEdit_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(946, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(35, 36);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 49;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(993, 869);
            this.Controls.Add(this.pbAddTestAppointment);
            this.Controls.Add(this.dgvAppoinmentsTable);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAppointment";
            this.Text = "frmAppointmentscs";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoinmentsTable)).EndInit();
            this.CMSAppointment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddTestAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvAppoinmentsTable;
        private System.Windows.Forms.PictureBox pbAddTestAppointment;
        private System.Windows.Forms.ContextMenuStrip CMSAppointment;
        private System.Windows.Forms.ToolStripMenuItem scTakeTest;
        private System.Windows.Forms.ToolStripMenuItem scEdit;
    }
}