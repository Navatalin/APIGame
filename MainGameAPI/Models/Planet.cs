/*
A Planet has an Id, a name, a x and y coordinate, and a collection of neighbors.
A Planet has a collection of resources.
A Planet has a collection of Factorys.
*/
using MainGameAPI.Models.Items;

namespace MainGameAPI.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public List<Planet> Neighbors { get; set; }
        public List<Resource> Resources { get; set; }
        public List<Factory> Factories { get; set; }

        public Planet(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
            Neighbors = new List<Planet>();
            Resources = new List<Resource>();
            Factories = new List<Factory>();
        }

        public void AddNeighbor(Planet neighbor)
        {
            Neighbors.Add(neighbor);
        }

        public void AddResource(Resource resource)
        {
            Resources.Add(resource);
        }

        public void AddFactory(Factory factory)
        {
            Factories.Add(factory);
        }

        public void RemoveFactory(Factory factory)
        {
            Factories.Remove(factory);
        }
    }
}