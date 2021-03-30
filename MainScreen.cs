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
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        //Data object declarations
        //DataSet Object
        private MVCHDBDataSet hospitalDataSet;
        //table adapter objects
        private MVCHDBDataSetTableAdapters.tblAdmissionsTableAdapter admissionsTable;
        private MVCHDBDataSetTableAdapters.tblHospitalTableAdapter hospitalTable;
        private MVCHDBDataSetTableAdapters.tblPatientTableAdapter tblPatients;
        private MVCHDBDataSetTableAdapters.tblPhysicianTableAdapter tblPhysician;
        

        private void btnRmUtilRprt_Click(object sender, EventArgs e)
        {
            RoomUtilization aRoomUtilization;
            aRoomUtilization = new RoomUtilization();

            try
            {
                //instantiate the dataset and table adapters
                hospitalDataSet = new MVCHDBDataSet();
                admissionsTable = new MVCHDBDataSetTableAdapters.tblAdmissionsTableAdapter();
                hospitalTable = new MVCHDBDataSetTableAdapters.tblHospitalTableAdapter();
                tblPatients = new MVCHDBDataSetTableAdapters.tblPatientTableAdapter();


                //fill the dataset via the two table adapters
                //fill with customers
                admissionsTable.Fill(hospitalDataSet.tblAdmissions);
                hospitalTable.Fill(hospitalDataSet.tblHospital);
                tblPatients.Fill(hospitalDataSet.tblPatient);

                //assign the filled dataset as the datasource for the report
                aRoomUtilization.SetDataSource(hospitalDataSet);

                //set up the report viewer object on the form to show the runtime report object
                roomUtilizationViewer.ReportSource = aRoomUtilization;
            }
            catch (Exception dataException)
            {
                //catch any exception thrown during instantiation
                MessageBox.Show("Data Error Encountered: " + dataException.Message);
            }

            roomUtilizationViewer.Visible = true;
            roomUtilizationViewer.Zoom(75);
            btnCloseRprt.Enabled = true;
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            PhysicianPatient aPhysicianPatient;
            aPhysicianPatient = new PhysicianPatient();

            try
            {
                //instantiate the dataset and table adapters
                hospitalDataSet = new MVCHDBDataSet();
                admissionsTable = new MVCHDBDataSetTableAdapters.tblAdmissionsTableAdapter();
                hospitalTable = new MVCHDBDataSetTableAdapters.tblHospitalTableAdapter();
                tblPatients = new MVCHDBDataSetTableAdapters.tblPatientTableAdapter();
                tblPhysician = new MVCHDBDataSetTableAdapters.tblPhysicianTableAdapter();


                //fill the dataset via the two table adapters
                //fill with customers
                admissionsTable.Fill(hospitalDataSet.tblAdmissions);
                hospitalTable.Fill(hospitalDataSet.tblHospital);
                tblPatients.Fill(hospitalDataSet.tblPatient);
                tblPhysician.Fill(hospitalDataSet.tblPhysician);

                //assign the filled dataset as the datasource for the report
                aPhysicianPatient.SetDataSource(hospitalDataSet);

                //set up the report viewer object on the form to show the runtime report object
                roomUtilizationViewer.ReportSource = aPhysicianPatient;
            }
            catch (Exception dataException)
            {
                //catch any exception thrown during instantiation
                MessageBox.Show("Data Error Encountered: " + dataException.Message);
            }

            roomUtilizationViewer.Visible = true;
            roomUtilizationViewer.Zoom(75);
            btnCloseRprt.Enabled = true;
        }

        private void btnCloseRprt_Click(object sender, EventArgs e)
        {
            roomUtilizationViewer.Visible = false;
            btnCloseRprt.Enabled = true;
        }
    }
}
