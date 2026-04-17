using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmLocalDLApplicationinfo : Form
    {




        private void AttachClickEvent(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == pbClose)
                {
                    continue;
                }
                ctrl.MouseDown += (s, e) =>
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                };
                if (ctrl.HasChildren)
                {
                    AttachClickEvent(ctrl);

                }


            }
        }

        private void MakeFormRounded()
        {
            int radius = 30;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);



        private int _LDLAID;
        public frmLocalDLApplicationinfo(int LDLAID)
        {
            _LDLAID = LDLAID;
            LoadData();
            InitializeComponent();

        }


       private void LoadData()
        {
           UcApplicationDetails ucApplicationDetails = new UcApplicationDetails(_LDLAID);
            ucApplicationDetails.Location = new Point(12, 98);
            this.Controls.Add(ucApplicationDetails);

        }
        private void frmLocalDLApplicationinfo_Load(object sender, EventArgs e)
        {
            AttachClickEvent(this);
            MakeFormRounded();
            pbClose.Location = new Point(this.ClientSize.Width - pbClose.Width - 10, 10);
        }

        private void ucApplicationDetails1_Load(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
