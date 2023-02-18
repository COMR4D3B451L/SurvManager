using System.Text.Json.Serialization;

namespace SurvManager.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public virtual List<Project> Projects { get; set; }
    }
}
