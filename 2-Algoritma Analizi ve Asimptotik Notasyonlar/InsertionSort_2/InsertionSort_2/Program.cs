using System;

namespace InsertionSort_2
{
    /*
     Ekleme Sıralamasının Zaman Karmaşıklığı:

      -> En iyi durum: O(n), Liste zaten sıralanmışsa.
      -> Ortalama durum: O(n^2), Liste rastgele sıralanmışsa.
      -> En kötü durum: O(n^2), Liste ters sıradaysa.

     Eklemeli Sıralamanın Uzay Karmaşıklığı:

      -> Yardımcı Alan: O(1), Ekleme sıralaması O(1) ek alan gerektirir.
      -> Bu da onu alan açısından verimli bir sıralama algoritması yapar.

     Eklemeli Sıralamanın Avantajları:

      -> Basit ve uygulaması kolaydır.
      -> Kararlı sıralama algoritmasıdır.
      -> Küçük listeler ve neredeyse sıralanmış listeler için etkilidir.
      -> Alan açısından verimlidir.
    */

    public class Program
    {
        // Insertion Sort algoritmasını uygulayan metot
        void sort(int[] arr)
        {
            int n = arr.Length; // Dizinin uzunluğu
            // Dizinin her elemanını sırayla ele al
            for (int i = 1; i < n; i++)
            {
                int key = arr[i]; // Sıralanacak anahtar eleman
                int j = i - 1;

                // Anahtar elemandan büyük olan tüm elemanları bir pozisyon öteye kaydır
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j]; // Büyük elemanı bir pozisyon öteye kaydır
                    j--; // Bir önceki elemana geç
                }
                arr[j + 1] = key; // Anahtar elemanı doğru konuma yerleştir
            }
        }

        // Diziyi ekrana yazdıran yardımcı metot
        static void printArray(int[] arr)
        {
            int n = arr.Length; // Dizinin uzunluğu
            // Dizinin her elemanını yazdır
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " | "); // Elemanı ve bir ayırıcıyı yazdır
                Console.WriteLine("\n"); // Yeni satıra geç
            }
        }

        // Programın giriş noktası
        static void Main(string[] args)
        {
            // Sıralanacak örnek dizi
            int[] arr = { 12, 11, 13, 5, 3, 4, 88, -1 };

            // Program sınıfından bir nesne oluştur
            Program ob = new Program();

            // Diziyi sıralamak için sort metodunu çağır
            ob.sort(arr);

            // Sıralanmış diziyi ekrana yazdırmak için printArray metodunu çağır
            Console.WriteLine("Sorted array:");
            printArray(arr);

            // Programın kapanmasını beklemek için bir tuşa basılmasını bekle
            Console.ReadKey();
        }
    }
}
