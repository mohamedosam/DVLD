using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Busniss_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_Project.Pages
{
    public partial class LocalDriverLicenseApplicationsUI : UserControl
    {


        string CurrntSelectedCb = "None";


        DataTable _DataSource = ClsApplication.GetLocalDriverLicenseApplications();

        public LocalDriverLicenseApplicationsUI()
        {
            InitializeComponent();
            dataGridView1.DataSource = _DataSource;
            SearchCb.SelectedIndex = 0;




        }

        private void Refesh()
        {
            _DataSource = ClsApplication.GetLocalDriverLicenseApplications();
            dataGridView1.DataSource = _DataSource;
        }

        

        private void CheckIfTestsCompleted()
        {
            int selectedApplicationID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            ClsLocalApplicationInfo clsLApplicationsData = ClsLocalApplicationInfo.GetApplicationInfo(selectedApplicationID);
            if (clsLApplicationsData._PassedTestCount == 0)
            {
                scVision.Enabled = true;
                scWritten.Enabled = false;
                scRoad.Enabled = false;
            }
            else if (clsLApplicationsData._PassedTestCount == 1)
            {
                scVision.Enabled = false;
                scWritten.Enabled = true;
                scRoad.Enabled = false;
            }
            else if (clsLApplicationsData._PassedTestCount == 2)
            {
                scVision.Enabled = false;
                scWritten.Enabled = false;
                scRoad.Enabled = true;
            }
            else
                {
                    scVision.Enabled = false;
                    scWritten.Enabled = false;
                    scRoad.Enabled = false;
            }
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
                    CurrntSelectedCb = "LocalDrivingLicenseApplicationID";
                    SearchTxt.Visible = true;
                    break;
                case 2:
                    CurrntSelectedCb = "ClassName";
                    SearchTxt.Visible = true;
                    break;
                case 3:
                    CurrntSelectedCb = "NationalNo";
                    SearchTxt.Visible = true;
                    break;
                case 4:
                    CurrntSelectedCb = "FullName";
                    SearchTxt.Visible = true;
                    break;

                case 5:
                    CurrntSelectedCb = "ApplicationDate";
                    SearchTxt.Visible = true;
                    break;
                case 6:
                    CurrntSelectedCb = "PassedTestCount";
                    SearchTxt.Visible = true;
                    break;
                case 7:
                    CurrntSelectedCb = "Status";
                    SearchTxt.Visible = true;
                    break;
                default:
                    CurrntSelectedCb = "None";
                    SearchTxt.Visible = true;
                    break;

            }
        }


        private void pbAddApplication_Click(object sender, EventArgs e)
        {
            frmAddLicenseApplication app = new frmAddLicenseApplication();
            app.ShowDialog();
            Refesh();
        }

        private void TSMshowappdetails_Click(object sender, EventArgs e)
        {
            int SelectedUserID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmLocalDLApplicationinfo frmLocalDLApplicationinfo = new frmLocalDLApplicationinfo(SelectedUserID);
            frmLocalDLApplicationinfo.ShowDialog();
        }

        private void scVision_Click(object sender, EventArgs e)
        {
           frmAppointment frmAppointment = new frmAppointment((int)dataGridView1.CurrentRow.Cells[0].Value, 1);
            frmAppointment.ShowDialog();
            Refesh();

        }

        private void LocalDriverLicenseApplicationsUI_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CMSPeople_Opening(object sender, CancelEventArgs e)
        {
            CheckIfTestsCompleted();
        }

        private void scWritten_Click(object sender, EventArgs e)
        {
            frmAppointment frmAppointment = new frmAppointment((int)dataGridView1.CurrentRow.Cells[0].Value, 2);
            frmAppointment.ShowDialog();
            Refesh();

        }

        private void scRoad_Click(object sender, EventArgs e)
        {
            frmAppointment frmAppointment = new frmAppointment((int)dataGridView1.CurrentRow.Cells[0].Value, 3);
            frmAppointment.ShowDialog();
            Refesh();

        }
    }
}
