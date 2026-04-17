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
    public partial class UserMangmentUI : UserControl
    {

        string CurrntSelectedCb = "None";

        public UserMangmentUI()
        {
            InitializeComponent();
            SearchCb.SelectedIndex = 0;
        }


        DataTable _DataSource = ClsUser.GetListUsers();

        private void UserMangmentUI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _DataSource;
        }
        public void Refresh()
        {

            _DataSource = ClsUser.GetListUsers();
            dataGridView1.DataSource = _DataSource;

        }


        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {

            DataView dv = _DataSource.DefaultView;


            if (string.IsNullOrWhiteSpace(SearchTxt.Text))
            {

                dv.RowFilter = "";
                return;

            }


            Type columnType = _DataSource.Columns[CurrntSelectedCb].DataType;

            if (columnType == typeof(int))
            {

                if (int.TryParse(SearchTxt.Text, out int value))
                {

                    dv.RowFilter = $"{CurrntSelectedCb} = {value}";

                }
                else
                {

                    dv.RowFilter = $" 1 = 0";

                }

            }
            else if (columnType == typeof(string))
            {

                dv.RowFilter = $"{CurrntSelectedCb} Like '%{SearchTxt.Text}%'";

            }
            else
            {

                dv.RowFilter = $" 1 = 0";


            }



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
                    CurrntSelectedCb = "UserID";
                    SearchTxt.Visible = true;
                    break;
                case 2:
                    CurrntSelectedCb = "PersonID";
                    SearchTxt.Visible = true;
                    break;
                case 3:
                    CurrntSelectedCb = "UserName";
                    SearchTxt.Visible = true;
                    break;
                case 4:
                    CurrntSelectedCb = "IsActive";
                    SearchTxt.Visible = true;
                    break;

                default:
                    CurrntSelectedCb = "None";
                    SearchTxt.Visible = true;
                    break;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser();

            frmAddNewUser.ShowDialog();
            Refresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int SelectedUserID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmShowUserDetails frmShowUser = new frmShowUserDetails(SelectedUserID);
            frmShowUser.ShowDialog();

        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frmAddNewPerson = new frmAddNewPerson();
            frmAddNewPerson.ShowDialog();
            Refresh();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int SelectedUserID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete this User?", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                ClsUser.DeleteUser(SelectedUserID);
                Refresh();

            };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
