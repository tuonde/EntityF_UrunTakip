using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyUrunProjesi
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtMarka.Text = "";
            txtStok.Text = "";
            txtFiyat.Text = "";
            txtDurum.Text = "";
            cmbKtgr.Text = "";
            txtAd.Focus();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM
                                        }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN urn = new TBLURUN();

            urn.URUNAD = txtAd.Text;
            urn.MARKA = txtMarka.Text;
            urn.STOK = short.Parse(txtStok.Text);
            urn.FIYAT = decimal.Parse(txtFiyat.Text);
            urn.DURUM = true;
            urn.KATEGORI = int.Parse(cmbKtgr.SelectedValue.ToString());

            db.TBLURUN.Add(urn);
            db.SaveChanges();
            MessageBox.Show("Ürün eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int rmvID = int.Parse(txtId.Text);
            var urn = db.TBLURUN.Find(rmvID);
            db.TBLURUN.Remove(urn);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbKtgr.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int gncID = int.Parse(txtId.Text);
            var urn = db.TBLURUN.Find(gncID);
            urn.URUNAD = txtAd.Text;
            urn.MARKA = txtMarka.Text;
            urn.STOK = short.Parse(txtStok.Text);

            db.SaveChanges();
            MessageBox.Show("Ürün güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        //KATEGORİLERİ COMBOBOX'A ÇEKME
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            cmbKtgr.ValueMember = "ID";
            cmbKtgr.DisplayMember = "AD";
            cmbKtgr.DataSource = kategoriler;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
