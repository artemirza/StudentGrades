using StudentsAndSubjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndSubjects
{
    public class Subject: ISubject
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public Guid StudentId { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }

        private Subject(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            StudentId = Guid.Empty;
            Grade = new Random().Next(40, 100);
            Date = DateTime.Now;
        }

        public static List<Subject> Fill()
        {

            return new List<Subject> 
            {
                new Subject("Math"),
                new Subject("Physics"),
                new Subject("History"),
                new Subject("Geography"),
                new Subject("Chemistry"),
                new Subject("Music")
            };

        }

        public static Subject GetByStudentId(List<Subject> subjects, Guid studentId)
        {
            return subjects.Where(x => x.StudentId == studentId).FirstOrDefault();
        }
    }
}
