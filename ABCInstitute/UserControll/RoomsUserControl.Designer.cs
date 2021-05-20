
namespace ABCInstitute.UserControll
{
    partial class RoomsUserControl
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
            this.btnlocation = new System.Windows.Forms.Button();
            this.btnconsecutibeSession = new System.Windows.Forms.Button();
            this.btnsuitableRoom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roomUI1 = new ABCInstitute.UserControll.RoomUI();
            this.addSutableRoom1 = new ABCInstitute.UserControll.AddSutableRoom();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlocation
            // 
            this.btnlocation.FlatAppearance.BorderSize = 0;
            this.btnlocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlocation.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlocation.Location = new System.Drawing.Point(29, 30);
            this.btnlocation.Name = "btnlocation";
            this.btnlocation.Size = new System.Drawing.Size(159, 27);
            this.btnlocation.TabIndex = 6;
            this.btnlocation.Text = "Location";
            this.btnlocation.UseVisualStyleBackColor = true;
            this.btnlocation.Click += new System.EventHandler(this.btnlocation_Click);
            // 
            // btnconsecutibeSession
            // 
            this.btnconsecutibeSession.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnconsecutibeSession.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsecutibeSession.Location = new System.Drawing.Point(347, 173);
            this.btnconsecutibeSession.Name = "btnconsecutibeSession";
            this.btnconsecutibeSession.Size = new System.Drawing.Size(237, 149);
            this.btnconsecutibeSession.TabIndex = 5;
            this.btnconsecutibeSession.Text = "Add Room For Session And Consecutibe Sessions And Not Available Times";
            this.btnconsecutibeSession.UseVisualStyleBackColor = false;
            this.btnconsecutibeSession.Click += new System.EventHandler(this.btnconsecutibeSession_Click);
            // 
            // btnsuitableRoom
            // 
            this.btnsuitableRoom.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsuitableRoom.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuitableRoom.Location = new System.Drawing.Point(45, 173);
            this.btnsuitableRoom.Name = "btnsuitableRoom";
            this.btnsuitableRoom.Size = new System.Drawing.Size(237, 149);
            this.btnsuitableRoom.TabIndex = 4;
            this.btnsuitableRoom.Text = "Add Suitable Room";
            this.btnsuitableRoom.UseVisualStyleBackColor = false;
            this.btnsuitableRoom.Click += new System.EventHandler(this.btnsuitableRoom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCInstitute.Properties.Resources.Button_Previous_icon;
            this.pictureBox1.Location = new System.Drawing.Point(29, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // roomUI1
            // 
            this.roomUI1.BackColor = System.Drawing.Color.White;
            this.roomUI1.Location = new System.Drawing.Point(0, 0);
            this.roomUI1.Name = "roomUI1";
            this.roomUI1.Size = new System.Drawing.Size(629, 500);
            this.roomUI1.TabIndex = 8;
            this.roomUI1.Load += new System.EventHandler(this.roomUI1_Load_2);
            // 
            // addSutableRoom1
            // 
            this.addSutableRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addSutableRoom1.Location = new System.Drawing.Point(0, 0);
            this.addSutableRoom1.Name = "addSutableRoom1";
            this.addSutableRoom1.Size = new System.Drawing.Size(629, 500);
            this.addSutableRoom1.TabIndex = 9;
            // 
            // RoomsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.addSutableRoom1);
            this.Controls.Add(this.roomUI1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlocation);
            this.Controls.Add(this.btnconsecutibeSession);
            this.Controls.Add(this.btnsuitableRoom);
            this.Name = "RoomsUserControl";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.RoomsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlocation;
        private System.Windows.Forms.Button btnconsecutibeSession;
        private System.Windows.Forms.Button btnsuitableRoom;
        private RoomUI roomUI1;
        private AddSutableRoom addSutableRoom1;
    }
}
