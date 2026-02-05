using System.ComponentModel.DataAnnotations;

namespace corusesStduentRelation.modles
{
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; } = Guid.NewGuid();
        [Required]
        public string StudentName { get; set; }

        public ICollection<StudentCours> StudentCourses { get; set; } = new List<StudentCours>();
    }
}
