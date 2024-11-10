namespace DatabaseConnection
{
    partial class Form6
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dtgStudent = new DataGridView();
            btnLoad = new Button();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            txtClassID = new TextBox();
            lblStudentID = new Label();
            lblStudentName = new Label();
            lblClassID = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgStudent).BeginInit();
            SuspendLayout();
            // 
            // dtgStudent
            // 
            dtgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStudent.Location = new Point(42, 46);
            dtgStudent.Name = "dtgStudent";
            dtgStudent.RowHeadersWidth = 82;
            dtgStudent.Size = new Size(738, 472);
            dtgStudent.TabIndex = 0;
            dtgStudent.CellContentClick += dtgStudent_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(480, 550);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(300, 52);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load table Student on DataGridView";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 10.125F);
            txtStudentID.Location = new Point(1038, 129);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(310, 43);
            txtStudentID.TabIndex = 2;
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 10.125F);
            txtStudentName.Location = new Point(1038, 189);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(310, 43);
            txtStudentName.TabIndex = 3;
            // 
            // txtClassID
            // 
            txtClassID.Font = new Font("Segoe UI", 10.125F);
            txtClassID.Location = new Point(1038, 249);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(310, 43);
            txtClassID.TabIndex = 4;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 10.125F);
            lblStudentID.Location = new Point(848, 132);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(141, 37);
            lblStudentID.TabIndex = 5;
            lblStudentID.Text = "Student ID";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 10.125F);
            lblStudentName.Location = new Point(848, 192);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(186, 37);
            lblStudentName.TabIndex = 6;
            lblStudentName.Text = "Student Name";
            // 
            // lblClassID
            // 
            lblClassID.AutoSize = true;
            lblClassID.Font = new Font("Segoe UI", 10.125F);
            lblClassID.Location = new Point(848, 252);
            lblClassID.Name = "lblClassID";
            lblClassID.Size = new Size(110, 37);
            lblClassID.TabIndex = 7;
            lblClassID.Text = "Class ID";
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 10.125F);
            btnInsert.Location = new Point(887, 370);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(116, 54);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.125F);
            btnUpdate.Location = new Point(1050, 370);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 54);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.125F);
            btnDelete.Location = new Point(1215, 370);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 54);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form6
            // 
            ClientSize = new Size(1394, 640);
            Controls.Add(lblClassID);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentID);
            Controls.Add(txtClassID);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnLoad);
            Controls.Add(dtgStudent);
            Name = "Form6";
            Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)dtgStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStudent;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
