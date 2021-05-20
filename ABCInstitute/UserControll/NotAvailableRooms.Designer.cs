
namespace ABCInstitute.UserControll
{
    partial class NotAvailableRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotAvailableRooms));
            this.button1 = new System.Windows.Forms.Button();
            this.btnS2Clear = new System.Windows.Forms.Button();
            this.btnS2Submit = new System.Windows.Forms.Button();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.lblSelectGroup = new System.Windows.Forms.Label();
            this.cmbSelectRoom = new System.Windows.Forms.ComboBox();
            this.lblSelectTag = new System.Windows.Forms.Label();
            this.lblSelectLecturer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSTime = new System.Windows.Forms.TextBox();
            this.txtETime = new System.Windows.Forms.TextBox();
            this.manageNotAvailableRooms1 = new ABCInstitute.UserControll.ManageNotAvailableRooms();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 162;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnS2Clear
            // 
            this.btnS2Clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnS2Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnS2Clear.FlatAppearance.BorderSize = 0;
            this.btnS2Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnS2Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnS2Clear.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS2Clear.Location = new System.Drawing.Point(272, 407);
            this.btnS2Clear.Name = "btnS2Clear";
            this.btnS2Clear.Size = new System.Drawing.Size(84, 36);
            this.btnS2Clear.TabIndex = 161;
            this.btnS2Clear.Text = "View";
            this.btnS2Clear.UseVisualStyleBackColor = false;
            this.btnS2Clear.Click += new System.EventHandler(this.btnS2Clear_Click);
            // 
            // btnS2Submit
            // 
            this.btnS2Submit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnS2Submit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnS2Submit.FlatAppearance.BorderSize = 0;
            this.btnS2Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnS2Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnS2Submit.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS2Submit.Location = new System.Drawing.Point(101, 407);
            this.btnS2Submit.Name = "btnS2Submit";
            this.btnS2Submit.Size = new System.Drawing.Size(98, 36);
            this.btnS2Submit.TabIndex = 158;
            this.btnS2Submit.Text = "Submit";
            this.btnS2Submit.UseVisualStyleBackColor = false;
            this.btnS2Submit.Click += new System.EventHandler(this.btnS2Submit_Click);
            // 
            // txtDay
            // 
            this.txtDay.BackColor = System.Drawing.Color.White;
            this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.Location = new System.Drawing.Point(294, 199);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(182, 20);
            this.txtDay.TabIndex = 157;
            // 
            // lblSelectSubject
            // 
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubject.Location = new System.Drawing.Point(132, 273);
            this.lblSelectSubject.Name = "lblSelectSubject";
            this.lblSelectSubject.Size = new System.Drawing.Size(90, 20);
            this.lblSelectSubject.TabIndex = 156;
            this.lblSelectSubject.Text = "End Time";
            // 
            // lblSelectGroup
            // 
            this.lblSelectGroup.AutoSize = true;
            this.lblSelectGroup.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGroup.Location = new System.Drawing.Point(132, 238);
            this.lblSelectGroup.Name = "lblSelectGroup";
            this.lblSelectGroup.Size = new System.Drawing.Size(99, 20);
            this.lblSelectGroup.TabIndex = 154;
            this.lblSelectGroup.Text = "Start Time";
            // 
            // cmbSelectRoom
            // 
            this.cmbSelectRoom.FormattingEnabled = true;
            this.cmbSelectRoom.Location = new System.Drawing.Point(294, 159);
            this.cmbSelectRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelectRoom.Name = "cmbSelectRoom";
            this.cmbSelectRoom.Size = new System.Drawing.Size(182, 21);
            this.cmbSelectRoom.TabIndex = 152;
            // 
            // lblSelectTag
            // 
            this.lblSelectTag.AutoSize = true;
            this.lblSelectTag.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTag.Location = new System.Drawing.Point(132, 199);
            this.lblSelectTag.Name = "lblSelectTag";
            this.lblSelectTag.Size = new System.Drawing.Size(42, 20);
            this.lblSelectTag.TabIndex = 150;
            this.lblSelectTag.Text = "Day";
            // 
            // lblSelectLecturer
            // 
            this.lblSelectLecturer.AutoSize = true;
            this.lblSelectLecturer.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLecturer.Location = new System.Drawing.Point(132, 159);
            this.lblSelectLecturer.Name = "lblSelectLecturer";
            this.lblSelectLecturer.Size = new System.Drawing.Size(110, 20);
            this.lblSelectLecturer.TabIndex = 149;
            this.lblSelectLecturer.Text = "Select Room";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(101, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(421, 66);
            this.btnBack.TabIndex = 151;
            this.btnBack.Text = "Add Not Available Times For The Rooms";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSTime
            // 
            this.txtSTime.BackColor = System.Drawing.Color.White;
            this.txtSTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTime.Location = new System.Drawing.Point(294, 238);
            this.txtSTime.Name = "txtSTime";
            this.txtSTime.Size = new System.Drawing.Size(182, 20);
            this.txtSTime.TabIndex = 163;
            // 
            // txtETime
            // 
            this.txtETime.BackColor = System.Drawing.Color.White;
            this.txtETime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtETime.Location = new System.Drawing.Point(294, 275);
            this.txtETime.Name = "txtETime";
            this.txtETime.Size = new System.Drawing.Size(182, 20);
            this.txtETime.TabIndex = 164;
            // 
            // manageNotAvailableRooms1
            // 
            this.manageNotAvailableRooms1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.manageNotAvailableRooms1.Location = new System.Drawing.Point(0, 0);
            this.manageNotAvailableRooms1.Name = "manageNotAvailableRooms1";
            this.manageNotAvailableRooms1.Size = new System.Drawing.Size(629, 500);
            this.manageNotAvailableRooms1.TabIndex = 165;
            this.manageNotAvailableRooms1.Load += new System.EventHandler(this.manageNotAvailableRooms1_Load);
            // 
            // NotAvailableRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.manageNotAvailableRooms1);
            this.Controls.Add(this.txtETime);
            this.Controls.Add(this.txtSTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnS2Clear);
            this.Controls.Add(this.btnS2Submit);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblSelectSubject);
            this.Controls.Add(this.lblSelectGroup);
            this.Controls.Add(this.cmbSelectRoom);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSelectTag);
            this.Controls.Add(this.lblSelectLecturer);
            this.Name = "NotAvailableRooms";
            this.Size = new System.Drawing.Size(629, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnS2Clear;
        private System.Windows.Forms.Button btnS2Submit;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.Label lblSelectGroup;
        private System.Windows.Forms.ComboBox cmbSelectRoom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSelectTag;
        private System.Windows.Forms.Label lblSelectLecturer;
        private System.Windows.Forms.TextBox txtSTime;
        private System.Windows.Forms.TextBox txtETime;
        private ManageNotAvailableRooms manageNotAvailableRooms1;
    }
}
