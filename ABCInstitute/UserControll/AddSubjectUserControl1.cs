using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCInstitute.UserControll
{
    public partial class AddSubjectUserControl1 : UserControl
    {
        public AddSubjectUserControl1()
        {
            InitializeComponent();
            viewSubjectUserControl11.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewSubjectUserControl11.Show();
            viewSubjectUserControl11.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String OfferYear = txtOfferedYear.Text;
            String OfferSemester = cmbOSemester.Text;
            String SubjectName = txtSubjectName.Text;
            String SubjectCode = txtCode.Text;
            String NoLecHours = cmbLech.Text;
            String NoTutHours = cmbTuh.Text;
            String NoLabHours = cmbLah.Text;
            String NoEvHours = cmbEvh.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into subjects(oyear,osemester,sname,scode,nlech,ntuh,nlah,nevh)  values ('" + OfferYear + "','" + OfferSemester + "','" + SubjectName + "' ,'" + SubjectCode + "','" + NoLecHours + "','" + NoTutHours + "','" + NoLabHours + "','" + NoEvHours + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();

            if (String.IsNullOrWhiteSpace(txtOfferedYear.Text))
            {
                MessageBox.Show("Enter Offer year!!!");
                txtOfferedYear.Select();
            }

            else if (String.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Enter Subject Name!!!");
                txtSubjectName.Select();
            }


            else
            {
                MessageBox.Show("Aded New Subject", "Data", MessageBoxButtons.OK);
                Clear();
            }


        }

        private void cmbOSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            //clear data 
            txtOfferedYear.Clear();
            cmbOSemester.ResetText();
            txtSubjectName.Clear();
            txtCode.Clear();
            cmbLech.ResetText();
            cmbTuh.ResetText();
            cmbLah.ResetText();
            cmbEvh.ResetText();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void viewSubjectUserControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
