using System;

namespace InsertionSort
{
    public class Program
    {

        /*
         Insertion Sort'un çalışma prensibi,
        diziyi sıralamak için elemanları birer birer alıp,
        doğru konumlarına yerleştirmektir. Her adımda,
        dizinin sağ tarafındaki eleman, soldaki elemanlarla
        karşılaştırılır ve uygun konuma yerleştirilir.

        Zaman karmaşıklığı açısından, bu algoritmanın
        en iyi durumu O(n) (dizi zaten sıralı) ve en kötü durumu
        O(n^2) (dizi ters sıralı) olarak ölçülür. Ortalama durumda da 
        O(n^2) zaman karmaşıklığına sahiptir.
         */
        static void Main(string[] args)
        {





            // 10 elemanlı int türünde bir array tanımlıyoruz
            int[] numbers = new int[10] { 7, 23, 11, -45, 12, 13, 4, -2, 11, 45 };

            // Array'in orijinal halini yazdırıyoruz
            Console.WriteLine("\nOriginal Array Elements:");
            PrintIntegerArray(numbers);

            // Insertion Sort uygulanmış array'i yazdırıyoruz
            Console.WriteLine("\nSorted Array Elements:");
            PrintIntegerArray(InsertionSort(numbers));
            Console.WriteLine("-----------------------");
        }

        // Insertion Sort algoritması
        private static int[] InsertionSort(int[] inputArray)
        {
            // Diziyi tarıyoruz
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                // Bir önceki elemanla karşılaştırma yapmak için j döngüsü
                for (int j = i + 1; j > 0; j--)
                {
                    // Eğer bir önceki eleman, bir sonraki elemandan büyükse
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        // Elemanları yer değiştiriyoruz
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            // Sıralanmış diziyi döndürüyoruz
            return inputArray;
        }

        // Diziyi yazdırmak için method
        private static void PrintIntegerArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i.ToString() + " ");
            }

           

            Console.ReadKey();
        }
    }
}
