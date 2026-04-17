using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Busniss_Layer;


namespace DVLD_Project
{
    public partial class PersonSearchBar : UserControl
    {

        string CurrntSelectedCb = "None";

       public  delegate void MyDelegate(int ID);


        public event MyDelegate BtnClicked;
        private void MakeFormRounded()
        {
            int radius = 15;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public PersonSearchBar()
        {
            InitializeComponent();
            MakeFormRounded();
            


        }

        public void InvokeViewDataFunction(int ID)
        {
            BtnClicked?.Invoke(ID);
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {

            int PersonID;
            if (CurrntSelectedCb == "PersonID")
            {
                PersonID = Convert.ToInt32(SearchTxt.Text);

            }
            else
            {
                PersonID = ClsPerson.SerachPersonByAnything(CurrntSelectedCb, SearchTxt.Text);
            }

            InvokeViewDataFunction(PersonID);



        }




        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frmAddNewPerson = new frmAddNewPerson();         
            frmAddNewPerson.BtnPressed += InvokeViewDataFunction;
            frmAddNewPerson.ShowDialog();


        }


        private void SearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SearchCb.SelectedIndex)
            {

                case 0:
                    CurrntSelectedCb = "None";
                    SearchTxt.Visible = false;
                    break;
                case 1:
                    CurrntSelectedCb = "PersonID";
                    SearchTxt.Visible = true;
                    break;
                case 2:
                    CurrntSelectedCb = "NationalNo";
                    SearchTxt.Visible = true;
                    break;
                case 3:
                    CurrntSelectedCb = "FirstName";
                    SearchTxt.Visible = true;
                    break;
                case 4:
                    CurrntSelectedCb = "SecondName";
                    SearchTxt.Visible = true;
                    break;
                case 5:
                    CurrntSelectedCb = "ThirdName";
                    SearchTxt.Visible = true;
                    break;
                case 6:
                    CurrntSelectedCb = "LastName";
                    SearchTxt.Visible = true;
                    break;
                case 7:
                    CurrntSelectedCb = "DateOfBirth";
                    SearchTxt.Visible = true;
                    break;
                case 8:
                    CurrntSelectedCb = "Gendor";
                    SearchTxt.Visible = true;
                    break;
                case 9:
                    CurrntSelectedCb = "Phone";
                    SearchTxt.Visible = true;
                    break;
                case 10:
                    CurrntSelectedCb = "Email";
                    SearchTxt.Visible = true;
                    break;
                case 11:
                    CurrntSelectedCb = "CountryName";
                    SearchTxt.Visible = true;
                    break;

                default:
                    CurrntSelectedCb = "None";
                    SearchTxt.Visible = true;
                    break;

            }
        }

        private void PersonSearchBar_Load(object sender, EventArgs e)
        {
            SearchCb.SelectedIndex = 0;
        }
    }
}
