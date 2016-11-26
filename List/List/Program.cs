using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1
            //List<int> numbers = new List<int>();

            //numbers.Add(1);
            //numbers.AddRange(new int[] { 2, 3 });
            //Console.WriteLine(numbers.Count);
            //Console.WriteLine();

            ////numbers.Clear();
            ////Console.WriteLine(numbers.Count);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine("{0} = {1}", i, numbers[i]);
            //}

            //Console.ReadKey();
            #endregion

            #region Ornek2

            //int[] array = new int[2];
            //array[0] = 3;
            //array[1] = 5;

            //List<int> list = new List<int>(array);

            //Console.WriteLine("Boyut: " + list.Count);

            //Console.Write("Elemanlar: ");
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.ReadKey();

            #endregion

            #region Ornek3
            //List<int> numbers = new List<int>(new int[] { 1903, 1904, 1905, 1907 });

            //int index = numbers.IndexOf(1905);
            //Console.WriteLine(index);

            //index = numbers.IndexOf(1907);
            //Console.WriteLine(index);

            //Console.ReadKey();

            #endregion

            #region Ornek4
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(5);
            numbers.AddRange(new int[] { 8, 10, 13, 3, 8 });


            //numbers.RemoveAt(0); // girilen index silinir
            //numbers.Remove(8); // girilen değer listeden silinir, 1 den fazla ise ilk değer silinir
            //numbers.RemoveRange(3, 2); // aralık siler

            //bool varmi = numbers.Contains(15); // girilen değeri listede arar varsa true yoksa false döner

            //var result = numbers.Find(i => i > 5); // 5 den büyük ilk item döner
            //var result = numbers.FindAll(i => i > 5).ToList(); // 5 den büyük tüm item lar döner
            //var result = numbers.FindAll(i => i > 5).Count(); // 5 den büyük tüm elemanların sayısını döner

            //numbers.RemoveAll(i => i > 5); // 5 den büyük elemanları siler

            //numbers.Sort();
            //numbers.Reverse();
            //numbers.Clear();

            foreach (var item in numbers)
            {
                Console.WriteLine("\n\t" + item);
            }

            #region alfabe
            //List<char> alfabe = new List<char>();

            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    alfabe.Add(i);
            //}

            ////alfabe.Sort();
            //alfabe.Reverse();

            //foreach (var item in alfabe)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region isimler
            //List<string> isimler = new List<string>();

            //isimler.AddRange(new string[] { "Özgür", "Ali", "Vali", "Veli" });

            //isimler.Reverse();

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            
            #endregion
        }
    }
}
