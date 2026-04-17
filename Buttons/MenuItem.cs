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
    public partial class CtrlMenuItem : UserControl
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
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public System.Drawing.Image CardImage
        {
            get { return pbImage.Image; }
            set { pbImage.Image = value; }
        }

        public CtrlMenuItem()
        {
            InitializeComponent();
            AttachClickEvent(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem_Load(object sender, EventArgs e)
        {

        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(48, 54, 79);
            lblTitle.ForeColor = Color.FromArgb(225, 217, 188);

        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(172, 186, 196);
            lblTitle.ForeColor = SystemColors.ControlText;


        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
