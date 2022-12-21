
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
            this.txbSifre = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.dilAdi = new System.Windows.Forms.Label();
            this.dilId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbSifre
            // 
            this.txbSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSifre.Location = new System.Drawing.Point(154, 169);
            this.txbSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSifre.Name = "txbSifre";
            this.txbSifre.Size = new System.Drawing.Size(148, 13);
            this.txbSifre.TabIndex = 41;
            // 
            // txbId
            // 
            this.txbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbId.Location = new System.Drawing.Point(154, 143);
            this.txbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(148, 13);
            this.txbId.TabIndex = 40;
            // 
            // dilAdi
            // 
            this.dilAdi.AutoSize = true;
            this.dilAdi.Location = new System.Drawing.Point(58, 169);
            this.dilAdi.Name = "dilAdi";
            this.dilAdi.Size = new System.Drawing.Size(38, 13);
            this.dilAdi.TabIndex = 39;
            this.dilAdi.Text = "ŞİFRE";
            // 
            // dilId
            // 
            this.dilId.AutoSize = true;
            this.dilId.Location = new System.Drawing.Point(58, 143);
            this.dilId.Name = "dilId";
            this.dilId.Size = new System.Drawing.Size(76, 13);
            this.dilId.TabIndex = 38;
            this.dilId.Text = "KULLANICI ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(94, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 37;
            this.label1.Text = "GİRİŞ EKRANI";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiris.Location = new System.Drawing.Point(61, 204);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(241, 22);
            this.btnGiris.TabIndex = 55;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txbSifre);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.dilAdi);
            this.Controls.Add(this.dilId);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
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
    }
}