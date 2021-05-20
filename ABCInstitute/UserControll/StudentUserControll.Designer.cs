
namespace ABCInstitute.UserControll
{
    partial class StudentUserControll
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
            this.btnAddStudentDetails = new System.Windows.Forms.Button();
            this.btnManageStudentDetails = new System.Windows.Forms.Button();
            this.btnGenerateStudentGroupID = new System.Windows.Forms.Button();
            this.addStudentUserControll1 = new ABCInstitute.UserControll.AddStudentUserControll();
            this.manageStudentUserControll1 = new ABCInstitute.UserControll.manageStudentUserControll();
            this.studentIdGenerate1 = new ABCInstitute.UserControll.StudentIdGenerate();
            this.SuspendLayout();
            // 
            // btnAddStudentDetails
            // 
            this.btnAddStudentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddStudentDetails.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudentDetails.Location = new System.Drawing.Point(20, 150);
            this.btnAddStudentDetails.Name = "btnAddStudentDetails";
            this.btnAddStudentDetails.Size = new System.Drawing.Size(224, 67);
            this.btnAddStudentDetails.TabIndex = 0;
            this.btnAddStudentDetails.Text = "Add Student Details";
            this.btnAddStudentDetails.UseVisualStyleBackColor = false;
            this.btnAddStudentDetails.Click += new System.EventHandler(this.btnAddStudentDetails_Click);
            // 
            // btnManageStudentDetails
            // 
            this.btnManageStudentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnManageStudentDetails.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudentDetails.Location = new System.Drawing.Point(145, 319);
            this.btnManageStudentDetails.Name = "btnManageStudentDetails";
            this.btnManageStudentDetails.Size = new System.Drawing.Size(273, 71);
            this.btnManageStudentDetails.TabIndex = 1;
            this.btnManageStudentDetails.Text = "Manage Student Details";
            this.btnManageStudentDetails.UseVisualStyleBackColor = false;
            this.btnManageStudentDetails.Click += new System.EventHandler(this.btnManageStudentDetails_Click);
            // 
            // btnGenerateStudentGroupID
            // 
            this.btnGenerateStudentGroupID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGenerateStudentGroupID.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateStudentGroupID.Location = new System.Drawing.Point(324, 150);
            this.btnGenerateStudentGroupID.Name = "btnGenerateStudentGroupID";
            this.btnGenerateStudentGroupID.Size = new System.Drawing.Size(237, 67);
            this.btnGenerateStudentGroupID.TabIndex = 2;
            this.btnGenerateStudentGroupID.Text = "Genarate Student Group ID\'S";
            this.btnGenerateStudentGroupID.UseVisualStyleBackColor = false;
            this.btnGenerateStudentGroupID.Click += new System.EventHandler(this.btnGenerateStudentGroupID_Click);
            // 
            // addStudentUserControll1
            // 
            this.addStudentUserControll1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addStudentUserControll1.Location = new System.Drawing.Point(0, 0);
            this.addStudentUserControll1.Name = "addStudentUserControll1";
            this.addStudentUserControll1.Size = new System.Drawing.Size(629, 500);
            this.addStudentUserControll1.TabIndex = 3;
            this.addStudentUserControll1.Load += new System.EventHandler(this.addStudentUserControll1_Load);
            // 
            // manageStudentUserControll1
            // 
            this.manageStudentUserControll1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.manageStudentUserControll1.Location = new System.Drawing.Point(0, 0);
            this.manageStudentUserControll1.Name = "manageStudentUserControll1";
            this.manageStudentUserControll1.Size = new System.Drawing.Size(629, 500);
            this.manageStudentUserControll1.TabIndex = 4;
            // 
            // studentIdGenerate1
            // 
            this.studentIdGenerate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.studentIdGenerate1.Location = new System.Drawing.Point(0, 0);
            this.studentIdGenerate1.Name = "studentIdGenerate1";
            this.studentIdGenerate1.Size = new System.Drawing.Size(629, 500);
            this.studentIdGenerate1.TabIndex = 5;
            this.studentIdGenerate1.Load += new System.EventHandler(this.studentIdGenerate1_Load);
            // 
            // StudentUserControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.studentIdGenerate1);
            this.Controls.Add(this.manageStudentUserControll1);
            this.Controls.Add(this.addStudentUserControll1);
            this.Controls.Add(this.btnGenerateStudentGroupID);
            this.Controls.Add(this.btnManageStudentDetails);
            this.Controls.Add(this.btnAddStudentDetails);
            this.Name = "StudentUserControll";
            this.Size = new System.Drawing.Size(629, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudentDetails;
        private System.Windows.Forms.Button btnManageStudentDetails;
        private System.Windows.Forms.Button btnGenerateStudentGroupID;
        private AddStudentUserControll addStudentUserControll1;
        private manageStudentUserControll manageStudentUserControll1;
        private StudentIdGenerate studentIdGenerate1;
    }
}
