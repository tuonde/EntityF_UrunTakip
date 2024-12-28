using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyUrunProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtAd.Focus();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORI.ToList();
            dataGridView1.DataSource = kategoriler; 
            temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI ktg = new TBLKATEGORI();
            ktg.AD = txtAd.Text;
            db.TBLKATEGORI.Add(ktg);
            db.SaveChanges();
            MessageBox.Show("Kategori eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int rmvID = int.Parse(txtId.Text);
            var ktg = db.TBLKATEGORI.Find(rmvID);
            db.TBLKATEGORI.Remove(ktg);
            db.SaveChanges();
            MessageBox.Show("Kategori silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int gncID = int.Parse(txtId.Text);
            var ktg = db.TBLKATEGORI.Find(gncID);
            ktg.AD = txtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori gücellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }
    }
}
