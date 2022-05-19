/*
A market has a id, a name, a planet location, a list of order buy and a list of order sell.
*/
using MainGameAPI.Models.Items;

namespace MainGameAPI.Models{
    public class Market{
        public int Id { get; set; }
        public string Name { get; set; }
        public Planet Planet { get; set; }
        public List<Order> OrderBuy { get; set; }
        public List<Order> OrderSell { get; set; }
        public List<MarketTransaction> MarketTransactions { get; set; }

        public Market(string name, Planet planet){
            Name = name;
            Planet = planet;
            OrderBuy = new List<Order>();
            OrderSell = new List<Order>();
            MarketTransactions = new List<MarketTransaction>();
        }

        public void AddOrderBuy(Order order){
            OrderBuy.Add(order);
        }

        public void Buy(Order order, int amount, Player buyer){
            MarketTransaction transaction = new MarketTransaction();
            transaction.Amount = amount * order.Price;
            transaction.To = order.Player;
            transaction.From = buyer;
            transaction.Item = order.Item;
            transaction.ItemAmount = amount;
            transaction.TransactionDate = DateTime.UtcNow;
            MarketTransactions.Add(transaction);
        }

        public void AddOrderSell(Order order){
            OrderSell.Add(order);
        }

        public void Sell(Order order, int amount, Player seller){
            MarketTransaction transaction = new MarketTransaction();
            transaction.Amount = amount * order.Price;
            transaction.To = seller;
            transaction.From = order.Player;
            transaction.Item = order.Item;
            transaction.ItemAmount = amount;
            transaction.TransactionDate = DateTime.UtcNow;
            MarketTransactions.Add(transaction);

        }

        public void ProcessTransactions(){
            foreach(MarketTransaction transaction in MarketTransactions){
            }

        }


    }

}