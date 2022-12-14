using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        private List<Course> _courses;

        public InMemoryCourseDal()
        {
            _courses= new List<Course>()
            {
                new Course() { CourseId = 1, CourseName = "C# Backend Developer", Image="jordon.jpg", CompletionRate=30, Price=150.5M},
                new Course() { CourseId = 2, CourseName = "Java Backend Developer", Image="jordon.jpg", CompletionRate=20, Price=100},
                new Course() { CourseId = 3, CourseName = "Data Science with Python", Image="jordon.jpg", CompletionRate=10, Price=380},
                new Course() { CourseId = 4, CourseName = "React Frontend", Image="jordon.jpg", CompletionRate=90, Price=85.5M},

            };
        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            _courses.Remove(entity);
        }

        public void Update(Course entity)
        {
            Console.WriteLine("Güncellendi");
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

    }
}
