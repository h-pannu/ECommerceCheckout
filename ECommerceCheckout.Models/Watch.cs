namespace ECommerceCheckout.Models
{
    public class Watch
    {
        public int WatchId { get; set; }
        public string WatchName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int DiscountId { get; set; }
    }
}