
namespace kitapSiparis
{
    partial class musteriAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriAnasayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kitap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(952, 53);
            this.label1.TabIndex = 61;
            this.label1.Text = "                               MÜŞTERİ İŞLEM EKRANI                              " +
    "           ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // kitap
            // 
            this.kitap.BackColor = System.Drawing.Color.Maroon;
            this.kitap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kitap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitap.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.kitap.FlatAppearance.BorderSize = 0;
            this.kitap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.kitap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kitap.Location = new System.Drawing.Point(0, 73);
            this.kitap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitap.Name = "kitap";
            this.kitap.Size = new System.Drawing.Size(182, 58);
            this.kitap.TabIndex = 64;
            this.kitap.Text = "SİPARİŞ VER";
            this.kitap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kitap.UseVisualStyleBackColor = false;
            this.kitap.Click += new System.EventHandler(this.kitap_Click);
            // 
            // musteriAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(945, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kitap);
            this.Controls.Add(this.label1);
            this.Name = "musteriAnasayfa";
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.musteriAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kitap;
    }
}