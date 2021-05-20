
namespace ABCInstitute.UserControll
{
    partial class RoomUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomUI));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.addConsecutiveSession1 = new ABCInstitute.UserControll.ADDConsecutiveSession();
            this.manageSessionRooms1 = new ABCInstitute.UserControll.ManageSessionRooms();
            this.notAvailableRooms1 = new ABCInstitute.UserControll.NotAvailableRooms();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 105);
            this.button1.TabIndex = 12;
            this.button1.Text = "ADD SESSION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(206, 293);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 101);
            this.button2.TabIndex = 13;
            this.button2.Text = "ADD NOT AVAILABLE TIMES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(347, 88);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 105);
            this.button3.TabIndex = 14;
            this.button3.Text = "ADD CONSECUTIVE SESSION";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(33, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(211, 32);
            this.btnBack.TabIndex = 104;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // addConsecutiveSession1
            // 
            this.addConsecutiveSession1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addConsecutiveSession1.Location = new System.Drawing.Point(0, 0);
            this.addConsecutiveSession1.Name = "addConsecutiveSession1";
            this.addConsecutiveSession1.Size = new System.Drawing.Size(629, 500);
            this.addConsecutiveSession1.TabIndex = 107;
            this.addConsecutiveSession1.Load += new System.EventHandler(this.addConsecutiveSession1_Load);
            // 
            // manageSessionRooms1
            // 
            this.manageSessionRooms1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.manageSessionRooms1.Location = new System.Drawing.Point(0, 0);
            this.manageSessionRooms1.Name = "manageSessionRooms1";
            this.manageSessionRooms1.Size = new System.Drawing.Size(629, 500);
            this.manageSessionRooms1.TabIndex = 106;
            // 
            // notAvailableRooms1
            // 
            this.notAvailableRooms1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.notAvailableRooms1.Location = new System.Drawing.Point(0, 0);
            this.notAvailableRooms1.Name = "notAvailableRooms1";
            this.notAvailableRooms1.Size = new System.Drawing.Size(629, 500);
            this.notAvailableRooms1.TabIndex = 105;
            this.notAvailableRooms1.Load += new System.EventHandler(this.notAvailableRooms1_Load_1);
            // 
            // RoomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addConsecutiveSession1);
            this.Controls.Add(this.manageSessionRooms1);
            this.Controls.Add(this.notAvailableRooms1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "RoomUI";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.RoomUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBack;
        private NotAvailableRooms notAvailableRooms1;
        private ManageSessionRooms manageSessionRooms1;
        private ADDConsecutiveSession addConsecutiveSession1;
    }
}
