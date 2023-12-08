using Exam.Domain.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrasturucture.Services.Abstractions
{
    public interface ILessonService
    {
        Task PostLesson(Lesson entity);
        Task<IEnumerable<Lesson>> GetLessonsByClass(decimal classNum);
        Task<IEnumerable<Lesson>> GetLessons();
    }
}
