using Task_1.Foundation.Entities;
using Task_1.Foundation.UnitOfWorks;

namespace Task_1.Foundation.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseUnitOfWork _courseUnitOfWork;

        public CourseService(ICourseUnitOfWork courseUnitOfWork)
        {
            _courseUnitOfWork = courseUnitOfWork;
        }

        public void AddCourse(Course course)
        {
            _courseUnitOfWork.CourseRepository.Add(course);
            _courseUnitOfWork.Save();
        }
    }
}
