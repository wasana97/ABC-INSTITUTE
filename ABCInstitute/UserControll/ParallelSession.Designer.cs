
namespace ABCInstitute.UserControll
{
    partial class ParallelSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParallelSession));
            this.cmbSelectTag = new System.Windows.Forms.ComboBox();
            this.cmbSelectGroup = new System.Windows.Forms.ComboBox();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.cmbSelectSubjectCode = new System.Windows.Forms.ComboBox();
            this.cmbSelectLecturer2 = new System.Windows.Forms.ComboBox();
            this.cmbSelectLecturer1 = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtView = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manageParallelSession1 = new ABCInstitute.UserControll.ManageParallelSession();
            this.SuspendLayout();
            // 
            // cmbSelectTag
            // 
            this.cmbSelectTag.FormattingEnabled = true;
            this.cmbSelectTag.Location = new System.Drawing.Point(285, 360);
            this.cmbSelectTag.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectTag.Name = "cmbSelectTag";
            this.cmbSelectTag.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectTag.TabIndex = 183;
            // 
            // cmbSelectGroup
            // 
            this.cmbSelectGroup.FormattingEnabled = true;
            this.cmbSelectGroup.Location = new System.Drawing.Point(285, 313);
            this.cmbSelectGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectGroup.Name = "cmbSelectGroup";
            this.cmbSelectGroup.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectGroup.TabIndex = 182;
            // 
            // cmbSelectSubject
            // 
            this.cmbSelectSubject.FormattingEnabled = true;
            this.cmbSelectSubject.Location = new System.Drawing.Point(285, 268);
            this.cmbSelectSubject.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectSubject.Name = "cmbSelectSubject";
            this.cmbSelectSubject.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectSubject.TabIndex = 181;
            // 
            // cmbSelectSubjectCode
            // 
            this.cmbSelectSubjectCode.FormattingEnabled = true;
            this.cmbSelectSubjectCode.Location = new System.Drawing.Point(285, 221);
            this.cmbSelectSubjectCode.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectSubjectCode.Name = "cmbSelectSubjectCode";
            this.cmbSelectSubjectCode.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectSubjectCode.TabIndex = 180;
            // 
            // cmbSelectLecturer2
            // 
            this.cmbSelectLecturer2.FormattingEnabled = true;
            this.cmbSelectLecturer2.Items.AddRange(new object[] {
            "Lectures",
            "Lab",
            "Tutorial",
            "Evalution"});
            this.cmbSelectLecturer2.Location = new System.Drawing.Point(285, 182);
            this.cmbSelectLecturer2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectLecturer2.Name = "cmbSelectLecturer2";
            this.cmbSelectLecturer2.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectLecturer2.TabIndex = 179;
            // 
            // cmbSelectLecturer1
            // 
            this.cmbSelectLecturer1.FormattingEnabled = true;
            this.cmbSelectLecturer1.Location = new System.Drawing.Point(285, 142);
            this.cmbSelectLecturer1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectLecturer1.Name = "cmbSelectLecturer1";
            this.cmbSelectLecturer1.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectLecturer1.TabIndex = 178;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(105, 39);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(418, 32);
            this.btnBack.TabIndex = 177;
            this.btnBack.Text = "Add Parallel Session";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtView
            // 
            this.txtView.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.txtView.FlatAppearance.BorderSize = 0;
            this.txtView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.txtView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.txtView.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView.Location = new System.Drawing.Point(256, 425);
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(75, 36);
            this.txtView.TabIndex = 176;
            this.txtView.Text = "View";
            this.txtView.UseVisualStyleBackColor = false;
            this.txtView.Click += new System.EventHandler(this.txtView_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 175;
            this.label6.Text = "Tag Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 174;
            this.label5.Text = "Group ID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(391, 425);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 173;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(105, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 172;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 171;
            this.label4.Text = "Subject Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 170;
            this.label3.Text = "Subject Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 169;
            this.label2.Text = "Lecturer 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 168;
            this.label1.Text = "Lecturer 1";
            // 
            // manageParallelSession1
            // 
            this.manageParallelSession1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.manageParallelSession1.Location = new System.Drawing.Point(0, 0);
            this.manageParallelSession1.Name = "manageParallelSession1";
            this.manageParallelSession1.Size = new System.Drawing.Size(629, 500);
            this.manageParallelSession1.TabIndex = 184;
            this.manageParallelSession1.Load += new System.EventHandler(this.manageParallelSession1_Load);
            // 
            // ParallelSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.manageParallelSession1);
            this.Controls.Add(this.cmbSelectTag);
            this.Controls.Add(this.cmbSelectGroup);
            this.Controls.Add(this.cmbSelectSubject);
            this.Controls.Add(this.cmbSelectSubjectCode);
            this.Controls.Add(this.cmbSelectLecturer2);
            this.Controls.Add(this.cmbSelectLecturer1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ParallelSession";
            this.Size = new System.Drawing.Size(629, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectTag;
        private System.Windows.Forms.ComboBox cmbSelectGroup;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.ComboBox cmbSelectSubjectCode;
        private System.Windows.Forms.ComboBox cmbSelectLecturer2;
        private System.Windows.Forms.ComboBox cmbSelectLecturer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button txtView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ManageParallelSession manageParallelSession1;
    }
}
