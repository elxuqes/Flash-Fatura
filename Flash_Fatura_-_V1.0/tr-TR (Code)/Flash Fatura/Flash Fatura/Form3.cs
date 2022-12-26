using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;

namespace Flash_Fatura
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurum seçip seçmediğiniz kontrol ediliyor, eğer seçtiyseniz siteye yönlendirileceksiniz. Devam etmek için TAMAM butonuna basınız..", "Flash Fatura - Yönlendiriliyorsunuz!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (comboBox1.SelectedIndex == 0) // Turknet
            {
                System.Diagnostics.Process.Start("https://turk.net/borc-sorgulama/");
            }
            else if (comboBox1.SelectedIndex == 1) // Türk Telekom (TTNET)
            {
                System.Diagnostics.Process.Start("https://onlineislemler.turktelekom.com.tr/fatura-sorgulama-odeme/internet");
            }
            else if (comboBox1.SelectedIndex == 2) // Vodafone Net
            {
                System.Diagnostics.Process.Start("https://www.vodafone.com.tr/yanimda/fatura-ode");
            }
            else if (comboBox1.SelectedIndex == 3)// D-Smart
            {
                System.Diagnostics.Process.Start("https://crmsso.dsmart.com.tr/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Doim_react_client%26redirect_uri%3Dhttps%253A%252F%252Fonlineislemler.dsmart.com.tr%252FloginCallback%26response_type%3Did_token%2520token%26scope%3Dopenid%2520profile%2520oimapi.admin%26state%3D16c159224ee24da4833335eb3b517485%26nonce%3Dc40470f182474b58aef2ef53357e27be");
            }   
            else if (comboBox1.SelectedIndex == 4) // SuperOnline
            {
                System.Diagnostics.Process.Start("https://www.superonline.net/yardim/musteri-islemleri/fatura-ve-odeme/odeme-kanallari-nelerdir?path=%2Fyardim&GUID=3fadfc19-2209-4ad8-9f0d-dcf00ca1a141");
                System.Diagnostics.Process.Start("https://www.superonline.net/?signin=true&r=%2Fhesabim");
                
            }
            else if (comboBox1.SelectedIndex == 5) // Turksat Kablo
            {
                System.Diagnostics.Process.Start("https://online.turksatkablo.com.tr/TcNoFaturalar.aspx");
                
            }
            else if (comboBox1.SelectedIndex == 6) // Milleni.com
            {
                System.Diagnostics.Process.Start("https://www.milleni.com.tr/musteri-islemleri/fatura-sorgulama");
               
            }
            else if (comboBox1.SelectedIndex == 7) // NetSpeed
            {
                System.Diagnostics.Process.Start("https://www.netspeed.com.tr/destek/fatura-odeme");
               
            }
            else if (comboBox1.SelectedIndex == 8) // Kullanıcı - İnternet
            {
                System.Diagnostics.Process.Start(Form6.internet2);
            }
            else
            {
                MessageBox.Show("Kurum seçmediniz, lütfen seçiniz!", "Flash Fatura - Kurum Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurum seçip seçmediğiniz kontrol ediliyor, eğer seçtiyseniz siteye yönlendirileceksiniz. Devam etmek için TAMAM butonuna basınız..", "Flash Fatura - Yönlendiriliyorsunuz!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (comboBox2.SelectedIndex == 0) //MEPAŞ
            {
                System.Diagnostics.Process.Start("https://oim.mepasenerji.com/Anasayfa/BorcSorgula#!");
            }
            else if (comboBox2.SelectedIndex == 1) // 2M
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/2m-enerji-toptan-elktrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 2) // Aksa
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-elkt-toptan-satis-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 3) // Avel Avrupa
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/avel-avrupa-elektrik-enerjisi-toptan-satis--faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 4) // Ayedaş Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/ayedas-dagitim-kaçak/tedarikçi/diger-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 5) // Başkent Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/baskent-dagitim-kaçak/tedarikçi/diger-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 6) // Bisen Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/bisen-elektrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 7) // Cerean Fina Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/cerean-fina-elektrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 8) // CLK Çamlıbel Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/clk-camlibel-elektrik-perakende-sivas-tokat-yozgat-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 9) // Çoruh Edaş
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/coruh-edas-rize-trabzon-giresun-artvin-gumushane-elektrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 10) // Dicle Epsaş
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/dicle-epsas-diyarbakir-sanliurfa-mardin-batman-siirt-sirnak-elektrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 11) // EkodaşElektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/ekodas-elektrik-ith-ihr-ve-top-satis-as-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 12) // Elektra Enerji 
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/elektra-enerji-top-sat-ve-ith-ihr-as-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 13) // Eltek Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/eltek-elektrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 14) // Enerjim Perakende Enerji
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerjim-perakende-enerji-tic-as-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 15) // Enerjisa Ayesaş
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerjisa-ayesas-satis-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 16) // Enerjisa Başkent
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerjisa-baskent-satis-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 17) // Enerjisa Toroslar
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerjisa-toroslar-satis-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 18) // Etic Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/etic-elektrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 19) // Ewe Enerji
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/ewe-enerji-as-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 20) // Fırat EDAŞ
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/firat-edas-bingol-elazig-malatya-tunceli-elektrik-faturasi-sorgula");

            }
            else if (comboBox2.SelectedIndex == 21) // Gediz Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/gediz-elektrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 22) // Halis Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/halis-elektrik-enerjisi-toptan-satis-ithalat-ve-ihr-as-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 23) // İdeal Perakende
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/ideal-perakende-elektrik-satis-as-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 24) // İkitelli Enerji
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/ikitelli-osb-mutesebbis-heyet-bask-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 25) // Kayseri Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kayseri-elektrik-perakende-satis-as-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 26) // Odaş Enerji
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/odas-enerji-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 27) // Osmangazi Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/osmangazi-elektrik-eskisehir-afyon-usak-bilecik-kutahya-elektrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 28) // Tek Elektrik (KGM Enerji)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/tek-elekt-kgm-enerji-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 29) // Toroslar Tedaş
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/toroslar-dagitim-kacak-tedarikci-diger-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 30) // TT Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/tt-elektrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 31) // Vangölü Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/vangolu-elektrik-vepsas-van-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 32) // Yüksel Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/yuksel-elektrik-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 33) // Zorlu Elektrik
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/zorlu-elk-en-ith-ihr-ve-top-tic-as-faturasi-sorgula");
            }
            else if (comboBox2.SelectedIndex == 34) // Kullanıcı Elektrik
            {
                System.Diagnostics.Process.Start(Form6.elektrik2);
            }
            else
            {
                MessageBox.Show("Kurum seçmediniz, lütfen seçiniz!", "Flash Fatura - Kurum Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurum seçip seçmediğiniz kontrol ediliyor, eğer seçtiyseniz siteye yönlendirileceksiniz. Devam etmek için TAMAM butonuna basınız..", "Flash Fatura - Yönlendiriliyorsunuz!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (comboBox3.SelectedIndex == 0) //Adıyaman Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/adiyaman-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 1) //AFJET AFYON JEOTERMAL
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/afjet-afyon-jeotermal-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 2) //AFYONKARAHİSAR SU
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/afyonkarahisar-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 3) //Aksaray Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksaray-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 4) //Arhavi Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/arhavi-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 5) //Antalya ASAT
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/asat-antalya-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 6) //Aydın Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aydin-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 7) //Balikesir Belediyesi (BASKİ)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/balikesir-belediyesi-baski-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 8) //Biga Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/biga-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 9) //BİGADİÇ JEOTERMAL SU
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/bigadic-jeotermal-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 10) //BULANCAK SU
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/bulancak-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 11) //Burdur Su 
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/burdur-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 12) //Çan Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/can-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 13) //Çorum Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/Corum%20Su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 14) //Denizli Deski
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/denizli-deski-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 15) //Diyarbakır Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/diyarbakir-belediyesi-su-diyarsu-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 16) //Erzurum Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/erzurum-su-eski-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 17) //Gaziantep Gaski
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/gaski-gaziantep-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 18) //Giresun Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/giresun-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 19) //Hatay Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/hatay-hatsu-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 20) //Hopa Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/hopa-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 21) //Isparta Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/isparta-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 22) //İzmit Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/izmit-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 23) //İzmir İzsu
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/izsu-izmir-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 24) //Kadirli Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kadirli-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 25) //Kahramanmaraş Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kahramanmaras-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 26) //Karadeniz Ereğli
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/karadeniz-eregli-su-zonguldak-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 27) //Karaman Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/karaman-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 28) //Kastamonu Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kastamonu-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 29) //Kırklareli Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kirklareli-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 30) //Kırşehir Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kirsehir-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 31) //Konya Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/konya-su-koski-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 32) //Kütayha Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kutahya-su-faturasi-sorgula");
            }
            else   if (comboBox3.SelectedIndex == 33) //Lüleburgaz Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/luleburgaz-su-faturasi-sorgula");
            }
            else   if (comboBox3.SelectedIndex == 34) //Malatya Su (MASKİ)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/malatya-su-maski-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 35) //Manisa Maski
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/manisa-maski-su-faturasi-sorgula");
            }
            else   if (comboBox3.SelectedIndex == 36) //Mardin Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/mardin-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 37) //Merzifon Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/merzifon-su-faturasi-sorgula");
            }
            else   if (comboBox3.SelectedIndex == 38) //Nevşehir Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/nevsehir-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 39) //Niğde Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/nigde-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 40) //Oski Ordu Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/oski-ordu-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 41) //Osmaniye Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/osmaniye-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 42) //Rize Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/rize-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 43) //Sakarya Saski
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/sakarya-saski-su-faturasi-sorgula");
            }
            else   if (comboBox3.SelectedIndex == 44) //SASKİ Samsun
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/saski-samsun-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 45) //Siirt Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/siirt-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 46) //Sivas Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/sivas-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 47) //Şanlıurfa Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/sanliurfa-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 48) //Tekirdağ Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/tekirdag-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 49) //Trabzon Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/trabzon-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 50) //Uşak Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/usak-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 51) //Uzunköprü Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/uzunkopru-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 52) //Vaski Van Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/vaski-van-su-faturasi-sorgula");
            }
            else  if (comboBox3.SelectedIndex == 53) //Yalova Belediyesi Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/yalova-belediyesi-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 54) //Yozgat Su
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/yozgat-su-faturasi-sorgula");
            }
            else if (comboBox3.SelectedIndex == 55) // Kullanıcı - Su
            {
                System.Diagnostics.Process.Start(Form6.su2);
            }
            else
            {
                MessageBox.Show("Kurum seçmediniz, lütfen seçiniz!", "Flash Fatura - Kurum Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurum seçip seçmediğiniz kontrol ediliyor, eğer seçtiyseniz siteye yönlendirileceksiniz. Devam etmek için TAMAM butonuna basınız..", "Flash Fatura - Yönlendiriliyorsunuz!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (comboBox4.SelectedIndex == 0) //Avea
            {
                System.Diagnostics.Process.Start("https://onlineislemler.turktelekom.com.tr/fatura-sorgulama-odeme/mobil");
            }
            else if (comboBox4.SelectedIndex == 1) //Turkcell
            {
                System.Diagnostics.Process.Start("https://www.turkcell.com.tr/yardim/yardim-araclari/fatura-borc-sorgulama-ve-odeme");
            }
            else if (comboBox4.SelectedIndex == 2) //Bimcell
             {
                 System.Diagnostics.Process.Start("https://www.bimcell.com.tr/pages/online-islemler.aspx?snkok=1");
             }
            else if (comboBox4.SelectedIndex == 3) //Vodafone
             {
                 System.Diagnostics.Process.Start("https://www.vodafone.com.tr/yanimda/fatura-ode");
             }
            else  if (comboBox4.SelectedIndex == 4) //Pttcell
             {
                 System.Diagnostics.Process.Start("https://onlineislemler.turktelekom.com.tr/mps/portal?cmd=LoginForThirdParty&thirdPartySite=pttcell&sessionId=&lang=tr&thirdPartySiteHost=http://www.pttcell.com.tr/Login/PostLogin&go=onlineTransactionsHome");
             }
            else  if (comboBox4.SelectedIndex == 5) //Teknosacell
             {
                 System.Diagnostics.Process.Start("https://onlineislemler.turktelekom.com.tr/mps/portal?cmd=LoginForThirdParty&thirdPartySite=teknosa&sessionId=&lang=tr");
             }
            else
            {
                MessageBox.Show("Kurum seçmediniz, lütfen seçiniz!", "Flash Fatura - Kurum Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void yenidenYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Flash Fatura yeniden başlatılıyor.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        {
            if (Application.OpenForms[0] == this)
            {
                MessageBox.Show("Flash Fatura yeniden başlatılıyor.", "Flash Fatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                Form2 f = new Form2();
                f.Show();
                this.Close();
            }
        }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(386, 600);

            //KURUM SEÇ:
            label3.Text = "Kurum Seçin:";
            label4.Text = "Kurum Seçin:";
            label7.Text = "Kurum Seçin:";
            label10.Text = "Kurum Seçin:";
            label13.Text = "Kurum Seçin:";

            //YÖNLENDİR
            button3.Text = "YÖNLENDİR";
            button4.Text = "YÖNLENDİR";
            button6.Text = "YÖNLENDİR";
            button8.Text = "YÖNLENDİR";
            button10.Text = "YÖNLENDİR";

            //SİMGE ALTI:
            label2.Text = "İnternet";
            label5.Text = "Elektrik";
            label8.Visible = false;
            label17.Visible = true;
            label11.Text = "Telefon";
            label14.Text = "Doğalgaz";

            //AYARLAR:
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            dilToolStripMenuItem.Text = "Dil";
            türkçeToolStripMenuItem.Text = "Türkçe";
            ingilizceToolStripMenuItem.Text = "İngilizce";
            dosyaToolStripMenuItem.Text = "Dosya";
            yenidenYükleToolStripMenuItem.Text = "Yeniden Yükle";
            çıkışToolStripMenuItem.Text = "Çıkış";
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            faturaHesaplamaToolStripMenuItem.Text = "Hesap Makinesi";
            kurumEkleToolStripMenuItem.Text = "Kurum Ekle";
            
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(372, 600);

            //SELECT INSTITUTION:
            label3.Text = "Select Institution:";
            label4.Text = "Select Institution:";
            label7.Text = "Select Institution:";
            label10.Text = "Select Institution:";
            label13.Text = "Select Institution:";

            //REDIRECT
            button3.Text = "REDIRECT";
            button4.Text = "REDIRECT";
            button6.Text = "REDIRECT";
            button8.Text = "REDIRECT";
            button10.Text = "REDIRECT";

            //ICON:
            label2.Text = "Internet";
            label5.Text = "Electricity";
            label8.Visible = true;
            label17.Visible = false;
            label11.Text = " Phone";
            label14.Text = "Natural Gas";

            //SETTINGS:
            ayarlarToolStripMenuItem.Text = "Settings";
            dilToolStripMenuItem.Text = "Language";
            türkçeToolStripMenuItem.Text = "Turkish";
            ingilizceToolStripMenuItem.Text = "English";
            dosyaToolStripMenuItem.Text = "File";
            yenidenYükleToolStripMenuItem.Text = "Restart";
            çıkışToolStripMenuItem.Text = "Exit";
            hakkımızdaToolStripMenuItem.Text = "About Us";
            faturaHesaplamaToolStripMenuItem.Text = "Calculator";
            kurumEkleToolStripMenuItem.Text = "Add Institution";
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kurum seçip seçmediğiniz kontrol ediliyor, eğer seçtiyseniz siteye yönlendirileceksiniz. Devam etmek için TAMAM butonuna basınız..", "Flash Fatura - Yönlendiriliyorsunuz!", MessageBoxButtons.OK, MessageBoxIcon.Information);   
           
            if (comboBox5.SelectedIndex == 0)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/agdas-adapazari-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/akmercan-batikar-zonguldak-bartin-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/akmercan-delta-bafra-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/akmercan-gepa-pamukova-gaz-faturasi-sorgula");
                   
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/akmercan-mardingaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 5)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/akmercan-mugla-dogalgaz-dag-san-ve-tic-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 6)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/akmercan-sinopgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 7)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/akmercangaz-dogalgaz-adiyaman-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 8)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-adana-dogal-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 9)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-afyon-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 10)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-balikesir-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 11)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-bandirma-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 12)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-bilecik-bolu-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 13)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-canakkale-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 14)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-duzce-eregli-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 15)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-elazig-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 16)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-gemlik-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 17)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-karadeniz-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 18)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-malatya-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 19)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-manisa-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 20)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-mustafakemalpasa-susurluk-karacabey-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 21)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-ordu-giresun-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 22)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-siirt-batman-dogalgaz-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 23)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-sivas-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 24)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-sanliurfa-dogalgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 25)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-tokat-amasya-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 26)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-trakya-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 27)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksa-van-dogalgaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 28)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksagaz-dagitim-as-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 29)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksagaz-sibadas-siirt-batman-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 30)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/aksagaz-gumushane-bayburt-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 31)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/armadas-kahramanmaras-dogalgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 32)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/armagaz-yalova-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 33)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/bahçesehir-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 34)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/bursa-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 35)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/cinigaz-gaz-sanayi-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 36)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/cinigaz-dogalgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 37)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/cinigaz-tavsanli-dogalgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 38)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/cordas-corlu-dogalgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 39)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/corum-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 40)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/diyargaz-diyarbakir-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 41)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerya-aksaray-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 42)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerya-antalya-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 43)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerya-aydin-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 44)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kentgaz-denizli-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 45)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerya-eregli-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 46)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerya-erzincan-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 47)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerya-kapadokya-gaz-nevsehir-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 48)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerya-karaman-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 49)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/enerya-konya-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 50)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/esgaz-eskisehir-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 51)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/gazdas---zorlu-enerji-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 52)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/igdas-istanbul-dogalgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 53)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/ingaz-inegol-gaz-dogalgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 54)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/izgaz-izmit-dogalgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 55)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kargaz-kars-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 56)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kars-kargaz-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 57)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kayseri-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 58)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kirgaz-kirikkale-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 59)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/kirsehir-kirgaz-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 60)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/olimposgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 61)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/palen-enerji-dogalgaz-erzurum-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 62)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/polgaz-polatli-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 63)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/samgaz-samsun-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 64)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/selcuk-dogalgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 65)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/surmeligaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 66)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/torosgaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 67)
            {
                System.Diagnostics.Process.Start("https://www.mokafatura.com/trakyagaz-edirne-tekirdag-kirklareli-gaz-faturasi-sorgula");
            }
            else if (comboBox5.SelectedIndex == 68)
            {
                System.Diagnostics.Process.Start(Form6.dogalgaz2);
            }
            else
            {
                MessageBox.Show("Kurum seçmediniz, lütfen seçiniz!", "Flash Fatura - Kurum Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void faturaHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Form4 form4sec = new Form4();
             form4sec.Show();
             this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 form6sec = new Form6();
            form6sec.Show();
            this.Hide();
        }

        private void hakkımızdaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form5 form5sec = new Form5();
            form5sec.Show();
            this.Hide();
        }

        private void kurumEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6sec = new Form6();
            form6sec.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Form6.internet1);
            comboBox2.Items.Add(Form6.elektrik1);
            comboBox3.Items.Add(Form6.su1);
            comboBox5.Items.Add(Form6.dogalgaz1);
        }

    

       

   

       

      

    

    
    }
}
