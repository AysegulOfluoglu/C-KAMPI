using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";  //Ürün İsmi
            product1.UnitPrice = 500;       //Stok Fiyatı
            product1.UnitInStock = 3;       //Stok Adedi


            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
            };

   //PascalCase = İlk harf büyük    //camelCase = İlk harf küçük sonraki kelime büyük 
            ProductMenager productMenager = new ProductMenager();
            productMenager.Add(product1);
            Console.WriteLine(product1.ProductName);

        }
    }
}
