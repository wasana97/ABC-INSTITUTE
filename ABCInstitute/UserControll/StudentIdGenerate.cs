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
    public partial class StudentIdGenerate : UserControl
    {
        public StudentIdGenerate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentUserControll studentDetail = new StudentUserControll();
            studentDetail.Show();
            studentDetail.BringToFront();
        }

        private void btnGenerateGroupId_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand(@"select CONCAT (yearAndSemester,'.',programme,'.',GroupNumber)as ConcatName from student where studentId = '"+txtStudentId.Text+"'",con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.Read()) {

                txtGroupId.Text = dr.GetValue(0).ToString();
            
            }
           
            con.Close();
        }

        private void btnGenerateSubGroupId_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand(@"select CONCAT (yearAndSemester,'.',programme,'.',GroupNumber,'.',subGroupNumber)as ConcatName from student where studentId = '" + txtStudentId.Text + "'", con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                
                txtSubGroupId.Text = dr.GetValue(0).ToString();

            }

            con.Close();
        }

        private void StudentIdGenerate_Load(object sender, EventArgs e)
        {

        }
    }
}
