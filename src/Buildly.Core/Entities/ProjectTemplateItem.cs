using System.ComponentModel.DataAnnotations;

[Serializable]
public class ProjectTemplateItem
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Title { get; set; }
}
