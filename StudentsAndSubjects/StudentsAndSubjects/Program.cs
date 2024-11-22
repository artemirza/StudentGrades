using StudentsAndSubjects.Interfaces;

namespace StudentsAndSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudent studentService = new Student();
            ISubject subjectService = new Subject();

            var students = studentService.Fill();

            var subjects = subjectService.Fill();

            foreach (var student in students)
            {
                student.SetSubjects(subjects);
            }

            foreach(var student in students)
            {
                student.CalculateAverageGrade();
                student.SetGrant();
            }

            students[0].DisplayInfo();
            students[1].DisplayInfo();
        }
    }
}
