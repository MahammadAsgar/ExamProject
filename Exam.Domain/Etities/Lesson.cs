using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Etities
{
    public  class Lesson
    {
        public string LessonCode { get; set; }
        public string Title { get; set; }
        public decimal ClassNumber { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
    }
}
