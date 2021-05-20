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
    public partial class NotAvailableRooms : UserControl
    {
        public NotAvailableRooms()
        {
            InitializeComponent();
            manageNotAvailableRooms1.Hide();
            fillcomboRoom();
        }

        private void manageNotAvailableRooms1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnS2Clear_Click(object sender, EventArgs e)
        {
            manageNotAvailableRooms1.Show();
            manageNotAvailableRooms1.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomUI UI = new RoomUI();
            UI.Show();
            UI.BringToFront();
        }

        public void Clear()
        {
            //clear data 
            cmbSelectRoom.ResetText();
            txtDay.ResetText();
            txtSTime.ResetText();
            txtETime.ResetText();
        }
        private void btnS2Submit_Click(object sender, EventArgs e)
        {
            String SelectRoom = cmbSelectRoom.Text;
            String Day = txtDay.Text;
            String StartDate = txtSTime.Text;
            String EndDate = txtETime.Text;
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Insert into NotRTimes(NRoom,NDay,NStartDate,NEndDate) values ('" + SelectRoom + "' ,'" + Day + "','" + StartDate + "','" + EndDate + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();


            MessageBox.Show("Aded Not available times for the Room.", "Added", MessageBoxButtons.OK);
            Clear();
        }


        void fillcomboRoom()
        {
            //2
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmbSelectRoom.Items.Clear();
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
                cmbSelectRoom.Items.Add(dr["roomName"].ToString());
            }
            con.Close();

        }
    }
}
