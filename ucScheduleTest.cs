using Busniss_Layer;
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
    public partial class ucScheduleTest : UserControl
    {




        public event EventHandler onSave;
        ClsTestAndAppointmentsBUS ExistingAppointment;
        private int _AppointmentID = 0;
        private int _TestTypeID = 0;
        private DateTime _AppointmentDate = DateTime.Now;
        private int _LocalDrivingLicenseApplicationID;
        private decimal _PaidFees;
        private bool _IsLocked;


        private int _Mode;
        // Mode = 1 for Add New Appointment
        // Mode = 2 for Edit Existing Appointment
        // Mode = 3 for View Appointment Details (Read-Only)




        public string BtnTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }


        public ucScheduleTest(int LDLAID, int TestTypeID)
        {
            _LocalDrivingLicenseApplicationID = LDLAID;
            _TestTypeID = TestTypeID;
            _Mode = 1;
            InitializeComponent();
            LoadData();
            lblDate.Visible = false;
        }


        public void HideHeaders()
        {
            panel1.Visible = false;
            pb1.Visible = false;
            pb2.Visible = false;
            lblTitle.Visible = false;
        }

        public ucScheduleTest(int AppointmentID , int Mode , bool flag)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _Mode = Mode;
            ExistingAppointment = ClsTestAndAppointmentsBUS.FindAppointmentByID(AppointmentID);
            _LocalDrivingLicenseApplicationID = ExistingAppointment._LocalDrivingLicenseApplicationID;
            _TestTypeID = ExistingAppointment._TestTypeID;
            _AppointmentDate = ExistingAppointment._AppointmentDate;
            LoadData();
        }

        public ucScheduleTest()
        {
            InitializeComponent();
        }

        public string GetTestTypeByID(int testTypeID)
        {

            switch (testTypeID)
            {

                case 1:
                    pb1.Image  = Properties.Resources.eye_open;
                    pb2.Image = pb1.Image;
                    return "Vision Test";                    
                case 2:
                    pb1.Image = Properties.Resources.exam;
                    pb2.Image = pb1.Image;
                    return "Written Test";
                case 3:
                    pb1.Image = Properties.Resources.car;
                    pb2.Image = pb1.Image;
                    return "Road Test";
                default:
                    return "Unknown Test Type";



            }


        }

        private void LoadData()
        {
            ClsLocalApplicationInfo localApplicationInfo = ClsLocalApplicationInfo.GetApplicationInfo(_LocalDrivingLicenseApplicationID);
            lblDLAID.Text = _LocalDrivingLicenseApplicationID.ToString();
            lblClassName.Text = localApplicationInfo._ClassName;
            _PaidFees = ClsTestAndAppointmentsBUS.GetFeesByTestType(_TestTypeID);
            lblFees.Text = _PaidFees.ToString("C");
            lblApplicant.Text = localApplicationInfo._FullName;
            lblTrials.Text = ClsTestAndAppointmentsBUS.GetNumberOfTestTrials(_TestTypeID, _LocalDrivingLicenseApplicationID).ToString();
           lblTitle.Text = "Schedule " + GetTestTypeByID(_TestTypeID);

            switch (_Mode) { 
            
                     case 1:
                    dtpDate.Enabled = true;
                    btnSave.Enabled = true;
                    lblDate.Visible = false;
                    break;

                   case 2:
                    dtpDate.Value = ExistingAppointment._AppointmentDate;
                    btnSave.Enabled = true;
                    lblDate.Visible = false;
                    break;

                    case 3:
                    dtpDate.Visible = false;
                    btnSave.Visible = false;
                    lblDate.Visible = true;
                    lblDate.Text = ExistingAppointment._AppointmentDate.ToString();
                    lblDate.BringToFront();
                    break;

            }


        }
        private void ucScheduleTest_Load(object sender, EventArgs e)
        {

        }


        private void AddNewAppointment()
        {
            ClsTestAndAppointmentsBUS Nwppointment = new ClsTestAndAppointmentsBUS();

            Nwppointment._TestTypeID = _TestTypeID;
            Nwppointment._LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            Nwppointment._AppointmentDate = _AppointmentDate;
            Nwppointment._PaidFees = _PaidFees;
            Nwppointment._CreatedByUserID = ClsGlobal._CurruntUser.ID;
            Nwppointment._IsLocked = _IsLocked;
            Nwppointment.Save();
        }

        private void UpdateExistingAppointment()
        {
            ClsTestAndAppointmentsBUS ExistingAppointment = ClsTestAndAppointmentsBUS.FindAppointmentByID(_AppointmentID);
            if (ExistingAppointment != null)
            {
                ExistingAppointment._AppointmentDate = _AppointmentDate;
                ExistingAppointment.Save();
            }
            else
            {
                MessageBox.Show("Error: Appointment not found.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           switch (_Mode)
            {
                case 1:
                    AddNewAppointment();
                    break;
                case 2:
                    UpdateExistingAppointment();
                    break;
            }


            
            onSave?.Invoke(this, EventArgs.Empty);

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            _AppointmentDate = dtpDate.Value;
        }

        private void btnSave_Load(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
