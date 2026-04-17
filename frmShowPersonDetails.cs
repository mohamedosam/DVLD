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
    public partial class frmShowPersonDetails : Form
    {
        private int _CurrentPersonID;
        public frmShowPersonDetails(int ID)
        {

            _CurrentPersonID = ID;

            InitializeComponent();
            
            ShowDetails showDetails = new ShowDetails();
            showDetails.LoadData(ID);
            showDetails.Location = new Point(3, 72);
            this.Controls.Add(showDetails);
            

        }
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


        private void ShowPersonDetails_Load(object sender, EventArgs e)
        {
            AttachClickEvent(this);
            MakeFormRounded();
            pbClose.Location = new Point(this.ClientSize.Width - pbClose.Width - 10, 10);
        }



        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
