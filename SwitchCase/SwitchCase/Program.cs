using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba, Lütfen yapmakistediğiniz işlemi Seçiniz...");
            //Console.WriteLine("1. Lira Yükleme");
            //Console.WriteLine("2. İnternet Paketi");
            //Console.WriteLine("3. Konuşma Paketi");

            //int secim = Convert.ToInt32(Console.ReadLine());

            //if (secim == 1)

            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine("Lira Yükleme Servisine Hoşgeldiniz");
            //        break;

            //    case 2:
            //        Console.WriteLine("İnternet Paketi Servisine Hoşgeldiniz");
            //        break;

            //    case 3:
            //        Console.WriteLine("Konuşma Paketi Servisine Hoşgeldiniz");
            //        break;

            //    default:
            //        Console.WriteLine("Müşteri Temsilcisine Yönlendiriliyorsunuz...");
            //        break;
            //}
            //Console.ReadKey();



            double sayi1, sayi2;
            char secim;

            sayi1 = Convert.ToDouble(Console.ReadLine());
            sayi2 = Convert.ToDouble(Console.ReadLine());

            bas:
            secim = Convert.ToChar(Console.ReadLine());

            switch (secim)
            {
                case '+':
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case '-':
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case '*':
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case '/':
                    Console.WriteLine(sayi1 / sayi2);
                    break;

                default:
                    Console.WriteLine("Yanlış Bir Seçim Yaptınız \nLütfen Yeniden Seçim Yapın");
                    goto bas; // Bilin ama kullanmayin :D
            }
            Console.ReadKey();
        }
    }
}
