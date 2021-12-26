using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class adminUrunEkleCikart : Form
    {
        public adminUrunEkleCikart()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OQPEAV8;Initial Catalog=kasapprojeUrunler;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ürün ekleme butonu...insert into tabloadı (sütunadları) values (parametreler)
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_urunBilgiler (urunIsim,urunMiktar,urunBirimFiyat,urunVergiOrani) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", comboBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.table_urunBilgilerTableAdapter.Fill(this.kasapprojeUrunlerDataSet1.Table_urunBilgiler);
            MessageBox.Show("Ürün Başarıyla Eklendi!");
            
            this.table_urunBilgilerTableAdapter.Fill(this.kasapprojeUrunlerDataSet1.Table_urunBilgiler);

            comboBox2.Items.Clear();

            for (int sayac = 0; sayac < dataGridView1.RowCount; sayac++)
            {
                comboBox2.Items.Add(dataGridView1.Rows[sayac].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ürün çıkarma butonu..combobox2 urun adi
            
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Table_urunBilgiler where urunIsim=@isim", baglanti);
            sil.Parameters.AddWithValue("@isim",comboBox2.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            this.table_urunBilgilerTableAdapter.Fill(this.kasapprojeUrunlerDataSet1.Table_urunBilgiler);
            MessageBox.Show("Ürün Başarıyla Çıkartıldı!");

            this.table_urunBilgilerTableAdapter.Fill(this.kasapprojeUrunlerDataSet1.Table_urunBilgiler);

            comboBox2.Items.Clear();

            for (int sayac = 0; sayac < dataGridView1.RowCount; sayac++)
            {
                comboBox2.Items.Add(dataGridView1.Rows[sayac].Cells[0].Value.ToString());
            }
        }

        private void adminUrunEkleCikart_Load(object sender, EventArgs e)
        {
            this.table_urunBilgilerTableAdapter.Fill(this.kasapprojeUrunlerDataSet1.Table_urunBilgiler);

            for (int sayac = 0; sayac < dataGridView1.RowCount; sayac++)
            {
                comboBox2.Items.Add(dataGridView1.Rows[sayac].Cells[0].Value.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.table_urunBilgilerTableAdapter.Fill(this.kasapprojeUrunlerDataSet1.Table_urunBilgiler);

            comboBox2.Items.Clear();

            for (int sayac = 0; sayac < dataGridView1.RowCount; sayac++)
            {
                comboBox2.Items.Add(dataGridView1.Rows[sayac].Cells[0].Value.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
