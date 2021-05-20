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
    public partial class ManageSessionRooms : UserControl
    {
        public ManageSessionRooms()
        {
            InitializeComponent();
            fillcomboSession();
            fillcomboRooms();
        }
        void fillcomboSession()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSession.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select roomName from building";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSession.Items.Add(dr["roomName"].ToString());
            }
            con.Close();
        }
        void fillcomboRooms()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSessionRoom.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select roomname from suitableRoom";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSessionRoom.Items.Add(dr["roomname"].ToString());
            }
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String Session = cmbSession.Text;
            String SessionRoom = cmbSessionRoom.Text;
            String Ssession = txtSsession.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Insert into ManageSession(Session,SessionRoom,Ssession) values ('" + Session + "' ,'" + SessionRoom + "','" + Ssession + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();


            MessageBox.Show("Aded Suitable Rooms.", "Added", MessageBoxButtons.OK);
           
        }

        private void ManageSessionRooms_Load(object sender, EventArgs e)
        {
            viewManageSessionRooms1.Hide();
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

        private void btnVIEW_Click(object sender, EventArgs e)
        {
            viewManageSessionRooms1.Show();
            viewManageSessionRooms1.BringToFront();
        }

        private void viewManageSessionRooms1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click_2(object sender, EventArgs e)
        {
            cmbSession.ResetText();
            cmbSessionRoom.ResetText();
            txtSsession.Clear();
        }
    }
}
