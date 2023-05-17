using System.ComponentModel.DataAnnotations.Schema;

namespace MyUni.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }
        
        public DateTime EnrollmentDate { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<Enrollment>Enrollments { get; set; }

    }
}
