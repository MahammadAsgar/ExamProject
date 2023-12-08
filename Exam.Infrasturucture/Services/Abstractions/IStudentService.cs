using Exam.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrasturucture.Services.Abstractions
{
    public interface IStudentService
    {
        Task PostStudent(Student entity);
        Task<IEnumerable<Student>> GetStudents();
        Task<IEnumerable<Student>> GetStudentsByClass(decimal classNum);
    }
}
