namespace MainGameAPI.Models.Items;

public interface IItem
{
    public int Id { get; set; }
    public string? Name { get; set;}
    public int Size { get; set; }
}