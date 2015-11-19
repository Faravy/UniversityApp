namespace UniversityCourseAndResultManagementSystem
{
    partial class MainUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterDepartmentButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.courseEntryButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.courseAssignButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterDepartmentButton
            // 
            this.enterDepartmentButton.Location = new System.Drawing.Point(34, 48);
            this.enterDepartmentButton.Name = "enterDepartmentButton";
            this.enterDepartmentButton.Size = new System.Drawing.Size(129, 23);
            this.enterDepartmentButton.TabIndex = 0;
            this.enterDepartmentButton.Text = "Enter Department";
            this.enterDepartmentButton.UseVisualStyleBackColor = true;
            this.enterDepartmentButton.Click += new System.EventHandler(this.enterDepartmentButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "View All Department";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // courseEntryButton
            // 
            this.courseEntryButton.Location = new System.Drawing.Point(12, 110);
            this.courseEntryButton.Name = "courseEntryButton";
            this.courseEntryButton.Size = new System.Drawing.Size(100, 23);
            this.courseEntryButton.TabIndex = 2;
            this.courseEntryButton.Text = "Course Entry";
            this.courseEntryButton.UseVisualStyleBackColor = true;
            this.courseEntryButton.Click += new System.EventHandler(this.courseEntryButton_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.Location = new System.Drawing.Point(334, 110);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(114, 23);
            this.teacherButton.TabIndex = 3;
            this.teacherButton.Text = "Teacher Entry";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // courseAssignButton
            // 
            this.courseAssignButton.Location = new System.Drawing.Point(148, 110);
            this.courseAssignButton.Name = "courseAssignButton";
            this.courseAssignButton.Size = new System.Drawing.Size(119, 23);
            this.courseAssignButton.TabIndex = 4;
            this.courseAssignButton.Text = "Course Assign";
            this.courseAssignButton.UseVisualStyleBackColor = true;
            this.courseAssignButton.Click += new System.EventHandler(this.courseAssignButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 261);
            this.Controls.Add(this.courseAssignButton);
            this.Controls.Add(this.teacherButton);
            this.Controls.Add(this.courseEntryButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enterDepartmentButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterDepartmentButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button courseEntryButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button courseAssignButton;
    }
}

