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
    public partial class manageTagUserController : UserControl
    {
        public manageTagUserController()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            TagsUserControll tag = new TagsUserControll();
            tag.Show();
            tag.BringToFront();
        }

        private void manageTagUserController_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tag";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            dataGridViewMnageTag.DataSource = DS.Tables[0];
        }

        int tagID;
        int rowID;

        private void dataGridViewMnageTag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMnageTag.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {


                tagID = int.Parse(dataGridViewMnageTag.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tag where tagID = " + tagID + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);

            rowID = int.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtTagName.Text = DS.Tables[0].Rows[0][1].ToString();
            txtTagCode.Text = DS.Tables[0].Rows[0][2].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            String tagName = txtTagName.Text;
            String tagCode = txtTagCode.Text;






            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update tag set  tagName='" + tagName + "',tagCode='" + tagCode + "' where tagID=  " + rowID + " ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tag";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            int v = DA.Fill(DS);
            dataGridViewMnageTag.DataSource = DS.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("this TAG recod will Delete", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-HBH4PT7;Initial Catalog=ABC_INSTITUTE;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from tag where tagID= " + txtdeleteId.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                int v = DA.Fill(DS);
            }
        }
    }
}
