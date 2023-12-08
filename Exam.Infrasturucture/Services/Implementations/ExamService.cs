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
    public class ExamService : IExamService
    {
        readonly IGenericRepository<ClassExam> repository;
        readonly IUnitOfWork unitOfWork;
        public ExamService(IGenericRepository<ClassExam> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<ClassExam>> Exams()
        {
            var exams = await repository.GetAll().ToListAsync();
            return exams;
        }

        public async Task PostExam(ClassExam entity)
        {
            await repository.AddAsync(entity);
            await unitOfWork.CommitAsync();
        }
    }
}
