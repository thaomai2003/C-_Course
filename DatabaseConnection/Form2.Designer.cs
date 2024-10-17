namespace DatabaseConnection
{
    partial class Form2
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
            label2 = new Label();
            txtClassID = new TextBox();
            txtNumber = new TextBox();
            btnCaculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 129);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 0;
            label1.Text = "ClassID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 215);
            label2.Name = "label2";
            label2.Size = new Size(231, 32);
            label2.TabIndex = 1;
            label2.Text = "Number of Students";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(424, 129);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(159, 39);
            txtClassID.TabIndex = 2;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(424, 212);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(159, 39);
            txtNumber.TabIndex = 3;
            // 
            // btnCaculate
            // 
            btnCaculate.Location = new Point(139, 310);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(470, 77);
            btnCaculate.TabIndex = 4;
            btnCaculate.Text = "CACULATE NUMBER OF STUDENTS";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCaculate);
            Controls.Add(txtNumber);
            Controls.Add(txtClassID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtClassID;
        private TextBox txtNumber;
        private Button btnCaculate;
    }
}