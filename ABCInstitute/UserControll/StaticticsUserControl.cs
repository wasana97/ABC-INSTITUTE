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
    public partial class StaticticsUserControl : UserControl
    {
        public StaticticsUserControl()
        {
            InitializeComponent();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            studentsUserControl1.Show();
            studentsUserControl1.BringToFront();
        }

        private void btnluctures_Click(object sender, EventArgs e)
        {
            lucturesUserControl1.Show();
            lucturesUserControl1.BringToFront();
        }

        private void btnsubjects_Click(object sender, EventArgs e)
        {
            subjectsUserControl1.Show();
            subjectsUserControl1.BringToFront();
        }

        private void StaticticsUserControl_Load(object sender, EventArgs e)
        {
            studentsUserControl1.Hide();
            subjectsUserControl1.Hide();
            lucturesUserControl1.Hide();
        }

        private void studentsUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void subjectsUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
