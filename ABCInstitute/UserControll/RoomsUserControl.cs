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
    public partial class RoomsUserControl : UserControl
    {
        public RoomsUserControl()
        {
            InitializeComponent();
            roomUI1.Hide();
            addSutableRoom1.Hide();


        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            this.Hide();

            ManageLocationUserControl manage = new ManageLocationUserControl();
            manage.Show();
            manage.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ManageLocationUserControl manage = new ManageLocationUserControl();
            manage.Show();
            manage.BringToFront();
        }

        private void btnconsecutibeSession_Click(object sender, EventArgs e)
        {
            roomUI1.Show();
            roomUI1.BringToFront();
        }

        private void btnsuitableRoom_Click(object sender, EventArgs e)
        {
            addSutableRoom1.Show();
            addSutableRoom1.BringToFront();
        }

        private void RoomsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void roomUI1_Load(object sender, EventArgs e)
        {

        }

        private void roomUI1_Load_1(object sender, EventArgs e)
        {

        }

        private void roomUI1_Load_2(object sender, EventArgs e)
        {

        }

        private void notAvailableRooms1_Load(object sender, EventArgs e)
        {

        }
    }
}
