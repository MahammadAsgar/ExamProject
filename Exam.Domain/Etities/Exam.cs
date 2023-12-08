using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Etities
{
    public class ClassExam
    {
        public int Id { get; set; }
        [ForeignKey("LessonCode")]
        public string LessonCode { get; set; }
        [ForeignKey("Number")]
        public decimal StudentNumber { get; set; }
        public DateTime DateOfExam { get; set; }
        public decimal Result { get; set; }
    }
}
