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
    public partial class DetailsOfWorkingDaysHours : UserControl
    {
        public DetailsOfWorkingDaysHours()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("this record will Update", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {
                String WorkDays = cmbDays.Text;


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

                String WorkHours = txtHours.Text;

                String TimeSlot = "";
                bool isChecked = RadioTime1.Checked;
                if (isChecked)
                    if (isChecked)
                    {
                        TimeSlot = RadioTime1.Text;
                    }
                    else
                    {
                        TimeSlot = RadioTime2.Text;
                    }





                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update tbl_Work set WorkDays='" + WorkDays + "', WorkDates='" + WorkDates + "', WorkHours='" + WorkHours + "',TimeSlot='" + TimeSlot + "'  where WorkId=" + WorkId + " ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);

            }
            Clear();
        }

        private void Clear()
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tbl_Work";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("this record will Delete", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from tbl_Work where WorkID = " + textBox1.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);




            }
            Clear();

        }

        private void DetailsOfWorkingDaysHours_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tbl_Work";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);


            dataGridView1.DataSource = DS.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            
        }

        int WorkId;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                WorkId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmbDays.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                /*checkBox1.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                checkBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                checkBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                checkBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                checkBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                checkBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                checkBox7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();*/
                txtHours.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                /*  RadioTime1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); 
                  RadioTime2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();*/
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tbl_Work where WorkId = " + WorkId + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

        
    }
    }
}
