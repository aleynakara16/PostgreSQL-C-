using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace kitapSiparis
{
    public partial class siparisler : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysodev ;user ID=postgres ; password=0609");

        public siparisler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            personelAnasayfa aa = new personelAnasayfa();
            this.Close();
            aa.Show();
        }

        private void siparisler_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from view_siparis order by id ASC";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (K_Adi.Text == String.Empty && S_Id.Text != string.Empty)
            {
                baglanti.Open();
                string komut5 = "select * from view_siparis where id= " + int.Parse(S_Id.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
                K_Adi.Text = "";
                S_Id.Text = "";
            }
            else if (S_Id.Text == string.Empty && K_Adi.Text != string.Empty)
            {
                baglanti.Open();
                K_Adi.CharacterCasing = CharacterCasing.Lower;
                string komut6 = "select * from view_siparis where ad like '%" + K_Adi.Text + "%'";
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(komut6, baglanti);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                dataGridView1.DataSource = ds2.Tables[0];
                baglanti.Close();
                K_Adi.Text = "";
                S_Id.Text = "";
            }
            else
            {
                MessageBox.Show("aradığınız siparişin bilgisini  girin lütfen", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
