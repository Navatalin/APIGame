namespace MainGameAPI.Models.Items
{
    public class Resource : IItem, IMarketItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Type { get; set; }
        public int Size { get; set; }

        public int Price {get; set;}

        public Resource(string name, string type, int size)
        {
            Name = name;
            Type = type;
            Size = size;
        } 
    }

}