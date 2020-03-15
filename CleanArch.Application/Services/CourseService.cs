using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public IEnumerable<CourseViewModel>GetAll()
        {
            return _courseRepository.GetAll().ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }

        public void Create(CourseViewModel courseViewModel)
        {
            _bus.SendCommand(_mapper.Map<CreateCourseCommand>(courseViewModel));
        }
    }
}