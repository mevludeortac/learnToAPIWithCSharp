using System;

namespace classlar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.NameOFCourse = "c++";
            kurs1.Instructor = "No Name Voman";
            kurs1.Views = 100;

            Kurs kurs2 = new Kurs();
            kurs2.NameOFCourse = "c#";
            kurs2.Instructor = "No Name Man";
            kurs2.Views = 100;
        
            Kurs kurs3 = new Kurs();
            kurs3.NameOFCourse = "java";
            kurs3.Instructor = "No Name Voman";
            kurs3.Views = 100;

            Kurs kurs4 = new Kurs();
            kurs4.NameOFCourse = "ruby";
            kurs4.Instructor = "No Name Man";
            kurs4.Views = 100;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.NameOFCourse + " : " + kurs.Instructor);
            }

        }
    }

    class Kurs
    {
        public string NameOFCourse{ get; set; }
        public string Instructor { get; set; }
        public int Views { get; set; }
    }
}
