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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=vtysodev ;user ID=postgres ; password=0609");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txbId.Text == String.Empty || txbSifre.Text == String.Empty)
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUN", " UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
            else
            {
                bool blnfound = false;

                baglanti.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Select * from kisi where kisi_id= '" + txbId.Text + "' and sifre = '" + txbSifre.Text + "'", baglanti);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                string kisi = string.Empty;

                if (dr.Read())
                {
                    blnfound = true;
                    kisi = dr["kisi_tur"].ToString();
                    if (kisi == "musteri")
                    {
                        musteriAnasayfa musteriAnasayfa = new musteriAnasayfa();
                        musteriAnasayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        personelAnasayfa personel = new personelAnasayfa();
                        personel.Show();
                        this.Hide();
                    }
                }
                 if (blnfound == false) 
                {
                    MessageBox.Show("LÜTFEN GEÇERLİ BİR KULLANICI ADI VE YA ŞİFRE GİRİNİZ ", " UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                dr.Close();
                baglanti.Close();
            }
           
        }
    }
}
