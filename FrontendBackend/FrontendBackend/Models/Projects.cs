namespace FrontendBackend.Models
{
    public class Projects:BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ICollection<ProjectImage> ProjectImages { get; set; }

    }
}
