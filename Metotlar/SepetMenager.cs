using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetMenager
    {
        //Naming Convention = İsimlendirme Kuralı
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : "  + urun.Adi);
        }

        public void Ekle2(string urunAdi, string acıklama, double fiyati, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
