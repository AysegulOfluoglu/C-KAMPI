using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array = Dizi
            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya BAşlangıç İçin Temel Kurs";
            //string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" ,
                "Programlamaya BAşlangıç İçin Temel Kurs" ,
                "Java" , "Python" , "C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
