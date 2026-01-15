Console.WriteLine("\n======================");
Console.WriteLine("Customer Service");
Console.WriteLine("======================");

// Test 1
// Scenario: Can I add one customer and then serve the customer?
// Expected Result: This should display the customer that was added
Console.WriteLine("Test 1");
var service = new CustomerService(4);
service.AddNewCustomer();
service.ServeCustomer();

Console.WriteLine("=================");

// Test 2
// Scenario: Can I add two customers and then serve the customers in the right order?
// Expected Result: This should display the customers in the same order that they were entered
Console.WriteLine("Test 2");
service = new CustomerService(4);
service.AddNewCustomer();
service.AddNewCustomer();
Console.WriteLine($"Before serving customers: {service}");
service.ServeCustomer();
service.ServeCustomer();
Console.WriteLine($"After serving customers: {service}");

Console.WriteLine("=================");

// Test 3
// Scenario: Can I serve a customer if there is no customer?
// Expected Result: This should display some error message
Console.WriteLine("Test 3");
service = new CustomerService(4);
service.ServeCustomer();

Console.WriteLine("=================");

// Test 4
// Scenario: Does the max queue size get enforced?
// Expected Result: This should display some error message when the 5th one is added
Console.WriteLine("Test 4");
service = new CustomerService(4);
service.AddNewCustomer();
service.AddNewCustomer();
service.AddNewCustomer();
service.AddNewCustomer();
service.AddNewCustomer();
Console.WriteLine($"Service Queue: {service}");

Console.WriteLine("=================");

// Test 5
// Scenario: Does the max size get defaulted to 10 if an invalid value is provided?
// Expected Result: It should display 10
Console.WriteLine("Test 5");
service = new CustomerService(0);
Console.WriteLine($"Size should be 10: {service}");