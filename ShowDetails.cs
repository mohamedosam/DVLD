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
    public partial class ShowDetails : UserControl
    {


        private ClsPerson _CurruntPerson;




        public ShowDetails()
        {
            InitializeComponent();
           


        }

        public void LoadData(int ID)
        {

            _CurruntPerson = ClsPerson.Find(ID);

            lblFirstName.Text = _CurruntPerson.FirstName;
            lblSecondName.Text = _CurruntPerson.SecondName;
            lblThirdName.Text = _CurruntPerson.ThirdName;
            lblLastName.Text = _CurruntPerson.LastName;
            lblID.Text = _CurruntPerson.ID.ToString();
            lblEmail.Text = _CurruntPerson.Email;
            lblPhone.Text = _CurruntPerson.Phone;

            if (_CurruntPerson.Gender == false)
            {
               pbMale.Visible = true;
               pbFemale.Visible = false;
               pbMale.BringToFront();
               lblGender.Text = "Male";
            }
            else
            {
                pbMale.Visible = false;
                pbFemale.Visible = true;
                pbFemale.BringToFront();
                lblGender.Text = "Female";
            }

            lblAddress.Text = _CurruntPerson.Address;
            lblDateOfBirth.Text = _CurruntPerson.DateOfBirth.ToShortDateString();

            lblNationalNo.Text = _CurruntPerson.NationalNo;

            lblCountry.Text = ClsCountryBUS.GetCountryNameByID(_CurruntPerson.NationalityCountryID);

            pbImage.ImageLocation = _CurruntPerson.ImagePath;



        }
     
    }
}
