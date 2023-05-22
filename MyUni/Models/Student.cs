using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyUni.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        // This adds a display name of full name in the database instead of showing last name and first name 
        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName { get { return FirstName + " " + LastName; } }
        
        public DateTime EnrollmentDate { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<Enrollment>Enrollments { get; set; }

    }
}
