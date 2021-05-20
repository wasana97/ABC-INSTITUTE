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
    public partial class ViewSessionUserControl1 : UserControl
    {
        public ViewSessionUserControl1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllocationUserControl1 al = new AllocationUserControl1();
            al.Show();
            al.BringToFront();
        }

        private void ViewSessionUserControl1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from session";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            dataGSelectLecturer.DataSource = DS.Tables[0];
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This Subject recod will Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from session where sessionId= " + cmbSSearch.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);
                MessageBox.Show("Deletetion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();



            }
        }
        public void Clear()
        {
            cmbSSearch.ResetText();
        }

        public void Clearrr()
        {
            //clear data 
            cmbSelectLecturer.ResetText();
            cmbSelectTag.ResetText();
            cmbSelectGroup.ResetText();
            cmbSelectSubject.ResetText();
            txtNoOfStudent.Clear();
            txtDuration.Clear();
        }
        public void Clearr()
        {
            //clear data 
            cmbSelectLecturer.ResetText();
            cmbSelectTag.ResetText();
            cmbSelectGroup.ResetText();
            cmbSelectSubject.ResetText();
            txtNoOfStudent.Clear();
            txtDuration.Clear();
        }
        int sessionId;
        Int64 rowID;

        private void btnSRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from session";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            dataGSelectLecturer.DataSource = DS.Tables[0];
            Clearrr();
        }

        private void btnSUpdate_Click(object sender, EventArgs e)
        {
            String SelectLecturer = cmbSelectLecturer.Text;
            String SelectTag = cmbSelectTag.Text;
            String SelectGroup = cmbSelectGroup.Text;
            String SelectSubject = cmbSelectSubject.Text;
            String NOOfStudent = txtNoOfStudent.Text;
            String Duration = txtDuration.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update session set  sLecturer='" + SelectLecturer + "',stag='" + SelectTag + "',sGroup='" + SelectGroup + "' ,sSubject='" + SelectSubject + "',nStudent='" + NOOfStudent + "',duration='" + Duration + "' where sessionId=" + rowID + " ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            MessageBox.Show("Updating Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clearrr();
        }

        private void dataGSelectLecturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGSelectLecturer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {


                sessionId = int.Parse(dataGSelectLecturer.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from session where sessionId = " + sessionId + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);


            rowID = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            cmbSelectLecturer.Text = DS.Tables[0].Rows[0][1].ToString();
            cmbSelectTag.Text = DS.Tables[0].Rows[0][2].ToString();
            cmbSelectGroup.Text = DS.Tables[0].Rows[0][3].ToString();
            cmbSelectSubject.Text = DS.Tables[0].Rows[0][4].ToString();
            txtNoOfStudent.Text = DS.Tables[0].Rows[0][5].ToString();
            txtDuration.Text = DS.Tables[0].Rows[0][6].ToString();

        }
    
    }
}
