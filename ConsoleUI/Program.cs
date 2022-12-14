
using Business.Concrete;
using DataAccess.Concrete.Hibernate;
using Entities.Concrete;
using Logging.Concrete;


Course course = new Course() { CourseId = 1, CourseName = "C# Backend Developer", Image="jordon.jpg", CompletionRate=30};
CourseManager courseManager = new CourseManager(new HibernateCourseDal(), new FileLoggerManager());
courseManager.Add(course);
courseManager.Log(course);