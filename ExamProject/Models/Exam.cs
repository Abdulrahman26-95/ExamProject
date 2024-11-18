using ExamProject.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models
{
    public class Exam : BaseModel
    {
        public int NumberOfQuestions { get; set; }

        public int MaxDgree { get; set; }

        public DateTime Date { get; set; }

        public Exmatype ExmaType { get; set; }

        public string InstructorId { get; set; }

        public int CourseId { get; set; }


        [ForeignKey(nameof(InstructorId))]
        [InverseProperty(nameof(User.Exams))]
        public virtual User Instructor { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty(nameof(Course.Exams))]
        public virtual Course Course { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

    }
}
