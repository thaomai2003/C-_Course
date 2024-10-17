namespace DatabaseConnection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonConnect = new Button();
            buttonDisconnect = new Button();
            SuspendLayout();
            // 
            // buttonConnect
            // 
            buttonConnect.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConnect.Location = new Point(127, 63);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(533, 94);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "CONNECT TO DATABASE";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDisconnect.Location = new Point(127, 219);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(533, 94);
            buttonDisconnect.TabIndex = 1;
            buttonDisconnect.Text = "DISCONNECT";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += buttonDisconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDisconnect);
            Controls.Add(buttonConnect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonConnect;
        private Button buttonDisconnect;
    }
}
