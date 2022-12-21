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
    public partial class yazarIslemleri : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysodev ;user ID=postgres ; password=0609");

        void Listele()
        {
            string sorgu = "select * from yazar order by yazar_id ASC";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public yazarIslemleri()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {

            if (Y_Adi.Text == String.Empty || Y_Id.Text == String.Empty )
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else { 
                baglanti.Open();
                 NpgsqlCommand komut1 = new NpgsqlCommand("insert into yazar(yazar_id,yazar_ad_soyad) values (@p1,@p2)", baglanti);
                 komut1.Parameters.AddWithValue("@p1", int.Parse(Y_Id.Text));
                 komut1.Parameters.AddWithValue("@p2", Y_Adi.Text);
                 komut1.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("YAZAR KAYDI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // içlerini temizledik.
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

        private void sil_Click(object sender, EventArgs e)
        {
            if (Y_Id.Text == String.Empty)
            {
                MessageBox.Show("LÜTFEN ÖNCE SİLMEK İSTEDİĞİNİZ YAZARIN ID NUMARASINI GİRİNİZ");
            }
            else
            {

                DialogResult result1 = MessageBox.Show("YAZARIN KAYDINI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "DİKKAT", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    baglanti.Open();
                    NpgsqlCommand komut2 = new NpgsqlCommand("Delete from yazar where yazar_id=@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", int.Parse(Y_Id.Text));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    Listele();
                }
                else { }
            }
        }

        private void listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (Y_Adi.Text == String.Empty || Y_Id.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("update yazar set yazar_ad_soyad=@p2 where yazar_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", int.Parse(Y_Id.Text));
                komut3.Parameters.AddWithValue("@p2", Y_Adi.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("YAZAR BİLGİLERİ BAŞARILI BİR ŞEKiLDE GÜNCELLENDİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }
           
        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (Y_Adi.Text == String.Empty )
            {
                MessageBox.Show("Yazarın adını girin lütfen", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                Y_Adi.CharacterCasing = CharacterCasing.Lower;
                string komut5 = "select * from yazar where yazar_ad_soyad like '%" + Y_Adi.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Y_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Y_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            personelAnasayfa aa = new personelAnasayfa();
            this.Close();
            aa.Show();
        }
    }
}
