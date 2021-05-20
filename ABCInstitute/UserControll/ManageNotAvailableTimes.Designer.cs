
namespace ABCInstitute.UserControll
{
    partial class ManageNotAvailableTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageNotAvailableTimes));
            this.label5 = new System.Windows.Forms.Label();
            this.NIDText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewManageStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "NID";
            // 
            // NIDText
            // 
            this.NIDText.Location = new System.Drawing.Point(159, 109);
            this.NIDText.Name = "NIDText";
            this.NIDText.Size = new System.Drawing.Size(182, 20);
            this.NIDText.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(426, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 41);
            this.button1.TabIndex = 59;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(59, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(366, 34);
            this.btnBack.TabIndex = 58;
            this.btnBack.Text = "Manage Not available times";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(120, 398);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 41);
            this.btnRefresh.TabIndex = 57;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewManageStudent
            // 
            this.dataGridViewManageStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageStudent.Location = new System.Drawing.Point(59, 151);
            this.dataGridViewManageStudent.Name = "dataGridViewManageStudent";
            this.dataGridViewManageStudent.Size = new System.Drawing.Size(511, 227);
            this.dataGridViewManageStudent.TabIndex = 56;
            // 
            // ManageNotAvailableTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NIDText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridViewManageStudent);
            this.Name = "ManageNotAvailableTimes";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.ManageNotAvailableTimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NIDText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewManageStudent;
    }
}
