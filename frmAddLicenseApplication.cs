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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Security.Cryptography;


namespace DVLD_Project
{
    public partial class frmAddLicenseApplication : Form
    {
        




        ShowDetails showDetails = new ShowDetails();

        private int _ID;
        AddLocalLicenseSecondPage AddLocalLicenseSecondPage = new AddLocalLicenseSecondPage();

        private void AttachClickEvent(Control parent ,bool WithCildern)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl == pbClose || ctrl is UcBtn)
                   continue;

                ctrl.MouseDown += (s, e) =>
                {
                    ReleaseCapture();
                    SendMessage(this.FindForm().Handle, 0x112, 0xf012, 0);
                };

                if (WithCildern)
                {

                    if (ctrl.HasChildren)
                    {

                        AttachClickEvent(ctrl , true);
                    }
                }

            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

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

        public frmAddLicenseApplication()
        {
            InitializeComponent();
            MakeFormRounded();
            pbClose.BringToFront();
            pbClose.Location = new Point(this.ClientSize.Width - pbClose.Width - 10, 10);
            AttachClickEvent(showDetails, true);
            ucBtnSave.Visible = false;
            personSearchBar1.BtnClicked += AddPersonData;
            panel1.Controls.Add(showDetails);
            showDetails.Location = new Point(0, 85);
            showDetails.BringToFront();
            ucBtnNext.Enabled = false;
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
           
        }

        public void AddPersonData(int ID)
        {

            showDetails.LoadData(ID);
            _ID = ID;   
            ucBtnNext.Enabled = true;




        }



        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void showDetails1_Load(object sender, EventArgs e)
        {

        }

        private void ucBtnCancel_Load(object sender, EventArgs e)
        {

        }

        private void ucBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucBtnNext_Click(object sender, EventArgs e)
        {
            AddLocalLicenseSecondPage = new AddLocalLicenseSecondPage(_ID);
            panel1.Controls.Add(AddLocalLicenseSecondPage);
            AddLocalLicenseSecondPage.Dock = DockStyle.Fill;
            AddLocalLicenseSecondPage.BringToFront();
            ucBtnCancel.Location = new Point(483, 465);
            ucBtnNext.SendToBack();
            ucBtnSave.Visible = true;


        }

        private void personSearchBar1_Load(object sender, EventArgs e)
        {

        }

        private void ucBtnSave_Click(object sender, EventArgs e)
        {
            AddLocalLicenseSecondPage.AddApplication();
            MessageBox.Show("Application Added Succsessfully! ", "Congrats", MessageBoxButtons.OK);
            this.Close();
        }

        private void ucBtnBack_Click(object sender, EventArgs e)
        {
            AddLocalLicenseSecondPage.SendToBack();
            ucBtnCancel.BringToFront();
            ucBtnCancel.Location = new Point(633, 465);
            ucBtnNext.BringToFront();
            ucBtnSave.Visible = false;



        }

        private void frmAddNewUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
