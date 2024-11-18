using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models
{
    public class QuestionChoise
    {
        public int QuestionId { get; set; }
        public int ChoiseId { get; set; }

        // Navigation Property

        [ForeignKey(nameof(QuestionId))]
        public virtual Question Question { get; set; }

        [ForeignKey(nameof(ChoiseId))]
        public virtual Choise Choise { get; set; }
    }
}
