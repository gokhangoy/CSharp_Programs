using System;

namespace Class_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Engin Demirog";
            course1.NumberOfViews = 68;


            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Instructor = "Gokhan Goy";
            course2.NumberOfViews = 64;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Instructor = "Nihat Baz";
            course3.NumberOfViews = 80;

            //Console.WriteLine(course1.CourseName + ":" + course1.Instructor);

            Course[] courses = new Course[] { course1,course2,course3};

            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Instructor);
            }
        }
    }


    class Course  
    {
        
        public string CourseName { get; set; }

        public string Instructor { get; set; }

        public int NumberOfViews { get; set; }



    }
}
