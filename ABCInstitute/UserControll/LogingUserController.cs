using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ABCInstitute.UserControll
{
    public partial class LogingUserController : UserControl
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


        public LogingUserController()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void LogingUserController_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                String userName = textBox1.Text;
                String Password = textBox2.Text;
                if (userName == "Admin" && Password == "Admin")
                {



                    panel1.Visible = false;



                }
                else
                {

                    MessageBox.Show("invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}


