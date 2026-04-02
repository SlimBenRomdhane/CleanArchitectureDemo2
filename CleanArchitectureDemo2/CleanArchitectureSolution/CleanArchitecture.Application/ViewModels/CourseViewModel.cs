using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; } = Enumerable.Empty<Course>();
    }
}
