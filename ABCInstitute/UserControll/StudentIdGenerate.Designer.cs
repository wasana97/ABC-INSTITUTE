
namespace ABCInstitute.UserControll
{
    partial class StudentIdGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentIdGenerate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.txtSubGroupId = new System.Windows.Forms.MaskedTextBox();
            this.txtStudentId = new System.Windows.Forms.MaskedTextBox();
            this.btnGenerateGroupId = new System.Windows.Forms.Button();
            this.btnGenerateSubGroupId = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sub Group ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Student ID";
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(283, 154);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(212, 20);
            this.txtGroupId.TabIndex = 3;
            // 
            // txtSubGroupId
            // 
            this.txtSubGroupId.Location = new System.Drawing.Point(283, 218);
            this.txtSubGroupId.Name = "txtSubGroupId";
            this.txtSubGroupId.Size = new System.Drawing.Size(212, 20);
            this.txtSubGroupId.TabIndex = 4;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(283, 313);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(79, 20);
            this.txtStudentId.TabIndex = 5;
            // 
            // btnGenerateGroupId
            // 
            this.btnGenerateGroupId.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateGroupId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateGroupId.Location = new System.Drawing.Point(283, 180);
            this.btnGenerateGroupId.Name = "btnGenerateGroupId";
            this.btnGenerateGroupId.Size = new System.Drawing.Size(212, 31);
            this.btnGenerateGroupId.TabIndex = 6;
            this.btnGenerateGroupId.Text = "generate Group Id";
            this.btnGenerateGroupId.UseVisualStyleBackColor = false;
            this.btnGenerateGroupId.Click += new System.EventHandler(this.btnGenerateGroupId_Click);
            // 
            // btnGenerateSubGroupId
            // 
            this.btnGenerateSubGroupId.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateSubGroupId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSubGroupId.Location = new System.Drawing.Point(283, 244);
            this.btnGenerateSubGroupId.Name = "btnGenerateSubGroupId";
            this.btnGenerateSubGroupId.Size = new System.Drawing.Size(212, 31);
            this.btnGenerateSubGroupId.TabIndex = 7;
            this.btnGenerateSubGroupId.Text = "generate Sub Group Id";
            this.btnGenerateSubGroupId.UseVisualStyleBackColor = false;
            this.btnGenerateSubGroupId.Click += new System.EventHandler(this.btnGenerateSubGroupId_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(33, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate Group ID\'S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentIdGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerateSubGroupId);
            this.Controls.Add(this.btnGenerateGroupId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtSubGroupId);
            this.Controls.Add(this.txtGroupId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentIdGenerate";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.StudentIdGenerate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.MaskedTextBox txtSubGroupId;
        private System.Windows.Forms.MaskedTextBox txtStudentId;
        private System.Windows.Forms.Button btnGenerateGroupId;
        private System.Windows.Forms.Button btnGenerateSubGroupId;
        private System.Windows.Forms.Button button1;
    }
}
