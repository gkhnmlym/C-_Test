using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim: "Gökhan");


            //diziler - arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Derin";
            string ogrenci3 = "Salih";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Derin";
            ogrenciler[2] = "Salih";

            Console.ReadLine();
        }

        static void SelamVer(string isim = "NoName")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        private static void Degiskenler()
        {
            string mesaj = "Hello World!";
            double tutar = 100.5;
            int adet = 5;
            bool durum = true;

            string ad = "Gökhan";
            string soyad = "Mülayim";
            int dogumYili = 1997;
            long tcNo = 12345678910;

            Console.WriteLine(mesaj);

        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}
