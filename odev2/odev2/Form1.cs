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

namespace odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ASUS;Initial Catalog=odev2;Integrated Security=True");

        private void getir_Click(object sender, EventArgs e)
        {
            try
            {
                string isim = add.Text;
                string soyadı = soyadd.Text;
                string tc1 = tcc.Text;
                string posta = postaa.Text;
                string yasi = yass.Text;
                string meslegi = meslekk.Text;
                string burcu = burcc.Text;

                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT ad, soyad, tc, eposta, yas, meslek, burc FROM tablo2 WHERE ad LIKE '%' + @isim + '%' AND soyad LIKE '%' + @soyadı + '%' AND tc LIKE '%' + @tc1 + '%' AND eposta LIKE '%' + @posta + '%' AND yas LIKE '%' + @yasi + '%' AND meslek LIKE '%' + @meslegi + '%' AND burc LIKE '%' + @burcu + '%'", baglanti);
                sqlKomut.Parameters.AddWithValue("@isim", isim);
                sqlKomut.Parameters.AddWithValue("@soyadı", soyadı);
                sqlKomut.Parameters.AddWithValue("@tc1", tc1);
                sqlKomut.Parameters.AddWithValue("@posta", posta);
                sqlKomut.Parameters.AddWithValue("@yasi", yasi);
                sqlKomut.Parameters.AddWithValue("@meslegi", meslegi);
                sqlKomut.Parameters.AddWithValue("@burcu", burcu);

                SqlDataReader sqlDR = sqlKomut.ExecuteReader();

                // Önce DataGridView'deki mevcut verileri temizleme
                dataGridView1.Rows.Clear();

                while (sqlDR.Read())
                {
                    string ad = sqlDR[0].ToString();
                    string soyad = sqlDR[1].ToString();
                    string tc = sqlDR[2].ToString();
                    string eposta = sqlDR[3].ToString();
                    string yas = sqlDR[4].ToString();
                    string meslek = sqlDR[5].ToString();
                    string burc = sqlDR[6].ToString();

                    // DataGridView'e verileri eklemek için yeni bir satır oluşturun
                    dataGridView1.Rows.Add(ad, soyad, tc, eposta, yas, meslek, burc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı kurulamadı!" + ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void add_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void soyadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void burcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void meslekk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        
    }
}