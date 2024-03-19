using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uyg02.Models;

namespace uyg02.Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void Form2_Load(object sender, EventArgs e)
        {

            GetCategoryList();
        }

        void GetCategoryList()
        {
            var categories = db.Categories.ToList();

            cbCategories.ValueMember = "Id";
            cbCategories.DisplayMember = "Name";
            cbCategories.DataSource = categories;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = new Product();
            product.Name = txtName.Text;
            product.Price = Convert.ToDouble(txtPrice.Text);
            product.CategoryId = Convert.ToInt32(cbCategories.SelectedValue);

            db.Products.Add(product);
            db.SaveChanges();

            MessageBox.Show("Ürün Eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnList.PerformClick();
            btnClear.PerformClick();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var catId = Convert.ToInt32(cbCategories.SelectedValue);

            var products = db.Products.Where(s => s.CategoryId == catId).ToList();
            dgProducts.Rows.Clear();
            foreach (var product in products)
            {
                dgProducts.Rows.Add(product.Id, product.Name, product.Price);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgProducts.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgProducts.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgProducts.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz ve Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);

            var product = db.Products.Where(s => s.Id == id).SingleOrDefault();
            if (product != null)
            {
                product.Name = txtName.Text;
                product.Price = Convert.ToDouble(txtPrice.Text);
                product.CategoryId = Convert.ToInt32(cbCategories.SelectedValue);

                db.Products.Update(product);
                db.SaveChanges();

                MessageBox.Show("Ürün Düzenlendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnList.PerformClick();
                btnClear.PerformClick();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);

            var product = db.Products.Where(s => s.Id == id).SingleOrDefault();
            if (product != null)
            {

                db.Products.Remove(product);
                db.SaveChanges();

                MessageBox.Show("Ürün Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnList.PerformClick();
                btnClear.PerformClick();
            }
        }
    }
}
