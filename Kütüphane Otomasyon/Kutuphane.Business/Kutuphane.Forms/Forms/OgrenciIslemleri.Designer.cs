
namespace Kutuphane.Forms.Forms
{
    partial class OgrenciIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelKitaplar = new System.Windows.Forms.Panel();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.lbl_hosgeldiniz = new System.Windows.Forms.Label();
            this.lbl_borc = new System.Windows.Forms.Label();
            this.panelEmanet = new System.Windows.Forms.Panel();
            this.dataGridViewEmanet = new System.Windows.Forms.DataGridView();
            this.btn_emanet = new System.Windows.Forms.Button();
            this.btn_iade = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.panelKitaplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.panelEmanet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKitaplar
            // 
            this.panelKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKitaplar.Controls.Add(this.dataGridViewKitaplar);
            this.panelKitaplar.Location = new System.Drawing.Point(28, 102);
            this.panelKitaplar.Name = "panelKitaplar";
            this.panelKitaplar.Size = new System.Drawing.Size(323, 225);
            this.panelKitaplar.TabIndex = 18;
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AllowUserToAddRows = false;
            this.dataGridViewKitaplar.AllowUserToDeleteRows = false;
            this.dataGridViewKitaplar.AllowUserToResizeColumns = false;
            this.dataGridViewKitaplar.AllowUserToResizeRows = false;
            this.dataGridViewKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewKitaplar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewKitaplar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKitaplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKitaplar.ColumnHeadersHeight = 50;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKitaplar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKitaplar.EnableHeadersVisualStyles = false;
            this.dataGridViewKitaplar.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(19, 33);
            this.dataGridViewKitaplar.MultiSelect = false;
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.ReadOnly = true;
            this.dataGridViewKitaplar.RowHeadersVisible = false;
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.ShowCellToolTips = false;
            this.dataGridViewKitaplar.ShowEditingIcon = false;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(280, 167);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewKitaplar_ColumnAdded);
            // 
            // lbl_hosgeldiniz
            // 
            this.lbl_hosgeldiniz.AutoSize = true;
            this.lbl_hosgeldiniz.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hosgeldiniz.ForeColor = System.Drawing.Color.Black;
            this.lbl_hosgeldiniz.Location = new System.Drawing.Point(111, 39);
            this.lbl_hosgeldiniz.Name = "lbl_hosgeldiniz";
            this.lbl_hosgeldiniz.Size = new System.Drawing.Size(164, 37);
            this.lbl_hosgeldiniz.TabIndex = 19;
            this.lbl_hosgeldiniz.Text = "lbl_hosgeldiniz";
            // 
            // lbl_borc
            // 
            this.lbl_borc.AutoSize = true;
            this.lbl_borc.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_borc.Location = new System.Drawing.Point(511, 39);
            this.lbl_borc.Name = "lbl_borc";
            this.lbl_borc.Size = new System.Drawing.Size(95, 37);
            this.lbl_borc.TabIndex = 22;
            this.lbl_borc.Text = "lbl_borc";
            // 
            // panelEmanet
            // 
            this.panelEmanet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmanet.Controls.Add(this.dataGridViewEmanet);
            this.panelEmanet.Location = new System.Drawing.Point(384, 102);
            this.panelEmanet.Name = "panelEmanet";
            this.panelEmanet.Size = new System.Drawing.Size(351, 225);
            this.panelEmanet.TabIndex = 23;
            // 
            // dataGridViewEmanet
            // 
            this.dataGridViewEmanet.AllowUserToAddRows = false;
            this.dataGridViewEmanet.AllowUserToDeleteRows = false;
            this.dataGridViewEmanet.AllowUserToResizeColumns = false;
            this.dataGridViewEmanet.AllowUserToResizeRows = false;
            this.dataGridViewEmanet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmanet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmanet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewEmanet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmanet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmanet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmanet.ColumnHeadersHeight = 50;
            this.dataGridViewEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmanet.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmanet.EnableHeadersVisualStyles = false;
            this.dataGridViewEmanet.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewEmanet.Location = new System.Drawing.Point(25, 24);
            this.dataGridViewEmanet.MultiSelect = false;
            this.dataGridViewEmanet.Name = "dataGridViewEmanet";
            this.dataGridViewEmanet.ReadOnly = true;
            this.dataGridViewEmanet.RowHeadersVisible = false;
            this.dataGridViewEmanet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmanet.ShowCellToolTips = false;
            this.dataGridViewEmanet.ShowEditingIcon = false;
            this.dataGridViewEmanet.Size = new System.Drawing.Size(308, 167);
            this.dataGridViewEmanet.TabIndex = 1;
            this.dataGridViewEmanet.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewEmanet_ColumnAdded);
            // 
            // btn_emanet
            // 
            this.btn_emanet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_emanet.BackColor = System.Drawing.Color.Black;
            this.btn_emanet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_emanet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_emanet.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_emanet.ForeColor = System.Drawing.Color.White;
            this.btn_emanet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_emanet.Location = new System.Drawing.Point(163, 345);
            this.btn_emanet.Name = "btn_emanet";
            this.btn_emanet.Size = new System.Drawing.Size(81, 58);
            this.btn_emanet.TabIndex = 24;
            this.btn_emanet.Text = "Emanet Al";
            this.btn_emanet.UseVisualStyleBackColor = false;
            this.btn_emanet.Click += new System.EventHandler(this.btn_emanet_Click);
            // 
            // btn_iade
            // 
            this.btn_iade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_iade.BackColor = System.Drawing.Color.Black;
            this.btn_iade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iade.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iade.ForeColor = System.Drawing.Color.White;
            this.btn_iade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iade.Location = new System.Drawing.Point(330, 345);
            this.btn_iade.Name = "btn_iade";
            this.btn_iade.Size = new System.Drawing.Size(81, 58);
            this.btn_iade.TabIndex = 25;
            this.btn_iade.Text = "İade Et";
            this.btn_iade.UseVisualStyleBackColor = false;
            this.btn_iade.Click += new System.EventHandler(this.btn_iade_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_geri.BackColor = System.Drawing.Color.Black;
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geri.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_geri.Location = new System.Drawing.Point(502, 345);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(81, 58);
            this.btn_geri.TabIndex = 26;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // OgrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_iade);
            this.Controls.Add(this.btn_emanet);
            this.Controls.Add(this.panelEmanet);
            this.Controls.Add(this.lbl_borc);
            this.Controls.Add(this.lbl_hosgeldiniz);
            this.Controls.Add(this.panelKitaplar);
            this.Name = "OgrenciIslemleri";
            this.Text = "OgrenciIslemleri";
            this.Load += new System.EventHandler(this.OgrenciIslemleri_Load);
            this.panelKitaplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.panelEmanet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKitaplar;
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.Label lbl_hosgeldiniz;
        private System.Windows.Forms.Label lbl_borc;
        private System.Windows.Forms.Panel panelEmanet;
        private System.Windows.Forms.DataGridView dataGridViewEmanet;
        private System.Windows.Forms.Button btn_emanet;
        private System.Windows.Forms.Button btn_iade;
        private System.Windows.Forms.Button btn_geri;
    }
}