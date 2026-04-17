using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busniss_Layer;

namespace DVLD_Project
{
    public partial class frmLogin : Form
    {


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
        public frmLogin()
        {
            InitializeComponent();
            

        }
        private void signOut()
        {

            this.Show();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            MakeFormRounded();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ClsUser User = ClsUser.Find(Convert.ToString(txtUsername.Text));


            if (User != null)
            {
                if (User.Password == Convert.ToString(txtPassword.Text))
                {

                    this.Hide();
                    frmMain Main = new frmMain(User);
                    Main.SignOutPressed += signOut;




                   
                    Main.ShowDialog();
                    this.Show();




                }

                else
                {

                    MessageBox.Show("Wrong Username Or Password");

                }
            }
            else
            {

                MessageBox.Show("Wrong Username Or Password");


            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
