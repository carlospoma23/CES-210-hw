using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        // Create some addresses
        Address address1 = new Address("5109 Hallmarc Dr", "Farmington", "NM", "USA");
        Address address2 = new Address("1832 N 1550 E", "Provo", "UT", "USA");
        Address address3 = new Address("456 Ice Ave", "Toronto", "ON", "Canada");

        // Create some customers
        Customer customer1 = new Customer("Hector Gonzales", address1);
        Customer customer2 = new Customer("Ruben Aquino", address2);
        Customer customer3 = new Customer("Julia Fernandez", address3);


        // Create some products
        Product product1 = new Product("Laptop", "P001", 800.00m, 1);
        Product product2 = new Product("Mouse", "P002", 20.00m, 2);
        Product product3 = new Product("Keyboard", "P003", 50.00m, 1);


        // Creatoing  orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product1);

        // Adding another order for me
        Order order3 = new Order(customer3);
        order3.AddProduct(product2);
        order3.AddProduct(product3);



        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
        DisplayOrderDetails(order3);


    }
    static void DisplayOrderDetails(Order order)
    {
        // Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        // Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
        Console.WriteLine();

    }

}










