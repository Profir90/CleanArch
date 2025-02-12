﻿using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System.Linq;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _dbContext;

        public CourseRepository(UniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Course> GetAll()
        {
            return _dbContext.Courses;
        }

        public void Add(Course course)
        {
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
        }
    }
}
