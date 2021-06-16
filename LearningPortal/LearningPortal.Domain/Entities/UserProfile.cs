using System.Collections.Generic;

namespace LearningPortal.Domain.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<CompletedTest> CompletedTests { get; set; }
        public List<CompletedCourse> CompletedCourses { get; set; }
        public List<UserSkill> UserSkills { get; set; }
    }
}
