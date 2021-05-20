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
    public partial class SubjectsUserControl : UserControl
    {
        public SubjectsUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            StaticticsUserControl statict = new StaticticsUserControl();
            statict.Show();
            statict.BringToFront();
        }

        private void btnstaticticSubject_Click(object sender, EventArgs e)
        {
            this.Hide();

            StaticticsUserControl statict = new StaticticsUserControl();
            statict.Show();
            statict.BringToFront();
        }

        private void SubjectsUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
