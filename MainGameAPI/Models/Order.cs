/*
An order has an id, a player, a resource, a product, a ordertype (buy or sell), a amount and a price.
*/
using MainGameAPI.Models.Items;

namespace MainGameAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Player? Player { get; set; }
        public IMarketItem? Item { get; set; }
        public string OrderType { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public Order(Player player, IMarketItem item, string orderType, int amount, int price)
        {
            Player = player;
            Item = item;
            OrderType = orderType;
            Amount = amount;
            Price = price;
        }
    }
}
