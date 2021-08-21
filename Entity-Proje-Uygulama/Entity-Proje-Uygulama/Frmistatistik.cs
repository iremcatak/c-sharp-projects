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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORI.Count().ToString();
            label3.Text = db.TBLURUN.Count().ToString();
            label5.Text = db.TBLMUSTERI.Count(x => x.DURUM==true).ToString(); //x yerine herhangi bir değer kullanılabilir.
            label19.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            label9.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            label15.Text = db.TBLSATIS.Sum(x => x.FIYAT).ToString()+" TL";
            //descending =  en yüksek sırala   ascending = en az  firstorderdefault = en üsttekini getir
            label17.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label23.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label7.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            label21.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            //distinct komutu tekrarsız olarak datayı getirir
            label13.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            label11.Text = db.MARKAGETIR().FirstOrDefault();
        }
    }
}
