using System;
namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 1 ==> Student Information
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Grade: ");
            int studentGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Average: ");
            double studentAverage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Student Gender: ");
            char studentGender = Convert.ToChar(Console.ReadLine());

            // part 2 ==> Student Report
            Console.WriteLine("----------Student Report ----------");
            Console.WriteLine($"Welcome {studentName}!");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Age: {studentAge}");
            Console.WriteLine($"Grade: {studentGrade}");
            Console.WriteLine($"Average: {studentAverage}");
            Console.WriteLine($"Gender: {studentGender}");

            // Part 3 ==> Student Name
            Console.WriteLine("-------------Name Information:------------");
            Console.WriteLine($"Original Name: {studentName}");
            Console.WriteLine($"Uppercase: {studentName.ToUpper()}");
            Console.WriteLine($"Lowercase: {studentName.ToLower()}");
            Console.WriteLine($"First Character: {studentName[0]}");

            // part 4 ==> Bonus Marks
            double newAverage = studentAverage + 5;

            Console.WriteLine("---------Student Calculation:----------");
            Console.WriteLine($"Original Average: {studentAverage}");
            Console.WriteLine("Bonus Marks: 5");
            Console.WriteLine($"New Average: {newAverage}");


            // part 5 ==> Student Status
            bool passed = newAverage >= 50;
            bool adult = studentAge >= 18;
            bool passedAndAdult = passed && adult;

            Console.WriteLine("---------Student Status--------");
            Console.WriteLine($"New Average: {newAverage}");
            Console.WriteLine($"Result: {(passed ? "Passed" : "Failed")}");
            Console.WriteLine($"Adult: {adult}");
            Console.WriteLine($"Passed and Adult: {passedAndAdult}");

        }
    }
}
