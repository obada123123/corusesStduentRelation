using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corusesStduentRelation.modles
{
    public class StudentCours
    {
        [Required]
        public Guid StudentId { get; set; }

        [Required]
        public Guid CourseId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public double Mark { get; set; }





















        public Student Student { get; set; }
        public Courses Course { get; set; }




    }
}
