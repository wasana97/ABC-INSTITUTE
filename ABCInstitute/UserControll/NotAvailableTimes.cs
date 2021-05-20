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
    public partial class NotAvailableTimes : UserControl
    {
        public NotAvailableTimes()
        {
            InitializeComponent();
            manageNotAvailableTimes1.Hide();
            fillcomboLecturer();
            fillcomboSession();
            fillcomboGroup();
            fillcomboSubGroup();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllocationUserControl1 al = new AllocationUserControl1();
            al.Show();
            al.BringToFront();
        }

        private void NotAvailableTimes_Load(object sender, EventArgs e)
        {

        }

        private void btnS2Clear_Click(object sender, EventArgs e)
        {
            manageNotAvailableTimes1.Show();
            manageNotAvailableTimes1.BringToFront();
        }

        private void manageNotAvailableTimes1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnS2Submit_Click(object sender, EventArgs e)
        {
            String SelectLecturers = cmbSelectLecturers.Text;
            String SelectGroup = cmbSelectGroup.Text;
            String SelectSubGroup = cmbSelectSubGroup.Text;
            String SelectSessionId = cmbSelectSessionId.Text;
            String NOOfTime = txtNoOfTime.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Insert into NotATime(NLecturer,NGroup,NSubGroup,NSessionId,NTime) values ('" + SelectLecturers + "' ,'" + SelectGroup + "','" + SelectSubGroup + "','" + SelectSessionId + "','" + NOOfTime + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();


            MessageBox.Show("Aded Not available time.", "Added", MessageBoxButtons.OK);
            Clear();
        }

        void fillcomboLecturer()
        {
            //2
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSelectLecturers.Items.Clear();
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
                cmbSelectLecturers.Items.Add(dr["lname"].ToString());
            }
            con.Close();

        }

        void fillcomboSession()
        {
            //2
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSelectSessionId.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select sessionId from session";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSelectSessionId.Items.Add(dr["sessionId"].ToString());
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

        //cmbSelectSubGroup
        void fillcomboSubGroup()
        {
            //2
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSelectSubGroup.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select subGroupNumber from student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                cmbSelectSubGroup.Items.Add(dr["subGroupNumber"].ToString());
            }
            con.Close();

        }

        public void Clear()
        {
            //clear data 
            cmbSelectLecturers.ResetText();
            cmbSelectGroup.ResetText();
            cmbSelectSubGroup.ResetText();
            cmbSelectSessionId.ResetText();
            txtNoOfTime.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
