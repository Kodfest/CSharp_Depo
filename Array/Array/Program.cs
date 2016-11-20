using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static int Bul(string _gun, string[] dizi)
        {
            int index = -1;

            for (int i = 0; i < dizi.Length; i++)
            {

                if (dizi[i] == _gun)
                {
                    index = i;
                }
            }

            return index;
        }

        static void Main(string[] args)
        {
            #region arrayOrnek
            //int[] array = new int[3];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //Console.ReadKey();
            #endregion

            #region arrayOrnek2
            //Console.Write("Sınıf Mevcudunu Girin: ");
            //int mevcut = Convert.ToInt32(Console.ReadLine());
            //string[] ogrenciler = new string[mevcut];

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.Write("{0}. öğrencini ismini girin: ", i);
            //    ogrenciler[i] = Console.ReadLine();
            //}

            //Console.Clear();

            //Console.WriteLine("Öğrenciler Listesi\n");
            //foreach (var item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            #endregion

            #region arrayOrnek3
            //Random random = new Random();
            //int pozitif = 0, negatif = 0, sifir = 0;
            //int[] numbers = new int[10];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(-100, 100);
            //}

            //foreach (var sayi in numbers)
            //{
            //    Console.WriteLine(sayi);

            //    if (sayi > 0)
            //    {
            //        pozitif++;
            //    }
            //    else if (sayi < 0)
            //    {
            //        negatif++;
            //    }
            //    else
            //    {
            //        sifir++;
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine(" {0} Tane Pozitif var.", pozitif);
            //Console.WriteLine(" {0} Tane Negatif var.", negatif);
            //Console.WriteLine(" {0} Tane Sifir var.", sifir);

            //Console.ReadKey();
            #endregion

            #region arrayOrnek4
            //string[] gunler = new string[7] { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };

            //bool devam = true;
            //while (devam)
            //{
            //    Console.Write("Kaçıncı Gün: ");
            //    byte gun = Convert.ToByte(Console.ReadLine());

            //    if (gun <= 7 && gun >= 1)
            //    {
            //        Console.WriteLine(gunler[gun - 1]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bir Haftada 7 Gün vardır.");
            //    }

            //    Console.WriteLine("Devam etmek istiyorsan \"e\" tuşuna bas");
            //    char c = Convert.ToChar(Console.ReadLine());

            //    if (c == 'e')
            //    {
            //        devam = true;
            //        Console.Clear();
            //    }
            //    else
            //    {
            //        devam = false;
            //    }
            //}
            #endregion

            #region BirOncekininTamTersi
            //string[] gunler = new string[7] { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };

            //Console.Write("Hangi Gün: ");

            //string gun = Convert.ToString(Console.ReadLine());

            //int gelenDeger = Bul(gun, gunler);

            //Console.WriteLine("{0} gün haftanın {1} . günüdür", gun, gelenDeger + 1);

            //Console.ReadKey();
            #endregion

            #region 2BoyutluDizi
            //int[,] sinavlar = new int[2, 3];
            //sinavlar[0, 0] = 1;
            //sinavlar[1, 0] = 20;
            //sinavlar[0, 1] = 2;
            //sinavlar[1, 1] = 30;
            //sinavlar[0, 2] = 3;
            //sinavlar[1, 2] = 40;

            ////for (int i = 0; i < 3; i++)
            ////{
            ////    Console.WriteLine(sinavlar[0, i] + " - " + sinavlar[1, i]);
            ////}


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(sinavlar[i,j]);
            //    }
            //}

            //Console.ReadKey();
            #endregion
        }
    }
}
