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
    public partial class ctrApplication : UserControl
    {


        public event EventHandler<string> BtnPressed;



        public ctrApplication()
        {
            InitializeComponent();
            ctrTransactionCardsDLS.BtnClicked += SendEventToMainForm;
            ctrTransactionCardsMA.BtnClicked += SendEventToMainForm;
            ctrTransactionCardsDL.BtnClicked += SendEventToMainForm;
            ctrTransactionCardsDLS.ButtonID = "Page1";
            ctrTransactionCardsMA.ButtonID = "Page2";
            ctrTransactionCardsDL.ButtonID = "Page3";


        }





        private void SendEventToMainForm(object sender, EventArgs e)
        {

            var btn = sender as ctrTransactionCards;
            BtnPressed?.Invoke(this, btn.ButtonID);

        }

        private void ctrApplication_Load(object sender, EventArgs e)
        {

        }

        private void ctrTransactionCardsDLS_Load(object sender, EventArgs e)
        {

        }

        private void ctrTransactionCardsDL_Load(object sender, EventArgs e)
        {

        }
    }
}
