using CleanArch.Domain.Entities;
using System.Collections.Generic;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAll();
    }
}
 