using ECommerceCheckout.API.Controllers;
using ECommerceCheckout.Models.DbContext;
using ECommerceCheckout.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Moq.Protected;

namespace ECommerceCheckout.Tests
{
    public class CheckoutControllerTests
    {
        [Fact]
        public void Checkout_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var request = new string[] { "001", "002", "001", "004", "003" }; //Array of Watch Id
            var expectedTotalPrice = 360; // expected total price.

            var checkoutServiceMock = new Mock<ICheckoutService>();
            checkoutServiceMock.Setup(service => service.CalculateTotalCost(request)).Returns(expectedTotalPrice);

            var controller = new CheckoutController(checkoutServiceMock.Object);

            // Act
            var result = controller.Checkout(request);

            //// Assert
            var okResult = Assert.IsType<OkObjectResult>(result);   // Ensure the result is an Ok response
            Assert.Equal(expectedTotalPrice, (decimal?)okResult.Value);
        }

        [Fact]
        public void Checkout_InvalidRequest_ReturnsBadRequest()
        {
            // Arrange
            string[] request = null; // or an empty array

            var checkoutServiceMock = new Mock<ICheckoutService>();
            var controller = new CheckoutController(checkoutServiceMock.Object);

            // Act
            var result = controller.Checkout(request);

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Invalid request", badRequestResult.Value);
        }
    }
}