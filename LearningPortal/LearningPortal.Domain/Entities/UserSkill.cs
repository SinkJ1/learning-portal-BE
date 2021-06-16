using System.Collections.Generic;

namespace LearningPortal.Domain.Entities
{
    public class UserSkill
    {
        public int Id { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
