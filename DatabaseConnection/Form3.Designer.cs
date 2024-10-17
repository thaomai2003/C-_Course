namespace DatabaseConnection
{
    partial class Form3
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
            label1 = new Label();
            txtEnterClassID = new TextBox();
            btnViewClass = new Button();
            txtClassID = new TextBox();
            label2 = new Label();
            txtClassName = new TextBox();
            label3 = new Label();
            txtYear = new TextBox();
            label4 = new Label();
            btnStudent = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lsvStudents = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(491, 50);
            label1.Name = "label1";
            label1.Size = new Size(184, 37);
            label1.TabIndex = 0;
            label1.Text = "Enter Class ID";
            // 
            // txtEnterClassID
            // 
            txtEnterClassID.Font = new Font("Segoe UI", 10.125F);
            txtEnterClassID.Location = new Point(695, 50);
            txtEnterClassID.Name = "txtEnterClassID";
            txtEnterClassID.Size = new Size(315, 43);
            txtEnterClassID.TabIndex = 1;
            // 
            // btnViewClass
            // 
            btnViewClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewClass.Location = new Point(87, 165);
            btnViewClass.Name = "btnViewClass";
            btnViewClass.Size = new Size(493, 61);
            btnViewClass.TabIndex = 2;
            btnViewClass.Text = "View in Details";
            btnViewClass.UseVisualStyleBackColor = true;
            btnViewClass.Click += btnViewClass_Click;
            // 
            // txtClassID
            // 
            txtClassID.Font = new Font("Segoe UI", 10.125F);
            txtClassID.Location = new Point(265, 315);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(315, 43);
            txtClassID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F);
            label2.Location = new Point(87, 315);
            label2.Name = "label2";
            label2.Size = new Size(110, 37);
            label2.TabIndex = 3;
            label2.Text = "Class ID";
            // 
            // txtClassName
            // 
            txtClassName.Font = new Font("Segoe UI", 10.125F);
            txtClassName.Location = new Point(265, 431);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(315, 43);
            txtClassName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F);
            label3.Location = new Point(87, 431);
            label3.Name = "label3";
            label3.Size = new Size(155, 37);
            label3.TabIndex = 5;
            label3.Text = "Class Name";
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Segoe UI", 10.125F);
            txtYear.Location = new Point(265, 548);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(315, 43);
            txtYear.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F);
            label4.Location = new Point(87, 548);
            label4.Name = "label4";
            label4.Size = new Size(67, 37);
            label4.TabIndex = 7;
            label4.Text = "Year";
            // 
            // btnStudent
            // 
            btnStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(906, 165);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(493, 61);
            btnStudent.TabIndex = 9;
            btnStudent.Text = "View List of Students";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Student ID";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ClassID";
            columnHeader3.Width = 200;
            // 
            // lsvStudents
            // 
            lsvStudents.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvStudents.Location = new Point(836, 304);
            lsvStudents.Name = "lsvStudents";
            lsvStudents.Size = new Size(699, 272);
            lsvStudents.TabIndex = 10;
            lsvStudents.UseCompatibleStateImageBehavior = false;
            lsvStudents.View = View.Details;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1641, 670);
            Controls.Add(lsvStudents);
            Controls.Add(btnStudent);
            Controls.Add(txtYear);
            Controls.Add(label4);
            Controls.Add(txtClassName);
            Controls.Add(label3);
            Controls.Add(txtClassID);
            Controls.Add(label2);
            Controls.Add(btnViewClass);
            Controls.Add(txtEnterClassID);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEnterClassID;
        private Button btnViewClass;
        private TextBox txtClassID;
        private Label label2;
        private TextBox txtClassName;
        private Label label3;
        private TextBox txtYear;
        private Label label4;
        private Button btnStudent;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lsvStudents;
    }
}