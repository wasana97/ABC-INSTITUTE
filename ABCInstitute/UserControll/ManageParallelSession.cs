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
    public partial class ManageParallelSession : UserControl
    {
        public ManageParallelSession()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParallelSession UI = new ParallelSession();
            UI.Show();
            UI.BringToFront();
        }

        public void Clear()
        {
            //clear data 
            PIDText.Clear();
        }
        private void ManageParallelSession_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Parallel";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);


            dataGridViewManageStudent.DataSource = DS.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Parallel";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            dataGridViewManageStudent.DataSource = DS.Tables[0];

            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Subject record will Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Parallel where PID= " + PIDText.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);
                MessageBox.Show("Deletetion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();


            }
        }
    }
}
