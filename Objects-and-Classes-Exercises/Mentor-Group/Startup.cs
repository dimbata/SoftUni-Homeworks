namespace Mentor_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class Startup
    {
        public static void Main()
        {
            /*
             * You are mentor of a group. You have done your job well 
             * and now you have to generate a report about your group's activity. 
             * You will be given usernames and dates ("dd/MM/yyyy"), 
             * dates (if any) are separated with comma, until you receive command "end of dates". 
             * After that you will receive user and some comment (separated with dash). 
             * You can add comment for every user who is in your group (if not ignore the line).
             *  Adding comment/date to same user more than once should append to that user the comment/date. 
             *  Upon receiving command "end of comments" you should generate report in format:
                {user} -
                Comments:
                - {firstComment} …
                Dates attended:
                -- {firstDate}
                -- {secondDate}
                Users should be printed ordered by name (ascending). 
                For every user dates should be sorted again in ascending order. 
                Input will be valid for in the format described - you should not check it explicitly!
             */

            var studentInfoDictionary = new SortedDictionary<string, Student>();

            while (true)
            {
                var studentsWithDates = Console.ReadLine().Split(new char[] { ' ', ',' });

                if (studentsWithDates[0]=="end")
                {
                    break;
                }

                string studentName = studentsWithDates[0];

                if (!studentInfoDictionary.ContainsKey(studentName))
                {
                    studentInfoDictionary[studentName] = new Student();
                }

                if (studentsWithDates.Length > 1)
                {
                    foreach (var date in studentsWithDates.Skip(1))
                    {
                        studentInfoDictionary[studentName].Attendances.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }
            }

            while (true)
            {
                var studentsWithComments = Console.ReadLine().Split('-');
                string studentName = studentsWithComments[0];

                if (studentsWithComments[0]=="end of comments")
                {
                    break;
                }

                if (!studentInfoDictionary.ContainsKey(studentName))
                {
                    continue;
                }
                else
                {
                    studentInfoDictionary[studentName].Comments.AddRange(studentsWithComments.Skip(1));
                }
            }

            foreach (var kvp in studentInfoDictionary)
            {
                Console.WriteLine(kvp.Key);

                Console.WriteLine("Comments:");

                foreach (var comment in kvp.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");

                foreach (var attendances in kvp.Value.Attendances.OrderBy(i => i))
                {
                    Console.WriteLine($"-- {attendances.Day.ToString("00")}/{attendances.Month.ToString("00")}/{attendances.Year}");
                }
            }
        }
    }
}
