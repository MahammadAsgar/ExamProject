using Exam.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrasturucture.Services.Abstractions
{
    public interface IExamService
    {
        Task PostExam(ClassExam entity);
        Task<IEnumerable<ClassExam>> Exams();
    }
}
