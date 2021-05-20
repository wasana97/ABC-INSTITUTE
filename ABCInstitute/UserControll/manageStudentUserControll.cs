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
    public partial class manageStudentUserControll : UserControl
    {
        public manageStudentUserControll()
        {
            InitializeComponent();
        }

        private void manageStudentUserControll_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from student";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            dataGridViewManageStudent.DataSource = DS.Tables[0];


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentUserControll studentDetail = new StudentUserControll();
            studentDetail.Show();
            studentDetail.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("this Student recod will Delete", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from student where studentId= " + textBox1.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);




            }
        }

        int studentId;
        Int64 rowId;

        private void dataGridViewManageStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewManageStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {


                studentId = int.Parse(dataGridViewManageStudent.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from student where studentId = " + studentId + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);


            rowId = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtYearAndSemester.Text = DS.Tables[0].Rows[0][1].ToString();
            txtProgramme.Text = DS.Tables[0].Rows[0][2].ToString();
            txtGroupNumber.Text = DS.Tables[0].Rows[0][3].ToString();
            txtSubGroupNumber.Text = DS.Tables[0].Rows[0][4].ToString();




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            String YearAndSemeste = txtYearAndSemester.Text;
            String Programme = txtProgramme.Text;
            String GroupNumber = txtGroupNumber.Text;
            String SubGroupNumber = txtSubGroupNumber.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update student set YearAndSemester='"+ YearAndSemeste + "', programme='" + Programme + "', groupNumber='"+ GroupNumber + "',subGroupNumber='"+ SubGroupNumber + "'  where studentId="+rowId+" ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from student";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            dataGridViewManageStudent.DataSource = DS.Tables[0];
        }

        private void dataGridViewManageStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
