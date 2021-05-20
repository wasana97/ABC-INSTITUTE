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
    public partial class ManageLocationUserControl : UserControl
    {
        public ManageLocationUserControl()
        {
            InitializeComponent();
        }

        private void btnbuilding_Click(object sender, EventArgs e)
        {
            addBuildingsUserControl1.Show();
            addBuildingsUserControl1.BringToFront();
        }

        private void btnview_Click(object sender, EventArgs e)
        {

        }

        private void btnallocation_Click(object sender, EventArgs e)
        {

        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            roomsUserControl1.Show();
            roomsUserControl1.BringToFront();
        }

        private void btnroomDatils_Click(object sender, EventArgs e)
        {
            viewRoomDetailsUserControl1.Show();
            viewRoomDetailsUserControl1.BringToFront();
        }

        private void ManageLocationUserControl_Load(object sender, EventArgs e)
        {

        }

        private void viewRoomDetailsUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void addBuildingsUserControl1_Load(object sender, EventArgs e)
        {
            addBuildingsUserControl1.Hide();
            roomsUserControl1.Hide();
            viewRoomDetailsUserControl1.Hide();
        }
    }
}
