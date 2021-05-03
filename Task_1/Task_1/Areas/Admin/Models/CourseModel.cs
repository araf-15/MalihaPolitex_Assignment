using Autofac;
using System.ComponentModel.DataAnnotations;
using Task_1.Foundation.Entities;
using Task_1.Foundation.Services;

namespace Task_1.Areas.Admin.Models
{
    public class CourseModel
    {
        private readonly ICourseService _courseService;

        [Required]
        public string Title { get; set; }
        [Required]
        public int SeatCout { get; set; }
        [Required]
        public int Fee { get; set; }

        public CourseModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public CourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public void Add()
        {
            _courseService.AddCourse(new Course
            {
                Title = Title,
                SeatCount = SeatCout,
                Fee = Fee
            });
        }
    }
}
