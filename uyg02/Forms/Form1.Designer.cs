namespace uyg02
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
            dgCategories = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgCategories).BeginInit();
            SuspendLayout();
            // 
            // dgCategories
            // 
            dgCategories.AllowUserToAddRows = false;
            dgCategories.AllowUserToDeleteRows = false;
            dgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategories.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgCategories.Location = new Point(26, 95);
            dgCategories.Name = "dgCategories";
            dgCategories.ReadOnly = true;
            dgCategories.RowHeadersWidth = 62;
            dgCategories.RowTemplate.Height = 33;
            dgCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCategories.Size = new Size(361, 290);
            dgCategories.TabIndex = 0;
            dgCategories.CellClick += dgCategories_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Adı";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 118);
            label1.Name = "label1";
            label1.Size = new Size(29, 25);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(487, 112);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(98, 31);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(487, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 31);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 155);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 3;
            label2.Text = "Adı";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(487, 195);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(641, 195);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 34);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(641, 235);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 34);
            btnClear.TabIndex = 6;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(487, 235);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 24);
            label3.Name = "label3";
            label3.Size = new Size(234, 54);
            label3.TabIndex = 8;
            label3.Text = "Kategoriler";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1000, 500);
            Controls.Add(label3);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgCategories);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Firebrick;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCategories;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label1;
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Label label3;
    }
}