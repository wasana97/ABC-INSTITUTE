
namespace ABCInstitute.UserControll
{
    partial class manageStudentUserControll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageStudentUserControll));
            this.dataGridViewManageStudent = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYearAndSemester = new System.Windows.Forms.TextBox();
            this.txtSubGroupNumber = new System.Windows.Forms.TextBox();
            this.txtGroupNumber = new System.Windows.Forms.TextBox();
            this.txtProgramme = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManageStudent
            // 
            this.dataGridViewManageStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageStudent.Location = new System.Drawing.Point(57, 270);
            this.dataGridViewManageStudent.Name = "dataGridViewManageStudent";
            this.dataGridViewManageStudent.Size = new System.Drawing.Size(511, 227);
            this.dataGridViewManageStudent.TabIndex = 0;
            this.dataGridViewManageStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageStudent_CellClick);
            this.dataGridViewManageStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageStudent_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(277, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Manage Student Details";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(439, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(57, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Acedemic Year And Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Programme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Group Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sub Group Number";
            // 
            // txtYearAndSemester
            // 
            this.txtYearAndSemester.Location = new System.Drawing.Point(294, 61);
            this.txtYearAndSemester.Name = "txtYearAndSemester";
            this.txtYearAndSemester.Size = new System.Drawing.Size(173, 20);
            this.txtYearAndSemester.TabIndex = 8;
            // 
            // txtSubGroupNumber
            // 
            this.txtSubGroupNumber.Location = new System.Drawing.Point(294, 188);
            this.txtSubGroupNumber.Name = "txtSubGroupNumber";
            this.txtSubGroupNumber.Size = new System.Drawing.Size(173, 20);
            this.txtSubGroupNumber.TabIndex = 9;
            // 
            // txtGroupNumber
            // 
            this.txtGroupNumber.Location = new System.Drawing.Point(294, 149);
            this.txtGroupNumber.Name = "txtGroupNumber";
            this.txtGroupNumber.Size = new System.Drawing.Size(173, 20);
            this.txtGroupNumber.TabIndex = 10;
            // 
            // txtProgramme
            // 
            this.txtProgramme.Location = new System.Drawing.Point(294, 103);
            this.txtProgramme.Name = "txtProgramme";
            this.txtProgramme.Size = new System.Drawing.Size(173, 20);
            this.txtProgramme.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Student ID";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(533, 223);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 41);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // manageStudentUserControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtProgramme);
            this.Controls.Add(this.txtGroupNumber);
            this.Controls.Add(this.txtSubGroupNumber);
            this.Controls.Add(this.txtYearAndSemester);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewManageStudent);
            this.Name = "manageStudentUserControll";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.manageStudentUserControll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManageStudent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYearAndSemester;
        private System.Windows.Forms.TextBox txtSubGroupNumber;
        private System.Windows.Forms.TextBox txtGroupNumber;
        private System.Windows.Forms.TextBox txtProgramme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
    }
}
