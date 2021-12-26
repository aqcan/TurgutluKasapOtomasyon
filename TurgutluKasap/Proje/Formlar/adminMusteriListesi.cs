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
    public partial class adminMusteriListesi : Form
    {
        public adminMusteriListesi()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-OQPEAV8; Initial Catalog = kasapprojeMusteriler; Integrated Security = True");

        private void button2_Click(object sender, EventArgs e)
        {
            anaEkran anaEkran = new anaEkran();
            anaEkran.Show();
            this.Hide();
        }

        private void adminMusteriListesi_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table_musteriBilgilerTableAdapter.Fill(this.kasapprojeMusterilerDataSet.Table_musteriBilgiler);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
