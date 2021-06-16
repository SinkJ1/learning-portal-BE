using System.Collections.Generic;

namespace LearningPortal.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public int UserTypeId { get; set; }

        public UserType UserTypes { get; set; }
        public List<CompletedCourse> Completed_Courses { get; set; }
        public List<CompletedTest> Completed_Tests { get; set; }
        public UserProfile UserProfile { get; set; }
        public List<Course> Courses { get; set; }
        public List<Test> Tests { get; set; }
    }
}
