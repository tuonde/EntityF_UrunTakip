using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EntitiyUrunProjesi
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lblTKS.Text = db.TBLKATEGORI.Count().ToString();
            lblTUS.Text = db.TBLURUN.Count().ToString();
            lblAMS.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            lblPMS.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            lblTS.Text = db.TBLURUN.Sum(y => y.STOK).ToString();
            lblEDFU.Text = db.TBLURUN.Where(z => z.FIYAT == db.TBLURUN.Min(t => t.FIYAT)).Select(z => z.URUNAD + "\n" + z.MARKA).FirstOrDefault();
            lblEYFU.Text = db.TBLURUN.Where(z => z.FIYAT == db.TBLURUN.Max(t => t.FIYAT)).Select(z => z.URUNAD + "\n" + z.MARKA).FirstOrDefault();
            lblKASA.Text = db.TBLSATIS.Sum(t => t.FIYAT).ToString() + " TL";
            lblBES.Text = db.TBLURUN.Count(z => z.KATEGORI == 1).ToString();
            label17.Text = db.TBLURUN.Count(z => z.URUNAD == "BUZDOLABI").ToString();
            lblSS.Text = db.TBLMUSTERI.Select(x => x.SEHIR).Distinct().Count().ToString();
            lblMRK.Text = db.MARKAGETIR().FirstOrDefault();
        }
    }
}
