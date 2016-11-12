using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            //int counter = 10;

            //counter++; 
            //console.writeline(counter); //Ekrana 11 yazar

            //counter--;
            //console.writeline(counter); //Ekrana 10 yazar

            /* -------------------------------- */

            //int toplam = 0;

            //toplam += counter;  // toplam = toplam + counter; bu işlemin kısa halidir. Diğer işlem seçenekleri içinde geçerlidir.

            //toplam -= counter;
            //toplam *= counter;
            //toplam /= counter;


            //int sayi1 = 10, sayi2 = 20, sayi3 = 30;

            //Console.WriteLine("Sayı1: {0} Sayı2: {1} Sayı3: {2}", sayi1, sayi2, sayi3);

            //sayi1 += sayi2;
            //sayi1 += sayi3;
            //sayi3 += sayi1;

            //sayi3 /= 3;
            //sayi1 /= 2;
            //sayi1 -= sayi2;

            //Console.WriteLine("Sayı1: {0} Sayı2: {1} Sayı3: {2}", sayi1, sayi2, sayi3);
            //Console.ReadKey();

            /* -------------------------------- */

            //sayi1 = sayi3 % sayi2; // Mod işlemi, sayi3 ün sayi2 ye bölümünden kalanı verir

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girilen Sayı Çift sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Sayi Tek sayıdır.");
            //}

            //Console.ReadKey();

            int a = 5;
            int r1 = ++a; // Önce a 1 artar sonra r1 e atama yapar
            // 6 - 6
             a = 5;
             r1 = a++; // Önce r1 e atama yapar sonra a 1 artar
            // 6 - 5
            Console.WriteLine(a + " - " + r1);
            Console.ReadKey();
        }
    }
}
