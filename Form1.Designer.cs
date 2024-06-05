namespace ErenSevindikFlightApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.lb_baslık = new System.Windows.Forms.Label();
            this.btn_ucakekle = new System.Windows.Forms.Button();
            this.tb_kapasite = new System.Windows.Forms.TextBox();
            this.tb_seri = new System.Windows.Forms.TextBox();
            this.lb_kapasite = new System.Windows.Forms.Label();
            this.lb_seri = new System.Windows.Forms.Label();
            this.tb_marka = new System.Windows.Forms.TextBox();
            this.lb_marka = new System.Windows.Forms.Label();
            this.lb_model = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_lokasyon = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Havaalani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cb_havaalani = new System.Windows.Forms.ComboBox();
            this.cb_sehir = new System.Windows.Forms.ComboBox();
            this.cb_ulke = new System.Windows.Forms.ComboBox();
            this.lb_Havaalani = new System.Windows.Forms.Label();
            this.lb_sehir = new System.Windows.Forms.Label();
            this.lb_ulke = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lb_secilenKoltuk = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_ucakgoruntu = new System.Windows.Forms.DataGridView();
            this.ıd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoltukKapasite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_koltukOnayla = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lokasyon)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ucakgoruntu)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Controls.Add(this.tabPage4);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(800, 450);
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_model);
            this.tabPage1.Controls.Add(this.lb_baslık);
            this.tabPage1.Controls.Add(this.btn_ucakekle);
            this.tabPage1.Controls.Add(this.tb_kapasite);
            this.tabPage1.Controls.Add(this.tb_seri);
            this.tabPage1.Controls.Add(this.lb_kapasite);
            this.tabPage1.Controls.Add(this.lb_seri);
            this.tabPage1.Controls.Add(this.tb_marka);
            this.tabPage1.Controls.Add(this.lb_marka);
            this.tabPage1.Controls.Add(this.lb_model);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UcakForm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(313, 121);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(226, 22);
            this.tb_model.TabIndex = 20;
            // 
            // lb_baslık
            // 
            this.lb_baslık.AutoSize = true;
            this.lb_baslık.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_baslık.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_baslık.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_baslık.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_baslık.Location = new System.Drawing.Point(211, 38);
            this.lb_baslık.Name = "lb_baslık";
            this.lb_baslık.Size = new System.Drawing.Size(331, 27);
            this.lb_baslık.TabIndex = 19;
            this.lb_baslık.Text = "Uçak  Rezervasyon Uygulaması";
            // 
            // btn_ucakekle
            // 
            this.btn_ucakekle.Location = new System.Drawing.Point(448, 312);
            this.btn_ucakekle.Name = "btn_ucakekle";
            this.btn_ucakekle.Size = new System.Drawing.Size(91, 23);
            this.btn_ucakekle.TabIndex = 18;
            this.btn_ucakekle.Text = "Uçak Ekle";
            this.btn_ucakekle.UseVisualStyleBackColor = true;
            this.btn_ucakekle.Click += new System.EventHandler(this.btn_ucakekle_Click);
            // 
            // tb_kapasite
            // 
            this.tb_kapasite.Location = new System.Drawing.Point(313, 257);
            this.tb_kapasite.Name = "tb_kapasite";
            this.tb_kapasite.Size = new System.Drawing.Size(226, 22);
            this.tb_kapasite.TabIndex = 17;
            // 
            // tb_seri
            // 
            this.tb_seri.Location = new System.Drawing.Point(313, 207);
            this.tb_seri.Name = "tb_seri";
            this.tb_seri.Size = new System.Drawing.Size(226, 22);
            this.tb_seri.TabIndex = 16;
            // 
            // lb_kapasite
            // 
            this.lb_kapasite.AutoSize = true;
            this.lb_kapasite.Location = new System.Drawing.Point(208, 257);
            this.lb_kapasite.Name = "lb_kapasite";
            this.lb_kapasite.Size = new System.Drawing.Size(99, 16);
            this.lb_kapasite.TabIndex = 15;
            this.lb_kapasite.Text = "Koltuk Kapasite";
            // 
            // lb_seri
            // 
            this.lb_seri.AutoSize = true;
            this.lb_seri.Location = new System.Drawing.Point(208, 207);
            this.lb_seri.Name = "lb_seri";
            this.lb_seri.Size = new System.Drawing.Size(52, 16);
            this.lb_seri.TabIndex = 14;
            this.lb_seri.Text = "Seri No";
            // 
            // tb_marka
            // 
            this.tb_marka.Location = new System.Drawing.Point(313, 163);
            this.tb_marka.Name = "tb_marka";
            this.tb_marka.Size = new System.Drawing.Size(226, 22);
            this.tb_marka.TabIndex = 13;
            // 
            // lb_marka
            // 
            this.lb_marka.AutoSize = true;
            this.lb_marka.Location = new System.Drawing.Point(208, 163);
            this.lb_marka.Name = "lb_marka";
            this.lb_marka.Size = new System.Drawing.Size(80, 16);
            this.lb_marka.TabIndex = 12;
            this.lb_marka.Text = "Uçak Marka";
            // 
            // lb_model
            // 
            this.lb_model.AutoSize = true;
            this.lb_model.Location = new System.Drawing.Point(208, 121);
            this.lb_model.Name = "lb_model";
            this.lb_model.Size = new System.Drawing.Size(80, 16);
            this.lb_model.TabIndex = 11;
            this.lb_model.Text = "Uçak Model";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_lokasyon);
            this.tabPage2.Controls.Add(this.cb_havaalani);
            this.tabPage2.Controls.Add(this.cb_sehir);
            this.tabPage2.Controls.Add(this.cb_ulke);
            this.tabPage2.Controls.Add(this.lb_Havaalani);
            this.tabPage2.Controls.Add(this.lb_sehir);
            this.tabPage2.Controls.Add(this.lb_ulke);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lokasyon";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_lokasyon
            // 
            this.dgv_lokasyon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lokasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lokasyon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Ulke,
            this.Sehir,
            this.Havaalani,
            this.Tarih,
            this.Saat,
            this.Sec});
            this.dgv_lokasyon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_lokasyon.Location = new System.Drawing.Point(3, 219);
            this.dgv_lokasyon.Name = "dgv_lokasyon";
            this.dgv_lokasyon.RowHeadersWidth = 51;
            this.dgv_lokasyon.RowTemplate.Height = 24;
            this.dgv_lokasyon.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_lokasyon.Size = new System.Drawing.Size(786, 199);
            this.dgv_lokasyon.TabIndex = 10;
            this.dgv_lokasyon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lokasyon_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "İd";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // Ulke
            // 
            this.Ulke.HeaderText = "Ülke";
            this.Ulke.MinimumWidth = 6;
            this.Ulke.Name = "Ulke";
            // 
            // Sehir
            // 
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.MinimumWidth = 6;
            this.Sehir.Name = "Sehir";
            // 
            // Havaalani
            // 
            this.Havaalani.HeaderText = "Havaalanı";
            this.Havaalani.MinimumWidth = 6;
            this.Havaalani.Name = "Havaalani";
            this.Havaalani.ReadOnly = true;
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // Saat
            // 
            this.Saat.HeaderText = "Saat";
            this.Saat.MinimumWidth = 6;
            this.Saat.Name = "Saat";
            this.Saat.ReadOnly = true;
            // 
            // Sec
            // 
            this.Sec.HeaderText = "Seç";
            this.Sec.MinimumWidth = 6;
            this.Sec.Name = "Sec";
            this.Sec.ReadOnly = true;
            // 
            // cb_havaalani
            // 
            this.cb_havaalani.FormattingEnabled = true;
            this.cb_havaalani.Location = new System.Drawing.Point(79, 74);
            this.cb_havaalani.Name = "cb_havaalani";
            this.cb_havaalani.Size = new System.Drawing.Size(182, 24);
            this.cb_havaalani.TabIndex = 9;
            this.cb_havaalani.SelectedIndexChanged += new System.EventHandler(this.cb_havaalani_SelectedIndexChanged);
            // 
            // cb_sehir
            // 
            this.cb_sehir.FormattingEnabled = true;
            this.cb_sehir.Location = new System.Drawing.Point(371, 23);
            this.cb_sehir.Name = "cb_sehir";
            this.cb_sehir.Size = new System.Drawing.Size(182, 24);
            this.cb_sehir.TabIndex = 8;
            this.cb_sehir.SelectedIndexChanged += new System.EventHandler(this.cb_sehir_SelectedIndexChanged);
            // 
            // cb_ulke
            // 
            this.cb_ulke.FormattingEnabled = true;
            this.cb_ulke.Location = new System.Drawing.Point(79, 23);
            this.cb_ulke.Name = "cb_ulke";
            this.cb_ulke.Size = new System.Drawing.Size(182, 24);
            this.cb_ulke.TabIndex = 7;
            this.cb_ulke.SelectedIndexChanged += new System.EventHandler(this.cb_ulke_SelectedIndexChanged);
            // 
            // lb_Havaalani
            // 
            this.lb_Havaalani.AutoSize = true;
            this.lb_Havaalani.Location = new System.Drawing.Point(4, 77);
            this.lb_Havaalani.Name = "lb_Havaalani";
            this.lb_Havaalani.Size = new System.Drawing.Size(69, 16);
            this.lb_Havaalani.TabIndex = 2;
            this.lb_Havaalani.Text = "Havaalanı";
            // 
            // lb_sehir
            // 
            this.lb_sehir.AutoSize = true;
            this.lb_sehir.Location = new System.Drawing.Point(304, 31);
            this.lb_sehir.Name = "lb_sehir";
            this.lb_sehir.Size = new System.Drawing.Size(38, 16);
            this.lb_sehir.TabIndex = 1;
            this.lb_sehir.Text = "Şehir";
            // 
            // lb_ulke
            // 
            this.lb_ulke.AutoSize = true;
            this.lb_ulke.Location = new System.Drawing.Point(20, 23);
            this.lb_ulke.Name = "lb_ulke";
            this.lb_ulke.Size = new System.Drawing.Size(35, 16);
            this.lb_ulke.TabIndex = 0;
            this.lb_ulke.Text = "Ülke";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_koltukOnayla);
            this.tabPage3.Controls.Add(this.lb_secilenKoltuk);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rezervasyon";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lb_secilenKoltuk
            // 
            this.lb_secilenKoltuk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_secilenKoltuk.Location = new System.Drawing.Point(3, 356);
            this.lb_secilenKoltuk.Name = "lb_secilenKoltuk";
            this.lb_secilenKoltuk.Size = new System.Drawing.Size(786, 62);
            this.lb_secilenKoltuk.TabIndex = 6;
            this.lb_secilenKoltuk.Text = "Seçilen Koltuk : ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgv_ucakgoruntu);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Uçak Görüntüle ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_ucakgoruntu
            // 
            this.dgv_ucakgoruntu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ucakgoruntu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ucakgoruntu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıd,
            this.Model,
            this.Marka,
            this.SeriNo,
            this.KoltukKapasite});
            this.dgv_ucakgoruntu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ucakgoruntu.Location = new System.Drawing.Point(3, 3);
            this.dgv_ucakgoruntu.Name = "dgv_ucakgoruntu";
            this.dgv_ucakgoruntu.RowHeadersWidth = 51;
            this.dgv_ucakgoruntu.RowTemplate.Height = 24;
            this.dgv_ucakgoruntu.Size = new System.Drawing.Size(786, 415);
            this.dgv_ucakgoruntu.TabIndex = 0;
            // 
            // ıd
            // 
            this.ıd.HeaderText = "İd";
            this.ıd.MinimumWidth = 6;
            this.ıd.Name = "ıd";
            this.ıd.ReadOnly = true;
            this.ıd.Visible = false;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Marka
            // 
            this.Marka.HeaderText = "Marka";
            this.Marka.MinimumWidth = 6;
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            // 
            // SeriNo
            // 
            this.SeriNo.HeaderText = "Seri No";
            this.SeriNo.MinimumWidth = 6;
            this.SeriNo.Name = "SeriNo";
            this.SeriNo.ReadOnly = true;
            // 
            // KoltukKapasite
            // 
            this.KoltukKapasite.HeaderText = "Koltuk Kapasite";
            this.KoltukKapasite.MinimumWidth = 6;
            this.KoltukKapasite.Name = "KoltukKapasite";
            this.KoltukKapasite.ReadOnly = true;
            // 
            // btn_koltukOnayla
            // 
            this.btn_koltukOnayla.Location = new System.Drawing.Point(636, 102);
            this.btn_koltukOnayla.Name = "btn_koltukOnayla";
            this.btn_koltukOnayla.Size = new System.Drawing.Size(132, 23);
            this.btn_koltukOnayla.TabIndex = 7;
            this.btn_koltukOnayla.Text = "Koltuk Onayla";
            this.btn_koltukOnayla.UseVisualStyleBackColor = true;
            this.btn_koltukOnayla.Click += new System.EventHandler(this.btn_koltukOnayla_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Uçak Bilet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lokasyon)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ucakgoruntu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label lb_baslık;
        private System.Windows.Forms.Button btn_ucakekle;
        private System.Windows.Forms.TextBox tb_kapasite;
        private System.Windows.Forms.TextBox tb_seri;
        private System.Windows.Forms.Label lb_kapasite;
        private System.Windows.Forms.Label lb_seri;
        private System.Windows.Forms.TextBox tb_marka;
        private System.Windows.Forms.Label lb_marka;
        private System.Windows.Forms.Label lb_model;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lb_Havaalani;
        private System.Windows.Forms.Label lb_sehir;
        private System.Windows.Forms.Label lb_ulke;
        private System.Windows.Forms.ComboBox cb_havaalani;
        private System.Windows.Forms.ComboBox cb_sehir;
        private System.Windows.Forms.ComboBox cb_ulke;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgv_ucakgoruntu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoltukKapasite;
        private System.Windows.Forms.DataGridView dgv_lokasyon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Havaalani;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewButtonColumn Sec;
        private System.Windows.Forms.Label lb_secilenKoltuk;
        private System.Windows.Forms.Button btn_koltukOnayla;
    }
}

