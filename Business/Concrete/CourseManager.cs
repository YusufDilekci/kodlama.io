﻿using Business.Abstract;
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
        private List<ILoggerService> _loggerServices;

        public CourseManager(ICourseDal courseDal, List<ILoggerService> loggerServices)
        {
            _courseDal = courseDal;
            _loggerServices = loggerServices;
        }
        public void Add(Course course)
        {
            var courses = _courseDal.GetAll();
            foreach(var item in courses)
            {
                if (item.CourseName == course.CourseName)
                {
                    throw new Exception("Kurs ismi tekrar edemez");
                }
            }
            if(course.Price < 0)
            {
                throw new Exception("Bir kursun fiyatı 0 dan küçük olamaz");
            }

            else
            {
                _courseDal.Add(course);
            }
           
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Log(Course course)
        {
            foreach(var logger in _loggerServices)  //polymorphsim
            {
                logger.Log(course.CourseName);     
            }
            
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
