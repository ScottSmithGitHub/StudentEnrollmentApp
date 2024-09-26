using Microsoft.EntityFrameworkCore;
using StudentEnrollment.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(StudentEnrollmentDbContext db) : base(db)
        {
        }

        public async Task<Student> GetStudentDetails(int studentId)
        {
            var student = await _db.Students
                .Include(q => q.Enrollments)
                .ThenInclude(q => q.Course)
                .FirstOrDefaultAsync(q => q.Id == studentId);

            return student;
        }
    }
}
