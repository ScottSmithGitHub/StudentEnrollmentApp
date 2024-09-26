using StudentEnrollment.API.DTOs.Course;
using StudentEnrollment.API.DTOs.Student;

namespace StudentEnrollment.API.DTOs.Enrollment
{
    public class EnrollmentDto
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        public virtual CourseDto Course { get; set; }
        public virtual StudentDto Student { get; set; }
    }
}
