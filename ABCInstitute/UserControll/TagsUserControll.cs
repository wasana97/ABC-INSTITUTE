using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ABCInstitute.UserControll
{
    public partial class TagsUserControll : UserControl
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


        public TagsUserControll()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            addTagsUserControll1.Hide();
            manageTagUserController1.Hide();
        }

        private void TagsUserControll_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTags_Click(object sender, EventArgs e)
        {
            addTagsUserControll1.Show();
            addTagsUserControll1.BringToFront();
        }

        private void btnManageTags_Click(object sender, EventArgs e)
        {
            manageTagUserController1.Show();
            manageTagUserController1.BringToFront();
        }

        private void manageTagUserController1_Load(object sender, EventArgs e)
        {

        }

        private void addTagsUserControll1_Load(object sender, EventArgs e)
        {

        }
    }
}
