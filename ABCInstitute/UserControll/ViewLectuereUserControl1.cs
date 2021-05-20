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
    public partial class ViewLectuereUserControl1 : UserControl
    {
        public ViewLectuereUserControl1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLectureUserControl1 ad = new AddLectureUserControl1();
            ad.Show();
            ad.BringToFront();
        }

        private void ViewLectuereUserControl1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Lecturers";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            dgv.DataSource = DS.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Lecturers where EID=" + txtEID.Text + "";


            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            dgv.DataSource = DS.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will Delete your Data.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)


            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Lecturers where EID=" + txtEID.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);
                MessageBox.Show("Deletetion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clearr();

            }
        }
        public void Clearr()
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

        Int64 rowId;
        int EID;

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {


                EID = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Lecturers where EID = " + EID + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);


            rowId = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtLecturerName.Text = DS.Tables[0].Rows[0][1].ToString();
            txtFaculty.Text = DS.Tables[0].Rows[0][2].ToString();
            txtDepartment.Text = DS.Tables[0].Rows[0][3].ToString();
            txtCenter.Text = DS.Tables[0].Rows[0][4].ToString();
            txtBuilding.Text = DS.Tables[0].Rows[0][5].ToString();
            txtCategory.Text = DS.Tables[0].Rows[0][6].ToString();
            txtLeval.Text = DS.Tables[0].Rows[0][7].ToString();
            txtRank.Text = DS.Tables[0].Rows[0][8].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String LID = txtEID.Text;

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
            cmd.CommandText = "update  Lecturers set lname='" + LecturerName + "', faculty='" + Faculty + "',department= '" + Department + "',center= '" + Center + "', building='" + Building + "',category= '" + Category + "', leval='" + Leval + "', Ranak='" + Rank + "' where EID=  " + rowId + " ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            //clear data after the update
            MessageBox.Show("Updating Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clearr();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Lecturers";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);

                dgv.DataSource = DS.Tables[0];
                Clearr();
            }
        }
    }
}
