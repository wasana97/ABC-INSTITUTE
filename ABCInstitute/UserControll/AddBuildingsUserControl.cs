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
    public partial class AddBuildingsUserControl : UserControl
    {
        public AddBuildingsUserControl()
        {
            InitializeComponent();
        }

        private void btnaddLocation_Click(object sender, EventArgs e)
        {
            this.Hide();

            ManageLocationUserControl manage = new ManageLocationUserControl();
            manage.Show();
            manage.BringToFront();
        }

        private void txtcapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtroomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbuildingName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String buildingName = txtbuildingName.Text;
            String roomName = txtroomName.Text;


            string roomType = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                roomType = radioButton1.Text;
            else
                roomType = radioButton2.Text;

            Int64 capacity = Int64.Parse(txtcapacity.Text);








            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into building (buildingName,roomName,roomType,capacity) values('" + buildingName + "','" + roomName + "','" + roomType + "','" + capacity + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();
            MessageBox.Show("Aded new ROOM ", "data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbuildingName.Clear();
            txtroomName.Clear();
            txtcapacity.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            ManageLocationUserControl manage = new ManageLocationUserControl();
            manage.Show();
            manage.BringToFront();
        }

        private void AddBuildingsUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
