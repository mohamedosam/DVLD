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
    public partial class ManageApplicationsUI : UserControl
    {
        public event EventHandler<string> InternalBtnPressed;


        public ManageApplicationsUI()
        {
            InitializeComponent();
            ctrbtnMangeLLA.BtnClicked += SendEventToMain;
            ctrbtnMangeILA.BtnClicked += SendEventToMain;

            ctrbtnMangeLLA.ButtonID = "Page5";
            ctrbtnMangeILA.ButtonID = "Page5";
        }

        public void SendEventToMain(object sender, EventArgs e)
        {

            var btn = sender as ctrTransactionCards;
            InternalBtnPressed?.Invoke(this, btn.ButtonID);

        }

        private void ManageApplicationsUI_Load(object sender, EventArgs e)
        {

        }

        private void ctrTransactionCards1_Click(object sender, EventArgs e)
        {

        }
    }
}
