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
    public partial class tedarikciIslemcs : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysodev ;user ID=postgres ; password=0609");
        void Listele()
        {
            string sorgu = "select * from tedarikci order by tedarikci_id ASC";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public tedarikciIslemcs()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (T_Adi.Text == String.Empty || T_Id.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into tedarikci(tedarikci_id,tedarikci_adi) values (@p1,@p2)", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(T_Id.Text));
                komut1.Parameters.AddWithValue("@p2", T_Adi.Text);
                komut1.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("TEDARİKÇİ BAŞARILI BİR ŞEKİLDE KAYDEDİLDİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (T_Id.Text == "")
            {
                MessageBox.Show("LÜTFEN ÖNCE SİLMEK İSTEDİĞİNİZ TEDARİKÇİNİN ID NUMARASINI GİRİNİZ");
            }
            else
            {

                DialogResult result1 = MessageBox.Show("TEDARİKÇİYİ  SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "DİKKAT", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    baglanti.Open();
                    NpgsqlCommand komut2 = new NpgsqlCommand("Delete from tedarikci where tedarikci_id=@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", int.Parse(T_Id.Text));
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

        private void ara_Click(object sender, EventArgs e)
        {
            if (T_Adi.Text == string.Empty)
            {
                MessageBox.Show("LÜTFEN ARAMAK İSTEDİĞİNİZ TEDARİKÇİNİN ID NUMARASINI GİRİNİZ");

            }
            else
            {
                baglanti.Open();
                T_Adi.CharacterCasing = CharacterCasing.Lower;
                string komut5 = "select * from tedarikci where tedarikci_adi like '%" + T_Adi.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (T_Adi.Text == String.Empty || T_Id.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("update tedarikci set tedarikci_adi=@p2 where tedarikci_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", int.Parse(T_Id.Text));
                komut3.Parameters.AddWithValue("@p2", T_Adi.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("TEDARİKÇİ BİLGİLERİ BAŞARILI BİR ŞEKiLDE GÜNCELLENDİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            T_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            T_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                personelAnasayfa aa = new personelAnasayfa();
                this.Close();
                aa.Show();
            }
        }
    }
}
