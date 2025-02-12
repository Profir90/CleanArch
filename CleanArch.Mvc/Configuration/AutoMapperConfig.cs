﻿using AutoMapper;
using CleanArch.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Mvc.Configuration
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }
}
