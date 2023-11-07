using System.ComponentModel.DataAnnotations;

[Serializable]
public class BuildingItemProperty
{
    [Key]
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid BuildingItemId { get; set; }
    public BuildingItem? BuildingItem { get; set; }
}
