using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("{0}. adım",i);
            //}
            //Console.ReadKey();

            //bool durum = true;
            //for (int i = 0; durum == true && i < 100; i = i + 5)
            //{
            //    if (i * 2 > 20)
            //    {
            //        durum = false;
            //    }

            //    Console.WriteLine("{0} iken devam ediyorum", i);
            //}
            //Console.ReadKey();


            //for (int i = 0; i < 100; i = i + 5)
            //{
            //    if (i * 2 < 20)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine("{0} iken devam ediyorum", i);
            //}
            //Console.ReadKey();

            #region [1,n]arasi_sayilarin_Toplami

            //int n = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    toplam += i;
            //    Console.WriteLine("Counter: {0} \tToplam: {1}", i, toplam);
            //}

            //Console.WriteLine("\nGenel Toplam: {0}", toplam);

            //Console.ReadKey();

            #endregion

            #region FaktoriyelHesaplama

            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int fakto = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    fakto *= i;
            //}

            //Console.WriteLine("{0}! = {1}", sayi, fakto);

            //Console.ReadKey();

            #endregion

            #region Harfler

            //char c;
            //Console.Write("\nHarfler: ");

            //for (c = 'a'; c <= 'z'; c++)
            //{
            //    Console.Write(c + " ");
            //}

            //Console.ReadKey();

            #endregion

            #region CiftSayilar

            //int toplam = 0;

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.Write(i + " ");
            //        toplam += i;
            //    }
            //}

            //Console.WriteLine("\n\nToplam = {0}", toplam);

            //Console.ReadKey();

            #endregion

            #region IcIceFor

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #endregion

            #region CarpimTablosu

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1}\t= {2}", i, j, i * j);
                }
                Console.WriteLine("------------");
            }
            Console.ReadKey();

            #endregion
        }
    }
}
