/*
A Ship has a id, a name, a player, a collection of resources, a collection of products, a planet location,
 a planet destination, a state, a cargoholdsize, a currentcargosize
*/
using MainGameAPI.Models.Items;
namespace MainGameAPI.Models
{
    public class Ship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Player Player { get; set; }
        public List<Resource> Resources { get; set; }
        public List<Product> Products { get; set; }
        public Planet PlanetLocation { get; set; }
        public Planet? PlanetDestination { get; set; }
        public string State { get; set; }
        public int CargoHoldSize { get; set; }
        public int CurrentCargoSize { get; set; }

        public int Price { get; set; }

        public Ship(string name, Player player, Planet planetLocation, int cargoHoldSize, int price)
        {
            Name = name;
            Player = player;
            PlanetLocation = planetLocation;
            PlanetDestination = null;
            State = "idle";
            CargoHoldSize = cargoHoldSize;
            CurrentCargoSize = 0;
            Resources = new List<Resource>();
            Products = new List<Product>();
            Price = price;
        }
    }
}