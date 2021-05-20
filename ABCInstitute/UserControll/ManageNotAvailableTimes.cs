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
    public partial class ManageNotAvailableTimes : UserControl
    {
        public ManageNotAvailableTimes()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotAvailableTimes UI = new NotAvailableTimes();
            UI.Show();
            UI.BringToFront();
        }

        private void ManageNotAvailableTimes_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NotATime";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

           
            dataGridViewManageStudent.DataSource = DS.Tables[0];
        }

        public void Clear()
        {
            //clear data 
            NIDText.Clear();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NotATime";
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
                cmd.CommandText = "delete from NotATime where NID= " + NIDText.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);
                MessageBox.Show("Deletetion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();



            }
        }
    }
}
