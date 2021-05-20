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
    public partial class ViewSubjectUserControl1 : UserControl
    {
        public ViewSubjectUserControl1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubjectUserControl1 add = new AddSubjectUserControl1();
            add.Show();
            add.BringToFront();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddSubjectUserControl1 add = new AddSubjectUserControl1();
            add.Show();
            add.BringToFront();
        }

        private void ViewSubjectUserControl1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from subjects";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            dgv1.DataSource = DS.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This Subject recod will Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from subjects where SID= " + txtSID.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);
                MessageBox.Show("Deletetion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();



            }
        }

        public void Clear()
        {
            txtSID.Clear();
        }

        public void Clearr()
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
        int SID;
        Int64 rowID;
        

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {


                SID = int.Parse(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from subjects where SID = " + SID + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);


            rowID = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtOfferedYear.Text = DS.Tables[0].Rows[0][1].ToString();
            cmbOSemester.Text = DS.Tables[0].Rows[0][2].ToString();
            txtSubjectName.Text = DS.Tables[0].Rows[0][3].ToString();
            txtCode.Text = DS.Tables[0].Rows[0][4].ToString();
            cmbLech.Text = DS.Tables[0].Rows[0][5].ToString();
            cmbTuh.Text = DS.Tables[0].Rows[0][6].ToString();
            cmbLah.Text = DS.Tables[0].Rows[0][7].ToString();
            cmbEvh.Text = DS.Tables[0].Rows[0][8].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            cmd.CommandText = "update subjects set  oyear='" + OfferYear + "',osemester='" + OfferSemester + "',sname='" + SubjectName + "' ,scode='" + SubjectCode + "',nlech='" + NoLecHours + "',ntuh='" + NoTutHours + "',nlah='" + NoLabHours + "',nevh='" + NoEvHours + "' where SID=" + rowID + " ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            MessageBox.Show("Updating Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clearrr();
        }
        public void Clearrr()
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from subjects";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            dgv1.DataSource = DS.Tables[0];
            Clearrr();
        }
    }
}
