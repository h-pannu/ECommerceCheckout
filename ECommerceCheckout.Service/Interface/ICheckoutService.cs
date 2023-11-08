using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceCheckout.Service.Interface
{
    public interface ICheckoutService
    {
        public decimal CalculateTotalCost(string[] watchIds);
    }
}
