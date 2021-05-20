
namespace ABCInstitute.UserControll
{
    partial class AddBuildingsUserControl
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
            this.btnclear = new System.Windows.Forms.Button();
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtroomName = new System.Windows.Forms.TextBox();
            this.txtbuildingName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnaddLocation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnclear.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(453, 357);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(125, 49);
            this.btnclear.TabIndex = 25;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(322, 275);
            this.txtcapacity.Multiline = true;
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(256, 30);
            this.txtcapacity.TabIndex = 24;
            this.txtcapacity.TextChanged += new System.EventHandler(this.txtcapacity_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(522, 232);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 23);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lab";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(322, 232);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 23);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lecture Hall";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtroomName
            // 
            this.txtroomName.Location = new System.Drawing.Point(322, 169);
            this.txtroomName.Multiline = true;
            this.txtroomName.Name = "txtroomName";
            this.txtroomName.Size = new System.Drawing.Size(256, 30);
            this.txtroomName.TabIndex = 21;
            this.txtroomName.TextChanged += new System.EventHandler(this.txtroomName_TextChanged);
            // 
            // txtbuildingName
            // 
            this.txtbuildingName.Location = new System.Drawing.Point(322, 119);
            this.txtbuildingName.Multiline = true;
            this.txtbuildingName.Name = "txtbuildingName";
            this.txtbuildingName.Size = new System.Drawing.Size(256, 29);
            this.txtbuildingName.TabIndex = 20;
            this.txtbuildingName.TextChanged += new System.EventHandler(this.txtbuildingName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Capacity                  =";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Room Type             =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Room Name            =";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Building Name       =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(322, 357);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(125, 49);
            this.btnadd.TabIndex = 14;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnaddLocation
            // 
            this.btnaddLocation.FlatAppearance.BorderSize = 0;
            this.btnaddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddLocation.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddLocation.Location = new System.Drawing.Point(33, 30);
            this.btnaddLocation.Name = "btnaddLocation";
            this.btnaddLocation.Size = new System.Drawing.Size(189, 33);
            this.btnaddLocation.TabIndex = 13;
            this.btnaddLocation.Text = "Add Location";
            this.btnaddLocation.UseVisualStyleBackColor = true;
            this.btnaddLocation.Click += new System.EventHandler(this.btnaddLocation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCInstitute.Properties.Resources.Button_Previous_icon;
            this.pictureBox1.Location = new System.Drawing.Point(16, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // AddBuildingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtcapacity);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtroomName);
            this.Controls.Add(this.txtbuildingName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnaddLocation);
            this.Name = "AddBuildingsUserControl";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.AddBuildingsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtcapacity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtroomName;
        private System.Windows.Forms.TextBox txtbuildingName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnaddLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
