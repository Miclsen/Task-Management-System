namespace Task_Management_System
{
    partial class frmTasks
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
            components = new System.ComponentModel.Container();
            txtTaskTitle = new TextBox();
            txtDescription = new TextBox();
            txtAssignedTo = new TextBox();
            txtSearch = new TextBox();
            cmbPriority = new ComboBox();
            cmbStatus = new ComboBox();
            cmbCategory = new ComboBox();
            dtpDueDate = new DateTimePicker();
            dgvTasks = new DataGridView();
            dbConnectionBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnViewAll = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectionBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(6, 19);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.PlaceholderText = "Title";
            txtTaskTitle.Size = new Size(237, 23);
            txtTaskTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(6, 48);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(237, 23);
            txtDescription.TabIndex = 1;
            // 
            // txtAssignedTo
            // 
            txtAssignedTo.Location = new Point(6, 77);
            txtAssignedTo.Name = "txtAssignedTo";
            txtAssignedTo.PlaceholderText = "Assigned to";
            txtAssignedTo.Size = new Size(121, 23);
            txtAssignedTo.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(225, 23);
            txtSearch.TabIndex = 3;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.ItemHeight = 15;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbPriority.Location = new Point(6, 121);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(121, 23);
            cmbPriority.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Completed" });
            cmbStatus.Location = new Point(133, 121);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(110, 23);
            cmbStatus.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(6, 165);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(237, 23);
            cmbCategory.TabIndex = 6;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(6, 209);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(237, 23);
            dtpDueDate.TabIndex = 7;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(268, 106);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.Size = new Size(334, 174);
            dgvTasks.TabIndex = 8;
            dgvTasks.CellClick += dgvTasks_CellClick;
            // 
            // dbConnectionBindingSource
            // 
            dbConnectionBindingSource.DataSource = typeof(DbConnection);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 238);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(87, 238);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(168, 238);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(156, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.Location = new Point(511, 21);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(90, 33);
            btnViewAll.TabIndex = 13;
            btnViewAll.Text = "View All";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(511, 63);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 37);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTaskTitle);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtAssignedTo);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(dtpDueDate);
            groupBox1.Controls.Add(cmbPriority);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 268);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Location = new Point(268, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(237, 88);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 103);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 12;
            label1.Text = "Priority:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 103);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 13;
            label2.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 147);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 14;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 191);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 15;
            label4.Text = "Due Date:";
            // 
            // frmTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 294);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(btnViewAll);
            Controls.Add(dgvTasks);
            Name = "frmTasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Management";
            Load += frmTasks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectionBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTaskTitle;
        private TextBox txtDescription;
        private TextBox txtAssignedTo;
        private TextBox txtSearch;
        private ComboBox cmbPriority;
        private ComboBox cmbStatus;
        private ComboBox cmbCategory;
        private DateTimePicker dtpDueDate;
        private DataGridView dgvTasks;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnViewAll;
        private Button btnClear;
        private BindingSource dbConnectionBindingSource;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}