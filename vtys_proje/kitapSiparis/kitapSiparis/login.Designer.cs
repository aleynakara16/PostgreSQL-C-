
namespace kitapSiparis
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txbSifre = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.dilAdi = new System.Windows.Forms.Label();
            this.dilId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSifre
            // 
            this.txbSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSifre.Location = new System.Drawing.Point(135, 202);
            this.txbSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSifre.Name = "txbSifre";
            this.txbSifre.Size = new System.Drawing.Size(148, 13);
            this.txbSifre.TabIndex = 41;
            // 
            // txbId
            // 
            this.txbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbId.Location = new System.Drawing.Point(135, 176);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(148, 13);
            this.txbId.TabIndex = 40;
            // 
            // dilAdi
            // 
            this.dilAdi.AutoSize = true;
            this.dilAdi.Location = new System.Drawing.Point(39, 202);
            this.dilAdi.Name = "dilAdi";
            this.dilAdi.Size = new System.Drawing.Size(38, 13);
            this.dilAdi.TabIndex = 39;
            this.dilAdi.Text = "ŞİFRE";
            // 
            // dilId
            // 
            this.dilId.AutoSize = true;
            this.dilId.Location = new System.Drawing.Point(39, 176);
            this.dilId.Name = "dilId";
            this.dilId.Size = new System.Drawing.Size(76, 13);
            this.dilId.TabIndex = 38;
            this.dilId.Text = "KULLANICI ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 35);
            this.label1.TabIndex = 37;
            this.label1.Text = "GİRİŞ EKRANI";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiris.Location = new System.Drawing.Point(42, 234);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(241, 22);
            this.btnGiris.TabIndex = 55;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(669, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txbSifre);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.dilAdi);
            this.Controls.Add(this.dilId);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSifre;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label dilAdi;
        private System.Windows.Forms.Label dilId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}