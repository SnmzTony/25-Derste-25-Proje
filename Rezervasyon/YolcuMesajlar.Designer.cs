namespace Rezervasyon
{
    partial class YolcuMesajlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YolcuMesajlar));
            this.button18 = new System.Windows.Forms.Button();
            this.Mesaj = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.OliveDrab;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(260, 343);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(190, 31);
            this.button18.TabIndex = 11;
            this.button18.Text = "Mesaj Gönder";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // Mesaj
            // 
            this.Mesaj.BackColor = System.Drawing.Color.Beige;
            this.Mesaj.FormattingEnabled = true;
            this.Mesaj.ItemHeight = 18;
            this.Mesaj.Location = new System.Drawing.Point(12, 6);
            this.Mesaj.Name = "Mesaj";
            this.Mesaj.Size = new System.Drawing.Size(457, 256);
            this.Mesaj.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 290);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(457, 42);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // YolcuMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(487, 388);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.Mesaj);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YolcuMesajlar";
            this.Text = "MRT BİLET | YOLCU DESTEK";
            this.Load += new System.EventHandler(this.YolcuMesajlar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.ListBox Mesaj;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}