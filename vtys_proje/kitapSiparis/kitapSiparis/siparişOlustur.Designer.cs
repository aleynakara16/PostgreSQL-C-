
namespace kitapSiparis
{
    partial class siparişOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparişOlustur));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.K_Adi = new System.Windows.Forms.TextBox();
            this.K_Id = new System.Windows.Forms.TextBox();
            this.dilAdi = new System.Windows.Forms.Label();
            this.dilId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ara = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tfiyatt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fiyatt = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txbsipaId = new System.Windows.Forms.TextBox();
            this.sipId = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.M_Tc = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // K_Adi
            // 
            this.K_Adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.K_Adi.Location = new System.Drawing.Point(367, 178);
            this.K_Adi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.K_Adi.Name = "K_Adi";
            this.K_Adi.Size = new System.Drawing.Size(148, 13);
            this.K_Adi.TabIndex = 97;
            // 
            // K_Id
            // 
            this.K_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.K_Id.Location = new System.Drawing.Point(367, 152);
            this.K_Id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.K_Id.Name = "K_Id";
            this.K_Id.Size = new System.Drawing.Size(148, 13);
            this.K_Id.TabIndex = 96;
            // 
            // dilAdi
            // 
            this.dilAdi.AutoSize = true;
            this.dilAdi.Location = new System.Drawing.Point(252, 178);
            this.dilAdi.Name = "dilAdi";
            this.dilAdi.Size = new System.Drawing.Size(55, 13);
            this.dilAdi.TabIndex = 95;
            this.dilAdi.Text = "Kitap Adı :";
            // 
            // dilId
            // 
            this.dilId.AutoSize = true;
            this.dilId.Location = new System.Drawing.Point(252, 152);
            this.dilId.Name = "dilId";
            this.dilId.Size = new System.Drawing.Size(51, 13);
            this.dilId.TabIndex = 94;
            this.dilId.Text = "Kitap ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 26);
            this.label1.TabIndex = 93;
            this.label1.Text = "SİPARİŞ OLUŞTUR";
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
            this.ara.Location = new System.Drawing.Point(5, 282);
            this.ara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(256, 24);
            this.ara.TabIndex = 103;
            this.ara.Text = "ARA";
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
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
            this.ekle.Location = new System.Drawing.Point(530, 284);
            this.ekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(256, 24);
            this.ekle.TabIndex = 100;
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
            this.dataGridView1.Location = new System.Drawing.Point(5, 314);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1035, 156);
            this.dataGridView1.TabIndex = 105;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // adet
            // 
            this.adet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adet.Location = new System.Drawing.Point(79, 178);
            this.adet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(148, 13);
            this.adet.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Toplam Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Adet :";
            // 
            // tfiyatt
            // 
            this.tfiyatt.AutoSize = true;
            this.tfiyatt.BackColor = System.Drawing.SystemColors.Control;
            this.tfiyatt.Location = new System.Drawing.Point(78, 208);
            this.tfiyatt.Name = "tfiyatt";
            this.tfiyatt.Size = new System.Drawing.Size(151, 13);
            this.tfiyatt.TabIndex = 111;
            this.tfiyatt.Text = "                                                ";
            this.tfiyatt.Click += new System.EventHandler(this.tfiyatt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Müşteri ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 114;
            this.label5.Text = "Fiyat :";
            // 
            // fiyatt
            // 
            this.fiyatt.AutoSize = true;
            this.fiyatt.BackColor = System.Drawing.SystemColors.Control;
            this.fiyatt.Location = new System.Drawing.Point(364, 208);
            this.fiyatt.Name = "fiyatt";
            this.fiyatt.Size = new System.Drawing.Size(151, 13);
            this.fiyatt.TabIndex = 115;
            this.fiyatt.Text = "                                                ";
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
            this.sil.Location = new System.Drawing.Point(815, 284);
            this.sil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(225, 24);
            this.sil.TabIndex = 118;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(530, 69);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(510, 210);
            this.dataGridView2.TabIndex = 119;
            // 
            // txbsipaId
            // 
            this.txbsipaId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbsipaId.Location = new System.Drawing.Point(79, 152);
            this.txbsipaId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbsipaId.Name = "txbsipaId";
            this.txbsipaId.Size = new System.Drawing.Size(148, 13);
            this.txbsipaId.TabIndex = 122;
            // 
            // sipId
            // 
            this.sipId.AutoSize = true;
            this.sipId.Location = new System.Drawing.Point(2, 152);
            this.sipId.Name = "sipId";
            this.sipId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sipId.Size = new System.Drawing.Size(55, 13);
            this.sipId.TabIndex = 121;
            this.sipId.Text = "Sipariş ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(367, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 124;
            this.label6.Text = "Kargo Firması Seçiniz :";
            // 
            // M_Tc
            // 
            this.M_Tc.AutoSize = true;
            this.M_Tc.BackColor = System.Drawing.SystemColors.Control;
            this.M_Tc.Location = new System.Drawing.Point(78, 128);
            this.M_Tc.Name = "M_Tc";
            this.M_Tc.Size = new System.Drawing.Size(151, 13);
            this.M_Tc.TabIndex = 125;
            this.M_Tc.Text = "                                                ";
            this.M_Tc.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(985, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 126;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(902, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 127;
            this.label7.Text = "BİLGİLERİM";
            // 
            // siparişOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1052, 483);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.M_Tc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txbsipaId);
            this.Controls.Add(this.sipId);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.fiyatt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tfiyatt);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.K_Adi);
            this.Controls.Add(this.K_Id);
            this.Controls.Add(this.dilAdi);
            this.Controls.Add(this.dilId);
            this.Controls.Add(this.label1);
            this.Name = "siparişOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "siparişOlustur";
            this.Load += new System.EventHandler(this.siparişOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox K_Adi;
        private System.Windows.Forms.TextBox K_Id;
        private System.Windows.Forms.Label dilAdi;
        private System.Windows.Forms.Label dilId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tfiyatt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fiyatt;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txbsipaId;
        private System.Windows.Forms.Label sipId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label M_Tc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}