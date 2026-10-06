using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Sami Ali";
            int Age = 20;
            int Grade = 12;
            double Average = 85.5;
            char Gender = 'M';
            bool Active = true;
            Console.WriteLine(" udent Information  Part 1");
            Console.WriteLine("Name :"+Name);
            Console.WriteLine("Age:"+Age);
            Console.WriteLine("Grade :"+Grade);
            Console.WriteLine("Avg :"+Average);
            Console.WriteLine("Char: "+ Gender);
            Console.WriteLine("Active :"+Active);

            Console.WriteLine("Students  Part 2 ");

            string[] stud = { "Ahmad", "Sare", "Omar", "Lina" };

            Console.WriteLine("Student 1 :"  + stud[0]);
            Console.WriteLine("Student 2 :" + stud[1]);
            Console.WriteLine("Student 3 :" + stud[2]);
            Console.WriteLine("Student 4 :" + stud[3]);
            Console.WriteLine("Number of Students  : " + stud.Length);


            Console.WriteLine("fter Change ");
            stud[2] = "khaled";
            stud[3] = "Lina";
            Console.WriteLine("Student 3" + stud[2]);
            Console.WriteLine("Student 4" + stud[3]);
        }
    }
}
