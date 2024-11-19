namespace StudentsAndSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = Student.Fill();

            var subjects = Subject.Fill();

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
        }
    }
}
