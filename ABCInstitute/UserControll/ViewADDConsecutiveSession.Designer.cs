
namespace ABCInstitute.UserControll
{
    partial class ViewADDConsecutiveSession
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
            this.consecutiveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutiveSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutivesessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instituteDataSet3 = new ABCInstitute.InstituteDataSet3();
            this.txtConsecutiveID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnviewRoomDetails = new System.Windows.Forms.Button();
            this.consecutivesessionTableAdapter = new ABCInstitute.InstituteDataSet3TableAdapters.ConsecutivesessionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consecutivesessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnRefresh.Location = new System.Drawing.Point(379, 393);
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
            this.btnDelete.Location = new System.Drawing.Point(136, 393);
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
            this.consecutiveIDDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn,
            this.consecutiveSessionDataGridViewTextBoxColumn,
            this.room01DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consecutivesessionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 150);
            this.dataGridView1.TabIndex = 102;
            // 
            // consecutiveIDDataGridViewTextBoxColumn
            // 
            this.consecutiveIDDataGridViewTextBoxColumn.DataPropertyName = "ConsecutiveID";
            this.consecutiveIDDataGridViewTextBoxColumn.HeaderText = "ConsecutiveID";
            this.consecutiveIDDataGridViewTextBoxColumn.Name = "consecutiveIDDataGridViewTextBoxColumn";
            this.consecutiveIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "Session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "Session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            // 
            // consecutiveSessionDataGridViewTextBoxColumn
            // 
            this.consecutiveSessionDataGridViewTextBoxColumn.DataPropertyName = "ConsecutiveSession";
            this.consecutiveSessionDataGridViewTextBoxColumn.HeaderText = "ConsecutiveSession";
            this.consecutiveSessionDataGridViewTextBoxColumn.Name = "consecutiveSessionDataGridViewTextBoxColumn";
            this.consecutiveSessionDataGridViewTextBoxColumn.Width = 150;
            // 
            // room01DataGridViewTextBoxColumn
            // 
            this.room01DataGridViewTextBoxColumn.DataPropertyName = "room01";
            this.room01DataGridViewTextBoxColumn.HeaderText = "Room Name";
            this.room01DataGridViewTextBoxColumn.Name = "room01DataGridViewTextBoxColumn";
            // 
            // consecutivesessionBindingSource
            // 
            this.consecutivesessionBindingSource.DataMember = "Consecutivesession";
            this.consecutivesessionBindingSource.DataSource = this.instituteDataSet3;
            // 
            // instituteDataSet3
            // 
            this.instituteDataSet3.DataSetName = "InstituteDataSet3";
            this.instituteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConsecutiveID
            // 
            this.txtConsecutiveID.Location = new System.Drawing.Point(254, 88);
            this.txtConsecutiveID.Multiline = true;
            this.txtConsecutiveID.Name = "txtConsecutiveID";
            this.txtConsecutiveID.Size = new System.Drawing.Size(223, 31);
            this.txtConsecutiveID.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label1.Location = new System.Drawing.Point(41, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 100;
            this.label1.Text = "Consecutive ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABCInstitute.Properties.Resources.Button_Previous_icon;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnviewRoomDetails
            // 
            this.btnviewRoomDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnviewRoomDetails.FlatAppearance.BorderSize = 0;
            this.btnviewRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewRoomDetails.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewRoomDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewRoomDetails.Location = new System.Drawing.Point(35, 15);
            this.btnviewRoomDetails.Name = "btnviewRoomDetails";
            this.btnviewRoomDetails.Size = new System.Drawing.Size(240, 29);
            this.btnviewRoomDetails.TabIndex = 98;
            this.btnviewRoomDetails.Text = "Consecutaive Session";
            this.btnviewRoomDetails.UseVisualStyleBackColor = true;
            this.btnviewRoomDetails.Click += new System.EventHandler(this.btnviewRoomDetails_Click);
            // 
            // consecutivesessionTableAdapter
            // 
            this.consecutivesessionTableAdapter.ClearBeforeFill = true;
            // 
            // ViewADDConsecutiveSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtConsecutiveID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnviewRoomDetails);
            this.Name = "ViewADDConsecutiveSession";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.ViewADDConsecutiveSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consecutivesessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutiveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutiveSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn room01DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource consecutivesessionBindingSource;
        private InstituteDataSet3 instituteDataSet3;
        private System.Windows.Forms.TextBox txtConsecutiveID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnviewRoomDetails;
        private InstituteDataSet3TableAdapters.ConsecutivesessionTableAdapter consecutivesessionTableAdapter;
    }
}
