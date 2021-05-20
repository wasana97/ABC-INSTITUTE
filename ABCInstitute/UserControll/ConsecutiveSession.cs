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
    public partial class ConsecutiveSession : UserControl
    {
        public ConsecutiveSession()
        {
            InitializeComponent();
            manageConsecutiveSession1.Hide();
            fillcomboLecturer();
            fillcomboSubjectCode();
            fillcomboSubjectName();
            fillcomboGroup();
            fillcomboTag();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllocationUserControl1 al = new AllocationUserControl1();
            al.Show();
            al.BringToFront();
        }

        private void txtView_Click(object sender, EventArgs e)
        {
            manageConsecutiveSession1.Show();
            manageConsecutiveSession1.BringToFront();
        }

        private void manageConsecutiveSession1_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            //clear data 
            cmbSelectLecturer1.ResetText();
            cmbSelectLecturer2.ResetText();
            cmbSelectGroup.ResetText();
            cmbSelectSubject.ResetText();
            cmbSelectSubjectCode.ResetText();
            cmbSelectTag.ResetText();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            String SelectLecturer1 = cmbSelectLecturer1.Text;
            String SelectLecturer2 = cmbSelectLecturer2.Text;
            String SelectSubjectCode = cmbSelectSubjectCode.Text;
            String SelectSubject = cmbSelectSubject.Text;
            String SelectGroup = cmbSelectGroup.Text;
            String SelectSelectTag = cmbSelectTag.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Insert into Consecutive(CLecturer1,CLecturer2,CSubjectCode,CSubjectName,CGroup,CTag) values ('" + SelectLecturer1 + "' ,'" + SelectLecturer2 + "','" + SelectSubjectCode + "','" + SelectSubject + "','" + SelectGroup + "','" + SelectSelectTag + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();


            MessageBox.Show("Aded Consecutive Session.", "Added", MessageBoxButtons.OK);
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

            cmbSelectLecturer1.Items.Clear();
            cmbSelectLecturer2.Items.Clear();
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
                cmbSelectLecturer1.Items.Add(dr["lname"].ToString());
                cmbSelectLecturer2.Items.Add(dr["lname"].ToString());
            }
            con.Close();

        }

        void fillcomboSubjectCode()
        {
            //2
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSelectSubjectCode.Items.Clear();

            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select scode from subjects";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSelectSubjectCode.Items.Add(dr["scode"].ToString());

            }
            con.Close();

        }
        void fillcomboSubjectName()
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

        void fillcomboTag()
        {
            //2
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSelectTag.Items.Clear();

            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select tagName from tag";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSelectTag.Items.Add(dr["tagName"].ToString());

            }
            con.Close();

        }
    }
}
