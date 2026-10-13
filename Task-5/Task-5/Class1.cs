using System;

namespace SchoolManagementSystem
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected string SchoolName { get; set; }

        private string _internalCode = "123";

        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }


    class Student : Person
    {
        public int Grade { get; set; }
        public int StudentId { get; set; }

        public Student(string name, int age, string schoolName, int grade, int studentId)
            : base(name, age, schoolName)
        {
            Grade = grade;
            StudentId = studentId;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("School: " + SchoolName);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("Student ID: " + StudentId);
        }
    }


    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string schoolName, string subject)
            : base(name, age, schoolName)
        {
            Subject = subject;
        }

        public void DisplayTeacherInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Subject: " + Subject);
        }
    }


    sealed class SchoolReport
    {
        public string ReportTitle { get; set; }

        public SchoolReport(string title)
        {
            ReportTitle = title;
        }

        public void DisplayReportTitle()
        {
            Console.WriteLine("Report: " + ReportTitle);
        }
    }
}