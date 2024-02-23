namespace Rezervasyon
{
    partial class YonetimMesajlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetimMesajlar));
            this.Müşteri = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Mesaj = new System.Windows.Forms.ListBox();
            this.button18 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Müşteri
            // 
            this.Müşteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.Müşteri.FormattingEnabled = true;
            this.Müşteri.ItemHeight = 18;
            this.Müşteri.Location = new System.Drawing.Point(2, 12);
            this.Müşteri.Name = "Müşteri";
            this.Müşteri.Size = new System.Drawing.Size(138, 364);
            this.Müşteri.TabIndex = 0;
//            this.Müşteri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Müşteri_MouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(146, 296);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(457, 42);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Mesaj
            // 
            this.Mesaj.BackColor = System.Drawing.Color.Beige;
            this.Mesaj.FormattingEnabled = true;
            this.Mesaj.ItemHeight = 18;
            this.Mesaj.Location = new System.Drawing.Point(162, 12);
            this.Mesaj.Name = "Mesaj";
            this.Mesaj.Size = new System.Drawing.Size(422, 256);
            this.Mesaj.TabIndex = 2;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.OliveDrab;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(394, 349);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(190, 31);
            this.button18.TabIndex = 7;
            this.button18.Text = "Mesaj Gönder";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // YonetimMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(615, 388);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.Mesaj);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Müşteri);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YonetimMesajlar";
            this.Text = "MRT BİLET | MÜŞTERİ DESTEK";
            this.Load += new System.EventHandler(this.YonetimMesajlar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Müşteri;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox Mesaj;
        private System.Windows.Forms.Button button18;
    }
}