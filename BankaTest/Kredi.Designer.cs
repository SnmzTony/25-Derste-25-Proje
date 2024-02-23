namespace BankaTest
{
    partial class Kredi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbKrediTutar = new System.Windows.Forms.ComboBox();
            this.CmbVade = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTaksitTutar = new System.Windows.Forms.Label();
            this.LblGeriOdeme = new System.Windows.Forms.Label();
            this.LblFaizOran = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kredi Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vade:";
            // 
            // CmbKrediTutar
            // 
            this.CmbKrediTutar.FormattingEnabled = true;
            this.CmbKrediTutar.Items.AddRange(new object[] {
            "50.000",
            "75.000",
            "100.000",
            "125.000",
            "150.000",
            "175.000",
            "200.000"});
            this.CmbKrediTutar.Location = new System.Drawing.Point(149, 64);
            this.CmbKrediTutar.Name = "CmbKrediTutar";
            this.CmbKrediTutar.Size = new System.Drawing.Size(205, 31);
            this.CmbKrediTutar.TabIndex = 2;
            // 
            // CmbVade
            // 
            this.CmbVade.FormattingEnabled = true;
            this.CmbVade.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "16",
            "24",
            "36"});
            this.CmbVade.Location = new System.Drawing.Point(149, 119);
            this.CmbVade.Name = "CmbVade";
            this.CmbVade.Size = new System.Drawing.Size(205, 31);
            this.CmbVade.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(183, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taksit Tutarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toplam Geri Ödeme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Faiz Oranı:";
            // 
            // LblTaksitTutar
            // 
            this.LblTaksitTutar.AutoSize = true;
            this.LblTaksitTutar.Location = new System.Drawing.Point(218, 285);
            this.LblTaksitTutar.Name = "LblTaksitTutar";
            this.LblTaksitTutar.Size = new System.Drawing.Size(34, 23);
            this.LblTaksitTutar.TabIndex = 8;
            this.LblTaksitTutar.Text = "00";
            // 
            // LblGeriOdeme
            // 
            this.LblGeriOdeme.AutoSize = true;
            this.LblGeriOdeme.Location = new System.Drawing.Point(228, 326);
            this.LblGeriOdeme.Name = "LblGeriOdeme";
            this.LblGeriOdeme.Size = new System.Drawing.Size(34, 23);
            this.LblGeriOdeme.TabIndex = 9;
            this.LblGeriOdeme.Text = "00";
            // 
            // LblFaizOran
            // 
            this.LblFaizOran.AutoSize = true;
            this.LblFaizOran.Location = new System.Drawing.Point(228, 369);
            this.LblFaizOran.Name = "LblFaizOran";
            this.LblFaizOran.Size = new System.Drawing.Size(34, 23);
            this.LblFaizOran.TabIndex = 10;
            this.LblFaizOran.Text = "00";
            // 
            // Kredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 439);
            this.Controls.Add(this.LblFaizOran);
            this.Controls.Add(this.LblGeriOdeme);
            this.Controls.Add(this.LblTaksitTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbVade);
            this.Controls.Add(this.CmbKrediTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Kredi";
            this.Text = "Kredi";
            this.Load += new System.EventHandler(this.Kredi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbKrediTutar;
        private System.Windows.Forms.ComboBox CmbVade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTaksitTutar;
        private System.Windows.Forms.Label LblGeriOdeme;
        private System.Windows.Forms.Label LblFaizOran;
    }
}