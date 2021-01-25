using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // string urunAdi = "Elma";
            //double fiyati = 15;
            //string açiklama = "Amasya Elması";
            //string[] meyveler = new string[] { };


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Açiklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Açiklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Açiklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("-------------Metotlar-------------");
            //İnstance = örnek
            //encapsulation

            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);
            sepetMenager.Ekle(urun2);

            sepetMenager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetMenager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetMenager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}
//Metotlar bizim için tekrar tekrar kullanılabilirliği sağlayan kod viloglarıdır.
//Dont repeat yourself (Kendin Tekrar Etme)
//Best practice (En İyi Uygulama Teknikleri)
