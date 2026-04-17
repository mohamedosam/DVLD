using Busniss_Layer;
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
    public partial class frmTakeTestcs : Form
    {

       private int _AppointmentID;
        private bool _Result;
       private string _Notes;  

        private void AttachClickEvent(Control parent, bool WithCildern)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == pbClose || ctrl is UcBtn || ctrl == rbFail || ctrl == rbPass)
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

        public frmTakeTestcs(int AppointmentID)
        {

            _AppointmentID = AppointmentID;
            InitializeComponent();
            pbClose.BringToFront();
            pbClose.Location = new Point(this.ClientSize.Width - pbClose.Width - 10, 10);
            MakeFormRounded();
            AttachClickEvent(this, true);
            ucScheduleTest scheduleTest = new ucScheduleTest(AppointmentID, 3, true);
            scheduleTest.HideHeaders();
            scheduleTest.Location = new Point(-5, -22);
            scheduleTest.Size = new Size (452, 481);
            this.Controls.Add(scheduleTest);


        }

        private void frmTakeTestcs_Load(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPass.Checked == true) 
            {
                _Result = true;
            }

        }

        private void rbFail_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFail.Checked == true)
            {
                _Result = false;
            }
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            _Notes = txtNotes.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int UserID = ClsGlobal._CurruntUser.ID;

            ClsTestAndAppointmentsBUS.TakeTest(_AppointmentID , _Result, UserID, _Notes);
            ClsTestAndAppointmentsBUS app = ClsTestAndAppointmentsBUS.FindAppointmentByID(_AppointmentID);
            app._IsLocked = true;
            app.Save();
            this.Close();

        }

        private void ucScheduleTest1_Load(object sender, EventArgs e)
        {

        }
    }

}
