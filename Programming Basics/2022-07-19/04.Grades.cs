using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            double grade = 0;
            double totalGrade = 0;
            double Grade2 = 0;
            double Grade3 = 0;
            double Grade4 = 0;
            double Grade5 = 0;
            for (int i = 1; i <= numberOfStudents; i++)
            {
                grade = double.Parse(Console.ReadLine());
                totalGrade += grade;
                if (grade >= 5)
                {
                    Grade5++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    Grade4++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    Grade3++;
                }
                else if (grade < 3)
                {
                    Grade2++;
                }
            }
            double topStudents = Grade5 / numberOfStudents * 100;
            double Between4And5 = Grade4 / numberOfStudents * 100;
            double Between3And4 = Grade3 / numberOfStudents * 100;
            double Between2And3 = Grade2 / numberOfStudents * 100;
            double averageGrade = totalGrade / numberOfStudents;
            Console.WriteLine($"Top students: {topStudents:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {Between4And5:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {Between3And4:F2}%");
            Console.WriteLine($"Fail: {Between2And3:F2}%");
            Console.WriteLine($"Average: {averageGrade:F2}");
        }
    }
}
