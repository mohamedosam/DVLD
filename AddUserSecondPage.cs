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
    public partial class AddUserSecondPage : UserControl
    {
        private int _ID;
        bool Error = false;




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

        public AddUserSecondPage(int ID)
        {

            _ID = ID;
            InitializeComponent();

            
        }
        public AddUserSecondPage()
        {

            InitializeComponent();

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text) {

                errorProvider1.SetError(txtConfirmPassword , "Password doesn't match");
                Error = true;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword,"");
                Error = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (ClsUser.IsUserExist(txtUsername.Text))
            {

                errorProvider1.SetError(txtUsername, "Username already exist");
                Error = true;

            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
                Error = false;
            }
        }

        private void AddUserSecondPage_Load(object sender, EventArgs e)
        {

        }

        public void AddUser()
        {
            if (Error != true)
            {
                ClsUser user = new ClsUser();

                user.PersonID = _ID;
                user.UserName = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.IsActive = cbIsActive.Checked;
                user.Save();

            }
            else {

                MessageBox.Show("Some fields have invalid values" ,"Alert!",MessageBoxButtons.OK);
            
            }

        }

        private void AddUserSecondPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.FindForm().Handle, 0x112, 0xf012, 0);
        }
    }
}
