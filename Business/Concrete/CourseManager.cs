using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Logging.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;
        private ILoggerService _loggerService;

        public CourseManager(ICourseDal courseDal, ILoggerService loggerService)
        {
            _courseDal = courseDal;
            _loggerService = loggerService;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public void Log(Course course)
        {
            _loggerService.Log(course.CourseName);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
