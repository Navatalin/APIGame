using MainGameAPI.Models.Items;

namespace MainGameAPI.Models
{
    public class MarketTransaction
    {
        public int Id { get; set; }
        public Player? From {get;set;}
        public Player? To {get;set;}
        public int Amount {get;set;}

        public IMarketItem? Item {get;set;}
        public int ItemAmount {get; set;}
        public DateTime TransactionDate {get;set;}
    }
}