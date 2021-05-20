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
    public partial class ADDConsecutiveSession : UserControl
    {
        public ADDConsecutiveSession()
        {
            InitializeComponent();
            fillcomboConsecutive();
        }
        void fillcomboConsecutive()
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbSession.ResetText();
            txtRoomName.Clear();
        }

        private void btnCclear_Click(object sender, EventArgs e)
        {
            cmbConsecutiveSession.ResetText();
            txtroom01.Clear();
            cmbSession.ResetText();
            txtRoomName.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
        }

        private void ADDConsecutiveSession_Load(object sender, EventArgs e)
        {
            viewADDConsecutiveSession1.Hide();
        }

        private void btnCADD_Click(object sender, EventArgs e)
        {
            String Session = cmbSession.Text;
            String RoomName = txtRoomName.Text;
            String ConsecutiveSession = cmbConsecutiveSession.Text;
            String room01 = txtroom01.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Consecutivesession (Session,RoomName,ConsecutiveSession,room01) values('" + Session + "','" + RoomName + "','" + ConsecutiveSession + "','" + room01 + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();
            MessageBox.Show("Aded Successfuly ", "data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnaddLocation_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomUI al = new RoomUI();
            al.Show();
            al.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomUI al = new RoomUI();
            al.Show();
            al.BringToFront();
        }

        private void bntView_Click(object sender, EventArgs e)
        {
            viewADDConsecutiveSession1.Show();
            viewADDConsecutiveSession1.BringToFront();
        }

        private void viewADDConsecutiveSession1_Load(object sender, EventArgs e)
        {

        }
    }
}
