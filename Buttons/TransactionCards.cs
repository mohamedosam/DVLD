using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class ctrTransactionCards : UserControl
    {



        public event EventHandler BtnClicked;

        public string ButtonID;

        private void AttachClickEvent(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.Click += (s, e) => this.OnClick(e);
                ctrl.MouseEnter += (s, e) => this.OnMouseEnter(e);
                ctrl.MouseLeave += (s, e) => this.OnMouseLeave(e);

                if (ctrl.HasChildren)
                    AttachClickEvent(ctrl);
            }
        }

        public System.Drawing.Image CardImage
        {
            get { return pbImage.Image; }
            set { pbImage.Image = value; }
        }
        public ctrTransactionCards()
        {
            InitializeComponent();
            AttachClickEvent(this);
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string SubTitle
        {
            get { return lblSubTitle.Text; }
            set { lblSubTitle.Text = value; }
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void ctrTransactionCards_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(172, 186, 196);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblSubTitle.ForeColor = SystemColors.ControlText;

        }

        private void ctrTransactionCards_MouseLeave(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(48, 54, 79);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblSubTitle.ForeColor = SystemColors.ButtonHighlight;
        }

        private void ctrTransactionCards_Load(object sender, EventArgs e)
        {

        }

        private void ctrTransactionCards_Click(object sender, EventArgs e)
        {

            BtnClicked?.Invoke(this, EventArgs.Empty);

        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
