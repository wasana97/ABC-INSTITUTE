
namespace ABCInstitute.UserControll
{
    partial class ViewSubjectUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSubjectUserControl1));
            this.cmbOSemester = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbEvh = new System.Windows.Forms.ComboBox();
            this.cmbLah = new System.Windows.Forms.ComboBox();
            this.cmbTuh = new System.Windows.Forms.ComboBox();
            this.cmbLech = new System.Windows.Forms.ComboBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.lblEvh = new System.Windows.Forms.Label();
            this.lblLah = new System.Windows.Forms.Label();
            this.lblTuh = new System.Windows.Forms.Label();
            this.lblLech = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtOfferedYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOfferedYear = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.lblRegistationID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOSemester
            // 
            this.cmbOSemester.FormattingEnabled = true;
            this.cmbOSemester.Items.AddRange(new object[] {
            "1_Semester",
            "2_Semester"});
            this.cmbOSemester.Location = new System.Drawing.Point(209, 105);
            this.cmbOSemester.Name = "cmbOSemester";
            this.cmbOSemester.Size = new System.Drawing.Size(235, 24);
            this.cmbOSemester.TabIndex = 137;
            this.cmbOSemester.Text = "     ---------------Select---------------";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(698, 301);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 44);
            this.btnRefresh.TabIndex = 136;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbEvh
            // 
            this.cmbEvh.FormattingEnabled = true;
            this.cmbEvh.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbEvh.Location = new System.Drawing.Point(771, 164);
            this.cmbEvh.Name = "cmbEvh";
            this.cmbEvh.Size = new System.Drawing.Size(50, 24);
            this.cmbEvh.TabIndex = 135;
            // 
            // cmbLah
            // 
            this.cmbLah.FormattingEnabled = true;
            this.cmbLah.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbLah.Location = new System.Drawing.Point(771, 135);
            this.cmbLah.Name = "cmbLah";
            this.cmbLah.Size = new System.Drawing.Size(50, 24);
            this.cmbLah.TabIndex = 134;
            // 
            // cmbTuh
            // 
            this.cmbTuh.FormattingEnabled = true;
            this.cmbTuh.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbTuh.Location = new System.Drawing.Point(771, 107);
            this.cmbTuh.Name = "cmbTuh";
            this.cmbTuh.Size = new System.Drawing.Size(50, 24);
            this.cmbTuh.TabIndex = 133;
            // 
            // cmbLech
            // 
            this.cmbLech.FormattingEnabled = true;
            this.cmbLech.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbLech.Location = new System.Drawing.Point(771, 77);
            this.cmbLech.Name = "cmbLech";
            this.cmbLech.Size = new System.Drawing.Size(50, 24);
            this.cmbLech.TabIndex = 132;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.BackColor = System.Drawing.Color.White;
            this.txtSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(208, 136);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(236, 23);
            this.txtSubjectName.TabIndex = 131;
            // 
            // lblEvh
            // 
            this.lblEvh.AutoSize = true;
            this.lblEvh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvh.Location = new System.Drawing.Point(464, 176);
            this.lblEvh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvh.Name = "lblEvh";
            this.lblEvh.Size = new System.Drawing.Size(233, 18);
            this.lblEvh.TabIndex = 130;
            this.lblEvh.Text = "Number of Evaluation hours";
            // 
            // lblLah
            // 
            this.lblLah.AutoSize = true;
            this.lblLah.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLah.Location = new System.Drawing.Point(469, 142);
            this.lblLah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLah.Name = "lblLah";
            this.lblLah.Size = new System.Drawing.Size(175, 18);
            this.lblLah.TabIndex = 129;
            this.lblLah.Text = "Number of Lab hours";
            // 
            // lblTuh
            // 
            this.lblTuh.AutoSize = true;
            this.lblTuh.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuh.Location = new System.Drawing.Point(469, 106);
            this.lblTuh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuh.Name = "lblTuh";
            this.lblTuh.Size = new System.Drawing.Size(212, 18);
            this.lblTuh.TabIndex = 128;
            this.lblTuh.Text = "Number of Tutorial hours";
            // 
            // lblLech
            // 
            this.lblLech.AutoSize = true;
            this.lblLech.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLech.Location = new System.Drawing.Point(469, 73);
            this.lblLech.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLech.Name = "lblLech";
            this.lblLech.Size = new System.Drawing.Size(216, 18);
            this.lblLech.TabIndex = 127;
            this.lblLech.Text = "Number of Lecturer hours";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(209, 167);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(235, 23);
            this.txtCode.TabIndex = 126;
            // 
            // txtOfferedYear
            // 
            this.txtOfferedYear.BackColor = System.Drawing.Color.White;
            this.txtOfferedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfferedYear.Location = new System.Drawing.Point(208, 75);
            this.txtOfferedYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtOfferedYear.Name = "txtOfferedYear";
            this.txtOfferedYear.Size = new System.Drawing.Size(236, 23);
            this.txtOfferedYear.TabIndex = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 124;
            this.label4.Text = "Subject Code";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(18, 134);
            this.lblSubjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(116, 18);
            this.lblSubjectName.TabIndex = 123;
            this.lblSubjectName.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 122;
            this.label2.Text = "Offered Semester";
            // 
            // lblOfferedYear
            // 
            this.lblOfferedYear.AutoSize = true;
            this.lblOfferedYear.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferedYear.Location = new System.Drawing.Point(18, 73);
            this.lblOfferedYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOfferedYear.Name = "lblOfferedYear";
            this.lblOfferedYear.Size = new System.Drawing.Size(112, 18);
            this.lblOfferedYear.TabIndex = 121;
            this.lblOfferedYear.Text = "Offered Year";
            // 
            // txtSID
            // 
            this.txtSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSID.ForeColor = System.Drawing.Color.Red;
            this.txtSID.Location = new System.Drawing.Point(457, 233);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(50, 34);
            this.txtSID.TabIndex = 119;
            // 
            // lblRegistationID
            // 
            this.lblRegistationID.AutoSize = true;
            this.lblRegistationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistationID.ForeColor = System.Drawing.Color.Maroon;
            this.lblRegistationID.Location = new System.Drawing.Point(323, 234);
            this.lblRegistationID.Name = "lblRegistationID";
            this.lblRegistationID.Size = new System.Drawing.Size(118, 25);
            this.lblRegistationID.TabIndex = 118;
            this.lblRegistationID.Text = "EmployeeID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(698, 428);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 44);
            this.btnDelete.TabIndex = 117;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(698, 365);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 44);
            this.btnUpdate.TabIndex = 116;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(22, 269);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(674, 337);
            this.dgv1.TabIndex = 115;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(12, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(403, 48);
            this.btnBack.TabIndex = 114;
            this.btnBack.Text = "Subject Details";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(538, 233);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 29);
            this.btnSearch.TabIndex = 120;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // ViewSubjectUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.cmbOSemester);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbEvh);
            this.Controls.Add(this.cmbLah);
            this.Controls.Add(this.cmbTuh);
            this.Controls.Add(this.cmbLech);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.lblEvh);
            this.Controls.Add(this.lblLah);
            this.Controls.Add(this.lblTuh);
            this.Controls.Add(this.lblLech);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtOfferedYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOfferedYear);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.lblRegistationID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Name = "ViewSubjectUserControl1";
            this.Size = new System.Drawing.Size(839, 615);
            this.Load += new System.EventHandler(this.ViewSubjectUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOSemester;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbEvh;
        private System.Windows.Forms.ComboBox cmbLah;
        private System.Windows.Forms.ComboBox cmbTuh;
        private System.Windows.Forms.ComboBox cmbLech;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label lblEvh;
        private System.Windows.Forms.Label lblLah;
        private System.Windows.Forms.Label lblTuh;
        private System.Windows.Forms.Label lblLech;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtOfferedYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOfferedYear;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label lblRegistationID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
    }
}
