namespace BankaTest
{
    partial class Gecmis
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBLHAREKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBankaDataSet = new BankaTest.DbBankaDataSet();
            this.tBLHAREKETTableAdapter = new BankaTest.DbBankaDataSetTableAdapters.TBLHAREKETTableAdapter();
            this.lblGecmısHesap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHAREKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBankaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(831, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // tBLHAREKETBindingSource
            // 
            this.tBLHAREKETBindingSource.DataMember = "TBLHAREKET";
            this.tBLHAREKETBindingSource.DataSource = this.dbBankaDataSet;
            // 
            // dbBankaDataSet
            // 
            this.dbBankaDataSet.DataSetName = "DbBankaDataSet";
            this.dbBankaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLHAREKETTableAdapter
            // 
            this.tBLHAREKETTableAdapter.ClearBeforeFill = true;
            // 
            // lblGecmısHesap
            // 
            this.lblGecmısHesap.AutoSize = true;
            this.lblGecmısHesap.Location = new System.Drawing.Point(567, 62);
            this.lblGecmısHesap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGecmısHesap.Name = "lblGecmısHesap";
            this.lblGecmısHesap.Size = new System.Drawing.Size(49, 18);
            this.lblGecmısHesap.TabIndex = 1;
            this.lblGecmısHesap.Text = "label1";
            this.lblGecmısHesap.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(839, 362);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geçmiş İşlemler";
            // 
            // Gecmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(839, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGecmısHesap);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gecmis";
            this.ShowIcon = false;
            this.Text = "Geçmiş İşlemler";
            this.Load += new System.EventHandler(this.Gecmis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHAREKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBankaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DbBankaDataSet dbBankaDataSet;
        private System.Windows.Forms.BindingSource tBLHAREKETBindingSource;
        private DbBankaDataSetTableAdapters.TBLHAREKETTableAdapter tBLHAREKETTableAdapter;
        private System.Windows.Forms.Label lblGecmısHesap;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}