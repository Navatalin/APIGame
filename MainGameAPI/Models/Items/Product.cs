/*
A Product has an Id, a name, a size
*/

namespace MainGameAPI.Models.Items
{
    public class Product: IItem, IMarketItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Size { get; set; }

        public int Price {get; set;}

        public Product(string name, int size)
        {
            Name = name;
            Size = size;
        }
    }
}