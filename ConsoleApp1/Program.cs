using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type Safety = Tip Güvenliği
            //Do Not Repeat Yourself = Kendini Tekrarlama
            // Alias = Değer Tutucu

            String kategoriEtiketi = "Kategoriler";
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.20;
            double dolarBugun = 7.75;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }



            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
        }
    }
}
