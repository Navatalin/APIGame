/*
Model for the universe.
There is only a single universe.
The universe has a collection of planets.
Each planet has a x and y coordinate.
Each planet has between 1 and 5 neighbors.
*/

namespace MainGameAPI.Models
{
    public class Universe
    {
        public int seed;
        public int width;
        public int height;
        public int numPlanets;

        public List<Planet> planets;

        public Universe(int seed, int width, int height, int numPlanets)
        {
            this.seed = seed;
            this.width = width;
            this.height = height;
            this.numPlanets = numPlanets;
            planets = new List<Planet>();
        }

        public void GeneratePlanets()
        {
            Random rnd = new Random(seed);
            for (int i = 0; i < numPlanets; i++)
            {
                int x = rnd.Next(width);
                int y = rnd.Next(height);
                if(!CheckIfPlanetExists(x, y)){
                    planets.Add(new Planet("Planet " + i, x, y));
                }
                else{
                    i--;
                }
            }
        }

        public bool CheckIfPlanetExists(int x, int y)
        {
            foreach (Planet p in planets)
            {
                if (p.X == x && p.Y == y)
                {
                    return true;
                }
            }
            return false;
        }

    }
}