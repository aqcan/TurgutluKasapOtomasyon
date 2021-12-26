
namespace Proje
{
    partial class adminUrunGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunVergiOraniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableurunBilgilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kasapprojeUrunlerDataSet1 = new Proje.kasapprojeUrunlerDataSet1();
            this.kasapprojeUrunlerDataSet = new Proje.kasapprojeUrunlerDataSet();
            this.kasapprojeUrunlerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableurunBilgilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_urunBilgilerTableAdapter = new Proje.kasapprojeUrunlerDataSetTableAdapters.Table_urunBilgilerTableAdapter();
            this.table_urunBilgilerTableAdapter1 = new Proje.kasapprojeUrunlerDataSet1TableAdapters.Table_urunBilgilerTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableurunBilgilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasapprojeUrunlerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasapprojeUrunlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasapprojeUrunlerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableurunBilgilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN GÜNCELLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(53, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(43, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Miktarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(60, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birim Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Tan;
            this.label5.Location = new System.Drawing.Point(61, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vergi Oranı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bilgileri Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ürün Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 26);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(204, 333);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 26);
            this.textBox3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIsimDataGridViewTextBoxColumn,
            this.urunMiktarDataGridViewTextBoxColumn,
            this.urunBirimFiyatDataGridViewTextBoxColumn,
            this.urunVergiOraniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableurunBilgilerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(394, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(448, 228);
            this.dataGridView1.TabIndex = 11;
            // 
            // urunIsimDataGridViewTextBoxColumn
            // 
            this.urunIsimDataGridViewTextBoxColumn.DataPropertyName = "urunIsim";
            this.urunIsimDataGridViewTextBoxColumn.HeaderText = "İSİM";
            this.urunIsimDataGridViewTextBoxColumn.Name = "urunIsimDataGridViewTextBoxColumn";
            this.urunIsimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunMiktarDataGridViewTextBoxColumn
            // 
            this.urunMiktarDataGridViewTextBoxColumn.DataPropertyName = "urunMiktar";
            this.urunMiktarDataGridViewTextBoxColumn.HeaderText = "MİKTAR";
            this.urunMiktarDataGridViewTextBoxColumn.Name = "urunMiktarDataGridViewTextBoxColumn";
            this.urunMiktarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunBirimFiyatDataGridViewTextBoxColumn
            // 
            this.urunBirimFiyatDataGridViewTextBoxColumn.DataPropertyName = "urunBirimFiyat";
            this.urunBirimFiyatDataGridViewTextBoxColumn.HeaderText = "FİYAT(KG)";
            this.urunBirimFiyatDataGridViewTextBoxColumn.Name = "urunBirimFiyatDataGridViewTextBoxColumn";
            this.urunBirimFiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunVergiOraniDataGridViewTextBoxColumn
            // 
            this.urunVergiOraniDataGridViewTextBoxColumn.DataPropertyName = "urunVergiOrani";
            this.urunVergiOraniDataGridViewTextBoxColumn.HeaderText = "VERGİ";
            this.urunVergiOraniDataGridViewTextBoxColumn.Name = "urunVergiOraniDataGridViewTextBoxColumn";
            this.urunVergiOraniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableurunBilgilerBindingSource1
            // 
            this.tableurunBilgilerBindingSource1.DataMember = "Table_urunBilgiler";
            this.tableurunBilgilerBindingSource1.DataSource = this.kasapprojeUrunlerDataSet1;
            // 
            // kasapprojeUrunlerDataSet1
            // 
            this.kasapprojeUrunlerDataSet1.DataSetName = "kasapprojeUrunlerDataSet1";
            this.kasapprojeUrunlerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasapprojeUrunlerDataSet
            // 
            this.kasapprojeUrunlerDataSet.DataSetName = "kasapprojeUrunlerDataSet";
            this.kasapprojeUrunlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasapprojeUrunlerDataSetBindingSource
            // 
            this.kasapprojeUrunlerDataSetBindingSource.DataSource = this.kasapprojeUrunlerDataSet;
            this.kasapprojeUrunlerDataSetBindingSource.Position = 0;
            // 
            // tableurunBilgilerBindingSource
            // 
            this.tableurunBilgilerBindingSource.DataMember = "Table_urunBilgiler";
            this.tableurunBilgilerBindingSource.DataSource = this.kasapprojeUrunlerDataSetBindingSource;
            // 
            // table_urunBilgilerTableAdapter
            // 
            this.table_urunBilgilerTableAdapter.ClearBeforeFill = true;
            // 
            // table_urunBilgilerTableAdapter1
            // 
            this.table_urunBilgilerTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(712, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 55);
            this.button3.TabIndex = 12;
            this.button3.Text = "Ana Menü";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminUrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.bulanık;
            this.ClientSize = new System.Drawing.Size(866, 498);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adminUrunGuncelle";
            this.Text = "ÜRÜN GÜNCELLE";
            this.Load += new System.EventHandler(this.adminUrunGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableurunBilgilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasapprojeUrunlerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasapprojeUrunlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasapprojeUrunlerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableurunBilgilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kasapprojeUrunlerDataSetBindingSource;
        private kasapprojeUrunlerDataSet kasapprojeUrunlerDataSet;
        private System.Windows.Forms.BindingSource tableurunBilgilerBindingSource;
        private kasapprojeUrunlerDataSetTableAdapters.Table_urunBilgilerTableAdapter table_urunBilgilerTableAdapter;
        private kasapprojeUrunlerDataSet1 kasapprojeUrunlerDataSet1;
        private System.Windows.Forms.BindingSource tableurunBilgilerBindingSource1;
        private kasapprojeUrunlerDataSet1TableAdapters.Table_urunBilgilerTableAdapter table_urunBilgilerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunVergiOraniDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}