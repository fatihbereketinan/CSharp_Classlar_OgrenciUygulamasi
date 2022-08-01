using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciUygulamasi
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private double vizenot1;
        private double vizenot2;
        private double finalnot;
        private string okulismi;

        public Ogrenci(int _ogrenciNo, string _isim, string _soyisim, double _vizenot1, double _vizenot2, double _finalnot, string _okulismi)
        {
            ogrenciNo = _ogrenciNo;
            isim = _isim;
            soyisim = _soyisim;
            vizenot1 = _vizenot1;
            vizenot2 = _vizenot2;
            finalnot = _finalnot;
            okulismi = _okulismi;
        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrencinin Okul Numarası: " + ogrenciNo);
            Console.WriteLine("Öğrencinin Adı ve Soyadı: " + isim + " " + soyisim);
            Console.WriteLine("Öğrencinin Vize1, Vize2 ve Final Notları: " + vizenot1 + "," + vizenot2 + "," + finalnot);
            Console.WriteLine("Öğrencinin Okul Ad: "+okulismi);
            Console.WriteLine("");
        }
        public void ogrenciOrtalamasiBul()
        {
            Console.WriteLine("Öğrencinin not ortalaması: "+((0.4*((vizenot1+vizenot2)/2))+(0.6*finalnot)));
            Console.WriteLine("");
        }
        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin eğitim gördüğü okul: " + okulismi);
            Console.WriteLine("");
        }
    }
}
