using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        static List<string> studentList = new List<string> { "Nathan", "Mahmoud", "Lamond", "Mac", "Colton", "Ryan", "Umar", "Kris", "David", "Mitch", "Matt", "Aaron", "Keith" };
        static void Main(string[] args)
        {
            PickGroup(studentList, 4);
            Console.ReadKey();
        }
        /// <summary>
        /// Picks a groups at random from a list of students
        /// </summary>
        /// <param name="classOfstudents">List of students</param>
        /// <param name="groupSize">The size of a group</param>
        public static void PickGroup(List<string> studentList, int groupSize)
        {
            List<string> currentGroupList = new List<string> { };
            int groupNumber = 1;
            Random randomStudent = new Random();
            while (studentList.Count > 0)
            {
                string currentStudent = studentList[randomStudent.Next(0, studentList.Count)];
                currentGroupList.Add(currentStudent);
                studentList.Remove(currentStudent);
                if (currentGroupList.Count == groupSize || studentList.Count == 0)
                {
                    Console.WriteLine("Group {0}", groupNumber);
                    for (int i = 0; i < currentGroupList.Count; i++)
                    {
                        Console.WriteLine(currentGroupList[i]);
                    }
                    Console.WriteLine();
                    currentGroupList.RemoveRange(0, currentGroupList.Count);
                    groupNumber++;

                }
            }
        }
    }
}

