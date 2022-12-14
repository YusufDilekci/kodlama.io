
using Business.Concrete;
using DataAccess.Concrete.Hibernate;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Logging.Abstract;
using Logging.Concrete;

CourseSimulation();

static void CourseSimulation()
{
    Course course = new Course() { CourseId = 1, CourseName = "Asp.Net Core", Image = "jordon.jpg", CompletionRate = 30, Price = 230 };

    var loggers = new List<ILoggerService>()
    {
        new FileLoggerManager(),
        new DatabaseLoggerManager(),
    };
    CourseManager courseManager = new CourseManager(new InMemoryCourseDal(), loggers);
    courseManager.Add(course);


    courseManager.Log(course);
    var courses = courseManager.GetAll();

    foreach (var item in courses)
    {
        Console.WriteLine(item.CourseName);
    }
}
