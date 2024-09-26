using StudentEnrollment.API.DTOs.Course;
using StudentEnrollment.API.DTOs.Enrollment;

namespace StudentEnrollment.API.DTOs.Student
{
    public class StudentDetailsDto : CreateStudentDto
    {
        public List<CourseDto> Courses { get; set; } = new List<CourseDto>();
    }
}
