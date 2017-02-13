namespace Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StudentGroups
    {
        public static void Main()
        {
            List<Town> result = ReadTownsAndStudents();
            List<Group> finish = DistributeStudentsInGroups(result);

            Console.WriteLine("Created {0} groups in {1} towns:", finish.Count, result.Count);
        }

        public static List<Town> ReadTownsAndStudents()
        {
            List<Town> towns = new List<Town>();

            string inputLine = Console.ReadLine();
            while (inputLine != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    string[] parsedTownInput = inputLine.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] seats = parsedTownInput[1].Trim().Split();

                    Town town = new Town();
                    List<Student> students = new List<Student>();

                    string townName = parsedTownInput[0].Trim();
                    int seatCount = int.Parse(seats[0].Trim());

                    town.Name = townName;
                    town.SeatCount = seatCount;
                    town.Students = students;
                    towns.Add(town);
                }
                else
                {
                    Student student = new Student();
                    Town town = new Town();
                    town.Students = new List<Student>();
                    string[] parsedStudentInput = inputLine.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    string studentName = parsedStudentInput[0].Trim();
                    string studentEmail = parsedStudentInput[1].Trim();
                    DateTime studentRegistrationDateTime = DateTime.ParseExact(parsedStudentInput[2].Trim(), "d-MMM-yyyy",
                        CultureInfo.InvariantCulture);

                    student.Name = studentName;
                    student.Email = studentEmail;
                    student.RegistrationDate = studentRegistrationDateTime;

                    town.Students.Add(student);
                    towns[towns.Count - 1].Students.Add(student);
                }
                inputLine = Console.ReadLine();
            }
            return towns;
        }

        static List<Group> DistributeStudentsInGroups(List<Town> towns)
        {
            var town = new Town();
            town.Students = new List<Student>();
            var groups = new List<Group>();

            for (int i = 0; i < towns.Count; i++)
            {
                List<Student> students = towns[i].Students;

                students = towns[i].Students.OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name.Distinct())
                    .ThenBy(x => x.Email)
                    .ToList();

                while (students.Any())
                {
                    Group group = new Group();

                    group.Town = towns[i];
                    group.Students = students.Take(group.Town.SeatCount).ToList();
                    students = students.Skip(group.Town.SeatCount).ToList();
                    groups.Add(group);
                }
            }
            return groups;
        }
    }
}