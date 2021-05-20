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
    public partial class AddLectureUserControl1 : UserControl
    {
        public AddLectureUserControl1()
        {
            InitializeComponent();
            viewLectuereUserControl11.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            viewLectuereUserControl11.Show();
            viewLectuereUserControl11.BringToFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String LecturerName = txtLecturerName.Text;
            String Faculty = txtFaculty.Text;
            String Department = txtDepartment.Text;
            String Center = txtCenter.Text;
            String Building = txtBuilding.Text;
            String Category = txtCategory.Text;
            String Leval = txtLeval.Text;
            String Rank = txtRank.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Insert into Lecturers(lname,faculty,department,center,building,category,leval,Ranak) values ('" + LecturerName + "' ,'" + Faculty + "','" + Department + "','" + Center + "','" + Building + "','" + Category + "','" + Leval + "','" + Rank + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();

            //validation
            if (String.IsNullOrWhiteSpace(txtLecturerName.Text))
            {
                MessageBox.Show("Enter Lecturer Name!!!");
                txtLecturerName.Select();
            }
            else if (String.IsNullOrWhiteSpace(txtFaculty.Text))
            {
                MessageBox.Show("Enter Faculty Name!!!");
                txtFaculty.Select();
            }
            else if (String.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                MessageBox.Show("Enter Department Name!!!");
                txtDepartment.Select();
            }
            else if (String.IsNullOrWhiteSpace(txtCenter.Text))
            {
                MessageBox.Show("Enter Center Name !!!");
                txtCenter.Select();
            }
            else if (String.IsNullOrWhiteSpace(txtBuilding.Text))
            {
                MessageBox.Show("Enter  Building !!!");
                txtBuilding.Select();
            }

            else if (String.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Enter category Name!!!");
                txtCategory.Select();
            }

            else if (String.IsNullOrWhiteSpace(txtLeval.Text))
            {
                MessageBox.Show("Enter Leval !!!");
                txtLeval.Select();
            }
            else if (String.IsNullOrWhiteSpace(txtRank.Text))
            {
                MessageBox.Show("Enter Rank !!!");
                txtRank.Select();
            }

            else
            {
                MessageBox.Show("Aded New Lecturer. Remember the ID", "Added", MessageBoxButtons.OK);
                Clear();
            }
        }

        //Clear data
        public void Clear()
        {
            txtLecturerName.Clear();
            txtFaculty.ResetText();
            txtDepartment.Clear();
            txtCenter.ResetText();
            txtBuilding.ResetText();
            txtCategory.ResetText();
            txtLeval.ResetText();
            txtRank.Clear();
            txtEID.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //auto incresing ID
        private void AddLectureUserControl1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max(EID) FROM Lecturers";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            txtEID.Text = (abc + 1).ToString();
        }
        private void txtEID_TextChanged(object sender, EventArgs e)
        {

        }
         

        private void txtEID_TextChanged_1(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select max(EID) FROM Lecturers";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Close();

                Int64 ABC = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
                txtEID.Text = (ABC + 1).ToString();
            }
        }

        private void viewLectuereUserControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
