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
    public partial class personelAnasayfa : Form
    {
        public personelAnasayfa()
        {
            InitializeComponent();
        }

        private void kitap_Click(object sender, EventArgs e)
        {
            KitapIslemleri kk = new KitapIslemleri();

            kk.Show();
            this.Hide();
        }

        private void yazar_Click(object sender, EventArgs e)
        {
            yazarIslemleri yy = new yazarIslemleri();
            yy.Show();
            this.Hide();

        }

        private void kategori_Click(object sender, EventArgs e)
        {
            kategoriIslemleri kk = new kategoriIslemleri();
            kk.Show();
            this.Hide();

        }

        private void dil_Click(object sender, EventArgs e)
        {
            dilIslemleri dd = new dilIslemleri();
            dd.Show();
            this.Hide();


        }

        private void tedarikci_Click(object sender, EventArgs e)
        {
            tedarikciIslemcs tt = new tedarikciIslemcs();
            tt.Show();
            this.Hide();

        }

        private void magaza_Click(object sender, EventArgs e)
        {
            magazaIslem mm = new magazaIslem();
            mm.Show();
            this.Hide();

        }

        private void personelAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void kisiler_Click(object sender, EventArgs e)
        {
            kisiler kk = new kisiler();
            kk.Show();
            this.Hide();
        }

        private void siparisler_Click(object sender, EventArgs e)
        {
            siparisler ss = new siparisler();
            ss.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login aa = new login();
            this.Close();
            aa.Show();
        }
    }
}
