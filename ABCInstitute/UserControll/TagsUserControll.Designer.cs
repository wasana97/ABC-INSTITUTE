
namespace ABCInstitute.UserControll
{
    partial class TagsUserControll
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
            this.btnAddTags = new System.Windows.Forms.Button();
            this.btnManageTags = new System.Windows.Forms.Button();
            this.addTagsUserControll1 = new ABCInstitute.UserControll.AddTagsUserControll();
            this.manageTagUserController1 = new ABCInstitute.UserControll.manageTagUserController();
            this.SuspendLayout();
            // 
            // btnAddTags
            // 
            this.btnAddTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddTags.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTags.Location = new System.Drawing.Point(240, 101);
            this.btnAddTags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTags.Name = "btnAddTags";
            this.btnAddTags.Size = new System.Drawing.Size(309, 100);
            this.btnAddTags.TabIndex = 0;
            this.btnAddTags.Text = "ADD TAGS";
            this.btnAddTags.UseVisualStyleBackColor = false;
            this.btnAddTags.Click += new System.EventHandler(this.btnAddTags_Click);
            // 
            // btnManageTags
            // 
            this.btnManageTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnManageTags.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTags.Location = new System.Drawing.Point(240, 377);
            this.btnManageTags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageTags.Name = "btnManageTags";
            this.btnManageTags.Size = new System.Drawing.Size(309, 100);
            this.btnManageTags.TabIndex = 1;
            this.btnManageTags.Text = "MANAGE TAGS";
            this.btnManageTags.UseVisualStyleBackColor = false;
            this.btnManageTags.Click += new System.EventHandler(this.btnManageTags_Click);
            // 
            // addTagsUserControll1
            // 
            this.addTagsUserControll1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addTagsUserControll1.Location = new System.Drawing.Point(0, 0);
            this.addTagsUserControll1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addTagsUserControll1.Name = "addTagsUserControll1";
            this.addTagsUserControll1.Size = new System.Drawing.Size(839, 615);
            this.addTagsUserControll1.TabIndex = 2;
            this.addTagsUserControll1.Load += new System.EventHandler(this.addTagsUserControll1_Load);
            // 
            // manageTagUserController1
            // 
            this.manageTagUserController1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.manageTagUserController1.Location = new System.Drawing.Point(0, 0);
            this.manageTagUserController1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.manageTagUserController1.Name = "manageTagUserController1";
            this.manageTagUserController1.Size = new System.Drawing.Size(839, 615);
            this.manageTagUserController1.TabIndex = 3;
            this.manageTagUserController1.Load += new System.EventHandler(this.manageTagUserController1_Load);
            // 
            // TagsUserControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.manageTagUserController1);
            this.Controls.Add(this.addTagsUserControll1);
            this.Controls.Add(this.btnManageTags);
            this.Controls.Add(this.btnAddTags);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TagsUserControll";
            this.Size = new System.Drawing.Size(839, 615);
            this.Load += new System.EventHandler(this.TagsUserControll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTags;
        private System.Windows.Forms.Button btnManageTags;
        private AddTagsUserControll addTagsUserControll1;
        private manageTagUserController manageTagUserController1;
    }
}
