
namespace ABCInstitute.UserControll
{
    partial class ManageNotAvailableRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageNotAvailableRooms));
            this.label5 = new System.Windows.Forms.Label();
            this.RIDText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewManageStudent = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "RID";
            // 
            // RIDText
            // 
            this.RIDText.Location = new System.Drawing.Point(157, 106);
            this.RIDText.Name = "RIDText";
            this.RIDText.Size = new System.Drawing.Size(182, 20);
            this.RIDText.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(426, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 41);
            this.button1.TabIndex = 65;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(120, 413);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 41);
            this.btnRefresh.TabIndex = 63;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewManageStudent
            // 
            this.dataGridViewManageStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageStudent.Location = new System.Drawing.Point(59, 166);
            this.dataGridViewManageStudent.Name = "dataGridViewManageStudent";
            this.dataGridViewManageStudent.Size = new System.Drawing.Size(511, 227);
            this.dataGridViewManageStudent.TabIndex = 62;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(59, 46);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(366, 34);
            this.btnBack.TabIndex = 64;
            this.btnBack.Text = "Manage Not available times";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ManageNotAvailableRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RIDText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewManageStudent);
            this.Name = "ManageNotAvailableRooms";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.ManageNotAvailableRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RIDText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewManageStudent;
    }
}
