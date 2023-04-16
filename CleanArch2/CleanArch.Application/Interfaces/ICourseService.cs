using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        //We donot need this one because CourseViewModel is already returning the Enumerable list of Courses 
        //  IEnumerable<CourseViewModel> GetCourses();

        CourseViewModel GetCourses();
    }
}
