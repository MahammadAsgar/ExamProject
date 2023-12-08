using Exam.Application.Repositories;
using Exam.Application.UnitOfWorks;
using Exam.Domain.Etities;
using Exam.Infrasturucture.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrasturucture.Services.Implementations
{
    public class LessonService : ILessonService
    {
        readonly IGenericRepository<Lesson> repository;
        readonly IUnitOfWork unitOfWork;
        public LessonService(IGenericRepository<Lesson> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Lesson>> GetLessons()
        {
            var lessons = await repository.GetAll().ToListAsync();
            return lessons;
        }

        public async Task<IEnumerable<Lesson>> GetLessonsByClass(decimal classNum)
        {
            var lessons = await repository.Where(x => x.ClassNumber == classNum).ToListAsync();
            return lessons;
        }

        public async Task PostLesson(Lesson entity)
        {
            await repository.AddAsync(entity);
            await unitOfWork.CommitAsync();
        }
    }
}
