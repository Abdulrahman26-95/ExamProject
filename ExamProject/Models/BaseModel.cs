using System.ComponentModel.DataAnnotations;

namespace ExamProject.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

        public string NameAr { get; set; }

        public string NameEn { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        public bool IsDelete { get; set; } 
    }
}
