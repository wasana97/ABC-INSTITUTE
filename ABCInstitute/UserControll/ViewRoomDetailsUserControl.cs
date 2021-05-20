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
    public partial class ViewRoomDetailsUserControl : UserControl
    {
        public ViewRoomDetailsUserControl()
        {
            InitializeComponent();
        }
        int buildingId;
        Int64 rowId;
        private void btnviewRoomDetails_Click(object sender, EventArgs e)
        {
            this.Hide();

            StaticticsUserControl statict = new StaticticsUserControl();
            statict.Show();
            statict.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            StaticticsUserControl statict = new StaticticsUserControl();
            statict.Show();
            statict.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbuildingName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtroomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtcapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtbuildingId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String buildingName = txtbuildingName.Text;
            String roomName = txtroomName.Text;
            //String GroupNumber = txtGroupNumber.Text;
            String capacity = txtcapacity.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update building set buildingName='" + buildingName + "', roomName='" + roomName + "',capacity = '" + capacity + "' where buildingId=" + rowId + "  ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Room will Delete", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from building where buildingId= " + txtbuildingId.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);




            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from building";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void ViewRoomDetailsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {


                buildingId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from building where buildingId = " + buildingId + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);


            rowId = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtbuildingName.Text = DS.Tables[0].Rows[0][1].ToString();
            txtroomName.Text = DS.Tables[0].Rows[0][2].ToString();
            radioButton1.Text = DS.Tables[0].Rows[0][3].ToString();
            txtcapacity.Text = DS.Tables[0].Rows[0][4].ToString();
            txtbuildingId.Text = DS.Tables[0].Rows[0][0].ToString();
        }
    }
}
