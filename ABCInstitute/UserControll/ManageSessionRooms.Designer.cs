
namespace ABCInstitute.UserControll
{
    partial class ManageSessionRooms
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSsession = new System.Windows.Forms.TextBox();
            this.cmbSessionRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.btnviewRoomDetails = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewManageSessionRooms1 = new ABCInstitute.UserControll.ViewManageSessionRooms();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVIEW
            // 
            this.btnVIEW.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVIEW.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnVIEW.Location = new System.Drawing.Point(191, 404);
            this.btnVIEW.Name = "btnVIEW";
            this.btnVIEW.Size = new System.Drawing.Size(125, 49);
            this.btnVIEW.TabIndex = 92;
            this.btnVIEW.Text = "VIEW";
            this.btnVIEW.UseVisualStyleBackColor = false;
            this.btnVIEW.Click += new System.EventHandler(this.btnVIEW_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnClear.Location = new System.Drawing.Point(477, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 49);
            this.btnClear.TabIndex = 91;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_2);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnAdd.Location = new System.Drawing.Point(338, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 49);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSsession
            // 
            this.txtSsession.Location = new System.Drawing.Point(366, 241);
            this.txtSsession.Multiline = true;
            this.txtSsession.Name = "txtSsession";
            this.txtSsession.Size = new System.Drawing.Size(236, 84);
            this.txtSsession.TabIndex = 89;
            // 
            // cmbSessionRoom
            // 
            this.cmbSessionRoom.FormattingEnabled = true;
            this.cmbSessionRoom.Location = new System.Drawing.Point(366, 169);
            this.cmbSessionRoom.Name = "cmbSessionRoom";
            this.cmbSessionRoom.Size = new System.Drawing.Size(236, 21);
            this.cmbSessionRoom.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label3.Location = new System.Drawing.Point(85, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 27);
            this.label3.TabIndex = 87;
            this.label3.Text = "Selected Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label2.Location = new System.Drawing.Point(85, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 86;
            this.label2.Text = "Select Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label1.Location = new System.Drawing.Point(85, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 85;
            this.label1.Text = "Select Session";
            // 
            // cmbSession
            // 
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(366, 104);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(236, 21);
            this.cmbSession.TabIndex = 84;
            // 
            // btnviewRoomDetails
            // 
            this.btnviewRoomDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnviewRoomDetails.FlatAppearance.BorderSize = 0;
            this.btnviewRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewRoomDetails.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewRoomDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewRoomDetails.Location = new System.Drawing.Point(37, 8);
            this.btnviewRoomDetails.Name = "btnviewRoomDetails";
            this.btnviewRoomDetails.Size = new System.Drawing.Size(240, 29);
            this.btnviewRoomDetails.TabIndex = 82;
            this.btnviewRoomDetails.Text = "Manage Session Rooms";
            this.btnviewRoomDetails.UseVisualStyleBackColor = true;
            this.btnviewRoomDetails.Click += new System.EventHandler(this.btnviewRoomDetails_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCInstitute.Properties.Resources.Button_Previous_icon;
            this.pictureBox1.Location = new System.Drawing.Point(17, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // viewManageSessionRooms1
            // 
            this.viewManageSessionRooms1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.viewManageSessionRooms1.Location = new System.Drawing.Point(2, 0);
            this.viewManageSessionRooms1.Name = "viewManageSessionRooms1";
            this.viewManageSessionRooms1.Size = new System.Drawing.Size(629, 500);
            this.viewManageSessionRooms1.TabIndex = 93;
            this.viewManageSessionRooms1.Load += new System.EventHandler(this.viewManageSessionRooms1_Load);
            // 
            // ManageSessionRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.viewManageSessionRooms1);
            this.Controls.Add(this.btnVIEW);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSsession);
            this.Controls.Add(this.cmbSessionRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSession);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnviewRoomDetails);
            this.Name = "ManageSessionRooms";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.ManageSessionRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVIEW;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSsession;
        private System.Windows.Forms.ComboBox cmbSessionRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnviewRoomDetails;
        private ViewManageSessionRooms viewManageSessionRooms1;
    }
}
