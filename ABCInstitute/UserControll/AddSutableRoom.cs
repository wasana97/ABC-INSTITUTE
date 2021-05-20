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
    public partial class AddSutableRoom : UserControl
    {
        public AddSutableRoom()
        {
            InitializeComponent();
            fillcomboRooms();
            fillcomboTag();
        }

        private void btnVIEW_Click(object sender, EventArgs e)
        {
            viewSuitableRooms1.Show();
            viewSuitableRooms1.BringToFront();
        }
        void fillcomboTag()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbtag.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select tagName from tag";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbtag.Items.Add(dr["tagName"].ToString());
            }
            
        }
        void fillcomboRooms()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbRoomtype.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select roomType from building";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbRoomtype.Items.Add(dr["roomType"].ToString());
            }
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String tag = cmbtag.Text;
            String roomtype = cmbRoomtype.Text;
            String roomname = txtroomname.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Insert into suitableRoom(tag,roomtype,roomname) values ('" + tag + "' ,'" + roomtype + "','" + roomname + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();


            MessageBox.Show("Aded Suitable Rooms.", "Added", MessageBoxButtons.OK);
            
        }

        private void btnviewRoomDetails_Click(object sender, EventArgs e)
        {
            this.Hide();

            RoomsUserControl manage = new RoomsUserControl();
            manage.Show();
            manage.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            RoomsUserControl manage = new RoomsUserControl();
            manage.Show();
            manage.BringToFront();
        }

        private void AddSutableRoom_Load(object sender, EventArgs e)
        {
            viewSuitableRooms1.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            cmbtag.ResetText();
            cmbRoomtype.ResetText();
            txtroomname.Clear();
        }

        private void viewSuitableRooms1_Load(object sender, EventArgs e)
        {

        }
    }
}
