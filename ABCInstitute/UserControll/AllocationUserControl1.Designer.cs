
namespace ABCInstitute.UserControll
{
    partial class AllocationUserControl1
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.consecutiveSession1 = new ABCInstitute.UserControll.ConsecutiveSession();
            this.notAvailableTimes1 = new ABCInstitute.UserControll.NotAvailableTimes();
            this.viewSessionUserControl11 = new ABCInstitute.UserControll.ViewSessionUserControl1();
            this.addSessionUserControl11 = new ABCInstitute.UserControll.AddSessionUserControl1();
            this.parallelSession1 = new ABCInstitute.UserControll.ParallelSession();
            this.nonOverlapping1 = new ABCInstitute.UserControll.NonOverlapping();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(64, 370);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 80);
            this.button3.TabIndex = 13;
            this.button3.Text = "PARALLEL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(362, 61);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 80);
            this.button2.TabIndex = 12;
            this.button2.Text = "MANAGE SESSION";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 80);
            this.button1.TabIndex = 11;
            this.button1.Text = "ADD SESSION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(64, 213);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 80);
            this.button4.TabIndex = 14;
            this.button4.Text = "CONSECUTIVE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(362, 213);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 80);
            this.button5.TabIndex = 15;
            this.button5.Text = "NON OVERLAPPING";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(362, 370);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 80);
            this.button6.TabIndex = 16;
            this.button6.Text = "NOT AVAILABLE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // consecutiveSession1
            // 
            this.consecutiveSession1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.consecutiveSession1.Location = new System.Drawing.Point(0, 0);
            this.consecutiveSession1.Name = "consecutiveSession1";
            this.consecutiveSession1.Size = new System.Drawing.Size(629, 500);
            this.consecutiveSession1.TabIndex = 20;
            this.consecutiveSession1.Load += new System.EventHandler(this.consecutiveSession1_Load);
            // 
            // notAvailableTimes1
            // 
            this.notAvailableTimes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.notAvailableTimes1.Location = new System.Drawing.Point(0, 0);
            this.notAvailableTimes1.Name = "notAvailableTimes1";
            this.notAvailableTimes1.Size = new System.Drawing.Size(629, 500);
            this.notAvailableTimes1.TabIndex = 19;
            // 
            // viewSessionUserControl11
            // 
            this.viewSessionUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.viewSessionUserControl11.Location = new System.Drawing.Point(2, 2);
            this.viewSessionUserControl11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewSessionUserControl11.Name = "viewSessionUserControl11";
            this.viewSessionUserControl11.Size = new System.Drawing.Size(629, 500);
            this.viewSessionUserControl11.TabIndex = 18;
            this.viewSessionUserControl11.Load += new System.EventHandler(this.viewSessionUserControl11_Load);
            // 
            // addSessionUserControl11
            // 
            this.addSessionUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addSessionUserControl11.Location = new System.Drawing.Point(0, 0);
            this.addSessionUserControl11.Margin = new System.Windows.Forms.Padding(2);
            this.addSessionUserControl11.Name = "addSessionUserControl11";
            this.addSessionUserControl11.Size = new System.Drawing.Size(629, 500);
            this.addSessionUserControl11.TabIndex = 17;
            // 
            // parallelSession1
            // 
            this.parallelSession1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.parallelSession1.Location = new System.Drawing.Point(2, 0);
            this.parallelSession1.Name = "parallelSession1";
            this.parallelSession1.Size = new System.Drawing.Size(629, 500);
            this.parallelSession1.TabIndex = 21;
            this.parallelSession1.Load += new System.EventHandler(this.parallelSession1_Load);
            // 
            // nonOverlapping1
            // 
            this.nonOverlapping1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nonOverlapping1.Location = new System.Drawing.Point(0, 0);
            this.nonOverlapping1.Name = "nonOverlapping1";
            this.nonOverlapping1.Size = new System.Drawing.Size(629, 500);
            this.nonOverlapping1.TabIndex = 22;
            this.nonOverlapping1.Load += new System.EventHandler(this.nonOverlapping1_Load);
            // 
            // AllocationUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nonOverlapping1);
            this.Controls.Add(this.parallelSession1);
            this.Controls.Add(this.consecutiveSession1);
            this.Controls.Add(this.notAvailableTimes1);
            this.Controls.Add(this.viewSessionUserControl11);
            this.Controls.Add(this.addSessionUserControl11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AllocationUserControl1";
            this.Size = new System.Drawing.Size(629, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private AddSessionUserControl1 addSessionUserControl11;
        private ViewSessionUserControl1 viewSessionUserControl11;
        private NotAvailableTimes notAvailableTimes1;
        private ConsecutiveSession consecutiveSession1;
        private ParallelSession parallelSession1;
        private NonOverlapping nonOverlapping1;
    }
}
