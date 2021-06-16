using System.Collections.Generic;

namespace LearningPortal.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CreaterId { get; set; }
        public string TestId { get; set; }

        public User User { get; set; }
        public List<Test> Tests { get; set; }
    }
}
