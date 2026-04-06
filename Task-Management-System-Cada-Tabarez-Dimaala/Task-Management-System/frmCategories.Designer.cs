namespace Task_Management_System
{
    partial class frmCategories
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
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            lblDescription = new Label();
            txtCategoryDesc = new TextBox();
            dgvCategories = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnViewAll = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(21, 19);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(93, 15);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "Category Name:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(120, 16);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(220, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(21, 48);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // txtCategoryDesc
            // 
            txtCategoryDesc.Location = new Point(120, 45);
            txtCategoryDesc.Multiline = true;
            txtCategoryDesc.Name = "txtCategoryDesc";
            txtCategoryDesc.Size = new Size(220, 80);
            txtCategoryDesc.TabIndex = 3;
            txtCategoryDesc.TextChanged += txtCategoryDesc_TextChanged;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(374, 16);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(420, 150);
            dgvCategories.TabIndex = 4;
            dgvCategories.CellContentClick += dgvCategories_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(100, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 43);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Category";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(289, 209);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 43);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update Category";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(473, 209);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 43);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Category";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.Location = new Point(100, 287);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(117, 43);
            btnViewAll.TabIndex = 8;
            btnViewAll.Text = "View All";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(289, 287);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 43);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(652, 209);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 43);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search Category";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(473, 287);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 43);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 411);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(btnViewAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvCategories);
            Controls.Add(txtCategoryDesc);
            Controls.Add(lblDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(lblCategoryName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management ";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private Label lblDescription;
        private TextBox txtCategoryDesc;
        private DataGridView dgvCategories;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnViewAll;
        private Button btnClear;
        private Button btnSearch;
        private Button btnExit;
    }
}