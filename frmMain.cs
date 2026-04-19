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
using Busniss_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace DVLD_Project
{
    public partial class frmMain : Form
    {

        public delegate void MyDelegate();
        public event MyDelegate SignOutPressed;

        bool closemark = false;

        ClsUser _CurrentUser ;
        frmSettingMenu frmSettingMenu1 ;

        private void AttachClickEvent(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == pbClose) {
                    continue;
                }
                ctrl.MouseDown += (s, e) =>
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                };


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




        public frmMain(ClsUser user)
        {
            InitializeComponent();
            _CurrentUser = user;
            ClsGlobal._CurruntUser = user;
            MakeFormRounded();
            AttachClickEvent(panel2);
            ctrApplication1.BtnPressed += PageDesider;
            addApplicationUI.InternalBtnPressed += PageDesider;
            driverLicensesServicesUI1.BtnPressed += PageDesider;
            manageApplicationsUI1.InternalBtnPressed += PageDesider;
            lblUsername.Text = user.UserName;


            panel2.Controls.Remove(pbClose);
            this.Controls.Add(pbClose);
            pbClose.BringToFront();
            pbClose.Location = new Point(this.ClientSize.Width - pbClose.Width - 10, 10);
            defultUI1.BringToFront();

        }
        public frmMain()
        {
            InitializeComponent();


        }

        private void  PageDesider(object sender, string buttonID)
        {
            var current = sender as ctrApplication;

            if (current != null) {

                current.Visible = false;

            }

            switch (buttonID) {

                case "Page1":
                    driverLicensesServicesUI1.Visible = true;
                    driverLicensesServicesUI1.BringToFront();
                    break;
                case "Page2":
                    manageApplicationsUI1.Visible = true;
                    manageApplicationsUI1.BringToFront();
                    break ;
                case "Page3":
                    detainLicenseUI1.Visible = true;
                    detainLicenseUI1.BringToFront();
                    break;
                case "Page4":
                    addApplicationUI.Visible = true;
                    addApplicationUI.BringToFront();
                    break;
                case "Page5":
                    localDriverLicenseApplicationsUI.Visible = true;
                    localDriverLicenseApplicationsUI.BringToFront();
                    break;
                case "frm1":
                    frmAddLicenseApplication frmAddLicense = new frmAddLicenseApplication();
                    frmAddLicense.ShowDialog();
                    break;


            }



        }


        private void SignOut()
        {
            SignOutPressed?.Invoke();
            this.Close();   
          

        }


        private void ctrApplication1_Load(object sender, EventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            ctrApplication1.Visible = true;
            ctrApplication1.BringToFront();
        }

        private void menuItem2_Load(object sender, EventArgs e)
        {
            
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            peopleManagmentUI1.Visible = true;
            peopleManagmentUI1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            userMangmentUI1.Visible = true;
            userMangmentUI1.BringToFront();
        }

        private void manageApplicationsUI1_Load(object sender, EventArgs e)
        {

        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            frmSettingMenu1 = new frmSettingMenu(_CurrentUser);
            frmSettingMenu1.Signedout += SignOut;
            frmSettingMenu1.ShowDialog();

        }

        private void pbSettings_MouseEnter(object sender, EventArgs e)
        {
            pbSettings.BackColor = Color.FromArgb(48, 54, 79);
        }

        private void pbSettings_MouseLeave(object sender, EventArgs e)
        {
            pbSettings.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void addApplicationUI_Load(object sender, EventArgs e)
        {

        }

        private void localDriverLicenseApplicationsUI_Load(object sender, EventArgs e)
        {

        }

        private void menuItem1_Load(object sender, EventArgs e)
        {

        }
    }
}
