namespace UniversityCourseAndResultManagementSystem.UI
{
    partial class ViewDepartmentUI
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
            this.viewDepartmentListView = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // viewDepartmentListView
            // 
            this.viewDepartmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Name});
            this.viewDepartmentListView.GridLines = true;
            this.viewDepartmentListView.Location = new System.Drawing.Point(45, 24);
            this.viewDepartmentListView.Name = "viewDepartmentListView";
            this.viewDepartmentListView.Size = new System.Drawing.Size(499, 206);
            this.viewDepartmentListView.TabIndex = 0;
            this.viewDepartmentListView.UseCompatibleStateImageBehavior = false;
            this.viewDepartmentListView.View = System.Windows.Forms.View.Details;
            this.viewDepartmentListView.SelectedIndexChanged += new System.EventHandler(this.viewDepartmentListView_SelectedIndexChanged);
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 127;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 274;
            // 
            // ViewDepartmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 261);
            this.Controls.Add(this.viewDepartmentListView);
          //  this.Name = "ViewDepartmentUI";
            this.Text = "View All Department";
            this.Load += new System.EventHandler(this.ViewDepartmentUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView viewDepartmentListView;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Name;
    }
}