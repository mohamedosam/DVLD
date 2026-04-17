using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busniss_Layer;

namespace DVLD_Project
{
    public partial class ChangePassword : UserControl
    {


        ClsUser _CurrentUser = new ClsUser();
        public ChangePassword(ClsUser user)
        {
            _CurrentUser = user;
            InitializeComponent();
        }
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text != _CurrentUser.Password)
            {
                errorProvider.SetError(txtCurrentPassword, "Password is incorrect!");


            }
            else 
            {
                errorProvider.SetError(txtCurrentPassword, "");

            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                errorProvider.SetError(txtConfirmPassword, "Password dons't match!");


            }
            else
            {
                errorProvider.SetError(txtConfirmPassword, "");

            }
        }

        private void ucBtnSave_Click(object sender, EventArgs e)
        {
            if (errorProvider.GetError(txtConfirmPassword) == string.Empty && errorProvider.GetError(txtCurrentPassword) == string.Empty)
            {

                _CurrentUser.UpdatePassword(txtNewPassword.Text);
                MessageBox.Show("Password Changed Successfully", "Congrats!", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("invalid fields input", "Error!", MessageBoxButtons.OK);
            }
        }
    }
}
