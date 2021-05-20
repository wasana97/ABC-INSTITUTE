using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCInstitute.UserControll
{
    public partial class RoomUI : UserControl
    {
        public RoomUI()
        {
            InitializeComponent();
            notAvailableRooms1.Hide();
            manageSessionRooms1.Hide();
            addConsecutiveSession1.Hide();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomsUserControl UI = new RoomsUserControl();
            UI.Show();
            UI.BringToFront();
        }

        private void notAvailableRooms1_Load(object sender, EventArgs e)
        {

        }

        private void RoomUI_Load(object sender, EventArgs e)
        {

        }

        private void notAvailableRooms1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            notAvailableRooms1.Show();
            notAvailableRooms1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageSessionRooms1.Show();
            manageSessionRooms1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addConsecutiveSession1.Show();
            addConsecutiveSession1.BringToFront();
        }

        private void addConsecutiveSession1_Load(object sender, EventArgs e)
        {

        }
    }
}
