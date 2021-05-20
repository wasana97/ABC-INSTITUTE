
namespace ABCInstitute.UserControll
{
    partial class StaticticsUserControl
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
            this.btnsubjects = new System.Windows.Forms.Button();
            this.btnluctures = new System.Windows.Forms.Button();
            this.btnstudents = new System.Windows.Forms.Button();
            this.lucturesUserControl1 = new ABCInstitute.UserControll.LucturesUserControl();
            this.studentsUserControl1 = new ABCInstitute.UserControll.StudentsUserControl();
            this.subjectsUserControl1 = new ABCInstitute.UserControll.SubjectsUserControl();
            this.SuspendLayout();
            // 
            // btnsubjects
            // 
            this.btnsubjects.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsubjects.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubjects.Location = new System.Drawing.Point(227, 289);
            this.btnsubjects.Name = "btnsubjects";
            this.btnsubjects.Size = new System.Drawing.Size(169, 89);
            this.btnsubjects.TabIndex = 6;
            this.btnsubjects.Text = "Subjects";
            this.btnsubjects.UseVisualStyleBackColor = false;
            this.btnsubjects.Click += new System.EventHandler(this.btnsubjects_Click);
            // 
            // btnluctures
            // 
            this.btnluctures.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnluctures.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluctures.Location = new System.Drawing.Point(390, 123);
            this.btnluctures.Name = "btnluctures";
            this.btnluctures.Size = new System.Drawing.Size(169, 89);
            this.btnluctures.TabIndex = 5;
            this.btnluctures.Text = "Lectures";
            this.btnluctures.UseVisualStyleBackColor = false;
            this.btnluctures.Click += new System.EventHandler(this.btnluctures_Click);
            // 
            // btnstudents
            // 
            this.btnstudents.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnstudents.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudents.Location = new System.Drawing.Point(70, 123);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(169, 89);
            this.btnstudents.TabIndex = 4;
            this.btnstudents.Text = "Students";
            this.btnstudents.UseVisualStyleBackColor = false;
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // lucturesUserControl1
            // 
            this.lucturesUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lucturesUserControl1.Location = new System.Drawing.Point(0, 1);
            this.lucturesUserControl1.Name = "lucturesUserControl1";
            this.lucturesUserControl1.Size = new System.Drawing.Size(629, 500);
            this.lucturesUserControl1.TabIndex = 7;
            // 
            // studentsUserControl1
            // 
            this.studentsUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.studentsUserControl1.Location = new System.Drawing.Point(-2, 0);
            this.studentsUserControl1.Name = "studentsUserControl1";
            this.studentsUserControl1.Size = new System.Drawing.Size(629, 500);
            this.studentsUserControl1.TabIndex = 8;
            this.studentsUserControl1.Load += new System.EventHandler(this.studentsUserControl1_Load);
            // 
            // subjectsUserControl1
            // 
            this.subjectsUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.subjectsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.subjectsUserControl1.Name = "subjectsUserControl1";
            this.subjectsUserControl1.Size = new System.Drawing.Size(629, 500);
            this.subjectsUserControl1.TabIndex = 9;
            this.subjectsUserControl1.Load += new System.EventHandler(this.subjectsUserControl1_Load);
            // 
            // StaticticsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.subjectsUserControl1);
            this.Controls.Add(this.studentsUserControl1);
            this.Controls.Add(this.lucturesUserControl1);
            this.Controls.Add(this.btnsubjects);
            this.Controls.Add(this.btnluctures);
            this.Controls.Add(this.btnstudents);
            this.Name = "StaticticsUserControl";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.StaticticsUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsubjects;
        private System.Windows.Forms.Button btnluctures;
        private System.Windows.Forms.Button btnstudents;
        private LucturesUserControl lucturesUserControl1;
        private StudentsUserControl studentsUserControl1;
        private SubjectsUserControl subjectsUserControl1;
    }
}
