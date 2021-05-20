using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ABCInstitute.UserControll
{
    public partial class AddStudentUserControll : UserControl
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
               int left,
               int top,
               int right,
               int bottom,
               int width,
               int height
           );


        public AddStudentUserControll()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void AddStudentUserControll_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentUserControll studentDetail = new StudentUserControll();
            studentDetail.Show();
            studentDetail.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            String yearAndSemester = txtAcedemicYear.Text;
            String programme = txtProgramme.Text;
            Int64 groupNumber = Int64.Parse(txtGroupNumber.Text);
            Int64 subGroupNumber = Int64.Parse(txtSubGroupNumber.Text);





            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into student(yearAndSemester,programme,groupNumber,subGroupNumber) values('" + yearAndSemester + "','" + programme + "','" + groupNumber + "','" + subGroupNumber + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();
            MessageBox.Show("Aded new STUDENT ", "data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAcedemicYear.Clear();
            txtProgramme.Clear();
            txtGroupNumber.Clear();
            txtSubGroupNumber.Clear();
        }
    }
}




