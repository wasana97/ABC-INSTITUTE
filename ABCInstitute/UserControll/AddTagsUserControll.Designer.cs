
namespace ABCInstitute.UserControll
{
    partial class AddTagsUserControll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTagsUserControll));
            this.TagName = new System.Windows.Forms.Label();
            this.TagCod = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddTag = new System.Windows.Forms.TextBox();
            this.txtTagCod = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TagName
            // 
            this.TagName.AutoSize = true;
            this.TagName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagName.Location = new System.Drawing.Point(90, 129);
            this.TagName.Name = "TagName";
            this.TagName.Size = new System.Drawing.Size(122, 25);
            this.TagName.TabIndex = 0;
            this.TagName.Text = "Tag Name";
            // 
            // TagCod
            // 
            this.TagCod.AutoSize = true;
            this.TagCod.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagCod.Location = new System.Drawing.Point(90, 217);
            this.TagCod.Name = "TagCod";
            this.TagCod.Size = new System.Drawing.Size(112, 25);
            this.TagCod.TabIndex = 1;
            this.TagCod.Text = "Tag Code";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(116, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddTag
            // 
            this.txtAddTag.Location = new System.Drawing.Point(295, 134);
            this.txtAddTag.Name = "txtAddTag";
            this.txtAddTag.Size = new System.Drawing.Size(235, 20);
            this.txtAddTag.TabIndex = 5;
            // 
            // txtTagCod
            // 
            this.txtTagCod.Location = new System.Drawing.Point(295, 222);
            this.txtTagCod.Name = "txtTagCod";
            this.txtTagCod.Size = new System.Drawing.Size(235, 20);
            this.txtTagCod.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(378, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackTag
            // 
            this.btnBackTag.FlatAppearance.BorderSize = 0;
            this.btnBackTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackTag.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTag.Image = ((System.Drawing.Image)(resources.GetObject("btnBackTag.Image")));
            this.btnBackTag.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBackTag.Location = new System.Drawing.Point(38, 23);
            this.btnBackTag.Name = "btnBackTag";
            this.btnBackTag.Size = new System.Drawing.Size(225, 33);
            this.btnBackTag.TabIndex = 8;
            this.btnBackTag.Text = "ADD TAGS";
            this.btnBackTag.UseVisualStyleBackColor = true;
            this.btnBackTag.Click += new System.EventHandler(this.btnBackTag_Click);
            // 
            // AddTagsUserControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.btnBackTag);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTagCod);
            this.Controls.Add(this.txtAddTag);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TagCod);
            this.Controls.Add(this.TagName);
            this.Name = "AddTagsUserControll";
            this.Size = new System.Drawing.Size(629, 500);
            this.Load += new System.EventHandler(this.AddTagsUserControll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TagName;
        private System.Windows.Forms.Label TagCod;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddTag;
        private System.Windows.Forms.TextBox txtTagCod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackTag;
    }
}
