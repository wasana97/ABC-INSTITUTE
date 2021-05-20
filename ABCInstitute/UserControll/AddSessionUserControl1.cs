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
    public partial class AddSessionUserControl1 : UserControl
    {
        public AddSessionUserControl1()
        {
            InitializeComponent();
            fillcomboLecturer();
            fillcombosubject();
            fillcomboGroup();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllocationUserControl1 al = new AllocationUserControl1();
            al.Show();
            al.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSessionUserControl1 ss = new ViewSessionUserControl1();
            ss.Show();
            ss.BringToFront();
        }

        private void btnS2Submit_Click(object sender, EventArgs e)
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

            cmd.CommandText = "Insert into session(sLecturer,stag,sGroup,sSubject,nStudent,duration) values ('" + SelectLecturer + "' ,'" + SelectTag + "','" + SelectGroup + "','" + SelectSubject + "','" + NOOfStudent + "','" + Duration + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();
            Clear();

            MessageBox.Show("Aded New Session.", "Added", MessageBoxButtons.OK);
        }

        public void Clear()
        {
            //clear data 
            cmbSelectLecturer.ResetText();
            cmbSelectTag.ResetText();
            cmbSelectGroup.ResetText();
            cmbSelectSubject.ResetText();
            txtNoOfStudent.Clear();
            txtDuration.Clear();

        }

        private void btnS2Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }



        //get data from database to combobox
        void fillcomboLecturer()
        {
            //2
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSelectLecturer.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select lname from Lecturers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSelectLecturer.Items.Add(dr["lname"].ToString());
            }
            con.Close();

        }

        //student name
        void fillcombosubject()
        {
            //2
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSelectSubject.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select sname from subjects";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSelectSubject.Items.Add(dr["sname"].ToString());
            }
            con.Close();

        }

        //cmbSelectGroup
        void fillcomboGroup()
        {
            //2
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSelectGroup.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select groupNumber from student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSelectGroup.Items.Add(dr["groupNumber"].ToString());
            }
            con.Close();

        }

        private void AddSessionUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
