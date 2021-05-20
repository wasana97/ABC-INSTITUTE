using System;
using System.Windows.Forms;

namespace ABCInstitute.UserControll
{
    public partial class StudentUserControll : UserControl
    {
        public StudentUserControll()
        {
            InitializeComponent();
            addStudentUserControll1.Hide();
            manageStudentUserControll1.Hide();
            studentIdGenerate1.Hide();
        }

        private void btnAddStudentDetails_Click(object sender, EventArgs e)
        {
            addStudentUserControll1.Show();
            addStudentUserControll1.BringToFront();
        }

        private void addStudentUserControll1_Load(object sender, EventArgs e)
        {

        }

        private void btnManageStudentDetails_Click(object sender, EventArgs e)
        {
            manageStudentUserControll1.Show();
            manageStudentUserControll1.BringToFront();
        }

        private void btnGenerateStudentGroupID_Click(object sender, EventArgs e)
        {
            studentIdGenerate1.Show();
            studentIdGenerate1.BringToFront();
        }

        private void studentIdGenerate1_Load(object sender, EventArgs e)
        {

        }
    }
}
