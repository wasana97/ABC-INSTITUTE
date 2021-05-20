
namespace ABCInstitute.UserControll
{
    partial class ConsecutiveSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsecutiveSession));
            this.cmbSelectTag = new System.Windows.Forms.ComboBox();
            this.cmbSelectGroup = new System.Windows.Forms.ComboBox();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.cmbSelectSubjectCode = new System.Windows.Forms.ComboBox();
            this.cmbSelectLecturer2 = new System.Windows.Forms.ComboBox();
            this.cmbSelectLecturer1 = new System.Windows.Forms.ComboBox();
            this.txtView = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.manageConsecutiveSession1 = new ABCInstitute.UserControll.ManageConsecutiveSession();
            this.SuspendLayout();
            // 
            // cmbSelectTag
            // 
            this.cmbSelectTag.FormattingEnabled = true;
            this.cmbSelectTag.Location = new System.Drawing.Point(276, 350);
            this.cmbSelectTag.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectTag.Name = "cmbSelectTag";
            this.cmbSelectTag.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectTag.TabIndex = 151;
            // 
            // cmbSelectGroup
            // 
            this.cmbSelectGroup.FormattingEnabled = true;
            this.cmbSelectGroup.Location = new System.Drawing.Point(276, 303);
            this.cmbSelectGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectGroup.Name = "cmbSelectGroup";
            this.cmbSelectGroup.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectGroup.TabIndex = 150;
            // 
            // cmbSelectSubject
            // 
            this.cmbSelectSubject.FormattingEnabled = true;
            this.cmbSelectSubject.Location = new System.Drawing.Point(276, 258);
            this.cmbSelectSubject.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectSubject.Name = "cmbSelectSubject";
            this.cmbSelectSubject.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectSubject.TabIndex = 149;
            // 
            // cmbSelectSubjectCode
            // 
            this.cmbSelectSubjectCode.FormattingEnabled = true;
            this.cmbSelectSubjectCode.Location = new System.Drawing.Point(276, 211);
            this.cmbSelectSubjectCode.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectSubjectCode.Name = "cmbSelectSubjectCode";
            this.cmbSelectSubjectCode.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectSubjectCode.TabIndex = 148;
            // 
            // cmbSelectLecturer2
            // 
            this.cmbSelectLecturer2.FormattingEnabled = true;
            this.cmbSelectLecturer2.Items.AddRange(new object[] {
            "Lectures",
            "Lab",
            "Tutorial",
            "Evalution"});
            this.cmbSelectLecturer2.Location = new System.Drawing.Point(276, 172);
            this.cmbSelectLecturer2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectLecturer2.Name = "cmbSelectLecturer2";
            this.cmbSelectLecturer2.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectLecturer2.TabIndex = 147;
            // 
            // cmbSelectLecturer1
            // 
            this.cmbSelectLecturer1.FormattingEnabled = true;
            this.cmbSelectLecturer1.Location = new System.Drawing.Point(276, 132);
            this.cmbSelectLecturer1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectLecturer1.Name = "cmbSelectLecturer1";
            this.cmbSelectLecturer1.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectLecturer1.TabIndex = 146;
            // 
            // txtView
            // 
            this.txtView.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.txtView.FlatAppearance.BorderSize = 0;
            this.txtView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.txtView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.txtView.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView.Location = new System.Drawing.Point(251, 410);
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(75, 36);
            this.txtView.TabIndex = 144;
            this.txtView.Text = "View";
            this.txtView.UseVisualStyleBackColor = false;
            this.txtView.Click += new System.EventHandler(this.txtView_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 143;
            this.label6.Text = "Tag Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 142;
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
            this.btnClear.Location = new System.Drawing.Point(386, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 141;
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
            this.btnSave.Location = new System.Drawing.Point(106, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 140;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 139;
            this.label4.Text = "Subject Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 138;
            this.label3.Text = "Subject Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 137;
            this.label2.Text = "Lecturer 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "Lecturer 1";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(106, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(418, 32);
            this.btnBack.TabIndex = 145;
            this.btnBack.Text = "Add Consecutive Session";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // manageConsecutiveSession1
            // 
            this.manageConsecutiveSession1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.manageConsecutiveSession1.Location = new System.Drawing.Point(0, 0);
            this.manageConsecutiveSession1.Name = "manageConsecutiveSession1";
            this.manageConsecutiveSession1.Size = new System.Drawing.Size(629, 500);
            this.manageConsecutiveSession1.TabIndex = 152;
            this.manageConsecutiveSession1.Load += new System.EventHandler(this.manageConsecutiveSession1_Load);
            // 
            // ConsecutiveSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.manageConsecutiveSession1);
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
            this.Name = "ConsecutiveSession";
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
        private ManageConsecutiveSession manageConsecutiveSession1;
    }
}
