using System;

namespace SchoolManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 =  new Student("Ahmad", 20, "ABC School", 85, 1);

            Student student2 =   new Student("Sara", 21, "ABC School", 92, 2);

            Teacher teacher1 =   new Teacher("Omar", 35, "ABC School", "Math");


            Console.WriteLine("Student 1");
            student1.DisplayInfo();
            student1.DisplayStudentInfo();

            Console.WriteLine();

            Console.WriteLine("Student 2");
            student2.DisplayInfo();
            student2.DisplayStudentInfo();

            Console.WriteLine();

            Console.WriteLine("Teacher");
            teacher1.DisplayTeacherInfo();

            Console.WriteLine();

            SchoolReport report =   new SchoolReport("School Report");

            report.DisplayReportTitle();


         
        }
    }
}