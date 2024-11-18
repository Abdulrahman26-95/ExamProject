using ExamProject.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models
{
    public class User
    {
        public User()
        {
            Courses = new HashSet<Course>();
            Exams = new HashSet<Exam>();
        }


        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public UserType Type { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public int? Grade { get; set; }
        public int? Age { get; set; }
        public int? Experience { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; }


        // Navigation Properties :

        [InverseProperty(nameof(Course.Instructor))]
        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

    }
}
