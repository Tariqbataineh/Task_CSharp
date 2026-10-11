using System;

namespace Task3
{
    internal class Program
    {
        // ---------------- Part 1 ----------------

        static void GuessingGame()
        {
            int randNum = new Random().Next(50, 76);

            int attempt = 1;
            int points = 0;

            Console.WriteLine("===== Guessing Game =====");

            while (true)
            {
                Console.Write("Guess a number between 50 and 75: ");

                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randNum)
                {
                    Console.WriteLine("Congratulations!");

                    if (attempt == 1)  {  points = 10;  }

                    else if (attempt == 2)  {   points = 7; }

                    else if (attempt == 3)  { points = 5; }
               
                    else  { points = 0;}  break; }

                if (guess > randNum)  {     Console.WriteLine("Try a lower number."); }

                else     {       Console.WriteLine("Try a higher number.");   }        attempt++;  }

            Console.WriteLine("Attempts: " + attempt);
            Console.WriteLine("Points: " + points); }
        // ---------------- Part 2 ----------------

        static void PrintNamesAndGrades()
        {
            string[] names = {    "Ahmad",    "Sara",    "Omar",    "Lina",    "Yazan"};

            int[] grades =   {   85,   92,   68,   75,   90  };

            Console.WriteLine("\nStudents:");

            for (int i = 0; i < names.Length; i++)   {      Console.WriteLine(names[i]);  }

            Console.WriteLine("\nGrades:");

            foreach (int grade in grades)   {   Console.WriteLine(grade); }  }


        static void CheckStudentName()
        {
            string[] names =  {     "Ahmad",  "Sara",  "Omar",  "Lina",  "Yazan"  };

            Console.Write("Enter student name: ");

            string studentName = Console.ReadLine();

            int i = 0;
            bool found = false;

            while (i < names.Length)
            {
                if (studentName == names[i])
                {
                    Console.WriteLine("Student Found!");    found = true;    break; }
             i++;
            }

            if (found == false) {   Console.WriteLine("Student Not Found."); }  }


        static void CheckStudentResult()
        {
            Console.Write("Enter student grade: ");

            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 90 && grade <= 100) {  Console.WriteLine("Excellent");    }

            else if (grade >= 80)    {    Console.WriteLine("Very Good");  }

            else if (grade >= 70)   {   Console.WriteLine("Good");  }

            else if (grade >= 60){  Console.WriteLine("Pass"); }

            else   {  Console.WriteLine("Fail");  }
        }


        static void DisplayMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PrintNamesAndGrades();
                        break;

                    case 2:
                        CheckStudentName();
                        break;

                    case 3:
                        CheckStudentResult();
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 4);
        }


        static void Main(string[] args)
        {
            GuessingGame();

            Console.WriteLine("\n---------- Part 2 - School System ----------\n");

            DisplayMenu();
        }
    }
}