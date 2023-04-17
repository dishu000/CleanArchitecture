﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Ioc
{
    public class DependencyContainer
    {
        public  static void RegisterServices(IServiceCollection services) 
        {
            //Connecting the ICourseService Interface with it's concrete Implemetnation 
            services.AddScoped<ICourseService, CourseService>();

            //Connecting the ICourseRepositary Interface with it's concrete Implemtation
            services.AddScoped<ICourseRepository, CourseRepository>();
        }

    }
}
