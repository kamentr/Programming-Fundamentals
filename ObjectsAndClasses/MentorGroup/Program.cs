using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGroup
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<string> Comments { get; set; }
            public List<DateTime> Attendance { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();
            
            while (command!="end of dates") 
            {
                string[] comm = command.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Student student = new Student();
                student.Name = comm[0];
                student.Attendance = new List<DateTime>();
                for (int i = 1; i < comm.Length; i++)
                {
                    student.Attendance.Add(DateTime.ParseExact(comm[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                student.Comments = new List<string>();
                students.Add(student);
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command!="end of comments")
            {
                string[] comm = command.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = comm[0];
                foreach (var st in students)
                {
                    if(st.Name == name)
                    {
                        st.Comments.Add(comm[1]);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(Environment.NewLine);
            foreach (var st in students)
            {
                Console.WriteLine(st.Name);
                Console.WriteLine("Comments: ");

                foreach (var comm in st.Comments)
                {
                    Console.WriteLine(" - " + comm);
                }
                
                Console.WriteLine("Dates attended: ");
                foreach (var date in st.Attendance)
                {
                    Console.WriteLine($" -- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}
