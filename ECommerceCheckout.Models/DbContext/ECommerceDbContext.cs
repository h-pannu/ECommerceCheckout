using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ECommerceCheckout.Models.DbContext
{
    public class ECommerceDbContext
    {
        public ECommerceDbContext()
        {
        }

        //Created watch list with dummy data. We need to fetch it from database table Watch using entity framework in real world application.
        public List<Watch> getDummyDataWatch()
        {
            var dummyDataWatchList = new List<Watch>
        {
            new Watch { WatchId = 1 ,WatchName = "Rolex", UnitPrice = 100, DiscountId = 1 },
            new Watch { WatchId = 2 ,WatchName = "Michael Kors", UnitPrice = 80, DiscountId = 2  },
            new Watch { WatchId = 3 ,WatchName = "Swatch", UnitPrice = 50  },
            new Watch { WatchId = 4 ,WatchName = "Casio", UnitPrice = 30  }
        };

            return dummyDataWatchList;
        }

        //Created discount list with dummy data. We need to fetch it from database table Discount using entity framework in real world application.
        public List<Discount> getDummyDataDiscount()
        {
            var dummyDataDiscountList = new List<Discount>
        {
            new Discount { DiscountId = 1, DiscountQuantity = 3, DiscountPrice = 200 },
            new Discount { DiscountId = 2, DiscountQuantity = 2, DiscountPrice = 120 },
        };

            return dummyDataDiscountList;
        }
    }
}
