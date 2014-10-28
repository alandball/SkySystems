namespace Common.Models
{
    public class StockLogOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int StockId { get; set; }

        public virtual Order Order { get; set; }
        public virtual StockLog Stock { get; set; }
    }
}
