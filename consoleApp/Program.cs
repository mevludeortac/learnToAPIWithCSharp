using System;

namespace consoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] kurslar = new string[]
                {
                    "C++", "C#", "JAVA", "Ruby"
                };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for döngüsü sona erdi");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("the end of the code");
        }
    }
}
