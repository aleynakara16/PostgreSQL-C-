
namespace kitapSiparis
{
    partial class siparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparisler));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ara = new System.Windows.Forms.Button();
            this.K_Adi = new System.Windows.Forms.TextBox();
            this.S_Id = new System.Windows.Forms.TextBox();
            this.kategoriAdi = new System.Windows.Forms.Label();
            this.kategoriId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 131);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 253);
            this.dataGridView1.TabIndex = 114;
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
            this.ara.Location = new System.Drawing.Point(540, 78);
            this.ara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(212, 19);
            this.ara.TabIndex = 113;
            this.ara.Text = "ARA";
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // K_Adi
            // 
            this.K_Adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.K_Adi.Location = new System.Drawing.Point(361, 84);
            this.K_Adi.Name = "K_Adi";
            this.K_Adi.Size = new System.Drawing.Size(138, 13);
            this.K_Adi.TabIndex = 111;
            // 
            // S_Id
            // 
            this.S_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.S_Id.Location = new System.Drawing.Point(90, 84);
            this.S_Id.Name = "S_Id";
            this.S_Id.Size = new System.Drawing.Size(138, 13);
            this.S_Id.TabIndex = 110;
            // 
            // kategoriAdi
            // 
            this.kategoriAdi.AutoSize = true;
            this.kategoriAdi.Location = new System.Drawing.Point(275, 84);
            this.kategoriAdi.Name = "kategoriAdi";
            this.kategoriAdi.Size = new System.Drawing.Size(80, 13);
            this.kategoriAdi.TabIndex = 109;
            this.kategoriAdi.Text = "MUŞTERİ ADI:";
            // 
            // kategoriId
            // 
            this.kategoriId.AutoSize = true;
            this.kategoriId.Location = new System.Drawing.Point(13, 84);
            this.kategoriId.Name = "kategoriId";
            this.kategoriId.Size = new System.Drawing.Size(66, 13);
            this.kategoriId.TabIndex = 108;
            this.kategoriId.Text = "SİPARİŞ ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 107;
            this.label1.Text = "SİPARİŞ LİSTESİ";
            // 
            // siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(806, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.K_Adi);
            this.Controls.Add(this.S_Id);
            this.Controls.Add(this.kategoriAdi);
            this.Controls.Add(this.kategoriId);
            this.Controls.Add(this.label1);
            this.Name = "siparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "siparisler";
            this.Load += new System.EventHandler(this.siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.TextBox K_Adi;
        private System.Windows.Forms.TextBox S_Id;
        private System.Windows.Forms.Label kategoriAdi;
        private System.Windows.Forms.Label kategoriId;
        private System.Windows.Forms.Label label1;
    }
}