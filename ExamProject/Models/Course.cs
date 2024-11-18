using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models
{
    public class Course : BaseModel
    {
        public Course()
        {
            Exams = new HashSet<Exam>();  
        }

        public string InstructorId { get; set; }

        public int TotalHours { get; set; }

        public int MaxStudent { get; set; }

        public DateTime StratDate { get; set; }

        public DateTime FinishDate { get; set; }


        [ForeignKey(nameof(InstructorId))]
        [InverseProperty(nameof(User.Courses))]
        public virtual User Instructor { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

    }
}
