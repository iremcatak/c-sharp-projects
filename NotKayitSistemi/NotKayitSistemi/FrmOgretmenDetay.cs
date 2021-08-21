using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NotKayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=USER-BILGISAYAR\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayıtDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS(OGRNUMARA,OGRAD,OGRSOYAD)values(@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", mtboxnumara.Text);
            komut.Parameters.AddWithValue("@p2", tboxad.Text);
            komut.Parameters.AddWithValue("@p3", tboxsoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci sisteme eklendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);//otomatik doldurma
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(tboxsınav1.Text);
            s2 = Convert.ToDouble(tboxsınav2.Text);
            s3 = Convert.ToDouble(tboxsınav3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            lblortalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@p1,OGRS2=@p2,OGRS3=@p3,ORTALAMA=@p4,DURUM=@p5 where OGRNUMARA=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", tboxsınav1.Text);
            komut.Parameters.AddWithValue("@p2", tboxsınav2.Text);
            komut.Parameters.AddWithValue("@p3", tboxsınav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblortalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", mtboxnumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi.");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayıtDataSet.TBLDERS);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mtboxnumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tboxad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tboxsoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tboxsınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tboxsınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            tboxsınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}
