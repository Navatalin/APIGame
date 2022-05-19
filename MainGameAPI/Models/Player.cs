/*
Player has a id, a name, a collection of factories, a collection of ships, a bank account
*/
namespace MainGameAPI.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Factory> Factories { get; set; }
        public List<Ship> Ships { get; set; }
        public int BankAccount { get; set; }

        public Player(string name, int bankAccount)
        {
            Name = name;
            BankAccount = bankAccount;
            Factories = new List<Factory>();
            Ships = new List<Ship>();
        }

        public bool BuyFactory(Factory factory){
            if (BankAccount >= factory.Cost)
            {
                BankAccount -= factory.Cost;
                Factories.Add(factory);
                return true;
            }
            return false;
        }

        public bool BuyShip(Ship ship){
            if (BankAccount >= ship.Price)
            {
                BankAccount -= ship.Price;
                Ships.Add(ship);
                return true;
            }
            return false;
        }
    }
}