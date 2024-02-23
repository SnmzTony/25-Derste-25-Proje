namespace Petrol_Istasyonu
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
            this.LblGaz = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblPowerDizel = new System.Windows.Forms.Label();
            this.LblEuroDizel = new System.Windows.Forms.Label();
            this.Lbl102Oktan = new System.Windows.Forms.Label();
            this.Lbl95Oktan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.LblGazMiktar = new System.Windows.Forms.Label();
            this.LblPowerDizelMiktar = new System.Windows.Forms.Label();
            this.LblEuroDizelMiktar = new System.Windows.Forms.Label();
            this.Lbl102OktanMiktar = new System.Windows.Forms.Label();
            this.Lbl95OktanMiktar = new System.Windows.Forms.Label();
            this.progressBarGaz = new System.Windows.Forms.ProgressBar();
            this.progressBarPower = new System.Windows.Forms.ProgressBar();
            this.progressBarEuro = new System.Windows.Forms.ProgressBar();
            this.progressBar102 = new System.Windows.Forms.ProgressBar();
            this.progressBar95 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblKasa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnPompa = new System.Windows.Forms.Button();
            this.BtnZRapor = new System.Windows.Forms.Button();
            this.BtnDepo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblGaz);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.LblPowerDizel);
            this.groupBox1.Controls.Add(this.LblEuroDizel);
            this.groupBox1.Controls.Add(this.Lbl102Oktan);
            this.groupBox1.Controls.Add(this.Lbl95Oktan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LblGaz
            // 
            this.LblGaz.AutoSize = true;
            this.LblGaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LblGaz.Location = new System.Drawing.Point(219, 261);
            this.LblGaz.Name = "LblGaz";
            this.LblGaz.Size = new System.Drawing.Size(28, 18);
            this.LblGaz.TabIndex = 11;
            this.LblGaz.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(123, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Gaz:";
            // 
            // LblPowerDizel
            // 
            this.LblPowerDizel.AutoSize = true;
            this.LblPowerDizel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LblPowerDizel.Location = new System.Drawing.Point(219, 210);
            this.LblPowerDizel.Name = "LblPowerDizel";
            this.LblPowerDizel.Size = new System.Drawing.Size(28, 18);
            this.LblPowerDizel.TabIndex = 9;
            this.LblPowerDizel.Text = "00";
            // 
            // LblEuroDizel
            // 
            this.LblEuroDizel.AutoSize = true;
            this.LblEuroDizel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LblEuroDizel.Location = new System.Drawing.Point(219, 162);
            this.LblEuroDizel.Name = "LblEuroDizel";
            this.LblEuroDizel.Size = new System.Drawing.Size(28, 18);
            this.LblEuroDizel.TabIndex = 8;
            this.LblEuroDizel.Text = "00";
            // 
            // Lbl102Oktan
            // 
            this.Lbl102Oktan.AutoSize = true;
            this.Lbl102Oktan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Lbl102Oktan.Location = new System.Drawing.Point(219, 112);
            this.Lbl102Oktan.Name = "Lbl102Oktan";
            this.Lbl102Oktan.Size = new System.Drawing.Size(28, 18);
            this.Lbl102Oktan.TabIndex = 7;
            this.Lbl102Oktan.Text = "00";
            // 
            // Lbl95Oktan
            // 
            this.Lbl95Oktan.AutoSize = true;
            this.Lbl95Oktan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Lbl95Oktan.Location = new System.Drawing.Point(219, 69);
            this.Lbl95Oktan.Name = "Lbl95Oktan";
            this.Lbl95Oktan.Size = new System.Drawing.Size(28, 18);
            this.Lbl95Oktan.TabIndex = 6;
            this.Lbl95Oktan.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(58, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Power Dizel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(69, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Euro Dizel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Benzin 102 Oktan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Benzin 95 Oktan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(167, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Litre Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yakıt Türü";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.LblGazMiktar);
            this.groupBox2.Controls.Add(this.LblPowerDizelMiktar);
            this.groupBox2.Controls.Add(this.LblEuroDizelMiktar);
            this.groupBox2.Controls.Add(this.Lbl102OktanMiktar);
            this.groupBox2.Controls.Add(this.Lbl95OktanMiktar);
            this.groupBox2.Controls.Add(this.progressBarGaz);
            this.groupBox2.Controls.Add(this.progressBarPower);
            this.groupBox2.Controls.Add(this.progressBarEuro);
            this.groupBox2.Controls.Add(this.progressBar102);
            this.groupBox2.Controls.Add(this.progressBar95);
            this.groupBox2.Location = new System.Drawing.Point(318, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label18.Location = new System.Drawing.Point(190, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(207, 23);
            this.label18.TabIndex = 12;
            this.label18.Text = "Depo Petrol Miktarı";
            // 
            // LblGazMiktar
            // 
            this.LblGazMiktar.AutoSize = true;
            this.LblGazMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LblGazMiktar.Location = new System.Drawing.Point(522, 252);
            this.LblGazMiktar.Name = "LblGazMiktar";
            this.LblGazMiktar.Size = new System.Drawing.Size(28, 18);
            this.LblGazMiktar.TabIndex = 11;
            this.LblGazMiktar.Text = "00";
            // 
            // LblPowerDizelMiktar
            // 
            this.LblPowerDizelMiktar.AutoSize = true;
            this.LblPowerDizelMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LblPowerDizelMiktar.Location = new System.Drawing.Point(522, 203);
            this.LblPowerDizelMiktar.Name = "LblPowerDizelMiktar";
            this.LblPowerDizelMiktar.Size = new System.Drawing.Size(28, 18);
            this.LblPowerDizelMiktar.TabIndex = 10;
            this.LblPowerDizelMiktar.Text = "00";
            // 
            // LblEuroDizelMiktar
            // 
            this.LblEuroDizelMiktar.AutoSize = true;
            this.LblEuroDizelMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LblEuroDizelMiktar.Location = new System.Drawing.Point(522, 154);
            this.LblEuroDizelMiktar.Name = "LblEuroDizelMiktar";
            this.LblEuroDizelMiktar.Size = new System.Drawing.Size(28, 18);
            this.LblEuroDizelMiktar.TabIndex = 9;
            this.LblEuroDizelMiktar.Text = "00";
            // 
            // Lbl102OktanMiktar
            // 
            this.Lbl102OktanMiktar.AutoSize = true;
            this.Lbl102OktanMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Lbl102OktanMiktar.Location = new System.Drawing.Point(522, 107);
            this.Lbl102OktanMiktar.Name = "Lbl102OktanMiktar";
            this.Lbl102OktanMiktar.Size = new System.Drawing.Size(28, 18);
            this.Lbl102OktanMiktar.TabIndex = 8;
            this.Lbl102OktanMiktar.Text = "00";
            // 
            // Lbl95OktanMiktar
            // 
            this.Lbl95OktanMiktar.AutoSize = true;
            this.Lbl95OktanMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Lbl95OktanMiktar.Location = new System.Drawing.Point(522, 60);
            this.Lbl95OktanMiktar.Name = "Lbl95OktanMiktar";
            this.Lbl95OktanMiktar.Size = new System.Drawing.Size(28, 18);
            this.Lbl95OktanMiktar.TabIndex = 7;
            this.Lbl95OktanMiktar.Text = "00";
            // 
            // progressBarGaz
            // 
            this.progressBarGaz.Location = new System.Drawing.Point(23, 249);
            this.progressBarGaz.Maximum = 10000;
            this.progressBarGaz.Name = "progressBarGaz";
            this.progressBarGaz.Size = new System.Drawing.Size(485, 30);
            this.progressBarGaz.TabIndex = 4;
            // 
            // progressBarPower
            // 
            this.progressBarPower.Location = new System.Drawing.Point(23, 198);
            this.progressBarPower.Maximum = 10000;
            this.progressBarPower.Name = "progressBarPower";
            this.progressBarPower.Size = new System.Drawing.Size(485, 30);
            this.progressBarPower.TabIndex = 3;
            // 
            // progressBarEuro
            // 
            this.progressBarEuro.Location = new System.Drawing.Point(23, 150);
            this.progressBarEuro.Maximum = 10000;
            this.progressBarEuro.Name = "progressBarEuro";
            this.progressBarEuro.Size = new System.Drawing.Size(485, 30);
            this.progressBarEuro.TabIndex = 2;
            // 
            // progressBar102
            // 
            this.progressBar102.Location = new System.Drawing.Point(23, 102);
            this.progressBar102.Maximum = 10000;
            this.progressBar102.Name = "progressBar102";
            this.progressBar102.Size = new System.Drawing.Size(485, 30);
            this.progressBar102.TabIndex = 1;
            // 
            // progressBar95
            // 
            this.progressBar95.Location = new System.Drawing.Point(23, 57);
            this.progressBar95.Maximum = 10000;
            this.progressBar95.Name = "progressBar95";
            this.progressBar95.Size = new System.Drawing.Size(485, 30);
            this.progressBar95.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblKasa);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(8, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // LblKasa
            // 
            this.LblKasa.AutoSize = true;
            this.LblKasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LblKasa.Location = new System.Drawing.Point(108, 63);
            this.LblKasa.Name = "LblKasa";
            this.LblKasa.Size = new System.Drawing.Size(42, 18);
            this.LblKasa.TabIndex = 7;
            this.LblKasa.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(29, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "KASA:";
            // 
            // BtnPompa
            // 
            this.BtnPompa.BackColor = System.Drawing.Color.Lime;
            this.BtnPompa.FlatAppearance.BorderSize = 0;
            this.BtnPompa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPompa.Location = new System.Drawing.Point(341, 349);
            this.BtnPompa.Name = "BtnPompa";
            this.BtnPompa.Size = new System.Drawing.Size(179, 50);
            this.BtnPompa.TabIndex = 3;
            this.BtnPompa.Text = "Pompa";
            this.BtnPompa.UseVisualStyleBackColor = false;
            this.BtnPompa.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnZRapor
            // 
            this.BtnZRapor.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnZRapor.FlatAppearance.BorderSize = 0;
            this.BtnZRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZRapor.Location = new System.Drawing.Point(549, 349);
            this.BtnZRapor.Name = "BtnZRapor";
            this.BtnZRapor.Size = new System.Drawing.Size(179, 50);
            this.BtnZRapor.TabIndex = 4;
            this.BtnZRapor.Text = "Z Raporu Oluştur";
            this.BtnZRapor.UseVisualStyleBackColor = false;
            this.BtnZRapor.Click += new System.EventHandler(this.BtnZRapor_Click);
            // 
            // BtnDepo
            // 
            this.BtnDepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(216)))));
            this.BtnDepo.FlatAppearance.BorderSize = 0;
            this.BtnDepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDepo.Location = new System.Drawing.Point(747, 349);
            this.BtnDepo.Name = "BtnDepo";
            this.BtnDepo.Size = new System.Drawing.Size(179, 50);
            this.BtnDepo.TabIndex = 5;
            this.BtnDepo.Text = "Depo";
            this.BtnDepo.UseVisualStyleBackColor = false;
            this.BtnDepo.Click += new System.EventHandler(this.BtnDepo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.BtnDepo);
            this.Controls.Add(this.BtnZRapor);
            this.Controls.Add(this.BtnPompa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MRT Petrol | Yönetim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblGaz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblPowerDizel;
        private System.Windows.Forms.Label LblEuroDizel;
        private System.Windows.Forms.Label Lbl102Oktan;
        private System.Windows.Forms.Label Lbl95Oktan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar95;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LblGazMiktar;
        private System.Windows.Forms.Label LblPowerDizelMiktar;
        private System.Windows.Forms.Label LblEuroDizelMiktar;
        private System.Windows.Forms.Label Lbl102OktanMiktar;
        private System.Windows.Forms.Label Lbl95OktanMiktar;
        private System.Windows.Forms.ProgressBar progressBarGaz;
        private System.Windows.Forms.ProgressBar progressBarPower;
        private System.Windows.Forms.ProgressBar progressBarEuro;
        private System.Windows.Forms.ProgressBar progressBar102;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblKasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnPompa;
        private System.Windows.Forms.Button BtnZRapor;
        private System.Windows.Forms.Button BtnDepo;
    }
}

