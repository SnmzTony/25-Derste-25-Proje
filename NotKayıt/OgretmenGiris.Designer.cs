namespace NotKayıt
{
    partial class OgretmenGiris
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
            this.MskOgrNumara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOgretmenGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MskOgrNumara
            // 
            this.MskOgrNumara.Location = new System.Drawing.Point(148, 22);
            this.MskOgrNumara.Mask = "0000";
            this.MskOgrNumara.Name = "MskOgrNumara";
            this.MskOgrNumara.Size = new System.Drawing.Size(204, 31);
            this.MskOgrNumara.TabIndex = 4;
            this.MskOgrNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci Numara:";
            // 
            // BtnOgretmenGiris
            // 
            this.BtnOgretmenGiris.BackColor = System.Drawing.Color.Blue;
            this.BtnOgretmenGiris.FlatAppearance.BorderSize = 0;
            this.BtnOgretmenGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOgretmenGiris.Location = new System.Drawing.Point(113, 59);
            this.BtnOgretmenGiris.Name = "BtnOgretmenGiris";
            this.BtnOgretmenGiris.Size = new System.Drawing.Size(239, 51);
            this.BtnOgretmenGiris.TabIndex = 5;
            this.BtnOgretmenGiris.Text = "Öğretmen Giriş";
            this.BtnOgretmenGiris.UseVisualStyleBackColor = false;
            this.BtnOgretmenGiris.Click += new System.EventHandler(this.BtnOgretmenGiris_Click);
            // 
            // OgretmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 163);
            this.Controls.Add(this.BtnOgretmenGiris);
            this.Controls.Add(this.MskOgrNumara);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "OgretmenGiris";
            this.Text = "OgretmenGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox MskOgrNumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOgretmenGiris;
    }
}