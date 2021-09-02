using System;

namespace consoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] courses = new string[]
                {
                    "C++", "C#", "JAVA", "Ruby"
                };
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("the end of the for loop");

            foreach (string kurs in courses)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("the end of the code");
        }
    }
}
