namespace LearningPortal.Domain.Entities
{
    public class UserType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public User Users { get; set; }
    }
}
