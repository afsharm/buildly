using System.ComponentModel.DataAnnotations;

[Serializable]
public class BuildingItem
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public BuildingItem? ParentItem { get; set; }
    
    public Guid? ParentItemId { get; set; }
}
