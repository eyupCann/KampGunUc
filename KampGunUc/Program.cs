using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampGunUc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 20;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var x in products)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("-------------------------------------------");
            }
            Console.WriteLine("----------Metotlar------------");

            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(product1);
            sepetMenager.Ekle(product2);


            sepetMenager.Ekle2("Armut", "Yeşil armut", 12);
            sepetMenager.Ekle2("Elma", "Yeşil elma", 15);
            sepetMenager.Ekle2("Karpuz", "Diyarbakır karpuzu", 18);




            Console.ReadKey();


        }
    }
}
