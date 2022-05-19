/*
A factory has an id, a name, a planet, a player, collection of machines, a collection of resources, a collection of products
*/
using MainGameAPI.Models.Items;

namespace MainGameAPI.Models
{
    public class Factory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Planet Planet { get; set; }
        public Player Player { get; set; }
        public List<Machine> Machines { get; set; }
        public Dictionary<Resource, int> Resources { get; set; }
        public Dictionary<Product, int> Products { get; set; }
        public int Cost { get; set; }
        public int Upkeep { get; set; }


        public Factory(string name, Planet planet, Player player, int cost)
        {
            Name = name;
            Planet = planet;
            Player = player;
            Machines = new List<Machine>();
            Resources = new Dictionary<Resource, int>();
            Products =  new Dictionary<Product, int>();
            Cost = cost;
            Upkeep = 0;
        }

        public void AddMachine(Machine machine)
        {
            Machines.Add(machine);
            Upkeep += machine.Upkeep;
        }

        public void AddResource(Resource resource, int amount)
        {
            Resources.Add(resource, amount);
        }

        public void AddProduct(Product product, int amount)
        {
            Products.Add(product, amount);
        }

        public void RemoveResource(Resource resource, int amount)
        {
            Resources.Remove(resource);
        }

        public bool CheckResourceAmount(Resource resource, int amount)
        {
            if (Resources.ContainsKey(resource))
            {
                if (Resources[resource] >= amount)
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveProduct(Product product, int amount)
        {
            Products.Remove(product);
        }

        public bool CheckProductAmount(Product product, int amount)
        {
            if (Products.ContainsKey(product))
            {
                if (Products[product] >= amount)
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveMachine(Machine machine)
        {
            Machines.Remove(machine);
            Upkeep -= machine.Upkeep;
        }

    }
}