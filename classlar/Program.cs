using System;

namespace classlar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.NameOFCourse = "c++";
            course1.Instructor = "No Name Voman";
            course1.Views = 100;

            Course course2 = new Course();
            course2.NameOFCourse = "c#";
            course2.Instructor = "No Name Man";
            course2.Views = 100;

            Course course3 = new Course();
            course3.NameOFCourse = "java";
            course3.Instructor = "No Name Voman";
            course3.Views = 100;

            Course course4 = new Course();
            course4.NameOFCourse = "ruby";
            course4.Instructor = "No Name Man";
            course4.Views = 100;


            Course[] courses = new Course[] { course1, course2, course3, course4 };
            foreach (Course course in courses)
            {
                Console.WriteLine(course.NameOFCourse + " : " + course.Instructor);
            }

        }
    }

    class Course
    {
        public string NameOFCourse{ get; set; }
        public string Instructor { get; set; }
        public int Views { get; set; }
    }
}
