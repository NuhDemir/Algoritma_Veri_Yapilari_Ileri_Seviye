using System;

namespace DataOrganization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte türü pozitif değerler taşır
            byte num1 = 8; // 1 1 1 1 1 1 1 1
            // sbyte türü işaretli bir veri yapısıdır, pozitif ve negatif değerler taşır
            sbyte num2 = -8;

            // Byte türü için minimum ve maksimum değerleri yazdır
            Console.WriteLine("Byte min: {0} | Byte max: {1}", byte.MinValue, byte.MaxValue);
            // Sonuç: Byte min: 0 255 (0 ile 255 arasında değer alabilir)

            //1 0 0 0 0 0 0 0  -> -128
            //0 1 1 1 1 1 1 1  -> 127

            // SByte türü için minimum ve maksimum değerleri yazdır
            Console.WriteLine("SByte min: {0} | SByte max: {1}", sbyte.MinValue, sbyte.MaxValue);
            // Sonuç: SByte min: -128 127 (-128 ile 127 arasında değer alabilir)

            Console.ReadKey();
        }
    }
}
