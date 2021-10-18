using System;

namespace ObjectBigONotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student
            {
                Name = "Rasim",
                Surname = "Abbasov",
                Age = 25,
                IsMarried = false,
                Height = 175
            };

            //stu1.Fullinfo();

            Student stu2 = new Student()
            {
                Name = "Qasim",
                Surname = "Agayev",
                Age = 32,
                IsMarried = true
            };

            Student stu3 = new Student()
            {
                Name = "Tofiq",
                Surname = "Quliyev",
                Age = 18,
                IsMarried = false
            };

            //stu2.Fullinfo();

            Student[] students = { stu1, stu2, stu3 };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].Name + " - " + students[i].Height);
            }


        }
    }
}
