using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [1,n]arasi_sayilarin_Toplami
            //int n = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;

            //int counter = 1;
            //while (counter <= n)
            //{
            //    toplam += counter;
            //    counter++;

            //    Console.WriteLine("Toplam: {0} Counter: {1}", toplam, counter);
            //}

            //Console.WriteLine("\nGenel Toplam: {0}", toplam);
            //Console.ReadKey();
            #endregion

            #region TahminOyunu
            //Console.WriteLine("[1-10] aralığında bir sayı tuttum. \nHadi Bil Bakalım.\n");

            //Random rnd = new Random(); //Rasgele sayi ürettirmek için
            //int sayi = rnd.Next(1, 11); // [1-10] aralığında
            //int tahmin;

            //int counter = 0;
            //while (true)
            //{
            //    counter++;
            //    Console.Write("\nTahminin Nedir: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == sayi)
            //    {
            //        break;
            //    }
            //    else if (tahmin < sayi)
            //    {
            //        Console.WriteLine("Tahmini Büyüt");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tahmini Küçült");
            //    }
            //}

            //Console.WriteLine("\nTabrikler... {0}.denemende buldun.", counter);
            //Console.ReadKey();
            #endregion

            #region Kullanici_Devam_Etmek_Isredigi_Surece_Islem_Yap
            int sayi1, sayi2;
            char secim;
            bool durum = true;

            while (durum == true)
            {
                sayi1 = Convert.ToInt32(Console.ReadLine());
                sayi2 = Convert.ToInt32(Console.ReadLine());
                secim = Convert.ToChar(Console.ReadLine());

                switch (secim)
                {
                    case '+':
                        Console.WriteLine("Toplam: {0}", sayi1 + sayi2);
                        break;

                    case '-':
                        Console.WriteLine("Fark: {0}", sayi1 - sayi2);
                        break;

                    case '*':
                        Console.WriteLine("Çarpım: {0}", sayi1 * sayi2);
                        break;

                    case '/':
                        Console.WriteLine("Bölüm: {0}", sayi1 / sayi2);
                        break;

                    default:
                        Console.WriteLine("Böyle Bir İşlem Yok!");
                        break;
                }

                Console.Write("Devam Etmek İstiyor Musun? (evet)");
                string devam = Console.ReadLine();

                if (devam == "evet")
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                }
            }
            Console.ReadKey();
            #endregion

            #region FaktoriyelHesaplama
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 1, fakto = 1;


            //while (sayac <= sayi)
            //{
            //    fakto *= sayac;
            //    sayac++;
            //}

            //Console.WriteLine("{0}! = {1}", sayi, fakto);
            //Console.ReadKey();
            #endregion

            #region TabanDonusturme_10tabanindan2tabanina
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;
            //int basamak = 1;

            //while (sayi > 0)
            //{
            //    sonuc += (sayi % 2) * basamak;
            //    basamak *= 10;
            //    sayi /= 2;
            //}
            //Console.WriteLine(sonuc);
            //Console.ReadKey();
            #endregion
        }
    }
}
