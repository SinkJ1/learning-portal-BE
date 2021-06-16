using System.Collections.Generic;

namespace LearningPortal.Domain.Entities
{
    public class CompletedCourse
    {
        public int Id { get; set; }
        public List<User> Users { get; set; }
        public List<Course> Courses { get; set; }
    }
}
