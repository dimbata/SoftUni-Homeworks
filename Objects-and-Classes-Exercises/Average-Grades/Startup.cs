namespace Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            /*
             * Define a class Student, which holds the following information about students
             * : name, list of grades and average grade (calculated property, read-only). 
             * A single grade will be in range [2…6], e.g. 3.25 or 5.50.
             * Read a list of students and print the students 
             * that have average grade ≥ 5.00 ordered by name (ascending), 
             * then by average grade (descending). 
             * Print the student name and the calculated average grade.
             */

            int n = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var studentInfo = Console.ReadLine().Split(' ');

                var currentStudent = new Student()
                {
                    Name = studentInfo[0],
                    Grades = studentInfo.Skip(1).Select(double.Parse).ToList()                    
                };

                students.Add(currentStudent);
            }

            foreach (var student in students.Where(i => i.AverageGrade >= 5).OrderBy(i => i.Name).ThenByDescending(i => i.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}
