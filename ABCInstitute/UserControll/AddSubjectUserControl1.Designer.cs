
namespace ABCInstitute.UserControll
{
    partial class AddSubjectUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubjectUserControl1));
            this.cmbOSemester = new System.Windows.Forms.ComboBox();
            this.cmbEvh = new System.Windows.Forms.ComboBox();
            this.cmbLah = new System.Windows.Forms.ComboBox();
            this.cmbTuh = new System.Windows.Forms.ComboBox();
            this.cmbLech = new System.Windows.Forms.ComboBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEvh = new System.Windows.Forms.Label();
            this.lblLah = new System.Windows.Forms.Label();
            this.lblTuh = new System.Windows.Forms.Label();
            this.lblLech = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtOfferedYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOfferedYear = new System.Windows.Forms.Label();
            this.viewSubjectUserControl11 = new ABCInstitute.UserControll.ViewSubjectUserControl1();
            this.SuspendLayout();
            // 
            // cmbOSemester
            // 
            this.cmbOSemester.FormattingEnabled = true;
            this.cmbOSemester.Items.AddRange(new object[] {
            "1_Semester",
            "2_Semester"});
            this.cmbOSemester.Location = new System.Drawing.Point(288, 127);
            this.cmbOSemester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOSemester.Name = "cmbOSemester";
            this.cmbOSemester.Size = new System.Drawing.Size(239, 21);
            this.cmbOSemester.TabIndex = 130;
            this.cmbOSemester.Text = "                     ---------------Select---------------";
            // 
            // cmbEvh
            // 
            this.cmbEvh.FormattingEnabled = true;
            this.cmbEvh.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbEvh.Location = new System.Drawing.Point(312, 323);
            this.cmbEvh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEvh.Name = "cmbEvh";
            this.cmbEvh.Size = new System.Drawing.Size(52, 21);
            this.cmbEvh.TabIndex = 129;
            // 
            // cmbLah
            // 
            this.cmbLah.FormattingEnabled = true;
            this.cmbLah.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbLah.Location = new System.Drawing.Point(312, 290);
            this.cmbLah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLah.Name = "cmbLah";
            this.cmbLah.Size = new System.Drawing.Size(52, 21);
            this.cmbLah.TabIndex = 128;
            // 
            // cmbTuh
            // 
            this.cmbTuh.FormattingEnabled = true;
            this.cmbTuh.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbTuh.Location = new System.Drawing.Point(312, 261);
            this.cmbTuh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTuh.Name = "cmbTuh";
            this.cmbTuh.Size = new System.Drawing.Size(52, 21);
            this.cmbTuh.TabIndex = 127;
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
            this.cmbLech.Location = new System.Drawing.Point(312, 226);
            this.cmbLech.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLech.Name = "cmbLech";
            this.cmbLech.Size = new System.Drawing.Size(52, 21);
            this.cmbLech.TabIndex = 126;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.BackColor = System.Drawing.Color.White;
            this.txtSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(288, 162);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(237, 20);
            this.txtSubjectName.TabIndex = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(190, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 124;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEvh
            // 
            this.lblEvh.AutoSize = true;
            this.lblEvh.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvh.Location = new System.Drawing.Point(58, 323);
            this.lblEvh.Name = "lblEvh";
            this.lblEvh.Size = new System.Drawing.Size(246, 20);
            this.lblEvh.TabIndex = 123;
            this.lblEvh.Text = "Number of Evaluation hours";
            // 
            // lblLah
            // 
            this.lblLah.AutoSize = true;
            this.lblLah.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLah.Location = new System.Drawing.Point(58, 291);
            this.lblLah.Name = "lblLah";
            this.lblLah.Size = new System.Drawing.Size(185, 20);
            this.lblLah.TabIndex = 122;
            this.lblLah.Text = "Number of Lab hours";
            // 
            // lblTuh
            // 
            this.lblTuh.AutoSize = true;
            this.lblTuh.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuh.Location = new System.Drawing.Point(58, 258);
            this.lblTuh.Name = "lblTuh";
            this.lblTuh.Size = new System.Drawing.Size(222, 20);
            this.lblTuh.TabIndex = 121;
            this.lblTuh.Text = "Number of Tutorial hours";
            // 
            // lblLech
            // 
            this.lblLech.AutoSize = true;
            this.lblLech.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLech.Location = new System.Drawing.Point(58, 223);
            this.lblLech.Name = "lblLech";
            this.lblLech.Size = new System.Drawing.Size(225, 20);
            this.lblLech.TabIndex = 120;
            this.lblLech.Text = "Number of Lecturer hours";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(40, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(302, 32);
            this.btnBack.TabIndex = 119;
            this.btnBack.Text = "Add Subject Details";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(433, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 118;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(312, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 117;
            this.btnSave.Text = "ADD";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(290, 193);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(237, 20);
            this.txtCode.TabIndex = 116;
            // 
            // txtOfferedYear
            // 
            this.txtOfferedYear.BackColor = System.Drawing.Color.White;
            this.txtOfferedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfferedYear.Location = new System.Drawing.Point(290, 93);
            this.txtOfferedYear.Name = "txtOfferedYear";
            this.txtOfferedYear.Size = new System.Drawing.Size(237, 20);
            this.txtOfferedYear.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 114;
            this.label4.Text = "Subject Code";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectName.Location = new System.Drawing.Point(58, 160);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(124, 20);
            this.lblSubjectName.TabIndex = 113;
            this.lblSubjectName.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 112;
            this.label2.Text = "Offered Semester";
            // 
            // lblOfferedYear
            // 
            this.lblOfferedYear.AutoSize = true;
            this.lblOfferedYear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfferedYear.Location = new System.Drawing.Point(58, 93);
            this.lblOfferedYear.Name = "lblOfferedYear";
            this.lblOfferedYear.Size = new System.Drawing.Size(114, 20);
            this.lblOfferedYear.TabIndex = 111;
            this.lblOfferedYear.Text = "Offered Year";
            // 
            // viewSubjectUserControl11
            // 
            this.viewSubjectUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.viewSubjectUserControl11.Location = new System.Drawing.Point(0, 0);
            this.viewSubjectUserControl11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewSubjectUserControl11.Name = "viewSubjectUserControl11";
            this.viewSubjectUserControl11.Size = new System.Drawing.Size(629, 500);
            this.viewSubjectUserControl11.TabIndex = 131;
            this.viewSubjectUserControl11.Load += new System.EventHandler(this.viewSubjectUserControl11_Load);
            // 
            // AddSubjectUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.viewSubjectUserControl11);
            this.Controls.Add(this.cmbOSemester);
            this.Controls.Add(this.cmbEvh);
            this.Controls.Add(this.cmbLah);
            this.Controls.Add(this.cmbTuh);
            this.Controls.Add(this.cmbLech);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEvh);
            this.Controls.Add(this.lblLah);
            this.Controls.Add(this.lblTuh);
            this.Controls.Add(this.lblLech);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtOfferedYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOfferedYear);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddSubjectUserControl1";
            this.Size = new System.Drawing.Size(629, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOSemester;
        private System.Windows.Forms.ComboBox cmbEvh;
        private System.Windows.Forms.ComboBox cmbLah;
        private System.Windows.Forms.ComboBox cmbTuh;
        private System.Windows.Forms.ComboBox cmbLech;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEvh;
        private System.Windows.Forms.Label lblLah;
        private System.Windows.Forms.Label lblTuh;
        private System.Windows.Forms.Label lblLech;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtOfferedYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOfferedYear;
        private ViewSubjectUserControl1 viewSubjectUserControl11;
    }
}
