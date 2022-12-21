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
    public partial class dilIslemleri : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysodev ;user ID=postgres ; password=0609");

        void Listele()
        {
            string sorgu = "select * from dil order by dil_id ASC";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public dilIslemleri()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (D_Adi.Text == String.Empty || D_Id.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into dil(dil_id,dil_adi) values (@p1,@p2)", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(D_Id.Text));
                komut1.Parameters.AddWithValue("@p2", D_Adi.Text);
                komut1.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("DİL KAYDI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (D_Id.Text == "")
            {
                MessageBox.Show("LÜTFEN ÖNCE SİLMEK İSTEDİĞİNİZ DİLİN ID NUMARASINI GİRİNİZ");
            }
            else
            {

                DialogResult result1 = MessageBox.Show("DİL KAYDINI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "DİKKAT", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    baglanti.Open();
                    NpgsqlCommand komut2 = new NpgsqlCommand("Delete from dil where dil_id=@p1", baglanti);
                    komut2.Parameters.AddWithValue("@p1", int.Parse(D_Id.Text));
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
            if (D_Adi.Text == String.Empty || D_Id.Text == String.Empty)
            {
                MessageBox.Show("Boş alan bırakılamaz !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand komut3 = new NpgsqlCommand("update dil set dil_adi=@p2 where dil_id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", int.Parse(D_Id.Text));
                komut3.Parameters.AddWithValue("@p2", D_Adi.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("DİL BİLGİLERİ BAŞARILI BİR ŞEKiLDE GÜNCELLENDİ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }    
        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (D_Adi.Text == string.Empty)
            {
                MessageBox.Show("LÜTFEN ARAMAK İSTEDİĞİNİZ DİLİN ID NUMARASINI GİRİNİZ");

            }
            else
            {
                baglanti.Open();
                D_Adi.CharacterCasing = CharacterCasing.Lower;
                string komut5 = "select * from dil where dil_adi like '%" + D_Adi.Text + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut5, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            D_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            D_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void D_Adi_TextChanged(object sender, EventArgs e)
        {

        }

        private void D_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dilAdi_Click(object sender, EventArgs e)
        {

        }

        private void dilId_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
