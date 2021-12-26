﻿using System;
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
    public partial class siparisEkranı : Form
    {
        public siparisEkranı()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OQPEAV8;Initial Catalog=kasapprojeUrunler;Integrated Security=True");

        private void siparisEkranı_Load(object sender, EventArgs e)
        {
            this.table_urunBilgilerTableAdapter.Fill(this.kasapprojeUrunlerDataSet.Table_urunBilgiler);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox1.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
        }
        int sepetToplam = 0;
        int vergiToplam;
        private void button2_Click(object sender, EventArgs e)
        {
            //anaekran butonu
            anaEkran anaEkran = new anaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //siparisi tamamla butonu
            string odemeYontemi;
            odemeYontemi = comboBox3.Text;
            if (odemeYontemi == ("Kredi Kartı"))
            {
                odemeKredikart odemeKredikart = new odemeKredikart();
                odemeKredikart.Show();
                this.Hide();
            }
            if (odemeYontemi == ("Nakit"))
            {
                MessageBox.Show("Siparişiniz Alınmıştır!");
            }
            if (odemeYontemi == ("Çek"))
            {
                odemeCek odemeCek = new odemeCek();
                odemeCek.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //gizli yenile butonu
            comboBox1.Items.Clear();
            this.table_urunBilgilerTableAdapter.Fill(this.kasapprojeUrunlerDataSet.Table_urunBilgiler);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox1.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //sepete ekle butonu
            baglanti.Open();
            string seciliUrunAd=comboBox1.Text;
            string miktar=comboBox2.Text;
            string birimfiyat;
            int fiyat;                  
            listBox1.Items.Add(seciliUrunAd);
            listBox2.Items.Add(miktar);
            for (int i = 0; i<1000; i++)
            {
                SqlCommand komut = new SqlCommand("select urunBirimFiyat from Table_urunBilgiler where urunIsim=@a1 and urunBirimFiyat=@a2", baglanti);
                komut.Parameters.AddWithValue("@a1", seciliUrunAd);
                komut.Parameters.AddWithValue("@a2", i);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label10.Text = i.ToString();
                }
                dr.Close();
            }

            baglanti.Close();
            //urunun birim fiyatı secildi simdi bunu listbox3'e aktar

            birimfiyat = label10.Text;
            listBox3.Items.Add(birimfiyat);
            fiyat = Convert.ToInt32(birimfiyat) * Convert.ToInt32(miktar);
            listBox4.Items.Add(fiyat.ToString());
            sepetToplam = sepetToplam + fiyat;
            textBox2.Text = sepetToplam.ToString();
            vergiToplam = sepetToplam * 18 / 100;
            textBox1.Text = vergiToplam.ToString();

            //buranın altı yenilemek için
            comboBox1.Items.Clear();
            this.table_urunBilgilerTableAdapter.Fill(this.kasapprojeUrunlerDataSet.Table_urunBilgiler);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox1.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            //sepeti temizle butonu
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            textBox1.Text = (" ");
            textBox2.Text = (" ");
            sepetToplam = 0;
            vergiToplam = 0;
        }
    }
}
