using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndSubjects.enums;

namespace StudentsAndSubjects.Interfaces
{
    public interface IStudent
    {
        Guid Id { get; } 
        string FirstName { get; set; }
        string SecondName { get; set; } 
        int Age { get; set; } 
        List<Subject> Subjects { get; set; }
        double AverageGrade { get; } 
        Grant Grant { get; }

        void SetSubjects(List<Subject> subjects); 
        void CalculateAverageGrade(); 
        void SetGrant(); 
        void DisplayInfo();
    }
}
