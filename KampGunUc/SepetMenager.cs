using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampGunUc
{
     class SepetMenager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi"+ product.Adi);
        }
        
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi"+ urunAdi);
        }
    }
}
