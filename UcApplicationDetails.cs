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

namespace DVLD_Project
{
    public partial class UcApplicationDetails : UserControl
    {


        private int _LDLAID;
        public UcApplicationDetails(int LDLAID)
        {

            _LDLAID = LDLAID;

            InitializeComponent();
            LoadDataintoForm();
        }
        public UcApplicationDetails()
        {

            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }


        private void LoadDataintoForm()
        {

            ClsLocalApplicationInfo applicationInfo = ClsLocalApplicationInfo.GetApplicationInfo(_LDLAID);
            if (applicationInfo != null && applicationInfo._LocalDrivingLicenseApplicationID != 0)
            {


                lblAppID.Text = applicationInfo._ApplicationID.ToString();
                lblClassName.Text = applicationInfo._ClassName;
                lblDLAID.Text = applicationInfo._LocalDrivingLicenseApplicationID.ToString();
                lblFees.Text = applicationInfo._ClassFees.ToString();
                lblApplicationType.Text = applicationInfo._ApplicationTypeTitle;
                lblApplicant.Text = applicationInfo._FullName;
                lblStatus.Text = applicationInfo._Status;
                lblPassedTestCount.Text = applicationInfo._PassedTestCount.ToString() + "/3";
                lblUsername.Text = applicationInfo._UserName.ToString();
                lblStatusDate.Text = applicationInfo._LastStatusDate.ToString();

            }




        }

        private void UcApplicationDetails_Load(object sender, EventArgs e)
        {



        }

        private void lblPassedTestCount_Click(object sender, EventArgs e)
        {

        }
    }
}
