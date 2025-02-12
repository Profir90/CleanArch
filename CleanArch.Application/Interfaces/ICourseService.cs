﻿using CleanArch.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetAll();
        void Create(CourseViewModel courseViewModel);
    }
}
