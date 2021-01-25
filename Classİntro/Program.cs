using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ayşegül";
            int yas = 20;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.İzlenmeOrani = 56;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.İzlenmeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.İzlenmeOrani = 60;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + ":  " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        //property = özellik
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
