
namespace kitapSiparis
{
    partial class yazarIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yazarIslemleri));
            this.Y_Adi = new System.Windows.Forms.TextBox();
            this.Y_Id = new System.Windows.Forms.TextBox();
            this.yazarAdi = new System.Windows.Forms.Label();
            this.yazarId = new System.Windows.Forms.Label();
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
            // Y_Adi
            // 
            this.Y_Adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Y_Adi.Location = new System.Drawing.Point(91, 152);
            this.Y_Adi.Name = "Y_Adi";
            this.Y_Adi.Size = new System.Drawing.Size(138, 13);
            this.Y_Adi.TabIndex = 16;
            // 
            // Y_Id
            // 
            this.Y_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Y_Id.Location = new System.Drawing.Point(91, 114);
            this.Y_Id.Name = "Y_Id";
            this.Y_Id.Size = new System.Drawing.Size(138, 13);
            this.Y_Id.TabIndex = 15;
            // 
            // yazarAdi
            // 
            this.yazarAdi.AutoSize = true;
            this.yazarAdi.Location = new System.Drawing.Point(22, 152);
            this.yazarAdi.Name = "yazarAdi";
            this.yazarAdi.Size = new System.Drawing.Size(55, 13);
            this.yazarAdi.TabIndex = 14;
            this.yazarAdi.Text = "Yazar Adı:";
            // 
            // yazarId
            // 
            this.yazarId.AutoSize = true;
            this.yazarId.Location = new System.Drawing.Point(26, 110);
            this.yazarId.Name = "yazarId";
            this.yazarId.Size = new System.Drawing.Size(51, 13);
            this.yazarId.TabIndex = 13;
            this.yazarId.Text = "Yazar ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "YAZAR İŞLEMLERİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 239);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.DarkGreen;
            this.guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelle.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.guncelle.FlatAppearance.BorderSize = 0;
            this.guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guncelle.Location = new System.Drawing.Point(22, 329);
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
            this.ara.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.ara.FlatAppearance.BorderSize = 0;
            this.ara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ara.Location = new System.Drawing.Point(22, 297);
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
            this.listele.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.listele.FlatAppearance.BorderSize = 0;
            this.listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listele.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listele.Location = new System.Drawing.Point(22, 269);
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
            this.sil.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.sil.FlatAppearance.BorderSize = 0;
            this.sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sil.Location = new System.Drawing.Point(22, 238);
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
            this.ekle.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.ekle.FlatAppearance.BorderSize = 0;
            this.ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ekle.Location = new System.Drawing.Point(22, 208);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // yazarIslemleri
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
            this.Controls.Add(this.Y_Adi);
            this.Controls.Add(this.Y_Id);
            this.Controls.Add(this.yazarAdi);
            this.Controls.Add(this.yazarId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "yazarIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yazarIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Y_Adi;
        private System.Windows.Forms.TextBox Y_Id;
        private System.Windows.Forms.Label yazarAdi;
        private System.Windows.Forms.Label yazarId;
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