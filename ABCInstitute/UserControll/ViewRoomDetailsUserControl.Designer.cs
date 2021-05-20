
namespace ABCInstitute.UserControll
{
    partial class ViewRoomDetailsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.txtbuildingId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtroomName = new System.Windows.Forms.TextBox();
            this.txtbuildingName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnviewRoomDetails = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buildingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instituteDataSet = new ABCInstitute.InstituteDataSet();
            this.buildingTableAdapter = new ABCInstitute.InstituteDataSetTableAdapters.buildingTableAdapter();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuildingId
            // 
            this.txtbuildingId.Location = new System.Drawing.Point(307, 201);
            this.txtbuildingId.Name = "txtbuildingId";
            this.txtbuildingId.Size = new System.Drawing.Size(232, 20);
            this.txtbuildingId.TabIndex = 34;
            this.txtbuildingId.TextChanged += new System.EventHandler(this.txtbuildingId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Building ID            =";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(307, 166);
            this.txtcapacity.Multiline = true;
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(232, 20);
            this.txtcapacity.TabIndex = 32;
            this.txtcapacity.TextChanged += new System.EventHandler(this.txtcapacity_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(307, 127);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 23);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lecture Hall";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtroomName
            // 
            this.txtroomName.Location = new System.Drawing.Point(307, 95);
            this.txtroomName.Multiline = true;
            this.txtroomName.Name = "txtroomName";
            this.txtroomName.Size = new System.Drawing.Size(232, 20);
            this.txtroomName.TabIndex = 30;
            this.txtroomName.TextChanged += new System.EventHandler(this.txtroomName_TextChanged);
            // 
            // txtbuildingName
            // 
            this.txtbuildingName.Location = new System.Drawing.Point(307, 63);
            this.txtbuildingName.Multiline = true;
            this.txtbuildingName.Name = "txtbuildingName";
            this.txtbuildingName.Size = new System.Drawing.Size(232, 19);
            this.txtbuildingName.TabIndex = 29;
            this.txtbuildingName.TextChanged += new System.EventHandler(this.txtbuildingName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Capacity                  =";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Room Type             =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Room Name            =";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Building Name       =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnviewRoomDetails
            // 
            this.btnviewRoomDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnviewRoomDetails.FlatAppearance.BorderSize = 0;
            this.btnviewRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewRoomDetails.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewRoomDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewRoomDetails.Location = new System.Drawing.Point(43, 21);
            this.btnviewRoomDetails.Name = "btnviewRoomDetails";
            this.btnviewRoomDetails.Size = new System.Drawing.Size(193, 29);
            this.btnviewRoomDetails.TabIndex = 23;
            this.btnviewRoomDetails.Text = "View Room Details";
            this.btnviewRoomDetails.UseVisualStyleBackColor = true;
            this.btnviewRoomDetails.Click += new System.EventHandler(this.btnviewRoomDetails_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCInstitute.Properties.Resources.Button_Previous_icon;
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingIdDataGridViewTextBoxColumn,
            this.buildingNameDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buildingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 179);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buildingIdDataGridViewTextBoxColumn
            // 
            this.buildingIdDataGridViewTextBoxColumn.DataPropertyName = "buildingId";
            this.buildingIdDataGridViewTextBoxColumn.HeaderText = "buildingId";
            this.buildingIdDataGridViewTextBoxColumn.Name = "buildingIdDataGridViewTextBoxColumn";
            this.buildingIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildingNameDataGridViewTextBoxColumn
            // 
            this.buildingNameDataGridViewTextBoxColumn.DataPropertyName = "buildingName";
            this.buildingNameDataGridViewTextBoxColumn.HeaderText = "buildingName";
            this.buildingNameDataGridViewTextBoxColumn.Name = "buildingNameDataGridViewTextBoxColumn";
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "roomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "roomName";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "roomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "roomType";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataMember = "building";
            this.buildingBindingSource.DataSource = this.instituteDataSet;
            // 
            // instituteDataSet
            // 
            this.instituteDataSet.DataSetName = "InstituteDataSet";
            this.instituteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingTableAdapter
            // 
            this.buildingTableAdapter.ClearBeforeFill = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnrefresh.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(400, 436);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(139, 38);
            this.btnrefresh.TabIndex = 38;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndelete.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(238, 436);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(150, 38);
            this.btndelete.TabIndex = 37;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnupdate.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(81, 436);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(150, 38);
            this.btnupdate.TabIndex = 36;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // ViewRoomDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbuildingId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcapacity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtroomName);
            this.Controls.Add(this.txtbuildingName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnviewRoomDetails);
            this.Name = "ViewRoomDetailsUserControl";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.ViewRoomDetailsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuildingId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcapacity;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtroomName;
        private System.Windows.Forms.TextBox txtbuildingName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnviewRoomDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private InstituteDataSet instituteDataSet;
        private InstituteDataSetTableAdapters.buildingTableAdapter buildingTableAdapter;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
    }
}
