using System.ComponentModel.DataAnnotations;

[Serializable]
public class ProjectTemplate
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Title { get; set; }

    public string? Description { get; set; }
}
