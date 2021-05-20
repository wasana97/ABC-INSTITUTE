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
    public partial class ViewSuitableRooms : UserControl
    {
        public ViewSuitableRooms()
        {
            InitializeComponent();
        }

        private void btnviewRoomDetails_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddSutableRoom manage = new AddSutableRoom();
            manage.Show();
            manage.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddSutableRoom manage = new AddSutableRoom();
            manage.Show();
            manage.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Suitable Rooms record will Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from suitableRoom where tagID= " + txtTAGID.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);
                MessageBox.Show("Deletetion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from suitableRoom";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

        }

        private void ViewSuitableRooms_Load(object sender, EventArgs e)
        {

        }
    }
}
