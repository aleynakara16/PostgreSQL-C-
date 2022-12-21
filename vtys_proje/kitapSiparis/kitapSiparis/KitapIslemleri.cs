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
    public partial class KitapIslemleri : Form
    {
        void Listele()
        {
            string sorgu = "select * from view_kitap order by kitap_id ASC";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public KitapIslemleri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysodev ;user ID=postgres ; password=0609");
        private void KitapIslemleri_Load(object sender, EventArgs e)
        { // combobox1 e kategoriler eklendi
            {
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from kategori  order by katagori_id ASC", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DisplayMember = "katagori_adi"; // bize gözükecek olan
                comboBox1.ValueMember = "katagori_id"; // arka kısımda çalışan
                comboBox1.DataSource = dt;
                baglanti.Close();
            }

           // comobobox2 ye diller eklendi
            {
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from dil  order by dil_id ASC", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox2.DisplayMember = "dil_adi"; // bize gözükecek olan
                comboBox2.ValueMember = "dil_id"; // arka kısımda çalışan
                comboBox2.DataSource = dt;
                baglanti.Close();
            }

            //combobox3 e yazarlar eklendi
            {
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from yazar  order by yazar_id ASC", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox3.DisplayMember = "yazar_ad_soyad"; // bize gözükecek olan
                comboBox3.ValueMember = "yazar_id"; // arka kısımda çalışan
                comboBox3.DataSource = dt;
                baglanti.Close();
            }

            //combobox4 e magaza eklendi
            {
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from magaza order by magaza_id ASC", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox4.DisplayMember = "magaza_ad"; // bize gözükecek olan
                comboBox4.ValueMember = "magaza_id"; // arka kısımda çalışan
                comboBox4.DataSource = dt;
                baglanti.Close();
            }

            //combobox5 e tedarikçi eklendi
            {
                baglanti.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from tedarikci  order by tedarikci_id ASC", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox5.DisplayMember = "tedarikci_adi"; // bize gözükecek olan
                comboBox5.ValueMember = "tedarikci_id"; // arka kısımda çalışan
                comboBox5.DataSource = dt;
                baglanti.Close();
            }

        }

        private void listele_Click(object sender, EventArgs e)
        {
            Listele(); 
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (K_Adi.Text == String.Empty || K_Id.Text == String.Empty || afiyatt.Text == String.Empty || sfiyatt.Text == String.Empty ||comboBox1.SelectedIndex==0
                || comboBox2.SelectedIndex==0 || comboBox3.SelectedIndex == 0 || comboBox4.SelectedIndex == 0 || comboBox5.SelectedIndex == 0)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into kitaplar(kitap_id,kitap_ad,yazar,alis_fiyat,stok,magaza,tedarikci,katagori,dil,satis_fiyat) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(K_Id.Text));
                komut1.Parameters.AddWithValue("@p2", K_Adi.Text);
                komut1.Parameters.AddWithValue("@p3", int.Parse(comboBox3.SelectedValue.ToString()));
                komut1.Parameters.AddWithValue("@p4", double.Parse(afiyatt.Text));
                komut1.Parameters.AddWithValue("@p10", double.Parse(sfiyatt.Text));
                komut1.Parameters.AddWithValue("@p5", int.Parse(stok.Value.ToString()));
                komut1.Parameters.AddWithValue("@p6", int.Parse(comboBox4.SelectedValue.ToString()));
                komut1.Parameters.AddWithValue("@p7", int.Parse(comboBox5.SelectedValue.ToString()));
                komut1.Parameters.AddWithValue("@p8", int.Parse(comboBox1.SelectedValue.ToString()));
                komut1.Parameters.AddWithValue("@p9", int.Parse(comboBox2.SelectedValue.ToString()));
                komut1.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("KİTAP KAYDI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // içlerini temizledik.
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }
                }
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;
                comboBox5.SelectedIndex = 0;
                stok.Value = 0;

                Listele();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (K_Id.Text == String.Empty)
            {
                MessageBox.Show("LÜTFEN ÖNCE SİLMEK İSTEDİĞİNİZ KİTABIN ID NUMARASINI GİRİNİZ");
            }
            else { 

            DialogResult result1 = MessageBox.Show("KİTAP KAYDINI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?","DİKKAT", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                baglanti.Open();
                NpgsqlCommand komut2 = new NpgsqlCommand("Delete from kitaplar where kitap_id=@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", int.Parse(K_Id.Text));
                NpgsqlCommand komut3 = new NpgsqlCommand("Delete from siparis where kitap=@p2", baglanti);
                komut3.Parameters.AddWithValue("@p2", int.Parse(K_Id.Text));
                komut3.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                baglanti.Close();
                Listele();    
                }
            else{ }
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (K_Adi.Text == String.Empty || K_Id.Text == String.Empty) {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("update kitaplar set kitap_ad=@p2,yazar=@p3,alis_fiyat=@p4,stok=@p5,magaza=@p6,tedarikci=@p7,katagori=@p8,dil=@p9,satis_fiyat=@p10 where kitap_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", int.Parse(K_Id.Text));
                komut3.Parameters.AddWithValue("@p2", K_Adi.Text);
                komut3.Parameters.AddWithValue("@p3", int.Parse(comboBox3.SelectedValue.ToString()));
                komut3.Parameters.AddWithValue("@p4", double.Parse(afiyatt.Text));
                komut3.Parameters.AddWithValue("@p10", double.Parse(sfiyatt.Text));
                komut3.Parameters.AddWithValue("@p5", int.Parse(stok.Value.ToString()));
                komut3.Parameters.AddWithValue("@p6", int.Parse(comboBox4.SelectedValue.ToString()));
                komut3.Parameters.AddWithValue("@p7", int.Parse(comboBox5.SelectedValue.ToString()));
                komut3.Parameters.AddWithValue("@p8", int.Parse(comboBox1.SelectedValue.ToString()));
                komut3.Parameters.AddWithValue("@p9", int.Parse(comboBox2.SelectedValue.ToString()));
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("KİTAP BİLGİLERİ BAŞARILI BİR ŞEK,LDE GÜNCELLENDİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }

        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (K_Adi.Text == String.Empty)
            {
                MessageBox.Show("kitabın adını girin lütfen", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                K_Adi.CharacterCasing = CharacterCasing.Lower;
                string komut5 = "select * from view_kitap where kitap like '%" + K_Adi.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }

        }

        private void stok_ValueChanged(object sender, EventArgs e)
        {

        }

        private void K_Id_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            K_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            K_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            afiyatt.Text =dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sfiyatt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            stok.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
            comboBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString(); ;
            comboBox2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            personelAnasayfa aa = new personelAnasayfa();
            this.Close();
            aa.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
