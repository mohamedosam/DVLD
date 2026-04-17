using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busniss_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DVLD_Project
{
    public partial class AddLocalLicenseSecondPage : UserControl
    {
        private int _ID;
        bool Error = false;
        ClsApplication Application  = new ClsApplication();



        private void AttachClickEvent(Control parent, bool WithCildern)
        {
            foreach (Control ctrl in parent.Controls)
            {


                ctrl.MouseDown += (s, e) =>
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        public AddLocalLicenseSecondPage(int ID)
        {

            _ID = ID;
            InitializeComponent();
            LoadInitiatData();

        }
        public AddLocalLicenseSecondPage()
        {

            InitializeComponent();
            LoadInitiatData();
        }


        public void AddApplication()
        {

            Application.Save(); 

        }

        private void LoadInitiatData() {


            Application._ApplicationTypeID = 1;
            ComLicenseClass.SelectedIndex = 0;
            lblApplicationDate.Text = DateTime.Now.ToString();
            Application._ApplicationDate = DateTime.Now;
            Application._ApplicationStatus = 1;
            Application._ApplicantPersonID = _ID;
            Application._LastStatusDate = DateTime.Now;
            lblCreatedBy.Text = ClsGlobal._CurruntUser.UserName;
            Application._CreatedByUserID = ClsGlobal._CurruntUser.ID;

        }



        private void AddUserSecondPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.FindForm().Handle, 0x112, 0xf012, 0);
        }

        private void lblApplicationDate_Click(object sender, EventArgs e)
        {

        }

        private void ComLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {

               Application._LicenseClassID = ComLicenseClass.SelectedIndex +1;

               lblApplicationFee.Text = ClsApplication.GetLicenseClassFeesByID(Application._LicenseClassID).ToString("0.00");
               Application._PaidFees = Convert.ToDecimal( lblApplicationFee.Text);
        }

        private void AddLocalLicenseSecondPage_Load(object sender, EventArgs e)
        {

        }
    }
}
