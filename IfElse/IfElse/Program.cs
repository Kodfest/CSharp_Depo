using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 sayı alayım ve istediği işlemi soralım.
            // İsteğine göre işlem yapalım.

            double num1, num2, sonuc = 0;
            char islem;
            bool farklilik = false;

            Console.Write("Birinci Sayi \t: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci Sayi \t: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İşlem Türü Seçiniz (Toplama: t , Çıkarma: ç, Çarpma c, Bölme b) : ");
            islem = Convert.ToChar(Console.ReadLine());

            
            if (islem == 't' || islem == 'T')
            {
                sonuc = num1 + num2;
            }
            else if (islem == 'ç' || islem == 'Ç')
            {
                sonuc = num1 - num2;
            }
            else if (islem == 'b' || islem == 'B')
            {
                sonuc = num1 / num2;
            }
            else if (islem == 'c' || islem == 'C')
            {
                sonuc = num1 * num2;
            }
            else
            {
                farklilik = true;
            }

            // belirlenen işlem durumları dışında bir değer girme durumunu kontrol ediyoruz
            if (farklilik == true)
            {
                Console.WriteLine("Uygun olmayan bir şeçim yaptınız.");
            }
            else
            {
                Console.WriteLine("Sonuç: " + sonuc);
            }

            Console.ReadKey();
        }
    }
}
