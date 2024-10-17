namespace DatabaseConnection
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lsbClass;
        private System.Windows.Forms.ListView lsvStudents;
        private System.Windows.Forms.Button btnLoadData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lsbClass = new System.Windows.Forms.ListBox();
            this.lsvStudents = new System.Windows.Forms.ListView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lsbClass (List of Classes)
            // 
            this.lsbClass.FormattingEnabled = true;
            this.lsbClass.ItemHeight = 20;
            this.lsbClass.Location = new System.Drawing.Point(20, 20);
            this.lsbClass.Name = "lsbClass";
            this.lsbClass.Size = new System.Drawing.Size(300, 300); // Tăng kích thước của ListBox
            this.lsbClass.TabIndex = 0;
            this.lsbClass.SelectedIndexChanged += new System.EventHandler(this.lsbClass_SelectedIndexChanged);

            // 
            // lsvStudents (List of Students)
            // 
            this.lsvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            new System.Windows.Forms.ColumnHeader { Text = "Student ID", Width = 120 },
            new System.Windows.Forms.ColumnHeader { Text = "Name", Width = 180 },
            new System.Windows.Forms.ColumnHeader { Text = "Class ID", Width = 120 }});
            this.lsvStudents.FullRowSelect = true;
            this.lsvStudents.GridLines = true;
            this.lsvStudents.HideSelection = false;
            this.lsvStudents.Location = new System.Drawing.Point(350, 20); // Di chuyển ListView sang bên phải
            this.lsvStudents.Name = "lsvStudents";
            this.lsvStudents.Size = new System.Drawing.Size(450, 300); // Tăng kích thước của ListView
            this.lsvStudents.TabIndex = 1;
            this.lsvStudents.UseCompatibleStateImageBehavior = false;
            this.lsvStudents.View = System.Windows.Forms.View.Details;

            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(20, 340); // Di chuyển Button xuống phía dưới
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(150, 50); // Tăng kích thước Button
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);

            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(830, 420); // Tăng kích thước của form
            this.Controls.Add(this.lsbClass);
            this.Controls.Add(this.lsvStudents);
            this.Controls.Add(this.btnLoadData);
            this.Name = "Form4";
            this.Text = "Class and Student Information";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
        }
    }
}
