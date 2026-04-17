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
using System.Drawing.Drawing2D; 

namespace DVLD_Project
{
    public partial class frmAddNewPerson : Form
    {

        public delegate void MyDelegate(int ID);

        public event MyDelegate BtnPressed;


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

        ClsPerson CurrntPerson = new ClsPerson();
        public frmAddNewPerson()
        {
            InitializeComponent();



           
        }
        public frmAddNewPerson(int ID)
        {
            InitializeComponent();

            CurrntPerson = ClsPerson.Find(ID);

            LoadData();


        }

        public void LoadData()
        {
            txtFN.Text = CurrntPerson.FirstName;
            txtSN.Text = CurrntPerson.SecondName;
            txtTN.Text = CurrntPerson.ThirdName;
            txtLN.Text = CurrntPerson.LastName;

            txtMail.Text = CurrntPerson.Email;
            txtPhone.Text = CurrntPerson.Phone;

            if (CurrntPerson.Gender == false)
            {
                rbMale.Checked = true;
            }
            else
            {
                RbFemale.Checked = true;
            }

            txtAddress.Text = CurrntPerson.Address;
            dtDOB.Value = CurrntPerson.DateOfBirth;

            txtNN.Text = CurrntPerson.NationalNo;

            ComCountry.SelectedIndex = CurrntPerson.NationalityCountryID;

            pbImage.ImageLocation = CurrntPerson.ImagePath;

            lblTitle.Text = "Edit Person";
            ucBtnConfirm.BtnTitle = "Save";
      

        }
        public void SaveData()
        {

            CurrntPerson.FirstName = txtFN.Text;
            CurrntPerson.SecondName = txtSN.Text;
            CurrntPerson.ThirdName = txtTN.Text;
            CurrntPerson.LastName = txtLN.Text;
            CurrntPerson.Email = txtMail.Text;
            CurrntPerson.Phone = txtPhone.Text;
            if (rbMale.Checked)
            {
                CurrntPerson.Gender = false;
            }
            else
            {
                CurrntPerson.Gender = true;
            }
            CurrntPerson.Address = txtAddress.Text;
            CurrntPerson.DateOfBirth = dtDOB.Value;
            CurrntPerson.NationalNo = txtNN.Text;
            CurrntPerson.NationalityCountryID = ComCountry.SelectedIndex;


            CurrntPerson.ImagePath = pbImage.ImageLocation;

            CurrntPerson.Save();

        }



        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            MakeFormRounded();
            rbMale.Checked = true;
        }



        private void ucBtnConfirm_Click(object sender, EventArgs e)
        {
            SaveData();

            int PersonID = ClsPerson.SerachPersonByAnything("NationalNo", CurrntPerson.NationalNo);




            BtnPressed?.Invoke(PersonID);
            this.Close();

        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Title = "Select Profile Image.";
            OFD.Filter = "Image Files|*.jpg;*.jpeg;*.png;";


            if (OFD.ShowDialog() == DialogResult.OK)
            {

                pbImage.ImageLocation = OFD.FileName;

            }
            llRemove.Visible = true;
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.Image = Properties.Resources.Image;
            llRemove.Visible = false;
        }

        private void frmAddNewPerson_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNN_TextChanged(object sender, EventArgs e)
        {
            if(ClsPerson.IsNationalNoExist(txtNN.Text))
            {

                if (CurrntPerson.Mode != ClsPerson.enMode.UpdateMode || CurrntPerson.NationalNo != txtNN.Text) {


                    errorProvider1 = new ErrorProvider();
                    errorProvider1.SetError(txtNN, "A Person With This National No Already Exist");
                    ucBtnConfirm.Enabled = false;

                }


            }
            else
            {

                errorProvider1.Clear();
                ucBtnConfirm.Enabled = true;

            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucBtnConfirm_Load(object sender, EventArgs e)
        {

        }

        private void ucBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
