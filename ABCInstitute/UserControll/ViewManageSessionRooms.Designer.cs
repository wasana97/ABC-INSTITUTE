
namespace ABCInstitute.UserControll
{
    partial class ViewManageSessionRooms
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
            this.mIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manageSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instituteDataSet2 = new ABCInstitute.InstituteDataSet2();
            this.txtMID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnviewRoomDetails = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.manageSessionTableAdapter = new ABCInstitute.InstituteDataSet2TableAdapters.ManageSessionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageSessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnRefresh.Location = new System.Drawing.Point(381, 394);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 49);
            this.btnRefresh.TabIndex = 97;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnDelete.Location = new System.Drawing.Point(138, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 49);
            this.btnDelete.TabIndex = 96;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIDDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn,
            this.sessionRoomDataGridViewTextBoxColumn,
            this.ssessionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.manageSessionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 150);
            this.dataGridView1.TabIndex = 95;
            // 
            // mIDDataGridViewTextBoxColumn
            // 
            this.mIDDataGridViewTextBoxColumn.DataPropertyName = "MID";
            this.mIDDataGridViewTextBoxColumn.HeaderText = "MID";
            this.mIDDataGridViewTextBoxColumn.Name = "mIDDataGridViewTextBoxColumn";
            this.mIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "Session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "Session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            this.sessionDataGridViewTextBoxColumn.Width = 150;
            // 
            // sessionRoomDataGridViewTextBoxColumn
            // 
            this.sessionRoomDataGridViewTextBoxColumn.DataPropertyName = "SessionRoom";
            this.sessionRoomDataGridViewTextBoxColumn.HeaderText = "SessionRoom";
            this.sessionRoomDataGridViewTextBoxColumn.Name = "sessionRoomDataGridViewTextBoxColumn";
            this.sessionRoomDataGridViewTextBoxColumn.Width = 150;
            // 
            // ssessionDataGridViewTextBoxColumn
            // 
            this.ssessionDataGridViewTextBoxColumn.DataPropertyName = "Ssession";
            this.ssessionDataGridViewTextBoxColumn.HeaderText = "Selected Session";
            this.ssessionDataGridViewTextBoxColumn.Name = "ssessionDataGridViewTextBoxColumn";
            this.ssessionDataGridViewTextBoxColumn.Width = 150;
            // 
            // manageSessionBindingSource
            // 
            this.manageSessionBindingSource.DataMember = "ManageSession";
            this.manageSessionBindingSource.DataSource = this.instituteDataSet2;
            // 
            // instituteDataSet2
            // 
            this.instituteDataSet2.DataSetName = "InstituteDataSet2";
            this.instituteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMID
            // 
            this.txtMID.Location = new System.Drawing.Point(256, 89);
            this.txtMID.Multiline = true;
            this.txtMID.Name = "txtMID";
            this.txtMID.Size = new System.Drawing.Size(223, 31);
            this.txtMID.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label1.Location = new System.Drawing.Point(114, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 27);
            this.label1.TabIndex = 93;
            this.label1.Text = "MID";
            // 
            // btnviewRoomDetails
            // 
            this.btnviewRoomDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnviewRoomDetails.FlatAppearance.BorderSize = 0;
            this.btnviewRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewRoomDetails.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewRoomDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewRoomDetails.Location = new System.Drawing.Point(37, 16);
            this.btnviewRoomDetails.Name = "btnviewRoomDetails";
            this.btnviewRoomDetails.Size = new System.Drawing.Size(240, 29);
            this.btnviewRoomDetails.TabIndex = 91;
            this.btnviewRoomDetails.Text = "Manage Session Rooms";
            this.btnviewRoomDetails.UseVisualStyleBackColor = true;
            this.btnviewRoomDetails.Click += new System.EventHandler(this.btnviewRoomDetails_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCInstitute.Properties.Resources.Button_Previous_icon;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // manageSessionTableAdapter
            // 
            this.manageSessionTableAdapter.ClearBeforeFill = true;
            // 
            // ViewManageSessionRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnviewRoomDetails);
            this.Name = "ViewManageSessionRooms";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.ViewManageSessionRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageSessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnviewRoomDetails;
        private System.Windows.Forms.BindingSource manageSessionBindingSource;
        private InstituteDataSet2 instituteDataSet2;
        private InstituteDataSet2TableAdapters.ManageSessionTableAdapter manageSessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssessionDataGridViewTextBoxColumn;
    }
}
