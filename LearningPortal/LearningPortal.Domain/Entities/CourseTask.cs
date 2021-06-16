using System.Collections.Generic;

namespace LearningPortal.Domain.Entities
{
    public class CourseTask
    {
        public int Id { get; set; }
        public virtual List<Task> Tasks { get; set; }
        public virtual Course Course { get; set; }
    }
}
