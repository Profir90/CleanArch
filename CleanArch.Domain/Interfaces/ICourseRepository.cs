using CleanArch.Domain.Entities;
using System.Linq;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetAll();
        void Add(Course course);
    }
}
 