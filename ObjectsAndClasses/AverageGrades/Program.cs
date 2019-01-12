using System;
using System.Linq;

namespace AverageGrades
{
    public class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                students[i] = new Student();
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                students[i].Name = name;
                students[i].Grades = new double[input.Length-1];
                for (int j = 1; j < input.Length; j++)
                {
                    
                    students[i].Grades[j - 1] = double.Parse(input[j]);
                }
                students[i].AverageGrade = students[i].Grades.Average();

                
            }
          
            foreach (var s in students.OrderBy(s => s.Name).OrderByDescending(s=>s.AverageGrade))
            {
                if (s.AverageGrade >= 5)
                {
                    Console.WriteLine($"{s.Name} -> {s.AverageGrade:F2}");
                }
            }
           
        }
    }
}
