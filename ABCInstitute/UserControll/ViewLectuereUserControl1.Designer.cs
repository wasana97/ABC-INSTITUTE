
namespace ABCInstitute.UserControll
{
    partial class ViewLectuereUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLectuereUserControl1));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtLeval = new System.Windows.Forms.ComboBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.txtBuilding = new System.Windows.Forms.ComboBox();
            this.txtCenter = new System.Windows.Forms.ComboBox();
            this.txtFaculty = new System.Windows.Forms.ComboBox();
            this.lblLeval = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblCenter = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtLecturerName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblLecturerName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.lblRegistationID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(689, 351);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(139, 44);
            this.btnRefresh.TabIndex = 138;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtLeval
            // 
            this.txtLeval.FormattingEnabled = true;
            this.txtLeval.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.txtLeval.Location = new System.Drawing.Point(599, 180);
            this.txtLeval.Name = "txtLeval";
            this.txtLeval.Size = new System.Drawing.Size(44, 24);
            this.txtLeval.TabIndex = 137;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(474, 209);
            this.lblRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(49, 18);
            this.lblRank.TabIndex = 136;
            this.lblRank.Text = "Rank";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Senior Lecturer",
            "Lecturer",
            "Assistant Lecturer"});
            this.txtCategory.Location = new System.Drawing.Point(599, 150);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(207, 24);
            this.txtCategory.TabIndex = 135;
            this.txtCategory.Text = "     ---------------Select---------------";
            // 
            // txtBuilding
            // 
            this.txtBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuilding.FormattingEnabled = true;
            this.txtBuilding.Items.AddRange(new object[] {
            "New Building",
            "Main Building",
            "SD4325A",
            "BA_404",
            "SD_606"});
            this.txtBuilding.Location = new System.Drawing.Point(599, 120);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(205, 24);
            this.txtBuilding.TabIndex = 134;
            this.txtBuilding.Text = "     ---------------Select---------------";
            // 
            // txtCenter
            // 
            this.txtCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenter.FormattingEnabled = true;
            this.txtCenter.Items.AddRange(new object[] {
            "Malabe",
            "Kandy",
            "Metro"});
            this.txtCenter.Location = new System.Drawing.Point(213, 203);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.Size = new System.Drawing.Size(215, 24);
            this.txtCenter.TabIndex = 133;
            this.txtCenter.Text = "      ---------------Select---------------";
            // 
            // txtFaculty
            // 
            this.txtFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaculty.FormattingEnabled = true;
            this.txtFaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Hospitality Management",
            "Nursing"});
            this.txtFaculty.Location = new System.Drawing.Point(213, 142);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(215, 24);
            this.txtFaculty.TabIndex = 132;
            this.txtFaculty.Text = "       ---------------Select---------------";
            // 
            // lblLeval
            // 
            this.lblLeval.AutoSize = true;
            this.lblLeval.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeval.Location = new System.Drawing.Point(474, 178);
            this.lblLeval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeval.Name = "lblLeval";
            this.lblLeval.Size = new System.Drawing.Size(52, 18);
            this.lblLeval.TabIndex = 131;
            this.lblLeval.Text = "Leval";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(471, 148);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 18);
            this.lblCategory.TabIndex = 130;
            this.lblCategory.Text = "Category";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding.Location = new System.Drawing.Point(471, 114);
            this.lblBuilding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(77, 18);
            this.lblBuilding.TabIndex = 129;
            this.lblBuilding.Text = "Building";
            // 
            // lblCenter
            // 
            this.lblCenter.AutoSize = true;
            this.lblCenter.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenter.Location = new System.Drawing.Point(17, 209);
            this.lblCenter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(63, 18);
            this.lblCenter.TabIndex = 128;
            this.lblCenter.Text = "Center";
            // 
            // txtRank
            // 
            this.txtRank.BackColor = System.Drawing.Color.White;
            this.txtRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRank.Location = new System.Drawing.Point(599, 207);
            this.txtRank.Margin = new System.Windows.Forms.Padding(4);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(207, 23);
            this.txtRank.TabIndex = 127;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.White;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(213, 173);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(215, 23);
            this.txtDepartment.TabIndex = 126;
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.BackColor = System.Drawing.Color.White;
            this.txtLecturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecturerName.Location = new System.Drawing.Point(213, 112);
            this.txtLecturerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.Size = new System.Drawing.Size(212, 23);
            this.txtLecturerName.TabIndex = 125;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(216, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 45);
            this.textBox1.TabIndex = 124;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(17, 178);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(104, 18);
            this.lblDepartment.TabIndex = 123;
            this.lblDepartment.Text = "Department";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(17, 148);
            this.lblFaculty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(68, 18);
            this.lblFaculty.TabIndex = 122;
            this.lblFaculty.Text = "Faculty";
            // 
            // lblLecturerName
            // 
            this.lblLecturerName.AutoSize = true;
            this.lblLecturerName.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturerName.Location = new System.Drawing.Point(17, 114);
            this.lblLecturerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLecturerName.Name = "lblLecturerName";
            this.lblLecturerName.Size = new System.Drawing.Size(128, 18);
            this.lblLecturerName.TabIndex = 121;
            this.lblLecturerName.Text = "Lecturer Name";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(17, 84);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(111, 18);
            this.lblEmployeeID.TabIndex = 120;
            this.lblEmployeeID.Text = "Employee ID";
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
            this.btnSearch.Location = new System.Drawing.Point(455, 270);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 29);
            this.btnSearch.TabIndex = 119;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEID
            // 
            this.txtEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEID.ForeColor = System.Drawing.Color.Red;
            this.txtEID.Location = new System.Drawing.Point(345, 265);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(83, 34);
            this.txtEID.TabIndex = 118;
            // 
            // lblRegistationID
            // 
            this.lblRegistationID.AutoSize = true;
            this.lblRegistationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistationID.ForeColor = System.Drawing.Color.Maroon;
            this.lblRegistationID.Location = new System.Drawing.Point(211, 265);
            this.lblRegistationID.Name = "lblRegistationID";
            this.lblRegistationID.Size = new System.Drawing.Size(128, 25);
            this.lblRegistationID.TabIndex = 117;
            this.lblRegistationID.Text = "Employee ID ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(689, 421);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 44);
            this.btnDelete.TabIndex = 116;
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
            this.btnUpdate.Location = new System.Drawing.Point(689, 490);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 44);
            this.btnUpdate.TabIndex = 115;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 305);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(667, 301);
            this.dgv.TabIndex = 114;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(11, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(403, 39);
            this.btnBack.TabIndex = 113;
            this.btnBack.Text = "Lecturers Details";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewLectuereUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtLeval);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtBuilding);
            this.Controls.Add(this.txtCenter);
            this.Controls.Add(this.txtFaculty);
            this.Controls.Add(this.lblLeval);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.lblCenter);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtLecturerName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblLecturerName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.lblRegistationID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnBack);
            this.Name = "ViewLectuereUserControl1";
            this.Size = new System.Drawing.Size(839, 615);
            this.Load += new System.EventHandler(this.ViewLectuereUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox txtLeval;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.ComboBox txtBuilding;
        private System.Windows.Forms.ComboBox txtCenter;
        private System.Windows.Forms.ComboBox txtFaculty;
        private System.Windows.Forms.Label lblLeval;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtLecturerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblLecturerName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.Label lblRegistationID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnBack;
    }
}
