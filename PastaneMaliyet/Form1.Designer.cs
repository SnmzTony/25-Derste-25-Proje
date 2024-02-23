namespace PastaneMaliyet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MalzemeID = new System.Windows.Forms.Label();
            this.BtnGuncelleMalzeme = new System.Windows.Forms.Button();
            this.BtnEkleMalzeme = new System.Windows.Forms.Button();
            this.TxtMalzemeNot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMalzemeFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMalzemeStok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMalzemeAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGuncelleUrun = new System.Windows.Forms.Button();
            this.TxtUrunSatis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUrunMaliyet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUrunStok = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbUrunOlustur = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtUrunOlusturMaliyet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUrunOlusturMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MalzemeID);
            this.groupBox1.Controls.Add(this.BtnGuncelleMalzeme);
            this.groupBox1.Controls.Add(this.BtnEkleMalzeme);
            this.groupBox1.Controls.Add(this.TxtMalzemeNot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtMalzemeFiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMalzemeStok);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMalzemeAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Girişi";
            // 
            // MalzemeID
            // 
            this.MalzemeID.AutoSize = true;
            this.MalzemeID.Location = new System.Drawing.Point(51, 198);
            this.MalzemeID.Name = "MalzemeID";
            this.MalzemeID.Size = new System.Drawing.Size(58, 18);
            this.MalzemeID.TabIndex = 10;
            this.MalzemeID.Text = "label13";
            this.MalzemeID.Visible = false;
            // 
            // BtnGuncelleMalzeme
            // 
            this.BtnGuncelleMalzeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnGuncelleMalzeme.FlatAppearance.BorderSize = 0;
            this.BtnGuncelleMalzeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelleMalzeme.Location = new System.Drawing.Point(21, 161);
            this.BtnGuncelleMalzeme.Name = "BtnGuncelleMalzeme";
            this.BtnGuncelleMalzeme.Size = new System.Drawing.Size(126, 34);
            this.BtnGuncelleMalzeme.TabIndex = 9;
            this.BtnGuncelleMalzeme.Text = "Güncelle";
            this.BtnGuncelleMalzeme.UseVisualStyleBackColor = false;
            this.BtnGuncelleMalzeme.Click += new System.EventHandler(this.BtnGuncelleMalzeme_Click);
            // 
            // BtnEkleMalzeme
            // 
            this.BtnEkleMalzeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.BtnEkleMalzeme.FlatAppearance.BorderSize = 0;
            this.BtnEkleMalzeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkleMalzeme.Location = new System.Drawing.Point(153, 161);
            this.BtnEkleMalzeme.Name = "BtnEkleMalzeme";
            this.BtnEkleMalzeme.Size = new System.Drawing.Size(126, 34);
            this.BtnEkleMalzeme.TabIndex = 8;
            this.BtnEkleMalzeme.Text = "Ekle";
            this.BtnEkleMalzeme.UseVisualStyleBackColor = false;
            this.BtnEkleMalzeme.Click += new System.EventHandler(this.BtnEkleMalzeme_Click);
            // 
            // TxtMalzemeNot
            // 
            this.TxtMalzemeNot.Location = new System.Drawing.Point(92, 129);
            this.TxtMalzemeNot.Name = "TxtMalzemeNot";
            this.TxtMalzemeNot.Size = new System.Drawing.Size(187, 26);
            this.TxtMalzemeNot.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOTLAR:";
            // 
            // TxtMalzemeFiyat
            // 
            this.TxtMalzemeFiyat.Location = new System.Drawing.Point(92, 97);
            this.TxtMalzemeFiyat.Name = "TxtMalzemeFiyat";
            this.TxtMalzemeFiyat.Size = new System.Drawing.Size(187, 26);
            this.TxtMalzemeFiyat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(23, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "FİYAT:";
            // 
            // TxtMalzemeStok
            // 
            this.TxtMalzemeStok.Location = new System.Drawing.Point(92, 65);
            this.TxtMalzemeStok.Name = "TxtMalzemeStok";
            this.TxtMalzemeStok.Size = new System.Drawing.Size(187, 26);
            this.TxtMalzemeStok.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "STOK:";
            // 
            // TxtMalzemeAd
            // 
            this.TxtMalzemeAd.Location = new System.Drawing.Point(92, 33);
            this.TxtMalzemeAd.Name = "TxtMalzemeAd";
            this.TxtMalzemeAd.Size = new System.Drawing.Size(187, 26);
            this.TxtMalzemeAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGuncelleUrun);
            this.groupBox2.Controls.Add(this.TxtUrunSatis);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtUrunMaliyet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtUrunStok);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtUrunAd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Güncelle";
            // 
            // BtnGuncelleUrun
            // 
            this.BtnGuncelleUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnGuncelleUrun.FlatAppearance.BorderSize = 0;
            this.BtnGuncelleUrun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelleUrun.Location = new System.Drawing.Point(92, 161);
            this.BtnGuncelleUrun.Name = "BtnGuncelleUrun";
            this.BtnGuncelleUrun.Size = new System.Drawing.Size(187, 34);
            this.BtnGuncelleUrun.TabIndex = 9;
            this.BtnGuncelleUrun.Text = "Güncelle";
            this.BtnGuncelleUrun.UseVisualStyleBackColor = false;
            this.BtnGuncelleUrun.Click += new System.EventHandler(this.BtnGuncelleUrun_Click);
            // 
            // TxtUrunSatis
            // 
            this.TxtUrunSatis.Location = new System.Drawing.Point(92, 129);
            this.TxtUrunSatis.Name = "TxtUrunSatis";
            this.TxtUrunSatis.Size = new System.Drawing.Size(187, 26);
            this.TxtUrunSatis.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(26, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "SATIŞ:";
            // 
            // TxtUrunMaliyet
            // 
            this.TxtUrunMaliyet.Location = new System.Drawing.Point(92, 97);
            this.TxtUrunMaliyet.Name = "TxtUrunMaliyet";
            this.TxtUrunMaliyet.ReadOnly = true;
            this.TxtUrunMaliyet.Size = new System.Drawing.Size(187, 26);
            this.TxtUrunMaliyet.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "MALİYET:";
            // 
            // TxtUrunStok
            // 
            this.TxtUrunStok.Location = new System.Drawing.Point(92, 65);
            this.TxtUrunStok.Name = "TxtUrunStok";
            this.TxtUrunStok.ReadOnly = true;
            this.TxtUrunStok.Size = new System.Drawing.Size(187, 26);
            this.TxtUrunStok.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(30, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "STOK:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(92, 33);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.ReadOnly = true;
            this.TxtUrunAd.Size = new System.Drawing.Size(187, 26);
            this.TxtUrunAd.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(51, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "AD:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbUrunOlustur);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.TxtUrunOlusturMaliyet);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtUrunOlusturMiktar);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(632, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 224);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Oluştur";
            // 
            // CmbUrunOlustur
            // 
            this.CmbUrunOlustur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUrunOlustur.FormattingEnabled = true;
            this.CmbUrunOlustur.Location = new System.Drawing.Point(95, 33);
            this.CmbUrunOlustur.Name = "CmbUrunOlustur";
            this.CmbUrunOlustur.Size = new System.Drawing.Size(187, 26);
            this.CmbUrunOlustur.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(165, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Üret";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtUrunOlusturMaliyet
            // 
            this.TxtUrunOlusturMaliyet.Location = new System.Drawing.Point(95, 100);
            this.TxtUrunOlusturMaliyet.Name = "TxtUrunOlusturMaliyet";
            this.TxtUrunOlusturMaliyet.ReadOnly = true;
            this.TxtUrunOlusturMaliyet.Size = new System.Drawing.Size(187, 26);
            this.TxtUrunOlusturMaliyet.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(6, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "MALİYET:";
            // 
            // TxtUrunOlusturMiktar
            // 
            this.TxtUrunOlusturMiktar.Location = new System.Drawing.Point(95, 68);
            this.TxtUrunOlusturMiktar.Name = "TxtUrunOlusturMiktar";
            this.TxtUrunOlusturMiktar.Size = new System.Drawing.Size(187, 26);
            this.TxtUrunOlusturMiktar.TabIndex = 5;
            this.TxtUrunOlusturMiktar.TextChanged += new System.EventHandler(this.TxtUrunOlusturMiktar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(18, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "MİKTAR:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(26, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "ÜRÜN:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(929, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 192);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İşlemler";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.OrangeRed;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(31, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 34);
            this.button5.TabIndex = 13;
            this.button5.Text = "Hareket";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(31, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 34);
            this.button4.TabIndex = 12;
            this.button4.Text = "Kasa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(31, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Malzeme Listesi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(31, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ürün Listesi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Location = new System.Drawing.Point(12, 242);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(911, 192);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Depo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(905, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(929, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 224);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eklenen Ürünler";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(3, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 199);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(183)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(1226, 437);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MRT PASTANE | ÜRETİM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEkleMalzeme;
        private System.Windows.Forms.TextBox TxtMalzemeNot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMalzemeFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMalzemeStok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMalzemeAd;
        private System.Windows.Forms.Button BtnGuncelleMalzeme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGuncelleUrun;
        private System.Windows.Forms.TextBox TxtUrunSatis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUrunMaliyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUrunStok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmbUrunOlustur;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtUrunOlusturMaliyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUrunOlusturMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label MalzemeID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

