using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment.Data.Contracts
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<Course> GetStudentList(int courseId);
    }
}
