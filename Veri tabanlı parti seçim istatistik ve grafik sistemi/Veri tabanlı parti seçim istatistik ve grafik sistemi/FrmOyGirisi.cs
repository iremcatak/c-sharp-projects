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
namespace Veri_tabanlı_parti_seçim_istatistik_ve_grafik_sistemi
{
    public partial class FrmOyGirisi : Form
    {
        public FrmOyGirisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection(@"Data Source=USER-BILGISAYAR\SQLEXPRESS;Initial Catalog=SECİM;Integrated Security=True");
        private void btnoygirisi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", tboxilcead.Text);
            komut.Parameters.AddWithValue("@p2", tboxapartisi.Text);
            komut.Parameters.AddWithValue("@p3", tboxbpartisi.Text);
            komut.Parameters.AddWithValue("@p4", tboxcpartisi.Text);
            komut.Parameters.AddWithValue("@p5", tboxdpartisi.Text);
            komut.Parameters.AddWithValue("@p6", tboxepartisi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy girişi yapıldı.");
        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
            this.Hide();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
