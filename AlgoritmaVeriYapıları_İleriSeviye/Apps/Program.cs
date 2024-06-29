using System;
using System.Collections;

namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            ////Array
            ////sabit boyutlu olduğu için ekleme silme güncelleme işlemi yapamıyoruz
            //var arrChar = new char[] { 'A', 'B', 'C' };

            ////ArrayList - Tip güvenliğini kaybedyoruz hem int hem string değerde tutar

            //var arrObj = new ArrayList();

            //arrObj.Add(19);
            //arrObj.Add('A');


            //var toplam = ((int)arrObj[0] + 11);
            //Console.WriteLine(toplam);

            //var arrInt = Array.CreateInstance(typeof(int), 5);

            //arrInt.SetValue(10, 0);
            //arrInt.SetValue(20, 0);
            //arrInt.SetValue(30, 0);
            //arrInt.GetValue(0);
            //arrInt.GetValue(1);
            #endregion

            var p1 = new DataStructures.Arrays.Array<int>(1, 2, 3, 4);
            var p2 = new int[] { 8, 9, 10, 11 };
            var p3 = new List<int>() { 5, 15, 20, 25 };
            var p4 = new ArrayList() { 12, 13, 14, 15 };



            var arr = new DataStructures
                .Arrays
                .Array<int>(p1);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }


            //Ekleme-Arama-Silme
            #region
            //arr.Add(123);
            //arr.Add(55);
            //arr.Add(22);
            //arr.Add(321);
            //arr.Add(43);

            //arr.Add(1);
            //arr.Remove();
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //arr.Where(x=>x%2==0)
            //  .ToList()
            //  .ForEach(x => Console.WriteLine(x));


            //  Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            #endregion 
            Console.ReadKey();
        }
    }
}
