using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Geliştirici Geliştirme Kampı"; 
            string kurs2 = "Programlamaya baslangic icin temek kurs"; 
            string kurs3 = "Java";
            string kurs4 = "Python";

            //array
            //Array declaration  
            string[] courses = new string[] { "Yazilim Geliştirici Geliştirme Kampı", 
                                              "Programlamaya baslangic icin temek kurs",
                                              "Java",
                                              "Python"};


            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            foreach (string kurs in courses)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("End of the page");
        }
    }
}
