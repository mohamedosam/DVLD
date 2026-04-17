using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busniss_Layer;

namespace DVLD_Project
{
    public partial class frmSettingMenu : Form
    {

        public delegate void MyDelegate();

        public event MyDelegate Signedout; 

        ClsUser _CurrentUser ;
        ShowDetails showDetails = new ShowDetails();
        ChangePassword changePassword = new ChangePassword();
        UserLofinInfo userLofinInfo = new UserLofinInfo();


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


        public frmSettingMenu(ClsUser CurrentUser)
        {
            _CurrentUser = CurrentUser;
            InitializeComponent();
            AttachClickEvent(this);
            MakeFormRounded();
            DeployInfoControls();
        }
        public frmSettingMenu()
        {
            InitializeComponent();

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void taskMenuItem2_Load(object sender, EventArgs e)
        {

        }

        private void frmSettingMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmSettingMenu_Load(object sender, EventArgs e)
        {

        }


        private void DeployInfoControls()
        {
            userLofinInfo = new UserLofinInfo(_CurrentUser.ID);
            showDetails.LoadData(_CurrentUser.PersonID);
            showDetails.Location = new Point(0, 60);
            showDetails.Size = new Size(913, 321);
            userLofinInfo.Location = new Point(0, 400);
            showDetails.Visible = true;
            userLofinInfo.Visible = true;
            changePassword.Visible = false;
            showDetails.BringToFront();
            userLofinInfo.BringToFront();
            if (!this.Controls.Contains(showDetails))
                this.Controls.Add(showDetails);

            if (!this.Controls.Contains(userLofinInfo))
                this.Controls.Add(userLofinInfo);
        }
        private void tmAccountInfo_Click(object sender, EventArgs e)
        {


            DeployInfoControls();

        }



        private void tmChangePassword_Click_1(object sender, EventArgs e)
        {
            showDetails.Visible = false;
            userLofinInfo.Visible = false;
            changePassword = new ChangePassword(_CurrentUser);
            this.Controls.Add(changePassword);
            changePassword.Location = new Point(0, 60);
            changePassword.BringToFront();
        }

        private void TMsignout_Click(object sender, EventArgs e)
        {

            Signedout?.Invoke();
            this.Close();
            
        }
    }
}
