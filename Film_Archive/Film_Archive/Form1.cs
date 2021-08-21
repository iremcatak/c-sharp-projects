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
namespace Film_Archive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=USER-BILGISAYAR\SQLEXPRESS;Initial Catalog=Fılm Archive;Integrated Security=True");
        void movies()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_MOVIES", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            movies();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TBL_MOVIES(NAME, CATEGORY, LINK)values(@p1, @p2, @p3)", connection);
            command.Parameters.AddWithValue("@p1", tboxname.Text);
            command.Parameters.AddWithValue("@p2", cboxcategory.Text);
            command.Parameters.AddWithValue("@p3", tboxlink.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Added to your movie list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[selected].Cells[3].Value.ToString();

            webBrowser1.Navigate(link);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnfullscreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
