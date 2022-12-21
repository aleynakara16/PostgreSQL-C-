
namespace kitapSiparis
{
    partial class dilIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dilIslemleri));
            this.D_Adi = new System.Windows.Forms.TextBox();
            this.D_Id = new System.Windows.Forms.TextBox();
            this.dilAdi = new System.Windows.Forms.Label();
            this.dilId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guncelle = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // D_Adi
            // 
            this.D_Adi.Location = new System.Drawing.Point(87, 168);
            this.D_Adi.Name = "D_Adi";
            this.D_Adi.Size = new System.Drawing.Size(147, 20);
            this.D_Adi.TabIndex = 27;
            this.D_Adi.TextChanged += new System.EventHandler(this.D_Adi_TextChanged);
            // 
            // D_Id
            // 
            this.D_Id.Location = new System.Drawing.Point(87, 130);
            this.D_Id.Name = "D_Id";
            this.D_Id.Size = new System.Drawing.Size(147, 20);
            this.D_Id.TabIndex = 26;
            this.D_Id.TextChanged += new System.EventHandler(this.D_Id_TextChanged);
            // 
            // dilAdi
            // 
            this.dilAdi.AutoSize = true;
            this.dilAdi.Location = new System.Drawing.Point(27, 171);
            this.dilAdi.Name = "dilAdi";
            this.dilAdi.Size = new System.Drawing.Size(40, 13);
            this.dilAdi.TabIndex = 25;
            this.dilAdi.Text = "Dil Adı:";
            this.dilAdi.Click += new System.EventHandler(this.dilAdi_Click);
            // 
            // dilId
            // 
            this.dilId.AutoSize = true;
            this.dilId.Location = new System.Drawing.Point(24, 133);
            this.dilId.Name = "dilId";
            this.dilId.Size = new System.Drawing.Size(36, 13);
            this.dilId.TabIndex = 24;
            this.dilId.Text = "Dil ID:";
            this.dilId.Click += new System.EventHandler(this.dilId_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "DİL İŞLEMLERİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 233);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.guncelle.Location = new System.Drawing.Point(27, 340);
            this.guncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(207, 24);
            this.guncelle.TabIndex = 63;
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
            this.ara.Location = new System.Drawing.Point(27, 308);
            this.ara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(207, 24);
            this.ara.TabIndex = 62;
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
            this.listele.Location = new System.Drawing.Point(27, 280);
            this.listele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(207, 22);
            this.listele.TabIndex = 61;
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
            this.sil.Location = new System.Drawing.Point(27, 249);
            this.sil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(207, 24);
            this.sil.TabIndex = 60;
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
            this.ekle.Location = new System.Drawing.Point(27, 219);
            this.ekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(207, 22);
            this.ekle.TabIndex = 59;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dilIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(806, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.D_Adi);
            this.Controls.Add(this.D_Id);
            this.Controls.Add(this.dilAdi);
            this.Controls.Add(this.dilId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dilIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dilIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox D_Adi;
        private System.Windows.Forms.TextBox D_Id;
        private System.Windows.Forms.Label dilAdi;
        private System.Windows.Forms.Label dilId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}