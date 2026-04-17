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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DVLD_Project
{
    public partial class frmAppointment : Form
    {

        private int _LocalDrivingLicenseApplicationID;
        private int _TestTypeID;
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }


        private void AttachClickEvent(Control parent, bool WithCildern)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == pbClose || ctrl is UcBtn || ctrl == pbAddTestAppointment)
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


        private void RefreshAppointments()
        {
            dgvAppoinmentsTable.DataSource = ClsTestAndAppointmentsBUS.GetAppointmentOfApplicant(_LocalDrivingLicenseApplicationID, _TestTypeID);
        }   


        private void ChangeTitleByTestTypeID()
        {
            switch (_TestTypeID)
            {
                case 1:
                    lblTitle.Text = "Appointments for Vision Test";
                    break;
                case 2:
                    lblTitle.Text = "Appointments for Written Test";
                    break;
                case 3:
                    lblTitle.Text = "Appointments for Road Test";
                    break;
                default:
                    lblTitle.Text = "Appointments";
                    break;
            }
        }


        public frmAppointment(int LocalDrivingLicenseApplicationID , int TestTypeID)
        {
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestTypeID = TestTypeID;
            InitializeComponent();
            pbClose.BringToFront();
            pbClose.Location = new Point(this.ClientSize.Width - pbClose.Width - 10, 10);
            MakeFormRounded();
            AttachClickEvent(this, true);
            dgvAppoinmentsTable.DataSource = ClsTestAndAppointmentsBUS.GetAppointmentOfApplicant(LocalDrivingLicenseApplicationID, TestTypeID);
            UcApplicationDetails ApplicationDetails = new UcApplicationDetails(LocalDrivingLicenseApplicationID);
            ApplicationDetails.Location = new Point(-1, 109);
            this.Controls.Add(ApplicationDetails);
            pbAddTestAppointment.BringToFront();
            ChangeTitleByTestTypeID();

        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {

        }

        private void ucApplicationDetails1_Load(object sender, EventArgs e)
        {

        }



        private void dgvAppoinmentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAddTestAppointment_Click(object sender, EventArgs e)
        {

            frmScheduleTest scheduleTestForm = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestTypeID);
            scheduleTestForm.ShowDialog();
            RefreshAppointments();

        }

        private void scTakeTest_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvAppoinmentsTable.CurrentCell.RowIndex;
            int appointmentID = Convert.ToInt32(dgvAppoinmentsTable.Rows[selectedRowIndex].Cells["TestAppointmentID"].Value);
            frmTakeTestcs Test = new frmTakeTestcs(appointmentID);
            Test.ShowDialog();
            RefreshAppointments();
        }

        private void scEdit_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvAppoinmentsTable.CurrentCell.RowIndex;
            int appointmentID = Convert.ToInt32(dgvAppoinmentsTable.Rows[selectedRowIndex].Cells["TestAppointmentID"].Value);
            frmScheduleTest scheduleTestForm = new frmScheduleTest(appointmentID, 2 , true);
            scheduleTestForm.ShowDialog();
            RefreshAppointments();
        }

        private void checkIfTestLocked(){
        
            ClsTestAndAppointmentsBUS appointment = ClsTestAndAppointmentsBUS.FindAppointmentByID(Convert.ToInt32(dgvAppoinmentsTable.Rows[dgvAppoinmentsTable.CurrentCell.RowIndex].Cells["TestAppointmentID"].Value));
            if (appointment._IsLocked == true)
            {
                scEdit.Enabled = false;
                scTakeTest.Enabled = false;

            }
            else
            {
                scEdit.Enabled = true;
                scTakeTest.Enabled = true;

            }
        }

        private void CMSAppointment_Opening(object sender, CancelEventArgs e)
        {
            checkIfTestLocked();
        }
    }
}
