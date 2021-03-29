using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAS5206_GRP1_MVCH
{
    public partial class frmMVCHReport : Form
    {
        public frmMVCHReport()
        {
            InitializeComponent();
        }

        //Data object declarations
        //DataSet Object
        private MVCHDBDataSet roomDataSet;
        //table adapter objects
        private MVCHDBDataSetTableAdapters.tblAdmissionsTableAdapter admissionsTable;
        private MVCHDBDataSetTableAdapters.tblHospitalTableAdapter hospitalTable;
        private MVCHDBDataSetTableAdapters.tblPatientTableAdapter tblPatients;
        


        private void Form1_Load(object sender, EventArgs e)
        {
            RoomUtilization aRoomUtilization;
            aRoomUtilization = new RoomUtilization();

            try
            {
                //instantiate the dataset and table adapters
                roomDataSet = new MVCHDBDataSet();
                admissionsTable = new MVCHDBDataSetTableAdapters.tblAdmissionsTableAdapter();
                hospitalTable = new MVCHDBDataSetTableAdapters.tblHospitalTableAdapter();
                tblPatients = new MVCHDBDataSetTableAdapters.tblPatientTableAdapter();


                //fill the dataset via the two table adapters
                //fill with customers
                admissionsTable.Fill(roomDataSet.tblAdmissions);
                hospitalTable.Fill(roomDataSet.tblHospital);
                tblPatients.Fill(roomDataSet.tblPatient);

                //assign the filled dataset as the datasource for the report
                aRoomUtilization.SetDataSource(roomDataSet);

                //set up the report viewer object on the form to show the runtime report object
                roomUtilizationViewer.ReportSource = aRoomUtilization;
            }
            catch (Exception dataException)
            {
                //catch any exception thrown during instantiation
                MessageBox.Show("Data Error Encountered: " + dataException.Message);
            }




        }
    }
}
