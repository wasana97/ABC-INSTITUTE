
namespace ABCInstitute.UserControll
{
    partial class ViewSuitableRooms
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suitableRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instituteDataSet1 = new ABCInstitute.InstituteDataSet1();
            this.txtTAGID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnviewRoomDetails = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.suitableRoomTableAdapter = new ABCInstitute.InstituteDataSet1TableAdapters.suitableRoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suitableRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnRefresh.Location = new System.Drawing.Point(375, 391);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 49);
            this.btnRefresh.TabIndex = 104;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnDelete.Location = new System.Drawing.Point(132, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 49);
            this.btnDelete.TabIndex = 103;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagIDDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.roomtypeDataGridViewTextBoxColumn,
            this.roomnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.suitableRoomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 150);
            this.dataGridView1.TabIndex = 102;
            // 
            // tagIDDataGridViewTextBoxColumn
            // 
            this.tagIDDataGridViewTextBoxColumn.DataPropertyName = "tagID";
            this.tagIDDataGridViewTextBoxColumn.HeaderText = "TAG ID";
            this.tagIDDataGridViewTextBoxColumn.Name = "tagIDDataGridViewTextBoxColumn";
            this.tagIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "TAG";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomtypeDataGridViewTextBoxColumn
            // 
            this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "roomtype";
            this.roomtypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
            this.roomtypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomnameDataGridViewTextBoxColumn
            // 
            this.roomnameDataGridViewTextBoxColumn.DataPropertyName = "roomname";
            this.roomnameDataGridViewTextBoxColumn.HeaderText = "Room Name";
            this.roomnameDataGridViewTextBoxColumn.Name = "roomnameDataGridViewTextBoxColumn";
            this.roomnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // suitableRoomBindingSource
            // 
            this.suitableRoomBindingSource.DataMember = "suitableRoom";
            this.suitableRoomBindingSource.DataSource = this.instituteDataSet1;
            // 
            // instituteDataSet1
            // 
            this.instituteDataSet1.DataSetName = "InstituteDataSet1";
            this.instituteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTAGID
            // 
            this.txtTAGID.Location = new System.Drawing.Point(250, 86);
            this.txtTAGID.Multiline = true;
            this.txtTAGID.Name = "txtTAGID";
            this.txtTAGID.Size = new System.Drawing.Size(223, 31);
            this.txtTAGID.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label1.Location = new System.Drawing.Point(108, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 100;
            this.label1.Text = "TAG ID";
            // 
            // btnviewRoomDetails
            // 
            this.btnviewRoomDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnviewRoomDetails.FlatAppearance.BorderSize = 0;
            this.btnviewRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewRoomDetails.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewRoomDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewRoomDetails.Location = new System.Drawing.Point(31, 13);
            this.btnviewRoomDetails.Name = "btnviewRoomDetails";
            this.btnviewRoomDetails.Size = new System.Drawing.Size(240, 29);
            this.btnviewRoomDetails.TabIndex = 98;
            this.btnviewRoomDetails.Text = "Manage Suitable Rooms";
            this.btnviewRoomDetails.UseVisualStyleBackColor = true;
            this.btnviewRoomDetails.Click += new System.EventHandler(this.btnviewRoomDetails_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCInstitute.Properties.Resources.Button_Previous_icon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // suitableRoomTableAdapter
            // 
            this.suitableRoomTableAdapter.ClearBeforeFill = true;
            // 
            // ViewSuitableRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTAGID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnviewRoomDetails);
            this.Name = "ViewSuitableRooms";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.ViewSuitableRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suitableRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTAGID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnviewRoomDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource suitableRoomBindingSource;
        private InstituteDataSet1 instituteDataSet1;
        private InstituteDataSet1TableAdapters.suitableRoomTableAdapter suitableRoomTableAdapter;
    }
}
