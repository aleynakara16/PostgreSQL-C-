using System;
using Npgsql;
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
    public partial class siparişOlustur : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysodev ;user ID=postgres ; password=0609");

        public siparişOlustur()
        {
            InitializeComponent();
        }


        private void siparişOlustur_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from view_urunler order by kitap_id ASC";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Open();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from kargo  order by firma_id ASC", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox1.DisplayMember = "firma_ad"; // bize gözükecek olan
            comboBox1.ValueMember = "firma_id"; // arka kısımda çalışan
            comboBox1.DataSource = dt2;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            K_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            K_Adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fiyatt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


        }

        private void ara_Click(object sender, EventArgs e)
        {
            if (K_Adi.Text == String.Empty)
            {
                MessageBox.Show("almak istediğiniz kitabın adını girin lütfen", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ekle_Click(object sender, EventArgs e)
        {
            if (K_Adi.Text == String.Empty || K_Id.Text == String.Empty || M_Tc.Text == string.Empty || adet.Text == string.Empty || txbsipaId.Text == string.Empty||comboBox1.SelectedIndex==0)
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Random random = new Random();
                int siparisNo = random.Next(1, 1000);

                baglanti.Open();
                NpgsqlCommand komut1 = new NpgsqlCommand("insert into siparis (siparis_id,musteri,kitap,adet,tutar,kargo) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut1.Parameters.AddWithValue("@p1", int.Parse(txbsipaId.Text));
                komut1.Parameters.AddWithValue("@p2", int.Parse(M_Tc.Text));
                komut1.Parameters.AddWithValue("@p3", int.Parse(K_Id.Text));
                komut1.Parameters.AddWithValue("@p4", int.Parse(adet.Text));
                komut1.Parameters.AddWithValue("@p6", int.Parse(comboBox1.SelectedValue.ToString()));

                double toplamTutar = (double.Parse(adet.Text)) * (double.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()));
                tfiyatt.Text = toplamTutar.ToString();
                komut1.Parameters.AddWithValue("@p5", double.Parse(tfiyatt.Text));

                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("SİPARİŞ OLUŞTURULDU", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                int musteri_id = int.Parse(M_Tc.Text);
                string sorgu = "select * from view_siparis WHERE musteri_id ="+musteri_id;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                { // içlerini temizledik.
                    K_Id.Text = "";
                    K_Adi.Text = "";
                    adet.Text = "";
                }
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand();

            komut1.Connection = baglanti;
            komut1.CommandText = "DELETE from siparis where siparis_id='" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'";
            komut1.ExecuteNonQuery();
            baglanti.Close();
            int selectedIndex = dataGridView2.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dataGridView2.Rows.RemoveAt(selectedIndex);
                dataGridView2.Refresh();
            }
        }

        private void tfiyatt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            musteriAnasayfa aa = new musteriAnasayfa();
            this.Close();
            aa.Show();
        }
    }
}
