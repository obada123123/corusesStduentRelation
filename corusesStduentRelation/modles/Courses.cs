using System.ComponentModel.DataAnnotations;

namespace corusesStduentRelation.modles
{
    public class Courses
    {
        [Key]
       public Guid CourseId { get; set; }= Guid.NewGuid();
        [Required]
        public string CourseName { get; set; }
        [Required]
        public ICollection<StudentCours> StudentCourses { get; set; } = new List<StudentCours>();

    }
}
