using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Proje_Uygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        { x.URUNID, x.URUNAD, x.MARKA, x.STOK, x.FIYAT, x.TBLKATEGORI.AD, x.DURUM }
                                        ).ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = tboxad.Text;
            t.MARKA = tboxmarka.Text;
            t.STOK = short.Parse(tboxstok.Text);
            t.FIYAT = decimal.Parse(tboxfiyat.Text);
            t.DURUM = true;
            t.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            t.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün eklendi.");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tboxid.Text);
            var ürün = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(ürün);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi.");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tboxid.Text);
            var ürün = db.TBLURUN.Find(x);
            ürün.URUNAD = tboxad.Text;
            ürün.MARKA = tboxmarka.Text;
            ürün.STOK = short.Parse(tboxstok.Text);
            db.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı.");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            //comboboxa verileri yansıtma
            //-----------------------------------------------
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               { x.ID, x.AD }
                             ).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;
            //-----------------------------------------------
        }
    }
}
