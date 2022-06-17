using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Aşağıdaki referansı ekliyoruz.
using System.Net;
using System.Diagnostics;

namespace Guncelleme
{
    public partial class guncelleme : Form
    {
        private string destPath = Application.StartupPath + "\\Panel.exe"; //güncellenecek dosyamızın adı
        private string GuncelDosya = "http://localhost/app/Panel.exe"; //Sunucudan çekeceğimiz dosyanın adresi
        private string DosyaAdi;
        private int saniye = 5;

        public guncelleme()
        {
            InitializeComponent();
        }

        private void Guncel_Load(object sender, EventArgs e)
        {
            timer1.Start(); //Load eventinde timeri aktif ediyoruz.
            zaman_label.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e) //Timer tick kısmı
        {
            timer1.Enabled = false; //Timerin bir kere çalışmasını istediğimiz için timeri pasif yapıyoruz.
            WebClient webClient = new WebClient(); //Webclient tanımlıyoruz.
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed); //Webclient içinde webClient.DownloadFileCompleted olayı tanımlıyoruz. Yani dosya yüklenmesi bitince bu kısım tetiklenecek.
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);//Webclient içinde webClient.DownloadProgressChanged olayı tanımlıyoruz. Dosyanın her bir kilobyte ı indiğinde bu olay tetiklenecek.
            webClient.DownloadFileAsync(new Uri(GuncelDosya), destPath); //En yukarıda tanımladıgımız GuncelDosya değişkeninde ki linki indirmeye başlıyoruz.

            //Bu kısımda ise indireceğimiz dosyanın sadece adını ve uzantısını çekiyoruz. Yani GuncelDosya değişkeninde ki linkin gereksiz kısımlarını silip sadece dosya adını ve uzantısını alıyoruz. 
            string DosyaAdiUrlAdresi = GuncelDosya;
            int karaktersayisi = DosyaAdiUrlAdresi.LastIndexOf('/');
            DosyaAdi = DosyaAdiUrlAdresi.Remove(0, karaktersayisi + 1);
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e) //Webclient kısmında tanımladığımız olay tetiklendiğinde bu kısım çalışacak.
        {
            progressBar1.Value = e.ProgressPercentage; //progressbarın ilerlemesini sağlıyoruz.
            ilerlemedurum_label.Text = DosyaAdi + " (%" + e.ProgressPercentage.ToString() + ")"; //Yüklenen kısmı yüzde olarak gösteriyoruz.
        }

        private void Completed(object sender, AsyncCompletedEventArgs e) //Webclient kısmında tanımladığımız olay tetiklendiğinde bu kısım çalışacak.
        {
            timer2.Interval = 1000;
            timer2.Start();
            ilerlemedurum_label.Text = "Güncelleme Tamamlandı!"; // Yükleme bitti
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            zaman_label.Text = Convert.ToString(saniye) + " saniye sonra yeniden başlayacak!"; // Yükleme bitti
            saniye = saniye - 1;
            if(saniye == 0)
            {
                Process.Start(Application.StartupPath + "\\Panel.exe"); //güncellenecek dosyamızın adı
                Process kapat;
                kapat = Process.GetProcessesByName("Guncelleme")[0];
                kapat.Kill();
            }
        }
    }
}