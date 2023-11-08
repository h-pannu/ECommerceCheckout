using ECommerceCheckout.Models;
using ECommerceCheckout.Models.DbContext;
using ECommerceCheckout.Service.Interface;

namespace ECommerceCheckout.Service
{
    public class CheckoutService : ICheckoutService
    {
        private readonly ECommerceDbContext _context;
        public CheckoutService(ECommerceDbContext eCommerceDbContext)
        {
            _context = eCommerceDbContext;
        }
        public decimal CalculateTotalCost(string[] watchIds)
        {
            List<Watch> watchCatalog = _context.getDummyDataWatch();

            decimal totalPrice = 0;
            var watchGroups = watchIds.GroupBy(id => id);

            foreach (var watchGroup in watchGroups)
            {
                int watchId = int.Parse(watchGroup.Key);
                int quantity = watchGroup.Count();

                // Find the watch from the catalog based on the ID
                Watch watch = watchCatalog.FirstOrDefault(w => w.WatchId == watchId);

                if (watch != null)
                {
                    int discountId = watch.DiscountId;
                    decimal unitPrice = watch.UnitPrice;

                    // Check if there is a discount available for this watch
                    if (discountId > 0)
                    {
                        // Find the applicable discount
                        Discount discount = GetDiscountById(discountId);

                        if (discount != null)
                        {
                            int discountQuantity = discount.DiscountQuantity;
                            decimal discountPrice = discount.DiscountPrice;

                            // Calculate how many times the discount should be applied
                            int discountApplications = quantity / discountQuantity;
                            int remainingItems = quantity % discountQuantity;

                            // Calculate the total cost for this watch group
                            decimal groupTotalPrice = (discountApplications * discountPrice) + (remainingItems * unitPrice);
                            totalPrice += groupTotalPrice;
                        }
                    }
                    else
                    {
                        // No discount for this watch, add the regular unit price to the total
                        totalPrice += unitPrice * quantity;
                    }
                }
            }

            return totalPrice;
        }

        // Retrieve discount by DiscountId
        private Discount GetDiscountById(int discountId)
        {
            List<Discount> discountCatalog = _context.getDummyDataDiscount();
            Discount? discount = discountCatalog.FirstOrDefault(i => i.DiscountId == discountId);
            return discount;
        }
    }

   
}