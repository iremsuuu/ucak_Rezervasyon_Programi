using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucak_Rezervasyon_Programı
{
    internal class Class1
    {
        public static string isimSoyisim;
        static void Main(string[] args)
        {
            DateTime TarihSaat1 = new DateTime(2023, 10, 05, 10, 30, 0);
            DateTime TarihSaat2 = new DateTime(2023, 10, 12, 10, 30, 0);
            DateTime TarihSaat3 = new DateTime(2023, 10, 17, 10, 30, 0);
            DateTime TarihSaat4 = new DateTime(2023, 10, 24, 10, 30, 0);

            UcakBilgileri ucak = new UcakBilgileri();
            ucak.model = "Kargo Uçağı";
            ucak.seriNo = 20204382691347;
            ucak.yolcuKapasitesi = 4;
            ucak.tasimaKapasitesi = 200000;
            ucak.bakimTarihi = "01, 10, 2023";
            ucak.ucakRengi = "koyu yeşil";

            KargoBilgileri kargo = new KargoBilgileri();
            Console.WriteLine("Gönderenin İsmi Soyismi:");
            kargo.gonderenAdSoyad = Console.ReadLine();
            Console.WriteLine("Kargo Türü Giriniz: (Tehlikeli, Acil Teslimat, Kuru Yük...)");
            kargo.tur = Console.ReadLine();
            Console.WriteLine("Kilogram Cinsinden Ağırlığını Giriniz:");
            kargo.agırlık_kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gönderici Numarasını Giriniz:");
            kargo.gondericiNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Alıcı Numarasını Giriniz:");
            kargo.alıcıNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İletişim Bilgilerinizi Giriniz (Telefon Numarası) +90");
            kargo.iletisimBilgileri = Console.ReadLine();

            LokasyonBilgileri lokasyon = new LokasyonBilgileri();
            Console.WriteLine("Kargonun Gideceği Ülkeyi Giriniz:");
            lokasyon.ulke = Console.ReadLine();
            Console.WriteLine("Kargonun Gideceği Şehri Giriniz:");
            lokasyon.sehir = Console.ReadLine();
            Console.WriteLine("Kargonun Gönderilmek İstendiği Havaalanını Giriniz:");
            lokasyon.havaalani = Console.ReadLine();
            Console.WriteLine("Doluluk Sebebiyle En Yakın Tarih Olan "+ TarihSaat1 +" Tarihine " + lokasyon.ulke + "/" + lokasyon.sehir + "/" + lokasyon.havaalani + " " + "Konumunda Kaydınız Oluşturulmuştur.");
        }
    }
}
