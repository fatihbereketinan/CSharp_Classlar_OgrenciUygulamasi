using System;

namespace OgrenciUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(100, "Fatih Bereket", "İnan", 50, 80, 100, "Erciyes Üniversitesi");
            while (kontrol)
            {
                int secim= ogrenciİslemi();
                switch (secim)
                {
                    case 1:
                        ogrenci1.ogrenciBilgileriGoster();
                        break;
                    case 2:
                        ogrenci1.ogrenciOrtalamasiBul();
                        break;
                    case 3:
                        ogrenci1.okulGetir();
                        break;
                    case 4:
                        Console.WriteLine("Sistemden çıkış yapıldı.");
                        kontrol = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız...");
                        Console.WriteLine("***************************");
                        break;
                }
            }
        }
        static int ogrenciİslemi()
        {
            Console.WriteLine("1- Öğrenci Bilgilerini Göster.");
            Console.WriteLine("2- Öğrenci Not Ortalamasını Göster.");
            Console.WriteLine("3- Öğrencinin Eğitim Gördüğü Okulu Göster.");
            Console.WriteLine("4- Çıkış Yap.");
            Console.Write("Lütfen bir işlemi seçiniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            return secim;
        }
    }
}
