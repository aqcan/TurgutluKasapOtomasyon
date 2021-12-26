
namespace Proje
{
    partial class adminMusteriListesi
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriKullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablemusteriBilgilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasapprojeMusterilerDataSet = new Proje.kasapprojeMusterilerDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.table_musteriBilgilerTableAdapter = new Proje.kasapprojeMusterilerDataSetTableAdapters.Table_musteriBilgilerTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablemusteriBilgilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasapprojeMusterilerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(433, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Müşteri Listesi";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(476, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 58);
            this.button2.TabIndex = 25;
            this.button2.Text = "Ana Menü";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIsimDataGridViewTextBoxColumn,
            this.musteriSoyisimDataGridViewTextBoxColumn,
            this.musteriAdresDataGridViewTextBoxColumn,
            this.musteriKullaniciAdiDataGridViewTextBoxColumn,
            this.musteriSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablemusteriBilgilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(138, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 300);
            this.dataGridView1.TabIndex = 26;
            // 
            // musteriIsimDataGridViewTextBoxColumn
            // 
            this.musteriIsimDataGridViewTextBoxColumn.DataPropertyName = "musteriIsim";
            this.musteriIsimDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.musteriIsimDataGridViewTextBoxColumn.Name = "musteriIsimDataGridViewTextBoxColumn";
            this.musteriIsimDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriIsimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.musteriIsimDataGridViewTextBoxColumn.Width = 150;
            // 
            // musteriSoyisimDataGridViewTextBoxColumn
            // 
            this.musteriSoyisimDataGridViewTextBoxColumn.DataPropertyName = "musteriSoyisim";
            this.musteriSoyisimDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.musteriSoyisimDataGridViewTextBoxColumn.Name = "musteriSoyisimDataGridViewTextBoxColumn";
            this.musteriSoyisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriSoyisimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.musteriSoyisimDataGridViewTextBoxColumn.Width = 150;
            // 
            // musteriAdresDataGridViewTextBoxColumn
            // 
            this.musteriAdresDataGridViewTextBoxColumn.DataPropertyName = "musteriAdres";
            this.musteriAdresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.musteriAdresDataGridViewTextBoxColumn.Name = "musteriAdresDataGridViewTextBoxColumn";
            this.musteriAdresDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriAdresDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.musteriAdresDataGridViewTextBoxColumn.Width = 157;
            // 
            // musteriKullaniciAdiDataGridViewTextBoxColumn
            // 
            this.musteriKullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "musteriKullaniciAdi";
            this.musteriKullaniciAdiDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.musteriKullaniciAdiDataGridViewTextBoxColumn.Name = "musteriKullaniciAdiDataGridViewTextBoxColumn";
            this.musteriKullaniciAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriKullaniciAdiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.musteriKullaniciAdiDataGridViewTextBoxColumn.Width = 150;
            // 
            // musteriSifreDataGridViewTextBoxColumn
            // 
            this.musteriSifreDataGridViewTextBoxColumn.DataPropertyName = "musteriSifre";
            this.musteriSifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.musteriSifreDataGridViewTextBoxColumn.Name = "musteriSifreDataGridViewTextBoxColumn";
            this.musteriSifreDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriSifreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.musteriSifreDataGridViewTextBoxColumn.Width = 150;
            // 
            // tablemusteriBilgilerBindingSource
            // 
            this.tablemusteriBilgilerBindingSource.DataMember = "Table_musteriBilgiler";
            this.tablemusteriBilgilerBindingSource.DataSource = this.kasapprojeMusterilerDataSet;
            // 
            // kasapprojeMusterilerDataSet
            // 
            this.kasapprojeMusterilerDataSet.DataSetName = "kasapprojeMusterilerDataSet";
            this.kasapprojeMusterilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(325, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 58);
            this.button1.TabIndex = 27;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // table_musteriBilgilerTableAdapter
            // 
            this.table_musteriBilgilerTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(629, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 58);
            this.button3.TabIndex = 28;
            this.button3.Text = "Admin Panel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminMusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.bulanık;
            this.ClientSize = new System.Drawing.Size(1065, 530);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adminMusteriListesi";
            this.Text = "MÜŞTERİ LİSTESİ";
            this.Load += new System.EventHandler(this.adminMusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablemusteriBilgilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasapprojeMusterilerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private kasapprojeMusterilerDataSet kasapprojeMusterilerDataSet;
        private System.Windows.Forms.BindingSource tablemusteriBilgilerBindingSource;
        private kasapprojeMusterilerDataSetTableAdapters.Table_musteriBilgilerTableAdapter table_musteriBilgilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriKullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}