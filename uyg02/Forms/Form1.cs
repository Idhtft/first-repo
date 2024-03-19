using uyg02.Models;

namespace uyg02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            GetCategoryList();
        }

        void GetCategoryList()
        {
            var categories = db.Categories.ToList();
            dgCategories.Rows.Clear();
            foreach (var category in categories)
            {
                dgCategories.Rows.Add(category.Id, category.Name);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Kategori Adý Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Categories.Count(c => c.Name == txtName.Text) > 0)
            {
                MessageBox.Show("Girilen Kategori Adý Kayýtlýdýr!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var category = new Category();
            category.Name = txtName.Text;
            db.Categories.Add(category);
            db.SaveChanges();
            GetCategoryList();
            MessageBox.Show("Kategori Eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }

        private void dgCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgCategories.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgCategories.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtId.Text == "")
            {
                MessageBox.Show("Kategori Seçiniz veya Kategori Adý Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var category = db.Categories.Where(s => s.Id == id).SingleOrDefault();
            if (category == null)
            {
                MessageBox.Show("Kategori Bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            category.Name = txtName.Text;
            db.Categories.Update(category);
            db.SaveChanges();
            GetCategoryList();
            MessageBox.Show("Kategori Düzenlendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Kategori Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var category = db.Categories.Where(s => s.Id == id).SingleOrDefault();
            if (category == null)
            {
                MessageBox.Show("Kategori Bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            db.Categories.Remove(category);
            db.SaveChanges();
            GetCategoryList();
            MessageBox.Show("Kategori Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
        }
    }
}