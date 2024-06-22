using System;

namespace DataOrganization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İkili sayıları temsil eden dizimiz
            var binaryNumbers = new string[]
            {
                "00000000", // 0
                "00000001", // 1
                "00000010", // 2
                "00000011", // 3
                "00001011", // 1 + 2 + 8 = 11
                "10000000", // 128 (unsigned byte)  sbyte olsaydı işaret bitinden dolayı: -128
                "10000001", // 129 (unsigned byte) sbyte olsaydı işaret bitinden dolayı: -128 + 1 = -127
                "10000011"  // 131 (unsigned byte) sbyte olsaydı işaret bitinden dolayı: -128 + 3 = -125
            };

            // Bayt değerlerini yazdırmak için metodu çağır
            PrintByteValues(binaryNumbers);

            Console.WriteLine("-----------------------------------");

            // İmzalı bayt (sbyte) değerlerini yazdırmak için metodu çağır
            PrintSByteValues(binaryNumbers);

            Console.ReadKey();
        }

        // Bayt değerlerini yazdırmak için metot
        static void PrintByteValues(string[] binaryNumbers)
        {
            Console.WriteLine("Bayt Değerleri:");

            foreach (var binaryString in binaryNumbers)
            {
                // İkili sayıyı bayt değerine dönüştür
                byte convertedNumber = Convert.ToByte(binaryString, 2);
                Console.WriteLine($"{binaryString} -> {convertedNumber}");
            }
        }

        // İmzalı bayt (sbyte) değerlerini yazdırmak için metot
        static void PrintSByteValues(string[] binaryNumbers)
        {
            Console.WriteLine("İmzalı Bayt (SByte) Değerleri:");

            foreach (var binaryString in binaryNumbers)
            {
                // İkili sayıyı imzalı bayt değerine dönüştür
                sbyte convertedNumber = Convert.ToSByte(binaryString, 2);
                Console.WriteLine($"{binaryString} -> {convertedNumber}");
            }
        }
    }
}
