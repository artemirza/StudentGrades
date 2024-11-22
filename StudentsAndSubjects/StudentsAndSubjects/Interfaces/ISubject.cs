using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndSubjects.Interfaces
{
    public interface ISubject
    {
        Guid Id { get; } 
        string Name { get; set; } 
        Guid StudentId { get; set; }
        int Grade { get; set; } 
        DateTime Date { get; set; }

        public List<Subject> Fill();
        public Subject GetByStudentId(List<Subject> subjects, Guid studentId);

    }
}
