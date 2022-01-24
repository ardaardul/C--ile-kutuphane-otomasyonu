
namespace Kutuphane.Forms.Forms
{
    partial class KitapDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapDetay));
            this.panelKitapDetay = new System.Windows.Forms.Panel();
            this.dataGridViewKitapDetay = new System.Windows.Forms.DataGridView();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.lbl_turVal = new System.Windows.Forms.Label();
            this.lbl_adVal = new System.Windows.Forms.Label();
            this.lbl_yazar = new System.Windows.Forms.Label();
            this.lbl_yazarVal = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelKitapDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitapDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKitapDetay
            // 
            this.panelKitapDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKitapDetay.BackColor = System.Drawing.Color.Transparent;
            this.panelKitapDetay.Controls.Add(this.dataGridViewKitapDetay);
            this.panelKitapDetay.Location = new System.Drawing.Point(22, 88);
            this.panelKitapDetay.Name = "panelKitapDetay";
            this.panelKitapDetay.Size = new System.Drawing.Size(367, 292);
            this.panelKitapDetay.TabIndex = 33;
            // 
            // dataGridViewKitapDetay
            // 
            this.dataGridViewKitapDetay.AllowUserToAddRows = false;
            this.dataGridViewKitapDetay.AllowUserToDeleteRows = false;
            this.dataGridViewKitapDetay.AllowUserToResizeColumns = false;
            this.dataGridViewKitapDetay.AllowUserToResizeRows = false;
            this.dataGridViewKitapDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKitapDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitapDetay.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewKitapDetay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewKitapDetay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKitapDetay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewKitapDetay.ColumnHeadersHeight = 50;
            this.dataGridViewKitapDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKitapDetay.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewKitapDetay.EnableHeadersVisualStyles = false;
            this.dataGridViewKitapDetay.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewKitapDetay.Location = new System.Drawing.Point(29, 19);
            this.dataGridViewKitapDetay.MultiSelect = false;
            this.dataGridViewKitapDetay.Name = "dataGridViewKitapDetay";
            this.dataGridViewKitapDetay.ReadOnly = true;
            this.dataGridViewKitapDetay.RowHeadersVisible = false;
            this.dataGridViewKitapDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitapDetay.ShowCellToolTips = false;
            this.dataGridViewKitapDetay.ShowEditingIcon = false;
            this.dataGridViewKitapDetay.Size = new System.Drawing.Size(309, 247);
            this.dataGridViewKitapDetay.TabIndex = 0;
            this.dataGridViewKitapDetay.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewKitapDetay_ColumnAdded);
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tur.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tur.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_tur.Location = new System.Drawing.Point(422, 196);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(132, 23);
            this.lbl_tur.TabIndex = 34;
            this.lbl_tur.Text = "Kitap Türü :";
            // 
            // lbl_turVal
            // 
            this.lbl_turVal.AutoSize = true;
            this.lbl_turVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_turVal.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_turVal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_turVal.Location = new System.Drawing.Point(573, 196);
            this.lbl_turVal.Name = "lbl_turVal";
            this.lbl_turVal.Size = new System.Drawing.Size(120, 23);
            this.lbl_turVal.TabIndex = 36;
            this.lbl_turVal.Text = "Kitap Türü";
            // 
            // lbl_adVal
            // 
            this.lbl_adVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adVal.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adVal.ForeColor = System.Drawing.Color.Black;
            this.lbl_adVal.Location = new System.Drawing.Point(420, 88);
            this.lbl_adVal.Name = "lbl_adVal";
            this.lbl_adVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_adVal.Size = new System.Drawing.Size(273, 96);
            this.lbl_adVal.TabIndex = 37;
            this.lbl_adVal.Text = "Kitap Adı";
            this.lbl_adVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_yazar
            // 
            this.lbl_yazar.AutoSize = true;
            this.lbl_yazar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yazar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazar.ForeColor = System.Drawing.Color.Black;
            this.lbl_yazar.Location = new System.Drawing.Point(423, 279);
            this.lbl_yazar.Name = "lbl_yazar";
            this.lbl_yazar.Size = new System.Drawing.Size(64, 18);
            this.lbl_yazar.TabIndex = 38;
            this.lbl_yazar.Text = "Yazar :";
            // 
            // lbl_yazarVal
            // 
            this.lbl_yazarVal.AutoSize = true;
            this.lbl_yazarVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yazarVal.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazarVal.ForeColor = System.Drawing.Color.Black;
            this.lbl_yazarVal.Location = new System.Drawing.Point(574, 279);
            this.lbl_yazarVal.Name = "lbl_yazarVal";
            this.lbl_yazarVal.Size = new System.Drawing.Size(87, 18);
            this.lbl_yazarVal.TabIndex = 39;
            this.lbl_yazarVal.Text = "Yazar Adı";
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikis.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikis.Image = ((System.Drawing.Image)(resources.GetObject("cikis.Image")));
            this.cikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cikis.Location = new System.Drawing.Point(618, 343);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(75, 79);
            this.cikis.TabIndex = 40;
            this.cikis.Text = "ÇIKIŞ";
            this.cikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(573, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Kitap Türü";
            // 
            // KitapDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.lbl_yazarVal);
            this.Controls.Add(this.lbl_yazar);
            this.Controls.Add(this.lbl_adVal);
            this.Controls.Add(this.lbl_turVal);
            this.Controls.Add(this.lbl_tur);
            this.Controls.Add(this.panelKitapDetay);
            this.Name = "KitapDetay";
            this.Text = "KitapDetay";
            this.Load += new System.EventHandler(this.KitapDetay_Load);
            this.panelKitapDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitapDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKitapDetay;
        private System.Windows.Forms.DataGridView dataGridViewKitapDetay;
        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.Label lbl_turVal;
        private System.Windows.Forms.Label lbl_adVal;
        private System.Windows.Forms.Label lbl_yazar;
        private System.Windows.Forms.Label lbl_yazarVal;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label2;
    }
}