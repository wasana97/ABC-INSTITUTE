
namespace ABCInstitute.UserControll
{
    partial class StudentsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnstaticticsStudents = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartStudent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.instituteDataSet4 = new ABCInstitute.InstituteDataSet4();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new ABCInstitute.InstituteDataSet4TableAdapters.subjectsTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstaticticsStudents
            // 
            this.btnstaticticsStudents.FlatAppearance.BorderSize = 0;
            this.btnstaticticsStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstaticticsStudents.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaticticsStudents.Location = new System.Drawing.Point(44, 19);
            this.btnstaticticsStudents.Name = "btnstaticticsStudents";
            this.btnstaticticsStudents.Size = new System.Drawing.Size(281, 27);
            this.btnstaticticsStudents.TabIndex = 4;
            this.btnstaticticsStudents.Text = "Statictics Related To Students";
            this.btnstaticticsStudents.UseVisualStyleBackColor = true;
            this.btnstaticticsStudents.Click += new System.EventHandler(this.btnstaticticsStudents_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCInstitute.Properties.Resources.Button_Previous_icon;
            this.pictureBox1.Location = new System.Drawing.Point(22, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chartStudent
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStudent.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStudent.Legends.Add(legend1);
            this.chartStudent.Location = new System.Drawing.Point(22, 100);
            this.chartStudent.Name = "chartStudent";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Lectures";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Lab";
            this.chartStudent.Series.Add(series1);
            this.chartStudent.Series.Add(series2);
            this.chartStudent.Size = new System.Drawing.Size(575, 321);
            this.chartStudent.TabIndex = 6;
            this.chartStudent.Text = "chart1";
            // 
            // instituteDataSet4
            // 
            this.instituteDataSet4.DataSetName = "InstituteDataSet4";
            this.instituteDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.instituteDataSet4;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(522, 452);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // StudentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.chartStudent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnstaticticsStudents);
            this.Name = "StudentsUserControl";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.StudentsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnstaticticsStudents;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStudent;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private InstituteDataSet4 instituteDataSet4;
        private InstituteDataSet4TableAdapters.subjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
    }
}
