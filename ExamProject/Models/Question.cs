using ExamProject.Enums;

namespace ExamProject.Models
{
    public class Question : BaseModel
    {
        public Question()
        {
            Choises = new HashSet<Choise>();
            Exams = new HashSet<Exam>();
        }

        public double Dgree { get; set; }

        public QuestionLevel Level { get; set; }

        public QuestionType Type { get; set; }

        // Navigation Property
        public virtual ICollection<Choise> Choises { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

    }
}
