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
    public class StudentService : IStudentService
    {
        readonly IGenericRepository<Student> repository;
        readonly IUnitOfWork unitOfWork;
        public StudentService(IGenericRepository<Student> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Student>> GetStudents()
        {
            var students = await repository.GetAll().ToListAsync();
            return students;
        }

        public async Task<IEnumerable<Student>> GetStudentsByClass(decimal classNum)
        {
            var students = await repository.Where(x => x.ClassNumber == classNum).ToListAsync();
            return students;
        }

        public async Task PostStudent(Student entity)
        {
            await repository.AddAsync(entity);
            await unitOfWork.CommitAsync();
        }
    }
}
