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
    public partial class musteribilgilerim : Form
    {
        public string musteri_id;
        void Listele()
        {
            baglanti.Open();
            string sorgu4 = "select * from view_musteri where kisi=" + int.Parse(id.Text);
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(sorgu4, baglanti);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            dataGridView1.DataSource = ds4.Tables[0];
            baglanti.Close();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysodev ;user ID=postgres ; password=0609");

        public musteribilgilerim()
        {
            InitializeComponent();
        }

        private void musteribilgilerim_Load(object sender, EventArgs e)
        {
            id.Text = musteri_id;
            // combobox a ilceler yazdırıldı
            {
                baglanti.Open();
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from ilce  order by ilce_id ASC", baglanti);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                comboBox1.DisplayMember = "ilce_ad"; // bize gözükecek olan
                comboBox1.ValueMember = "ilce_id"; // arka kısımda çalışan
                comboBox1.DataSource = dt2;
                baglanti.Close();
            }

            Listele();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iletisimno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            soyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sifre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update tbl_musteri set ad=@p1,soyad=@p2,sifre=@p3 where id=" + int.Parse(id.Text), baglanti);
            komut3.Parameters.AddWithValue("@p1", ad.Text);
            komut3.Parameters.AddWithValue("@p2", soyad.Text);
            komut3.Parameters.AddWithValue("@p3",int.Parse( sifre.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("update tbl_iletisim set mail=@p1,telefon=@p2,ilce=@p3 where iletisim_no=" + int.Parse(iletisimno.Text), baglanti);
            komut4.Parameters.AddWithValue("@p1", mail.Text);
            komut4.Parameters.AddWithValue("@p2", tel.Text);
            komut4.Parameters.AddWithValue("@p3", int.Parse(comboBox1.SelectedValue.ToString()));
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("BİLGİLERİNİZ BAŞARILI BİR ŞEK,LDE GÜNCELLENDİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();

        }
    }
}
