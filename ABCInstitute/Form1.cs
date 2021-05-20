using System;
using System.Windows.Forms;

namespace ABCInstitute
{
    public partial class homeScreen : Form
    {
        public homeScreen()
        {
            InitializeComponent();
            studentUserControll1.Hide();
            
            logingUserController1.Show();
            logingUserController1.BringToFront();




        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHover_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            studentUserControll1.Hide();
            tagsUserControll1.Hide();
            logingUserController1.Show();
            logingUserController1.BringToFront();
            staticticsUserControl1.Hide();
            manageLocationUserControl1.Hide();

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            logingUserController1.Hide();

            studentUserControll1.Show();
            studentUserControll1.BringToFront();
            tagsUserControll1.Hide();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            tagsUserControll1.Show();
            tagsUserControll1.BringToFront();
        }

        private void btnWorkDay_Click(object sender, EventArgs e)
        {
            addWorkingDaysHours1.Show();
            addWorkingDaysHours1.BringToFront();

        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            manageLocationUserControl1.Show();
            manageLocationUserControl1.BringToFront();
        }

        private void btnStatisctic_Click(object sender, EventArgs e)
        {
            staticticsUserControl1.Show();
            staticticsUserControl1.BringToFront();
        }

        private void staticticsUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnLectures_Click(object sender, EventArgs e)
        {
            addLectureUserControl11.Show();
            addLectureUserControl11.BringToFront();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            addSubjectUserControl11.Show();
            addSubjectUserControl11.BringToFront();

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAllocation_Click(object sender, EventArgs e)
        {
            allocationUserControl11.Show();
            allocationUserControl11.BringToFront();
        }
    }
}
