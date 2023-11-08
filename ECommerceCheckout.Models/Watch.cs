namespace ECommerceCheckout.Models
{
    public class Watch
    {
        public int Id { get; set; }
        public string WatchId { get; set; } = string.Empty;
        public string WatchName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public string Discount { get; set; } = string.Empty;
    }
}