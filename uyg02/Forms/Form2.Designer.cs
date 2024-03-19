namespace uyg02.Forms
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
            btnList = new Button();
            dgProducts = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            cbCategories = new ComboBox();
            label1 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            txtName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.FlatStyle = FlatStyle.Flat;
            btnList.Location = new Point(397, 107);
            btnList.Name = "btnList";
            btnList.Size = new Size(139, 34);
            btnList.TabIndex = 15;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.AllowUserToDeleteRows = false;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Column3 });
            dgProducts.Location = new Point(36, 155);
            dgProducts.Name = "dgProducts";
            dgProducts.ReadOnly = true;
            dgProducts.RowHeadersWidth = 62;
            dgProducts.RowTemplate.Height = 33;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(500, 250);
            dgProducts.TabIndex = 14;
            dgProducts.CellClick += dgProducts_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Adı";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Fiyatı";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 112);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 13;
            label3.Text = "Kategori Seçiniz";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(191, 107);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(200, 33);
            cbCategories.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 54);
            label1.TabIndex = 16;
            label1.Text = "Ürünler";
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(718, 320);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 34);
            btnClear.TabIndex = 23;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(564, 320);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 34);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(718, 280);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 34);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(564, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 34);
            btnSave.TabIndex = 22;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(629, 197);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 31);
            txtName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(564, 203);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 19;
            label2.Text = "Adı";
            // 
            // txtId
            // 
            txtId.Location = new Point(629, 160);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(98, 31);
            txtId.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(564, 166);
            label4.Name = "label4";
            label4.Size = new Size(29, 25);
            label4.TabIndex = 17;
            label4.Text = "Id";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(629, 234);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(229, 31);
            txtPrice.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(564, 240);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 25;
            label5.Text = "Fiyatı";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(978, 444);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnList);
            Controls.Add(dgProducts);
            Controls.Add(label3);
            Controls.Add(cbCategories);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Firebrick;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnList;
        private DataGridView dgProducts;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column3;
        private Label label3;
        private ComboBox cbCategories;
        private Label label1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private TextBox txtName;
        private Label label2;
        private TextBox txtId;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
    }
}