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

            var arr = new DataStructures.Arrays.Array<int>();
            arr.Add(123);
            arr.Add(55);
            arr.Add(22);
            arr.Add(321);
            arr.Add(43);
            arr.Add(1);
            arr.Remove();
            Console.WriteLine($"{arr.Count} / {arr.Capacity}");
            Console.ReadKey();
        }
    }
}
 