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
    public partial class PeopleManagmentUI : UserControl
    {

        string CurrntSelectedCb = "None";


        DataTable _DataSource = ClsPerson.GetListPersons();


        public void Refresh()
        {

            _DataSource = ClsPerson.GetListPersons();
            dataGridView1.DataSource = _DataSource;

        }

        public PeopleManagmentUI()
        {
            InitializeComponent();
            SearchCb.SelectedIndex = 0;
            SearchTxt.Visible = false;
            Refresh();
        }



        private void PeopleManagmentUI_Load(object sender, EventArgs e)
        {

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
                    DataTable dt = new DataTable();
                    

                    dv.RowFilter = $"{CurrntSelectedCb} = {value}";

                }
                else {

                    dv.RowFilter = $" 1 = 0";
                
                }

            }
            else if (columnType == typeof(string)) {

                dv.RowFilter = $"{CurrntSelectedCb} Like '%{SearchTxt.Text}%'";

            }
            else
            {

                dv.RowFilter = $" 1 = 0";


            }



        }

        private void SearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SearchCb.SelectedIndex) {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAddNewPerson FrmAddNewPerson = new frmAddNewPerson();

            FrmAddNewPerson.ShowDialog();
            Refresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int SelectedPersonID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmShowPersonDetails frmShowPersonDetails = new frmShowPersonDetails(SelectedPersonID);
            frmShowPersonDetails.ShowDialog();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int SelectedPersonID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmAddNewPerson NewPerson = new frmAddNewPerson(SelectedPersonID);
            NewPerson.ShowDialog();
            Refresh();


        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
                frmAddNewPerson frmAddNewPerson = new frmAddNewPerson();
                frmAddNewPerson.ShowDialog();
                Refresh();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int SelectedPersonID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete this Person?", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes) {
             
                ClsPerson.DeletePerson(SelectedPersonID);
                Refresh();

            };
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
