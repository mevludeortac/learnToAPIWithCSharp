using System;

namespace ValueTypeAndReferenceType
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //value type
            int number1 = 10;
            int number2 = 45;
            number1 = number2;    //number1'ın burdaki değeri number1 için son değerdir, bi sonraki satırda gerçekleşen number2 değişikliği number1'i etkilemez. Yani sonuç 45'tir.
            number2 = 67;
            Console.WriteLine(number1);

            //reference type
            int[] evenNumbers = new int[] { 0, 2, 4, 6, 8 };
            int[] oddNumbers = new int[] { 1, 3, 5, 7, 9 };
            evenNumbers = oddNumbers; //oddNumber'ı referans aldığı için oddNumber'ın [0] elemanın değeri neyse evenNumber'ın [0] elemanının değeri de o'dur. Yani cevap 90.
            oddNumbers[0] = 90;
            Console.WriteLine(evenNumbers[0]);

        }
    }
}
