using System.Collections.Generic;

namespace LearningPortal.Domain.Entities
{
    public class CompletedTest
    {
        public int Id { get; set; }
        public List<User> Users { get; set; }
        public List<Test> Tests { get; set; }
    }
}
