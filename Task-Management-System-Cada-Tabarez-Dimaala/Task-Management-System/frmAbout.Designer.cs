namespace Task_Management_System
{
    partial class frmAbout
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
            btnClose = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(223, 179);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(81, 29);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(49, 30);
            label1.Name = "label1";
            label1.Size = new Size(430, 92);
            label1.TabIndex = 1;
            label1.Text = "Task Management System\nCourse: Object Oriented Programming, Information Management and Database\nDevelopers: Jed Miclsen Cada, Mark Justin Tabarez\nSection: BSCS\nInstructor: Sir. Jun Ercia\nVersion 1.0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 250);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Name = "Form1";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
    }
}
