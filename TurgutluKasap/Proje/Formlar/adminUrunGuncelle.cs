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
    public partial class adminUrunGuncelle : Form
    {
        public adminUrunGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OQPEAV8;Initial Catalog=kasapprojeUrunler;Integrated Security=True");

        private void adminUrunGuncelle_Load(object sender, EventArgs e)
        {
            this.table_urunBilgilerTableAdapter1.Fill(this.kasapprojeUrunlerDataSet1.Table_urunBilgiler);

            for (int sayac = 0; sayac < dataGridView1.RowCount ; sayac++)
            {
                comboBox1.Items.Add(dataGridView1.Rows[sayac].Cells[0].Value.ToString()) ;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Table_urunBilgiler Set urunMiktar=@a1,urunBirimFiyat=@a2,urunVergiOrani=@a3 where urunIsim=@a4", baglanti);

            guncelle.Parameters.AddWithValue("@a1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@a2", textBox2.Text);
            guncelle.Parameters.AddWithValue("@a3", textBox3.Text);
            guncelle.Parameters.AddWithValue("@a4", comboBox1.Text);
            guncelle.ExecuteNonQuery();

            this.table_urunBilgilerTableAdapter1.Fill(this.kasapprojeUrunlerDataSet1.Table_urunBilgiler);
            baglanti.Close();
            MessageBox.Show("Ürün bilgisi başarıyla güncellendi!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenUrun;
            secilenUrun = comboBox1.Text;
            for (int sayac = 0; sayac < dataGridView1.RowCount; sayac++)
            {
                string dataDegeri = dataGridView1.Rows[sayac].Cells[0].Value.ToString();
                if ( dataDegeri == secilenUrun)
                {
                    textBox1.Text=dataGridView1.Rows[sayac].Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[sayac].Cells[2].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[sayac].Cells[3].Value.ToString();
                }
            }
            

            //textbox1 ürün miktarı, 2 birim fiyatı, 3 vergi oranı ... 2. kolon miktar, 3 fiyat, 4 vergi
            this.table_urunBilgilerTableAdapter1.Fill(this.kasapprojeUrunlerDataSet1.Table_urunBilgiler);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anaEkran anaEkran = new anaEkran();
            anaEkran.Show();
            this.Hide();
        }
    }
}
