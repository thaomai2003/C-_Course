namespace DatabaseConnection
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

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
            lvwStudent = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtClassID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtStudentID = new TextBox();
            SuspendLayout();
            // 
            // lvwStudent
            // 
            lvwStudent.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwStudent.Location = new Point(32, 52);
            lvwStudent.Margin = new Padding(5, 6, 5, 6);
            lvwStudent.Name = "lvwStudent";
            lvwStudent.Size = new Size(485, 356);
            lvwStudent.TabIndex = 3;
            lvwStudent.UseCompatibleStateImageBehavior = false;
            lvwStudent.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Student ID";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Full Name";
            columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ClassID";
            columnHeader3.Width = 150;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(536, 448);
            btnInsert.Margin = new Padding(5, 6, 5, 6);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(130, 60);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(682, 448);
            btnUpdate.Margin = new Padding(5, 6, 5, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 60);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(829, 448);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 60);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(628, 52);
            label1.Name = "label1";
            label1.Size = new Size(266, 37);
            label1.TabIndex = 8;
            label1.Text = "Student Information";
            // 
            // txtName
            // 
            txtName.Location = new Point(715, 234);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 39);
            txtName.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 239);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 11;
            label3.Text = "Name";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(715, 335);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(236, 39);
            txtClassID.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 340);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 13;
            label4.Text = "Class ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(554, 136);
            label5.Name = "label5";
            label5.Size = new Size(127, 32);
            label5.TabIndex = 9;
            label5.Text = "Student ID";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(715, 131);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(236, 39);
            txtStudentID.TabIndex = 10;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 600);
            Controls.Add(txtClassID);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtStudentID);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(lvwStudent);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form5";
            Text = "Student Management";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListView lvwStudent;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private Label label1;
        private TextBox txtName;
        private Label label3;
        private TextBox txtClassID;
        private Label label4;
        private Label label5;
        private TextBox txtStudentID;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
