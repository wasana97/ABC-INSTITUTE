
namespace ABCInstitute.UserControll
{
    partial class AddLectureUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLectureUserControl1));
            this.btnView = new System.Windows.Forms.Button();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtLecturerName = new System.Windows.Forms.TextBox();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblLecturerName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.viewLectuereUserControl11 = new ABCInstitute.UserControll.ViewLectuereUserControl1();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnView.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(160, 380);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 36);
            this.btnView.TabIndex = 98;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            this.txtLeval.Location = new System.Drawing.Point(454, 270);
            this.txtLeval.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeval.Name = "txtLeval";
            this.txtLeval.Size = new System.Drawing.Size(34, 21);
            this.txtLeval.TabIndex = 97;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(82, 305);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(53, 20);
            this.lblRank.TabIndex = 96;
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
            this.txtCategory.Location = new System.Drawing.Point(238, 269);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(156, 21);
            this.txtCategory.TabIndex = 95;
            this.txtCategory.Text = "        -------------Select--------------";
            // 
            // txtBuilding
            // 
            this.txtBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuilding.FormattingEnabled = true;
            this.txtBuilding.Items.AddRange(new object[] {
            "New Building",
            "Main Building",
            "SD4325A"});
            this.txtBuilding.Location = new System.Drawing.Point(238, 236);
            this.txtBuilding.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(249, 21);
            this.txtBuilding.TabIndex = 94;
            this.txtBuilding.Text = "        ---------------------------Select----------------------------";
            // 
            // txtCenter
            // 
            this.txtCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenter.FormattingEnabled = true;
            this.txtCenter.Items.AddRange(new object[] {
            "Malabe",
            "Kandy",
            "Metro"});
            this.txtCenter.Location = new System.Drawing.Point(238, 202);
            this.txtCenter.Margin = new System.Windows.Forms.Padding(2);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.Size = new System.Drawing.Size(249, 21);
            this.txtCenter.TabIndex = 93;
            this.txtCenter.Text = "       ---------------------------Select----------------------------";
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
            this.txtFaculty.Location = new System.Drawing.Point(238, 138);
            this.txtFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(249, 21);
            this.txtFaculty.TabIndex = 92;
            this.txtFaculty.Text = "        ---------------------------Select----------------------------";
            // 
            // lblLeval
            // 
            this.lblLeval.AutoSize = true;
            this.lblLeval.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeval.Location = new System.Drawing.Point(399, 271);
            this.lblLeval.Name = "lblLeval";
            this.lblLeval.Size = new System.Drawing.Size(56, 20);
            this.lblLeval.TabIndex = 91;
            this.lblLeval.Text = "Leval";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(82, 271);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 20);
            this.lblCategory.TabIndex = 90;
            this.lblCategory.Text = "Category";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding.Location = new System.Drawing.Point(82, 237);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(82, 20);
            this.lblBuilding.TabIndex = 89;
            this.lblBuilding.Text = "Building";
            // 
            // lblCenter
            // 
            this.lblCenter.AutoSize = true;
            this.lblCenter.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenter.Location = new System.Drawing.Point(82, 202);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(66, 20);
            this.lblCenter.TabIndex = 88;
            this.lblCenter.Text = "Center";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(412, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 86;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(290, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 85;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRank
            // 
            this.txtRank.BackColor = System.Drawing.Color.White;
            this.txtRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRank.Location = new System.Drawing.Point(238, 305);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(249, 20);
            this.txtRank.TabIndex = 84;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.White;
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(238, 170);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(249, 20);
            this.txtDepartment.TabIndex = 83;
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.BackColor = System.Drawing.Color.White;
            this.txtLecturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecturerName.Location = new System.Drawing.Point(238, 107);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.Size = new System.Drawing.Size(249, 20);
            this.txtLecturerName.TabIndex = 82;
            // 
            // txtEID
            // 
            this.txtEID.BackColor = System.Drawing.Color.LightGray;
            this.txtEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEID.ForeColor = System.Drawing.Color.Red;
            this.txtEID.Location = new System.Drawing.Point(238, 55);
            this.txtEID.Name = "txtEID";
            this.txtEID.ReadOnly = true;
            this.txtEID.Size = new System.Drawing.Size(86, 46);
            this.txtEID.TabIndex = 81;
            this.txtEID.TextChanged += new System.EventHandler(this.txtEID_TextChanged_1);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(82, 170);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(108, 20);
            this.lblDepartment.TabIndex = 80;
            this.lblDepartment.Text = "Department";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(82, 139);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(73, 20);
            this.lblFaculty.TabIndex = 79;
            this.lblFaculty.Text = "Faculty";
            // 
            // lblLecturerName
            // 
            this.lblLecturerName.AutoSize = true;
            this.lblLecturerName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturerName.Location = new System.Drawing.Point(82, 107);
            this.lblLecturerName.Name = "lblLecturerName";
            this.lblLecturerName.Size = new System.Drawing.Size(134, 20);
            this.lblLecturerName.TabIndex = 78;
            this.lblLecturerName.Text = "Lecturer Name";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmployeeID.Location = new System.Drawing.Point(81, 64);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(126, 23);
            this.lblEmployeeID.TabIndex = 77;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(16, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(302, 32);
            this.btnBack.TabIndex = 87;
            this.btnBack.Text = "Add Lecturers Details";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // viewLectuereUserControl11
            // 
            this.viewLectuereUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.viewLectuereUserControl11.Location = new System.Drawing.Point(-2, 0);
            this.viewLectuereUserControl11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewLectuereUserControl11.Name = "viewLectuereUserControl11";
            this.viewLectuereUserControl11.Size = new System.Drawing.Size(629, 500);
            this.viewLectuereUserControl11.TabIndex = 99;
            this.viewLectuereUserControl11.Load += new System.EventHandler(this.viewLectuereUserControl11_Load);
            // 
            // AddLectureUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.viewLectuereUserControl11);
            this.Controls.Add(this.btnView);
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
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRank);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtLecturerName);
            this.Controls.Add(this.txtEID);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblLecturerName);
            this.Controls.Add(this.lblEmployeeID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddLectureUserControl1";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.AddLectureUserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtLecturerName;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblLecturerName;
        private System.Windows.Forms.Label lblEmployeeID;
        private ViewLectuereUserControl1 viewLectuereUserControl11;
    }
}
