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
    public partial class UserLofinInfo : UserControl
    {
        private int _UserID;
        public UserLofinInfo(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
            LoadData();
        }
        public UserLofinInfo()
        {
            InitializeComponent();

        }

        public void LoadData()
        {
            ClsUser User = new ClsUser();
            User = ClsUser.Find(_UserID);

            lblUserID.Text = User.ID.ToString();
            lblUsername.Text = User.UserName;
            if (User.IsActive)
            {
                lblIsActive.Text = "Yes";

            }
            else
            {
                lblIsActive.Text = "No";
            }


        }


        private void UserLofinInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
