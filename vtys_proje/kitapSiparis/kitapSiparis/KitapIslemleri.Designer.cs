
namespace kitapSiparis
{
    partial class KitapIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapIslemleri));
            this.K_Adi = new System.Windows.Forms.TextBox();
            this.K_Id = new System.Windows.Forms.TextBox();
            this.dilAdi = new System.Windows.Forms.Label();
            this.dilId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.afiyatt = new System.Windows.Forms.TextBox();
            this.afiyat = new System.Windows.Forms.Label();
            this.yazar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stok = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.sfiyatt = new System.Windows.Forms.TextBox();
            this.sfiyat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // K_Adi
            // 
            this.K_Adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.K_Adi.Location = new System.Drawing.Point(84, 146);
            this.K_Adi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.K_Adi.Name = "K_Adi";
            this.K_Adi.Size = new System.Drawing.Size(148, 13);
            this.K_Adi.TabIndex = 36;
            // 
            // K_Id
            // 
            this.K_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.K_Id.Location = new System.Drawing.Point(84, 115);
            this.K_Id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.K_Id.Name = "K_Id";
            this.K_Id.Size = new System.Drawing.Size(148, 13);
            this.K_Id.TabIndex = 35;
            this.K_Id.TextChanged += new System.EventHandler(this.K_Id_TextChanged);
            // 
            // dilAdi
            // 
            this.dilAdi.AutoSize = true;
            this.dilAdi.Location = new System.Drawing.Point(21, 140);
            this.dilAdi.Name = "dilAdi";
            this.dilAdi.Size = new System.Drawing.Size(55, 13);
            this.dilAdi.TabIndex = 34;
            this.dilAdi.Text = "Kitap Adı :";
            // 
            // dilId
            // 
            this.dilId.AutoSize = true;
            this.dilId.Location = new System.Drawing.Point(21, 114);
            this.dilId.Name = "dilId";
            this.dilId.Size = new System.Drawing.Size(51, 13);
            this.dilId.TabIndex = 33;
            this.dilId.Text = "Kitap ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "KİTAP İŞLEMLERİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 280);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 166);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // afiyatt
            // 
            this.afiyatt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.afiyatt.Location = new System.Drawing.Point(84, 178);
            this.afiyatt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.afiyatt.Name = "afiyatt";
            this.afiyatt.Size = new System.Drawing.Size(146, 13);
            this.afiyatt.TabIndex = 43;
            // 
            // afiyat
            // 
            this.afiyat.AutoSize = true;
            this.afiyat.Location = new System.Drawing.Point(22, 176);
            this.afiyat.Name = "afiyat";
            this.afiyat.Size = new System.Drawing.Size(56, 13);
            this.afiyat.TabIndex = 41;
            this.afiyat.Text = "Alış Fiyatı :";
            // 
            // yazar
            // 
            this.yazar.AutoSize = true;
            this.yazar.Location = new System.Drawing.Point(351, 173);
            this.yazar.Name = "yazar";
            this.yazar.Size = new System.Drawing.Size(42, 13);
            this.yazar.TabIndex = 40;
            this.yazar.Text = "Yazarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Mağaza :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Stok :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Dil :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Kategori :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tedarikçi :";
            // 
            // stok
            // 
            this.stok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stok.Location = new System.Drawing.Point(84, 240);
            this.stok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stok.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(149, 20);
            this.stok.TabIndex = 49;
            this.stok.ValueChanged += new System.EventHandler(this.stok_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(423, 106);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.guncelle.Location = new System.Drawing.Point(687, 231);
            this.guncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(216, 24);
            this.guncelle.TabIndex = 58;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
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
            this.ara.Location = new System.Drawing.Point(687, 199);
            this.ara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(216, 24);
            this.ara.TabIndex = 57;
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
            this.listele.Location = new System.Drawing.Point(687, 171);
            this.listele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(216, 22);
            this.listele.TabIndex = 56;
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
            this.sil.Location = new System.Drawing.Point(687, 140);
            this.sil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(216, 24);
            this.sil.TabIndex = 55;
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
            this.ekle.Location = new System.Drawing.Point(687, 110);
            this.ekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(216, 22);
            this.ekle.TabIndex = 54;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(423, 138);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 59;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(423, 170);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(146, 21);
            this.comboBox3.TabIndex = 61;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(423, 204);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(146, 21);
            this.comboBox4.TabIndex = 60;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(423, 239);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(146, 21);
            this.comboBox5.TabIndex = 62;
            // 
            // sfiyatt
            // 
            this.sfiyatt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sfiyatt.Location = new System.Drawing.Point(84, 212);
            this.sfiyatt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sfiyatt.Name = "sfiyatt";
            this.sfiyatt.Size = new System.Drawing.Size(146, 13);
            this.sfiyatt.TabIndex = 64;
            // 
            // sfiyat
            // 
            this.sfiyat.AutoSize = true;
            this.sfiyat.Location = new System.Drawing.Point(21, 210);
            this.sfiyat.Name = "sfiyat";
            this.sfiyat.Size = new System.Drawing.Size(63, 13);
            this.sfiyat.TabIndex = 63;
            this.sfiyat.Text = "Satış Fiyatı :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(932, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sfiyatt);
            this.Controls.Add(this.sfiyat);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.afiyatt);
            this.Controls.Add(this.afiyat);
            this.Controls.Add(this.yazar);
            this.Controls.Add(this.K_Adi);
            this.Controls.Add(this.K_Id);
            this.Controls.Add(this.dilAdi);
            this.Controls.Add(this.dilId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KitapIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapIslemleri";
            this.Load += new System.EventHandler(this.KitapIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox K_Adi;
        private System.Windows.Forms.TextBox K_Id;
        private System.Windows.Forms.Label dilAdi;
        private System.Windows.Forms.Label dilId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox afiyatt;
        private System.Windows.Forms.Label afiyat;
        private System.Windows.Forms.Label yazar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown stok;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox sfiyatt;
        private System.Windows.Forms.Label sfiyat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}