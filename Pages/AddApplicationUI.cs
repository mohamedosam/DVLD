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
    public partial class AddApplicationUI : UserControl
    {

        public event EventHandler<string> InternalBtnPressed;

        public AddApplicationUI()
        {
            InitializeComponent();


            ctrTransactionCardsAddInternationakLicense.BtnClicked += SendEventToMain;
            ctrTransactionCardsAddLocalLicense.BtnClicked += SendEventToMain;

            ctrTransactionCardsAddLocalLicense.ButtonID = "frm1";
            ctrTransactionCardsAddInternationakLicense.ButtonID = "frm2";
        }


        public void SendEventToMain(object sender, EventArgs e)
        {

            var btn = sender as ctrTransactionCards;
            InternalBtnPressed?.Invoke(this, btn.ButtonID);

        }


        private void ctrTransactionCardsAddLocalLicense_Click(object sender, EventArgs e)
        {

        }
    }
}
