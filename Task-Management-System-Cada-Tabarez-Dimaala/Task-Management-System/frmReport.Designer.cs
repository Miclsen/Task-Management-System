namespace Task_Management_System
{
    partial class frmReport
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
            btnAll = new Button();
            dataGridView1 = new DataGridView();
            btnCompleted = new Button();
            btnPending = new Button();
            btnOverdue = new Button();
            btnRefresh = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearchTitle = new Button();
            btnSearchAssigned = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAll
            // 
            btnAll.ImageAlign = ContentAlignment.TopCenter;
            btnAll.Location = new Point(12, 98);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(119, 39);
            btnAll.TabIndex = 0;
            btnAll.Text = "View All";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(516, 185);
            dataGridView1.TabIndex = 8;
            // 
            // btnCompleted
            // 
            btnCompleted.Location = new Point(214, 98);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(119, 39);
            btnCompleted.TabIndex = 6;
            btnCompleted.Text = "Completed";
            btnCompleted.UseVisualStyleBackColor = true;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // btnPending
            // 
            btnPending.Location = new Point(12, 153);
            btnPending.Name = "btnPending";
            btnPending.Size = new Size(119, 39);
            btnPending.TabIndex = 7;
            btnPending.Text = "Pending";
            btnPending.UseVisualStyleBackColor = true;
            btnPending.Click += btnPending_Click;
            // 
            // btnOverdue
            // 
            btnOverdue.Location = new Point(409, 98);
            btnOverdue.Name = "btnOverdue";
            btnOverdue.Size = new Size(119, 39);
            btnOverdue.TabIndex = 8;
            btnOverdue.Text = "Overdue";
            btnOverdue.UseVisualStyleBackColor = true;
            btnOverdue.Click += button4_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(214, 153);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(119, 39);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BorderStyle = BorderStyle.Fixed3D;
            lblSearch.Font = new Font("Segoe UI", 11F);
            lblSearch.Location = new Point(21, 19);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(58, 22);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(85, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 11;
            // 
            // btnSearchTitle
            // 
            btnSearchTitle.FlatStyle = FlatStyle.Flat;
            btnSearchTitle.Location = new Point(308, 14);
            btnSearchTitle.Name = "btnSearchTitle";
            btnSearchTitle.Size = new Size(87, 30);
            btnSearchTitle.TabIndex = 12;
            btnSearchTitle.Text = "Search Title";
            btnSearchTitle.UseVisualStyleBackColor = true;
            btnSearchTitle.Click += btnSearchTitle_Click;
            // 
            // btnSearchAssigned
            // 
            btnSearchAssigned.FlatStyle = FlatStyle.Flat;
            btnSearchAssigned.ImageAlign = ContentAlignment.TopLeft;
            btnSearchAssigned.Location = new Point(401, 14);
            btnSearchAssigned.Name = "btnSearchAssigned";
            btnSearchAssigned.Size = new Size(103, 30);
            btnSearchAssigned.TabIndex = 13;
            btnSearchAssigned.Text = "Search Assigned";
            btnSearchAssigned.TextAlign = ContentAlignment.MiddleLeft;
            btnSearchAssigned.UseVisualStyleBackColor = true;
            btnSearchAssigned.Click += btnSearchAssigned_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(409, 153);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(119, 39);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSearchAssigned);
            Controls.Add(btnSearchTitle);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnOverdue);
            Controls.Add(btnPending);
            Controls.Add(btnCompleted);
            Controls.Add(dataGridView1);
            Controls.Add(btnAll);
            Name = "frmReport";
            Text = "Reports / View Tasks";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button btnAll;
        private DataGridView dataGridView1;
        private Button btnCompleted;
        private Button btnPending;
        private Button btnOverdue;
        private Button btnRefresh;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearchTitle;
        private Button btnSearchAssigned;
        private Button btnClose;
    }
}