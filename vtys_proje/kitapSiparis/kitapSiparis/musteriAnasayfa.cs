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
    public partial class musteriAnasayfa : Form
    {
        public musteriAnasayfa()
        {
            InitializeComponent();
        }

        private void musteriAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kitap_Click(object sender, EventArgs e)
        {
            siparişOlustur sp = new siparişOlustur();
            sp.Show();
            this.Hide();
        }
    }
}
