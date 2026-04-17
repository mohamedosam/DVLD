using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Project
{
    public partial class UcBtn : UserControl
    {
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
        public UcBtn()
        {
            InitializeComponent();
            AttachClickEvent(this);
        }
        public System.Drawing.Image BtnImage
        {
            get { return pbImage.Image; }
            set { pbImage.Image = value; }
        }
        public string BtnTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        private void UcBtn_Load(object sender, EventArgs e)
        {

        }

        private void UcBtn_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(225, 217, 188);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
        }

        private void UcBtn_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(172, 186, 196);
            lblTitle.ForeColor = SystemColors.ControlText;
        }
    }
}
