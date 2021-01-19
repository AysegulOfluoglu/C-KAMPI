using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ayşegül";
            musteri1.Soyad = "Ofluoğlu";
            musteri1.Id = 405594;
            musteri1.Yas = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Salih";
            musteri2.Soyad = "Malkoç";
            musteri2.Id = 405792;
            musteri2.Yas = 25;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Hasan";
            musteri3.Soyad = "Aksoy";
            musteri3.Id = 405122;
            musteri3.Yas = 30;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Yas);
            }
            MusteriMenager musteriMenager = new MusteriMenager();
            musteriMenager.Ekle(musteri1);
            musteriMenager.Ekle(musteri2);
            musteriMenager.Ekle(musteri3);

            musteriMenager.Listele(musteriler);

            musteriMenager.Sil(musteri1);
            musteriMenager.Sil(musteri2);
            musteriMenager.Sil(musteri3);
        } 
    }
}
