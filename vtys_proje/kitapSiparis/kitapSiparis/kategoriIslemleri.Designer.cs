
namespace kitapSiparis
{
    partial class kategoriIslemleri
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kategoriIslemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.kategoriId = new System.Windows.Forms.Label();
            this.kategoriAdi = new System.Windows.Forms.Label();
            this.K_Id = new System.Windows.Forms.TextBox();
            this.K_Adi = new System.Windows.Forms.TextBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "KATEGORİ İŞLEMLERİ";
            // 
            // kategoriId
            // 
            this.kategoriId.AutoSize = true;
            this.kategoriId.Location = new System.Drawing.Point(23, 131);
            this.kategoriId.Name = "kategoriId";
            this.kategoriId.Size = new System.Drawing.Size(63, 13);
            this.kategoriId.TabIndex = 2;
            this.kategoriId.Text = "Kategori ID:";
            // 
            // kategoriAdi
            // 
            this.kategoriAdi.AutoSize = true;
            this.kategoriAdi.Location = new System.Drawing.Point(19, 169);
            this.kategoriAdi.Name = "kategoriAdi";
            this.kategoriAdi.Size = new System.Drawing.Size(67, 13);
            this.kategoriAdi.TabIndex = 3;
            this.kategoriAdi.Text = "Kategori Adı:";
            // 
            // K_Id
            // 
            this.K_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.K_Id.Location = new System.Drawing.Point(92, 131);
            this.K_Id.Name = "K_Id";
            this.K_Id.Size = new System.Drawing.Size(138, 13);
            this.K_Id.TabIndex = 4;
            // 
            // K_Adi
            // 
            this.K_Adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.K_Adi.Location = new System.Drawing.Point(92, 169);
            this.K_Adi.Name = "K_Adi";
            this.K_Adi.Size = new System.Drawing.Size(138, 13);
            this.K_Adi.TabIndex = 5;
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.DarkGreen;
            this.guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.guncelle.FlatAppearance.BorderSize = 0;
            this.guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guncelle.Location = new System.Drawing.Point(22, 338);
            this.guncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(208, 24);
            this.guncelle.TabIndex = 68;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.DarkGreen;
            this.ara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ara.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ara.FlatAppearance.BorderSize = 0;
            this.ara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ara.Location = new System.Drawing.Point(22, 306);
            this.ara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(208, 24);
            this.ara.TabIndex = 67;
            this.ara.Text = "ARA";
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.DarkGreen;
            this.listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.listele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listele.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.listele.FlatAppearance.BorderSize = 0;
            this.listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listele.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listele.Location = new System.Drawing.Point(22, 278);
            this.listele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(208, 22);
            this.listele.TabIndex = 66;
            this.listele.Text = "LİSTELE";
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.DarkGreen;
            this.sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.sil.FlatAppearance.BorderSize = 0;
            this.sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sil.Location = new System.Drawing.Point(22, 247);
            this.sil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(208, 24);
            this.sil.TabIndex = 65;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.DarkGreen;
            this.ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ekle.FlatAppearance.BorderSize = 0;
            this.ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ekle.Location = new System.Drawing.Point(22, 217);
            this.ekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(208, 22);
            this.ekle.TabIndex = 64;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 131);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 231);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kategoriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(806, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.K_Adi);
            this.Controls.Add(this.K_Id);
            this.Controls.Add(this.kategoriAdi);
            this.Controls.Add(this.kategoriId);
            this.Controls.Add(this.label1);
            this.Name = "kategoriIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kategoriId;
        private System.Windows.Forms.Label kategoriAdi;
        private System.Windows.Forms.TextBox K_Id;
        private System.Windows.Forms.TextBox K_Adi;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

