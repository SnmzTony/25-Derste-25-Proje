namespace NotKayıt
{
    partial class OgrGiris
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
            this.MskOgrNumara = new System.Windows.Forms.MaskedTextBox();
            this.BtnOgrGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numara:";
            // 
            // MskOgrNumara
            // 
            this.MskOgrNumara.Location = new System.Drawing.Point(155, 19);
            this.MskOgrNumara.Mask = "0000";
            this.MskOgrNumara.Name = "MskOgrNumara";
            this.MskOgrNumara.Size = new System.Drawing.Size(204, 31);
            this.MskOgrNumara.TabIndex = 1;
            this.MskOgrNumara.ValidatingType = typeof(int);
            // 
            // BtnOgrGiris
            // 
            this.BtnOgrGiris.BackColor = System.Drawing.Color.Orange;
            this.BtnOgrGiris.FlatAppearance.BorderSize = 0;
            this.BtnOgrGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOgrGiris.Location = new System.Drawing.Point(143, 69);
            this.BtnOgrGiris.Name = "BtnOgrGiris";
            this.BtnOgrGiris.Size = new System.Drawing.Size(234, 43);
            this.BtnOgrGiris.TabIndex = 2;
            this.BtnOgrGiris.Text = "Öğrenci Giriş";
            this.BtnOgrGiris.UseVisualStyleBackColor = false;
            this.BtnOgrGiris.Click += new System.EventHandler(this.BtnOgrGiris_Click);
            // 
            // OgrGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 146);
            this.Controls.Add(this.BtnOgrGiris);
            this.Controls.Add(this.MskOgrNumara);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "OgrGiris";
            this.Text = "OgrGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskOgrNumara;
        private System.Windows.Forms.Button BtnOgrGiris;
    }
}