using Microsoft.EntityFrameworkCore;
using StudentEnrollment.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Data.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(StudentEnrollmentDbContext db) : base(db)
        {
        }

        public async Task<Course> GetStudentList(int courseId)
        {
            var course = await _db.Courses
                .Include(q => q.Enrollments)
                .ThenInclude(q => q.Student)
                .FirstOrDefaultAsync(q => q.Id == courseId);

            return course;
        }
    }
}
