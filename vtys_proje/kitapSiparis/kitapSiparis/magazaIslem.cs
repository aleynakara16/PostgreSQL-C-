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
    public partial class magazaIslem : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysodev ;user ID=postgres ; password=0609");
        void Listele()
        {
            string sorgu = "select * from magaza order by magaza_id ASC";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public magazaIslem()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (M_Adi.Text == String.Empty || M_Id.Text == String.Empty || M_tel.Text == String.Empty|| M_adres.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into magaza(magaza_id,magaza_ad,magaza_tel,magaza_adres) values (@p1,@p2,@p3,@p4)", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(M_Id.Text));
                komut1.Parameters.AddWithValue("@p2", M_Adi.Text);
                komut1.Parameters.AddWithValue("@p3", M_tel.Text);
                komut1.Parameters.AddWithValue("@p4", M_adres.Text);

                komut1.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("MAĞAZA BAŞARILI BİR ŞEKİLDE KAYDEDİLDİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (M_Id.Text == "")
            {
                MessageBox.Show("LÜTFEN ÖNCE SİLMEK İSTEDİĞİNİZ MAĞAZANIN ID NUMARASINI GİRİNİZ");
            }
            else
            {

                DialogResult result1 = MessageBox.Show("MAĞAZAYI  SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "DİKKAT", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    baglanti.Open();
                    NpgsqlCommand komut2 = new NpgsqlCommand("Delete from magaza where magaza_id=@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", int.Parse(M_Id.Text));
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
            if (M_Adi.Text == string.Empty)
            {
                MessageBox.Show("LÜTFEN ARAMAK İSTEDİĞİNİZ MAĞAZANIN ID NUMARASINI GİRİNİZ");

            }
            else
            {
                baglanti.Open();
                M_Adi.CharacterCasing = CharacterCasing.Lower;
                string komut5 = "select * from magaza where magaza_ad like '%" + M_Adi.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (M_Adi.Text == String.Empty || M_Id.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("update magaza set magaza_ad=@p2,magaza_tel=@p3,magaza_adres=@p4 where magaza_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", int.Parse(M_Id.Text));
                komut3.Parameters.AddWithValue("@p2", M_Adi.Text);
                komut3.Parameters.AddWithValue("@p3", M_tel.Text);
                komut3.Parameters.AddWithValue("@p4", M_adres.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("MAĞAZA BİLGİLERİ BAŞARILI BİR ŞEKiLDE GÜNCELLENDİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            M_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            M_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            M_tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            M_adres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            personelAnasayfa aa = new personelAnasayfa();
            this.Close();
            aa.Show();
        }

        private void magazaIslem_Load(object sender, EventArgs e)
        {

        }
    }
}
