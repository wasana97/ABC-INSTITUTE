using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCInstitute.UserControll
{
    public partial class AddWorkingDaysHours : UserControl
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
        public AddWorkingDaysHours()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

            detailsOfWorkingDaysHours1.Hide();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Int64 WorkDays = Int64.Parse(cmbDays.Text);


            String WorkHours = txtHours.Text;

            String TimeSlot = "";
            bool isChecked = RadioTime1.Checked;
            if (isChecked)
            {
                TimeSlot = RadioTime1.Text;
            }
            else
            {
                TimeSlot = RadioTime2.Text;
            }



            string WorkDates = "";

            if (checkBox1.Checked)

            {

                WorkDates = WorkDates + "," + checkBox1.Text;

            }

            if (checkBox2.Checked)

            {

                WorkDates = WorkDates + "," + checkBox2.Text;

            }
            if (checkBox3.Checked)

            {

                WorkDates = WorkDates + "," + checkBox3.Text;

            }
            if (checkBox4.Checked)

            {

                WorkDates = WorkDates + "," + checkBox4.Text;

            }
            if (checkBox5.Checked)

            {

                WorkDates = WorkDates + "," + checkBox5.Text;

            }
            if (checkBox6.Checked)

            {

                WorkDates = WorkDates + "," + checkBox6.Text;

            }
            if (checkBox7.Checked)

            {

                WorkDates = WorkDates + "," + checkBox7.Text;

            }
            WorkDates = WorkDates.TrimStart(',');



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_Work(WorkDays,WorkDates,WorkHours,TimeSlot) values('" + WorkDays + "','" + WorkDates + "','" + WorkHours + "','" + TimeSlot + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            con.Close();
            if (string.IsNullOrWhiteSpace(cmbDays.Text))
            {
                MessageBox.Show("Enter Working days !!!");
                cmbDays.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtHours.Text))
            {
                MessageBox.Show("Enter Working Hours !!!");
                txtHours.Select();
            }

            else
            {
                MessageBox.Show("Added Succesfully ", "data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }

        }
        public void Clear()
        {
            cmbDays.SelectedIndex = -1;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            txtHours.Clear();
            RadioTime1.Checked = false;
            RadioTime2.Checked = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
           detailsOfWorkingDaysHours1.Show();
            detailsOfWorkingDaysHours1.BringToFront();
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void detailsOfWorkingDaysHours1_Load(object sender, EventArgs e)
        {

        }

        private void AddWorkingDaysHours_Load(object sender, EventArgs e)
        {

        }
    }
}

