using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;        //access için kullanılıyor
namespace Kelime_Ogren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\dbSozluk.accdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;
        void getir()
        {
            int sayi;

            sayi = rast.Next(1, 2490);
            //   lblcevap.Text = sayi.ToString();

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                tboxing.Text = dr[1].ToString();
                lblcevap.Text = dr[2].ToString();
                lblcevap.Text = lblcevap.Text.ToLower();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            tboxtur.Focus();
            timer1.Start();
        }

        private void tboxtur_TextChanged(object sender, EventArgs e)
        {
            if (tboxtur.Text == lblcevap.Text)
            {
                kelime++;
                lblkelime.Text = kelime.ToString();
                getir();
                tboxtur.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsure.Text = sure.ToString();
            if (sure == 0)
            {
                tboxtur.Enabled = false;
                tboxing.Enabled = false;
            }
        }
    }
}
