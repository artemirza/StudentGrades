using StudentsAndSubjects.enums;
using StudentsAndSubjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndSubjects
{
    public class Student: IStudent
    {
        public Guid Id { get; private set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public List<Subject> Subjects { get; set; }
        public double AverageGrade { get; private set; }
        public Grant Grant { get; private set; }

        public Student()
        {

        }

        private Student(string firstName, string secondName, int age)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }

        public List<Student> Fill()
        {
            return new List<Student>
            {
                new Student("Ivan", "Ivanov", 20),
                new Student ("Petro", "Petrov", 21),
                new Student ("Anna", "Anisimova", 22),
                new Student ("Maria", "Marinova", 19),
                new Student ("Oleg", "Olegov", 23),
            };
        }

        public void SetSubjects(List<Subject> subjects)
        {
            Subjects = subjects;
            foreach (var subject in Subjects)
            {
                subject.StudentId = Id; 
            }
        }

        public void CalculateAverageGrade()
        {
            AverageGrade = Subjects.Average(s => s.Grade);
        }

        public void SetGrant()
        {
            switch (AverageGrade)
            {
                case < 60:
                    Grant = Grant.None;
                    break;
                case >= 60 and < 90:
                    Grant = Grant.Regular; 
                    break;
                case >= 90:
                    Grant = Grant.Increased;
                    break;
                default:
                    break;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Second Name: {SecondName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Average Grade: {AverageGrade:F2}");
            Console.WriteLine($"Grant: {Grant}");
            Console.WriteLine("Grades:");
            foreach (var subject in Subjects)
            {
                Console.WriteLine($"  {subject.Name}: {subject.Grade} ({subject.Date.ToShortDateString()})");
            }
        }
    }
}
