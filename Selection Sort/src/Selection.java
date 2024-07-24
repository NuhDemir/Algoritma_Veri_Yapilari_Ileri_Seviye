public class Selection {
    // minIndex metodu, belirtilen başlangıç (start) ve bitiş (end) indeksleri arasında
    // en küçük elemanın indeksini bulur ve geri döner.
    int minIndex(int Array[], int start, int end) {
        int minIndex = start; // En küçük elemanın başlangıçta start indeksinde olduğunu varsayarız
        for (int i = start + 1; i < end; i++) { // start+1'den end'e kadar döngü
            if (Array[i] < Array[minIndex]) { // Eğer Array[i] değeri Array[minIndex] değerinden küçükse
                minIndex = i; // minIndex'i i olarak güncelleriz
            }
        }
        return minIndex; // Bulunan en küçük elemanın indeksini geri döneriz
    }

    // sorting metodu, selection sort algoritmasını kullanarak diziyi sıralar
    int[] sorting(int Array[], int length) {
        // Dizinin uzunluğu -1 kadar döngü
        for (int i = 0; i < length - 1; i++) {
            int minI = minIndex(Array, i, length); // i'den length'e kadar en küçük elemanın indeksini bulur
            int temp = Array[minI]; // En küçük elemanı geçici değişkene alır
            Array[minI] = Array[i]; // En küçük elemanı i indeksine yerleştirir
            Array[i] = temp; // Geçici değişkendeki değeri minI indeksine yerleştirir
        }
        return Array; // Sıralanmış diziyi geri döneriz
    }

    public static void main(String[] args) {
        int Array[] = {1, 2, 3, 4, 5, 6, 7, 8}; // Sıralanacak dizi
        Selection selection1 = new Selection(); // Selection sınıfından bir nesne oluştururuz
        long startTime = System.nanoTime(); // Başlangıç zamanını nanoyani cinsinden alırız
        int sortedArray[] = selection1.sorting(Array, 8); // Diziyi sıralarız
        long endTime = System.nanoTime(); // Bitiş zamanını nanoyani cinsinden alırız

        // Sıralanmış diziyi ekrana yazdırırız
        for (int i = 0; i < 8; i++) {
            System.out.println(sortedArray[i]); // Her bir elemanı yazdırırız
        }

        // Algoritmanın toplam çalışma süresini ekrana yazdırırız
        System.out.println("Toplam süre: " + (endTime - startTime) + " ns");
    }
}
