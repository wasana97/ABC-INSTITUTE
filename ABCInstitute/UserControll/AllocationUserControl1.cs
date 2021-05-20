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
    public partial class AllocationUserControl1 : UserControl
    {
        public AllocationUserControl1()
        {
            InitializeComponent();
            addSessionUserControl11.Hide();
            viewSessionUserControl11.Hide();
            notAvailableTimes1.Hide();
            consecutiveSession1.Hide();
            parallelSession1.Hide();
            nonOverlapping1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ADDSESSION
            addSessionUserControl11.Show();
            addSessionUserControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MANAGESESSION
            viewSessionUserControl11.Show();
            viewSessionUserControl11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CONSECULATIVE
            consecutiveSession1.Show();
            consecutiveSession1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //NOOVERLAPPING
            nonOverlapping1.Show();
            nonOverlapping1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PARALELL
            parallelSession1.Show();
            parallelSession1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //NOTAVAILABLE
            notAvailableTimes1.Show();
            notAvailableTimes1.BringToFront();
        }

        private void viewSessionUserControl11_Load(object sender, EventArgs e)
        {

        }

        private void consecutiveSession1_Load(object sender, EventArgs e)
        {

        }

        private void parallelSession1_Load(object sender, EventArgs e)
        {

        }

        private void nonOverlapping1_Load(object sender, EventArgs e)
        {

        }
    }
}
