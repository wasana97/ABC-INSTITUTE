using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ABCInstitute.UserControll
{
    public partial class AddTagsUserControll : UserControl
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


        public AddTagsUserControll()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void AddTagsUserControll_Load(object sender, EventArgs e)
        {

        }

        private void btnBackTag_Click(object sender, EventArgs e)
        {
            this.Hide();

            TagsUserControll tag = new TagsUserControll();
            tag.Show();
            tag.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            String tagName = txtAddTag.Text;
            String tagCode = txtTagCod.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tag(tagName,tagCode) values('" + tagName + "','" + tagCode + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();
            MessageBox.Show("Aded New TAG", "data", MessageBoxButtons.OK, MessageBoxIcon.Hand);




        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddTag.Clear();
            txtTagCod.Clear();
        }
    }
}
