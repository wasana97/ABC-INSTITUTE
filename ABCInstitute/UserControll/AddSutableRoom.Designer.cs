
namespace ABCInstitute.UserControll
{
    partial class AddSutableRoom
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
            this.btnVIEW = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtroomname = new System.Windows.Forms.TextBox();
            this.cmbRoomtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtag = new System.Windows.Forms.ComboBox();
            this.btnviewRoomDetails = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewSuitableRooms1 = new ABCInstitute.UserControll.ViewSuitableRooms();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVIEW
            // 
            this.btnVIEW.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVIEW.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnVIEW.Location = new System.Drawing.Point(183, 405);
            this.btnVIEW.Name = "btnVIEW";
            this.btnVIEW.Size = new System.Drawing.Size(125, 49);
            this.btnVIEW.TabIndex = 99;
            this.btnVIEW.Text = "VIEW";
            this.btnVIEW.UseVisualStyleBackColor = false;
            this.btnVIEW.Click += new System.EventHandler(this.btnVIEW_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnAdd.Location = new System.Drawing.Point(330, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 49);
            this.btnAdd.TabIndex = 98;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtroomname
            // 
            this.txtroomname.Location = new System.Drawing.Point(355, 243);
            this.txtroomname.Multiline = true;
            this.txtroomname.Name = "txtroomname";
            this.txtroomname.Size = new System.Drawing.Size(236, 84);
            this.txtroomname.TabIndex = 97;
            // 
            // cmbRoomtype
            // 
            this.cmbRoomtype.FormattingEnabled = true;
            this.cmbRoomtype.Location = new System.Drawing.Point(355, 170);
            this.cmbRoomtype.Name = "cmbRoomtype";
            this.cmbRoomtype.Size = new System.Drawing.Size(236, 21);
            this.cmbRoomtype.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label3.Location = new System.Drawing.Point(74, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 27);
            this.label3.TabIndex = 95;
            this.label3.Text = "Selected Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label2.Location = new System.Drawing.Point(74, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 94;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label1.Location = new System.Drawing.Point(74, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 93;
            this.label1.Text = "Tag";
            // 
            // cmbtag
            // 
            this.cmbtag.FormattingEnabled = true;
            this.cmbtag.Location = new System.Drawing.Point(355, 105);
            this.cmbtag.Name = "cmbtag";
            this.cmbtag.Size = new System.Drawing.Size(236, 21);
            this.cmbtag.TabIndex = 92;
            // 
            // btnviewRoomDetails
            // 
            this.btnviewRoomDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnviewRoomDetails.FlatAppearance.BorderSize = 0;
            this.btnviewRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewRoomDetails.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewRoomDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewRoomDetails.Location = new System.Drawing.Point(26, 9);
            this.btnviewRoomDetails.Name = "btnviewRoomDetails";
            this.btnviewRoomDetails.Size = new System.Drawing.Size(240, 29);
            this.btnviewRoomDetails.TabIndex = 90;
            this.btnviewRoomDetails.Text = "Add Suitable Rooms";
            this.btnviewRoomDetails.UseVisualStyleBackColor = true;
            this.btnviewRoomDetails.Click += new System.EventHandler(this.btnviewRoomDetails_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnClear.Location = new System.Drawing.Point(476, 405);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 49);
            this.btnClear.TabIndex = 100;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCInstitute.Properties.Resources.Button_Previous_icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // viewSuitableRooms1
            // 
            this.viewSuitableRooms1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.viewSuitableRooms1.Location = new System.Drawing.Point(0, 0);
            this.viewSuitableRooms1.Name = "viewSuitableRooms1";
            this.viewSuitableRooms1.Size = new System.Drawing.Size(629, 500);
            this.viewSuitableRooms1.TabIndex = 101;
            this.viewSuitableRooms1.Load += new System.EventHandler(this.viewSuitableRooms1_Load);
            // 
            // AddSutableRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.viewSuitableRooms1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVIEW);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtroomname);
            this.Controls.Add(this.cmbRoomtype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbtag);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnviewRoomDetails);
            this.Name = "AddSutableRoom";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.AddSutableRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVIEW;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtroomname;
        private System.Windows.Forms.ComboBox cmbRoomtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbtag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnviewRoomDetails;
        private System.Windows.Forms.Button btnClear;
        private ViewSuitableRooms viewSuitableRooms1;
    }
}
