using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTıpler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int decimal float double bool =DEĞER TİP
            // stack : sayi1=10  sayi2=30 (sayi2 değeri 30 diye okunur. sayi1=sayi2 olunca sayi1(10) değeri sayi2(30) değerine döner ve bütün irtibatı kopar)
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 =30

            // array class interface = REFERANS TiP
            //Heap =
            int[] sayilar1 =new int[] {10,20,30 };
            int[] sayilar2 =new int[] {100,200,300 };
            sayilar1= sayilar2;
            sayilar2[0] = 999;
            //sayilar[0]=999








            //https://www.youtube.com/watch?v=1j68gb1-qOw&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=4 2.28.00-
        }
    }
}
