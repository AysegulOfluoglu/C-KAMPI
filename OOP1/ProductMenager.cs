using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductMenager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }
  //Void = Emir kipiyle işleme geçmesi (git ekle, git sil vs.)
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
    }
}