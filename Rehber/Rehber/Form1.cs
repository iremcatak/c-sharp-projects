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
namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=USER-BILGISAYAR\SQLEXPRESS;Initial Catalog=REhber;Integrated Security=True");

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from KISILER", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            tboxad.Text = "";
            tboxid.Text = "";
            tboxsoyad.Text = "";
            tboxmail.Text = "";
            maskedTextBox1.Text = "";
            tboxad.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KISILER (AD,SOYAD,TEL,MAIL) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", tboxad.Text);
            komut.Parameters.AddWithValue("@p2", tboxsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", tboxmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi rehbere eklendi.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from KISILER where ID=" + tboxid.Text, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi rehberden silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btntemile_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tboxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tboxad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tboxsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tboxmail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update KISILER set AD=@p1,SOYAD=@p2,TEL=@p3,MAIL=@p4 WHERE ID =@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", tboxad.Text);
            komut.Parameters.AddWithValue("@p2", tboxsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", tboxmail.Text);
            komut.Parameters.AddWithValue("@p5", tboxid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi.");
            listele();
            temizle();

        }
    }
}
