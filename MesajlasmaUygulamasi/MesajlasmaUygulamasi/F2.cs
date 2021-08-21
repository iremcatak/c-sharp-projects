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
namespace MesajlasmaUygulamasi
{
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=USER-BILGISAYAR\SQLEXPRESS;Initial Catalog=TEST;Integrated Security=True");
        private void lblnumara_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;
            gelenkutusu();
            gidenkutusu();
            //ad soyad çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"select AD,SOYAD from TBLKISILER where numara=" + numara, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
        }
        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from TBLMESAJLAR where ALICI=" + numara, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBLMESAJLAR where GONDEREN=" + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(@"insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", tboxalici.Text);
            komut.Parameters.AddWithValue("@p3", tboxbaslik.Text);
            komut.Parameters.AddWithValue("@p4", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız iletildi.");
            gidenkutusu();
        }
    }
}
