using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Algoritma
            /*
            Belirli bir problemi çözen veya amacı gerçekleştiren yöntemlere algoritma denir.
            
            Bir algoritmanın temel özellikleri:
            * Başlangıcı ve sonu olmalı
            * Adım adım ilerlemeli
            * Basit ve anlaşılır olmalı

            Faktöriyel Hesaplama
            Adım 1. Başla
            Adım 2. sayi Gir
            Adım 3. sayac = 1 fakto = 1
            Adım 4. fakto = fakto * sayac
            Adım 5. sayac++
            Adım 6. sayac <= sayi ise 4. adıma dön değilse 7. adıma git
            Adım 7. fakto yu yazdır.
            Adım 8. Bitir
            */
            #endregion

            #region islemSec

            //bool durum = true;
            //char islem;

            //while (durum)
            //{
            //    Console.WriteLine("Dört işlemden birini seçiniz: (+,-,*,/)");
            //    islem = Convert.ToChar(Console.ReadLine());

            //    Console.WriteLine();

            //    #region switchcase
            //    switch (islem)
            //    {
            //        case '+':
            //            for (int i = 0; i <= 4; i++)
            //            {
            //                for (int j = 0; j <= 4; j++)
            //                {
            //                    if (i == 2)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else if (i != 2 && j == 2)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else
            //                    {
            //                        Console.Write(" ");
            //                    }
            //                }
            //                Console.WriteLine();
            //            }
            //            break;

            //        case '-':
            //            for (int i = 0; i <= 4; i++)
            //            {
            //                for (int j = 0; j <= 4; j++)
            //                {
            //                    if (i == 2)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else
            //                    {
            //                        Console.Write(" ");
            //                    }
            //                }
            //                Console.WriteLine();
            //            }
            //            break;

            //        case '*':
            //            for (int i = 0; i <= 4; i++)
            //            {
            //                for (int j = 0; j <= 4; j++)
            //                {
            //                    if (i == j)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else if (j + i == 4)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else
            //                    {
            //                        Console.Write(" ");
            //                    }
            //                }
            //                Console.WriteLine();
            //            }
            //            break;

            //        case '/':
            //            for (int i = 0; i <= 4; i++)
            //            {
            //                for (int j = 0; j <= 4; j++)
            //                {
            //                    if (i == 2)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else if ((i == 1 || i == 3) && j == 2)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else
            //                    {
            //                        Console.Write(" ");
            //                    }
            //                }
            //                Console.WriteLine();
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Yanlış Bir Seçim Yaptınız.");
            //            break;
            //    }
            //    #endregion

            //    #region DevamEtmekSorgusu
            //    Console.WriteLine("\nDevam edelim mi? İstiyorsan \"evet\" yaz.");
            //    string devam = Console.ReadLine();

            //    if (devam == "evet")
            //    {
            //        durum = true;
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        durum = false; ;
            //        Console.WriteLine("Tekrar Görüşmek üzere :)");
            //    }
            //    #endregion

            //}
            //Console.ReadKey();

            #endregion

            #region UsAlma

            Console.Write("Taban Değerini Girin:");
            int taban = Convert.ToInt32(Console.ReadLine());
            int us = 0;
            int sonuc = 1;

            bool durum = true;
            while (durum)
            {
                Console.Write("Us Değerini Girin:");
                us = Convert.ToInt32(Console.ReadLine());

                if (us <= 0)
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                }
            }

            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }

            Console.WriteLine("{0}^{1} = {2}", taban, us, sonuc);

            Console.ReadKey();

            #endregion
        }
    }
}
