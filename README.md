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



