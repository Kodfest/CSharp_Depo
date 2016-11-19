using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
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
            Random random = new Random();
            int pozitif = 0, negatif = 0, sifir = 0;
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-100, 100);
            }

            foreach (var sayi in numbers)
            {
                Console.WriteLine(sayi);

                if (sayi > 0)
                {
                    pozitif++;
                }
                else if (sayi < 0)
                {
                    negatif++;
                }
                else
                {
                    sifir++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(" {0} Tane Pozitif var.", pozitif);
            Console.WriteLine(" {0} Tane Negatif var.", negatif);
            Console.WriteLine(" {0} Tane Sifir var.", sifir);

            Console.ReadKey();
            #endregion
        }
    }
}
