
namespace Kutuphane.Forms.Forms
{
    partial class KitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkle));
            this.lbl_ad = new System.Windows.Forms.Label();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.lbl_yazar = new System.Windows.Forms.Label();
            this.tb_yazar = new System.Windows.Forms.TextBox();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.tb_tur = new System.Windows.Forms.TextBox();
            this.lbl_sayfa = new System.Windows.Forms.Label();
            this.tb_sayfa = new System.Windows.Forms.TextBox();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.tb_stok = new System.Windows.Forms.TextBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ad.Location = new System.Drawing.Point(32, 55);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(87, 19);
            this.lbl_ad.TabIndex = 12;
            this.lbl_ad.Text = "Kitap Adı :";
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(162, 55);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(100, 20);
            this.tb_ad.TabIndex = 13;
            // 
            // lbl_yazar
            // 
            this.lbl_yazar.AutoSize = true;
            this.lbl_yazar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yazar.Location = new System.Drawing.Point(32, 111);
            this.lbl_yazar.Name = "lbl_yazar";
            this.lbl_yazar.Size = new System.Drawing.Size(90, 19);
            this.lbl_yazar.TabIndex = 14;
            this.lbl_yazar.Text = "Yazar Adı :";
            // 
            // tb_yazar
            // 
            this.tb_yazar.Location = new System.Drawing.Point(162, 112);
            this.tb_yazar.Name = "tb_yazar";
            this.tb_yazar.Size = new System.Drawing.Size(100, 20);
            this.tb_yazar.TabIndex = 15;
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tur.Location = new System.Drawing.Point(32, 167);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(96, 19);
            this.lbl_tur.TabIndex = 16;
            this.lbl_tur.Text = "Kitap Türü :";
            // 
            // tb_tur
            // 
            this.tb_tur.Location = new System.Drawing.Point(162, 168);
            this.tb_tur.Name = "tb_tur";
            this.tb_tur.Size = new System.Drawing.Size(100, 20);
            this.tb_tur.TabIndex = 17;
            // 
            // lbl_sayfa
            // 
            this.lbl_sayfa.AutoSize = true;
            this.lbl_sayfa.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sayfa.Location = new System.Drawing.Point(32, 221);
            this.lbl_sayfa.Name = "lbl_sayfa";
            this.lbl_sayfa.Size = new System.Drawing.Size(101, 19);
            this.lbl_sayfa.TabIndex = 18;
            this.lbl_sayfa.Text = "Sayfa Sayısı :";
            // 
            // tb_sayfa
            // 
            this.tb_sayfa.Location = new System.Drawing.Point(162, 222);
            this.tb_sayfa.Name = "tb_sayfa";
            this.tb_sayfa.Size = new System.Drawing.Size(100, 20);
            this.tb_sayfa.TabIndex = 19;
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stok.Location = new System.Drawing.Point(32, 275);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(103, 19);
            this.lbl_stok.TabIndex = 20;
            this.lbl_stok.Text = "Kitap Adedi :";
            // 
            // tb_stok
            // 
            this.tb_stok.Location = new System.Drawing.Point(162, 275);
            this.tb_stok.Name = "tb_stok";
            this.tb_stok.Size = new System.Drawing.Size(100, 20);
            this.tb_stok.TabIndex = 21;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_iptal.BackColor = System.Drawing.Color.Black;
            this.btn_iptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iptal.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iptal.ForeColor = System.Drawing.Color.White;
            this.btn_iptal.Image = ((System.Drawing.Image)(resources.GetObject("btn_iptal.Image")));
            this.btn_iptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_iptal.Location = new System.Drawing.Point(257, 301);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(66, 69);
            this.btn_iptal.TabIndex = 22;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ekle.BackColor = System.Drawing.Color.Black;
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ekle.Image")));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ekle.Location = new System.Drawing.Point(185, 301);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(66, 69);
            this.btn_ekle.TabIndex = 23;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(333, 382);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.tb_stok);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.tb_sayfa);
            this.Controls.Add(this.lbl_sayfa);
            this.Controls.Add(this.tb_tur);
            this.Controls.Add(this.lbl_tur);
            this.Controls.Add(this.tb_yazar);
            this.Controls.Add(this.lbl_yazar);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.lbl_ad);
            this.Name = "KitapEkle";
            this.Text = "KitapEkle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.Label lbl_yazar;
        private System.Windows.Forms.TextBox tb_yazar;
        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.TextBox tb_tur;
        private System.Windows.Forms.Label lbl_sayfa;
        private System.Windows.Forms.TextBox tb_sayfa;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.TextBox tb_stok;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_ekle;
    }
}