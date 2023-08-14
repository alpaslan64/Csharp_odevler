using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] turkishCities = {
                "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara",
                "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl",
                "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı",
                "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan",
                "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
                "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
                "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli",
                "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin",
                "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
                "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon",
                "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak",
                "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
                "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye",
                "Düzce"
            };

            // ComboBox'a il isimlerini ekleyin
            il_sec.Items.AddRange(turkishCities);

            string[] duzeyler = { "Çok iyi", "İyi", "Orta", "Düşük", "Başlangıç" };
            duzey.Items.AddRange(duzeyler);



        }



        private void gönder_Click(object sender, EventArgs e)
        {
            string adı = ad.Text;
            string soyadı = soyad.Text;
            string ili = il_sec.SelectedItem.ToString();
            string epostası = eposta.Text;
            string cep_alan = alank.Text;
            string cep_num = tel.Text;
            string ev_alan = alankev.Text;
            string ev_num = telev.Text;
            
            //string cinsiyet = bay.Checked ? "Bay" : "Bayan";
            string cinsiyet = "Boş Bırakıldı!";
            if (bay.Checked)
            {
                cinsiyet = "Bay";
            }
            else if (bayan.Checked)
            {
                cinsiyet = "Bayan";
            }
            string gun1 = gun.Text;
            string ay1 = ay.Text;
            string yil1 = yil.Text;
            
            //string evli1 = evli.Checked ? "Evli" : "Bekar"; // true: evli, false: diğer
            string evli1 = "Boş Bırakıldı!";
            if (evli.Checked) 
            {   
                evli1="Evli";
            }
            else if (bekar.Checked)
            {
                evli1 = "Bekar";
            }

            //string ehliyet_var = var.Checked ? "Var" : "Yok"; // true: ehliyet var, false: ehliyet yok
            string ehliyet_var = "Boş Bırakıldı!";
            if (var.Checked)
                ehliyet_var = "Var";
            else if (yok.Checked)
                ehliyet_var = "Yok";
            
            //string askerlik_yaptı = yapti.Checked ? "Yaptı" : "Yapmadı"; // true: yaptı, false: yapmadı
            string askerlik_yaptı = "Boş Bırakıldı!";
            if (yapti.Checked)
                askerlik_yaptı = "Yaptı";
            else if (yapmadi.Checked)
                askerlik_yaptı = "Yapmadı";

            //string tc1 = tc.Checked ? "T.C." : diğer_.Text; // true: TC, false: diğer
            string tc1 = "Boş Bırakıldı!";
            if (tc.Checked)
                tc1 = "T.C.";
            else if (diger.Checked)
                tc1 = diğer_.Text;
            //string diger_secim = diger.Checked ? diğer_.Text : ""; // Diğer seçildiyse diğer seçeneğinin değeri
            string okul_ad = okul.Text;
            string bolum_adı = bolum.Text;
            string dil1 = dil.Text;
            string dil_duzey1 = duzey.Text;

            

            try
            {
                using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QUGL3SJ\SQLEXPRESS01;Initial Catalog=odevim1;Integrated Security=True"))
                {
                    baglanti.Open();

                    // SQL sorgusu oluşturma
                    string query = "INSERT INTO tablo1 (ad, soyad, il, eposta, cep_telefonu_alan_kodu, cep_telefonu_numara, ev_telefonu_alan_kodu, ev_telefonu_numara, cinsiyet, dogum_tarihi_gun, dogum_tarihi_ay, dogum_tarihi_yil, medeni_durumu, ehliyet, askerlik_durumu, uyrugu, okul_adi, bolumu, yabanci_dil, yabanci_dil_duzeyi) VALUES (@ad, @soyad, @il, @eposta, @cep_telefonu_alan_kodu, @cep_telefonu_numara, @ev_telefonu_alan_kodu, @ev_telefonu_numara, @cinsiyet, @dogum_tarihi_gun, @dogum_tarihi_ay, @dogum_tarihi_yil, @medeni_durumu, @ehliyet, @askerlik_durumu, @uyrugu, @okul_adi, @bolumu, @yabanci_dil, @yabanci_dil_duzeyi)";

                    // SqlCommand nesnesi oluşturma
                    using (SqlCommand command = new SqlCommand(query, baglanti))
                    {
                        // Parametreleri eklemek
                        command.Parameters.AddWithValue("@ad", adı);
                        command.Parameters.AddWithValue("@soyad", soyadı);
                        command.Parameters.AddWithValue("@il", ili);
                        command.Parameters.AddWithValue("@eposta", epostası);
                        command.Parameters.AddWithValue("@cep_telefonu_alan_kodu", cep_alan);
                        command.Parameters.AddWithValue("@cep_telefonu_numara", cep_num);
                        command.Parameters.AddWithValue("@ev_telefonu_alan_kodu", ev_alan);
                        command.Parameters.AddWithValue("@ev_telefonu_numara", ev_num);
                        command.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        command.Parameters.AddWithValue("@dogum_tarihi_gun", gun1);
                        command.Parameters.AddWithValue("@dogum_tarihi_ay", ay1);
                        command.Parameters.AddWithValue("@dogum_tarihi_yil", yil1);
                        command.Parameters.AddWithValue("@medeni_durumu", evli1);
                        command.Parameters.AddWithValue("@ehliyet", ehliyet_var);
                        command.Parameters.AddWithValue("@askerlik_durumu", askerlik_yaptı);
                        command.Parameters.AddWithValue("@uyrugu", tc1);
                        command.Parameters.AddWithValue("@diger_secim", tc1);
                        command.Parameters.AddWithValue("@okul_adi", okul_ad);
                        command.Parameters.AddWithValue("@bolumu", bolum_adı);
                        command.Parameters.AddWithValue("@yabanci_dil", dil1);
                        command.Parameters.AddWithValue("@yabanci_dil_duzeyi", dil_duzey1);

                        // Sorguyu çalıştırma
                        int rowsAffected = command.ExecuteNonQuery();

                        // Eğer sorgu başarıyla çalıştıysa veri başarıyla eklendi demektir.
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Veri başarıyla eklendi.");
                        }
                        else
                        {
                            MessageBox.Show("Veri eklenirken bir hata oluştu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void alank_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void alankev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void telev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void diğer__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void okul_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void bolum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void dil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
