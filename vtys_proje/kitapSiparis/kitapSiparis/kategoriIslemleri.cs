using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitapSiparis
{
    public partial class kategoriIslemleri : Form
    {
        void Listele()
        {
            string sorgu = "select * from kategori order by katagori_id ASC";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public kategoriIslemleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysodev ;user ID=postgres ; password=0609");
        private void KitapIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (K_Adi.Text == String.Empty || K_Id.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into kategori(katagori_id,katagori_adi) values(@p1,@p2)", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(K_Id.Text));
                komut1.Parameters.AddWithValue("@p2", K_Adi.Text);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("KATEGORİ EKLEME İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }

                }
                Listele();
            }
        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (K_Adi.Text == String.Empty)
            {
                MessageBox.Show("Kategorinin adını girin lütfen", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
               K_Adi.CharacterCasing = CharacterCasing.Lower;
                string komut5 = "select * from kategori where katagori_adi like '%" + K_Adi.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            K_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            K_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void sil_Click(object sender, EventArgs e)
        {

            if (K_Id.Text == String.Empty)
            {
                MessageBox.Show("LÜTFEN ÖNCE SİLMEK İSTEDİĞİNİZ KATEGORİNİN ID NUMARASINI GİRİNİZ");
            }
            else
            {

                DialogResult result1 = MessageBox.Show("YAZARIN KAYDINI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "DİKKAT", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    baglanti.Open();
                    NpgsqlCommand komut2 = new NpgsqlCommand("Delete from kategori where katagori_id=@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", int.Parse(K_Id.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    Listele();
                }
                else { }
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            personelAnasayfa aa = new personelAnasayfa();
            this.Close();
            aa.Show();
        }
    }
}
