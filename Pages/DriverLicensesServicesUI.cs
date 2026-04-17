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
    public partial class DriverLicensesServicesUI : UserControl
    {

        public event EventHandler<string> BtnPressed;

        public DriverLicensesServicesUI()
        {


            InitializeComponent();
            ctrTransactionCardsNDL.BtnClicked += SendToMain;
            ctrTransactionCardsNDL.ButtonID = "Page4";

        }


        public void SendToMain(object sender, EventArgs e)
        {

            var btn = sender as ctrTransactionCards;

            BtnPressed?.Invoke(this, btn.ButtonID);
        }


        private void ctrTransactionCards1_Click(object sender, EventArgs e)
        {

        }

        private void ctrTransactionCards1_Load(object sender, EventArgs e)
        {

        }

        private void DriverLicensesServicesUI_Load(object sender, EventArgs e)
        {

        }
    }
}
