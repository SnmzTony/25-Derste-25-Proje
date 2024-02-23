namespace ETUTOKUL
{
    partial class Mesaj
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
            this.CmbKisi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDurum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.Mesajlarım = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblOkunmamisMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbKisi
            // 
            this.CmbKisi.FormattingEnabled = true;
            this.CmbKisi.Location = new System.Drawing.Point(57, 26);
            this.CmbKisi.Name = "CmbKisi";
            this.CmbKisi.Size = new System.Drawing.Size(212, 26);
            this.CmbKisi.TabIndex = 0;
            this.CmbKisi.SelectedIndexChanged += new System.EventHandler(this.CmbKisi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kişi:";
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Location = new System.Drawing.Point(136, 64);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(50, 18);
            this.LblDurum.TabIndex = 2;
            this.LblDurum.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mesaj Gönder:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 259);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(415, 38);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(135)))), ((int)(((byte)(113)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(84, 303);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(264, 25);
            this.button6.TabIndex = 13;
            this.button6.Text = "Gönder";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Mesajlarım
            // 
            this.Mesajlarım.FormattingEnabled = true;
            this.Mesajlarım.ItemHeight = 18;
            this.Mesajlarım.Location = new System.Drawing.Point(424, 16);
            this.Mesajlarım.Name = "Mesajlarım";
            this.Mesajlarım.Size = new System.Drawing.Size(397, 292);
            this.Mesajlarım.TabIndex = 15;
            this.Mesajlarım.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mesajlarım_MouseClick);
            this.Mesajlarım.SelectedIndexChanged += new System.EventHandler(this.Mesajlarım_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Okunmamış Mesajın:";
            // 
            // LblOkunmamisMesaj
            // 
            this.LblOkunmamisMesaj.AutoSize = true;
            this.LblOkunmamisMesaj.Location = new System.Drawing.Point(171, 114);
            this.LblOkunmamisMesaj.Name = "LblOkunmamisMesaj";
            this.LblOkunmamisMesaj.Size = new System.Drawing.Size(18, 18);
            this.LblOkunmamisMesaj.TabIndex = 19;
            this.LblOkunmamisMesaj.Text = "0";
            // 
            // Mesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 338);
            this.Controls.Add(this.LblOkunmamisMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mesajlarım);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbKisi);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mesaj";
            this.Text = "Mesaj";
            this.Load += new System.EventHandler(this.Mesaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbKisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox Mesajlarım;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblOkunmamisMesaj;
    }
}