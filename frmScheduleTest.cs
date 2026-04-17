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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DVLD_Project
{


    public partial class frmScheduleTest : Form
    {

        private void AttachClickEvent(Control parent, bool WithCildern)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == pbClose || ctrl is UcBtn)
                    continue;

                ctrl.MouseDown += (s, e) =>
                {
                    ReleaseCapture();
                    SendMessage(this.FindForm().Handle, 0x112, 0xf012, 0);
                };

                if (WithCildern)
                {

                    if (ctrl.HasChildren)
                    {

                        AttachClickEvent(ctrl, true);
                    }
                }

            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

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



        public frmScheduleTest(int LDLAID, int TestTypeID)
        {
            InitializeComponent();
            pbClose.BringToFront();
            pbClose.Location = new Point(this.ClientSize.Width - pbClose.Width - 10, 10);
            MakeFormRounded();
            AttachClickEvent(this, true);
            ucScheduleTest scheduleTest = new ucScheduleTest(LDLAID, TestTypeID);
            scheduleTest.Location = new Point(3, 94);
            this.Controls.Add(scheduleTest);
            scheduleTest.onSave += (s, e) =>
            {
                this.Close();
            };
        }
        public frmScheduleTest (int AppointmentID , int Mode , bool flag)
        {
            InitializeComponent();
            pbClose.BringToFront();
            pbClose.Location = new Point(this.ClientSize.Width - pbClose.Width - 10, 10);
            MakeFormRounded();
            AttachClickEvent(this, true);
            ucScheduleTest scheduleTest = new ucScheduleTest(AppointmentID, Mode, flag);
            scheduleTest.Location = new Point(3, 94);
            this.Controls.Add(scheduleTest);
            scheduleTest.onSave += (s, e) =>
            {
                this.Close();
            };



        }




        private void frmScheduleTest_Load(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
