using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models
{
    public class ExamQuestion
    {
        public int QuestionId { get; set; }
        public int ExamId { get; set; }

        // Navigation Property

        [ForeignKey(nameof(QuestionId))]
        public virtual Question Question { get; set; }

        [ForeignKey(nameof(ExamId))]
        public virtual Exam Exam { get; set; }
    }
}
