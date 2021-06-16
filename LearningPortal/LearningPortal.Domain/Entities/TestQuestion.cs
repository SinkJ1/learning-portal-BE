using System.Collections.Generic;

namespace LearningPortal.Domain.Entities
{
    class TestQuestion
    {
        public int Id { get; set; }
        public Test Test { get; set; }
        public List<Question> Questions { get; set; }
    }
}
