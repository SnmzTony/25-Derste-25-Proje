namespace NotKayıt
{
    partial class Giris
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
            this.BtnOgrGiris = new System.Windows.Forms.Button();
            this.BtnOgretmenGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOgrGiris
            // 
            this.BtnOgrGiris.BackColor = System.Drawing.Color.Orange;
            this.BtnOgrGiris.FlatAppearance.BorderSize = 0;
            this.BtnOgrGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOgrGiris.Location = new System.Drawing.Point(36, 199);
            this.BtnOgrGiris.Name = "BtnOgrGiris";
            this.BtnOgrGiris.Size = new System.Drawing.Size(332, 58);
            this.BtnOgrGiris.TabIndex = 0;
            this.BtnOgrGiris.Text = "Öğrenci Giriş";
            this.BtnOgrGiris.UseVisualStyleBackColor = false;
            this.BtnOgrGiris.Click += new System.EventHandler(this.BtnOgrGiris_Click);
            // 
            // BtnOgretmenGiris
            // 
            this.BtnOgretmenGiris.BackColor = System.Drawing.Color.Blue;
            this.BtnOgretmenGiris.FlatAppearance.BorderSize = 0;
            this.BtnOgretmenGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOgretmenGiris.Location = new System.Drawing.Point(36, 92);
            this.BtnOgretmenGiris.Name = "BtnOgretmenGiris";
            this.BtnOgretmenGiris.Size = new System.Drawing.Size(332, 58);
            this.BtnOgretmenGiris.TabIndex = 1;
            this.BtnOgretmenGiris.Text = "Öğretmen Giriş";
            this.BtnOgretmenGiris.UseVisualStyleBackColor = false;
            this.BtnOgretmenGiris.Click += new System.EventHandler(this.BtnOgretmenGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Not Kayıt Sistemi";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOgretmenGiris);
            this.Controls.Add(this.BtnOgrGiris);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Giris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOgrGiris;
        private System.Windows.Forms.Button BtnOgretmenGiris;
        private System.Windows.Forms.Label label1;
    }
}

