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
    public partial class StudentsUserControl : UserControl
    {
        public StudentsUserControl()
        {
            InitializeComponent();
        }

        private void btnstaticticsStudents_Click(object sender, EventArgs e)
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

        private void StudentsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
         
            
            
        }





        





    }
}
