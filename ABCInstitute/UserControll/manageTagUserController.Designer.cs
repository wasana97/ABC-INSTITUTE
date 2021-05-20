
namespace ABCInstitute.UserControll
{
    partial class manageTagUserController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageTagUserController));
            this.dataGridViewMnageTag = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTagName = new System.Windows.Forms.TextBox();
            this.txtTagCode = new System.Windows.Forms.TextBox();
            this.txtdeleteId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMnageTag)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMnageTag
            // 
            this.dataGridViewMnageTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMnageTag.Location = new System.Drawing.Point(144, 297);
            this.dataGridViewMnageTag.Name = "dataGridViewMnageTag";
            this.dataGridViewMnageTag.Size = new System.Drawing.Size(341, 203);
            this.dataGridViewMnageTag.TabIndex = 0;
            this.dataGridViewMnageTag.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMnageTag_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tag Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tag Code";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(40, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(487, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 42);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTagName
            // 
            this.txtTagName.Location = new System.Drawing.Point(290, 92);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(186, 20);
            this.txtTagName.TabIndex = 5;
            // 
            // txtTagCode
            // 
            this.txtTagCode.Location = new System.Drawing.Point(290, 140);
            this.txtTagCode.Name = "txtTagCode";
            this.txtTagCode.Size = new System.Drawing.Size(186, 20);
            this.txtTagCode.TabIndex = 6;
            // 
            // txtdeleteId
            // 
            this.txtdeleteId.Location = new System.Drawing.Point(290, 238);
            this.txtdeleteId.Name = "txtdeleteId";
            this.txtdeleteId.Size = new System.Drawing.Size(143, 20);
            this.txtdeleteId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TagID";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(25, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(193, 37);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "manage Tag";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRefresh
            // 
            this.txtRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtRefresh.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefresh.Location = new System.Drawing.Point(487, 273);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(98, 42);
            this.txtRefresh.TabIndex = 10;
            this.txtRefresh.Text = "Refresh";
            this.txtRefresh.UseVisualStyleBackColor = false;
            this.txtRefresh.Click += new System.EventHandler(this.txtRefresh_Click);
            // 
            // manageTagUserController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.txtRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdeleteId);
            this.Controls.Add(this.txtTagCode);
            this.Controls.Add(this.txtTagName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMnageTag);
            this.Name = "manageTagUserController";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.manageTagUserController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMnageTag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMnageTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTagName;
        private System.Windows.Forms.TextBox txtTagCode;
        private System.Windows.Forms.TextBox txtdeleteId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button txtRefresh;
    }
}
