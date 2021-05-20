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
    public partial class LucturesUserControl : UserControl
    {
        public LucturesUserControl()
        {
            InitializeComponent();
        }

        private void btnstaticticsLecture_Click(object sender, EventArgs e)
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void LucturesUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
