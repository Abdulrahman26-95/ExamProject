namespace ExamProject.Models
{
    public class Choise : BaseModel
    {
        public Choise()
        {
            Questions = new HashSet<Question>();
        }

        public virtual ICollection<Question> Questions { get; set; }

    }
}
