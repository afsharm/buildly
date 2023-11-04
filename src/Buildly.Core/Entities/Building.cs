using System.ComponentModel.DataAnnotations;

[Serializable]
public class Building
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }
}
