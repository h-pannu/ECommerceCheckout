using ECommerceCheckout.Models;
using ECommerceCheckout.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCheckout.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private readonly ICheckoutService _checkoutService;
        public CheckoutController(ICheckoutService checkoutService)
        {
            _checkoutService = checkoutService;
        }
        [HttpPost]
        public IActionResult Checkout([FromBody] string[] request)
        {
            if (request == null || request.Length == 0)
            {
                return BadRequest("Invalid request");
            }

            decimal totalPrice = _checkoutService.CalculateTotalCost(request);

            //return Ok(new { price = totalPrice });
            return Ok(totalPrice);
        }


    }
}
