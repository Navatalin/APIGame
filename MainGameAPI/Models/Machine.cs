/*
A Machine has an id, a name, a resource input and a product output.
*/
using MainGameAPI.Models.Items;

namespace MainGameAPI.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Resource Input { get; set; }
        public Product Output { get; set; }
        public int Price { get; set; }
        public int Upkeep { get; set; }

        public Machine(string name, Resource input, Product output, int price, int upkeep)
        {
            Name = name;
            Input = input;
            Output = output;
            Price = price;
        }

    }
}