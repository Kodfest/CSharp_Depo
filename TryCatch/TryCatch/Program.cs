using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1
            //int[] array = new int[4];
            //Console.WriteLine(array[5]);
            /*
                dizinin 6. elemanı olmadığı için hata alacağız.
                
                Hata : IndexOutOfRangeException, dizi sınırlarının dışına çıktığımız için. 
            */
            #endregion

            #region Ornek2
            //try
            //{
            //    int[] array = new int[4];
            //    Console.WriteLine(array[5]);
            //}
            //// catch ile IndexOutOfRangeException yakalayıp hata messajını ekrana yazdırdık
            //catch (IndexOutOfRangeException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadKey();
            #endregion

            #region Ornek3
            //try
            //{
            //    // Bir sayı girilmesi bekliyoruz
            //    // Int.Parse metodu string bir ifadeyi int tipine dönüştürür
            //    int sayi = int.Parse(Console.ReadLine());
            //}
            //// Fortma hatası yakalıyoruz, örneğin a girilmesi
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //// int boyutundan daha büyük bir değer girildiğinde
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //// hata alınmasa bile her zaman çalışan kısım, işlem biterken gerekli işlemler veya servisler sonlandırılır
            //finally
            //{
            //    Console.WriteLine("Finally Kısmı çalıştı");
            //}
            //Console.ReadKey();
            #endregion

            #region Ornek4
            //try
            //{
            //    // Kendimizde FormatException oluşturabiliriz
            //    // aşağıdaki exception ları sırayla deneyebilirsiniz

            //    //throw new FormatException();
            //    //throw new IndexOutOfRangeException();
            //    //throw new ArgumentNullException();
            //}
            //// Exception ile herhangi bir hata durumu yakalanabilir
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
        }
    }
}
