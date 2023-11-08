******E-commerce Checkout API:******
This is a simplified e-commerce API with a single endpoint for performing a checkout action. It calculates the total cost of a list of watches based on the provided watch IDs. Discounts are applied as per the specified catalog.

****Setup****
To set up and run the application, follow these steps:

**Prerequisites:**

Install Visual Studio if not already installed.

**Clone the Repository:**

Clone this repository to your local machine using Git.

git clone https://github.com/h-pannu/ECommerceCheckout.git

**Open the Project:**

Open the project using Visual Studio.

**Build and Run:**

Build the project.
Run the application using F5 or by pressing Ctrl + F5 in Visual Studio.

**API Endpoint:**

The API endpoint will be available at http://localhost:port/api/checkout by default.

****Usage****

**Checkout API Endpoint**
To calculate the total price of a list of watches, make a POST request to the following endpoint:

**URL: http://localhost:port/api/checkout**

Method: POST

Headers:

Accept: application/json
Content-Type: application/json
Request Body:

Provide a list of watch IDs as strings in the request body. For example:
["001", "002", "001", "004", "003"]

Response:

The API will respond with the total price in JSON format, like this:
{ "price": 360 }  

<img width="721" alt="image" src="https://github.com/h-pannu/ECommerceCheckout/assets/16377823/b86f2eff-96d3-4f61-83cb-87c98e945ba1">


******Approach******
I built this e-commerce checkout API using ASP.NET Core. Here's an overview of my approach:

**Project Setup:**

I created N-Tier architecture by creating Web Api project, Library project for Models, Library project for Services and xunit project to have seperation of concerns. I used dependency injection to inject checkout service into controller post method.

<img width="223" alt="image" src="https://github.com/h-pannu/ECommerceCheckout/assets/16377823/76e9225b-019a-49cc-b2a0-12e7d25db7b8">


**Data Model:**

Created a Watch class to represent watches with properties for Watch ID, Watch Name, Unit Price, and Discount.
Created a Discount class to represent Discount Id, DiscountQuantity, DiscountPrice

<img width="190" alt="image" src="https://github.com/h-pannu/ECommerceCheckout/assets/16377823/c86bcc51-48d7-49be-801c-5172ca30a105">


**Checkout Controller:**

Implemented a CheckoutController with a Checkout action. Injected checkout service interface to call CalculateTotalCost method.

<img width="818" alt="image" src="https://github.com/h-pannu/ECommerceCheckout/assets/16377823/c0d0a138-6a3c-4df3-90d0-05bea6c37185">


This action calculates the total price based on the provided watch IDs, considering any discounts.

Discount Logic:

Implemented logic in the CalculateTotalCost Logic method to calculate the total price and apply discounts as specified in the requirements.

**Testing:**

Added unit tests to validate the API's functionality.
Ensured the API returns the correct total price for different combinations of watches.

**Documentation and Readme:**

Documented the setup process and usage of the API in this README.
Explained my approach, design decisions, and how I handled discount logic.


****Improvements****
If I had more time, here are some improvements I would consider:

**Error Handling:**

Implement better error handling and provide meaningful error responses for edge cases or invalid input.

**Authentication and Authorization:**

Add authentication and authorization mechanisms to secure the API if it were to be used in a real e-commerce system.

**Logging:**

Implement logging to capture important events and exceptions for monitoring and debugging purposes.

**Optimization:**

Optimize the discount calculation logic for performance, especially if there is a large catalog.

**API Versioning:**

Consider adding versioning to the API to handle future changes or updates to the checkout logic.

**More Testing:**

Expand the test suite to cover additional scenarios and edge cases.

**Containerization and Deployment:**

Dockerize the application for easy deployment and consider deploying it to a cloud platform.
