using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("street", "city", "state", "USA");
        Customer customer1 = new Customer("customer", address1);
        Console.WriteLine(customer1.DisplayAll());

        //Product details Display:
        List<string> customer1Products = ["Cardstock", "Paper", "Scissors", "Staples"];
        List<int> customer1ProductsID = [001, 002, 003, 004];
        List<double> customer1ProductsCost = [5.99, 1.99, 11.99, 2.99];
        List<int> customer1ProductsQuantity = [3, 10, 1, 2];
        List<string> products1 = new List<string>();
        double totalcost = 0;

        for (int i = 0; i < customer1Products.Count; i++)
        {
            Product product1 = new Product(customer1Products[i], customer1ProductsID[i], customer1ProductsCost[i], customer1ProductsQuantity[i]);
            totalcost = totalcost + product1.GetTotalCost();
            products1.Add(product1.DisplayAll());
        }

        //Console.WriteLine(product1.DisplayAll());
        Order order = new Order(products1, customer1, address1);
        string packingLabel = order.DisplayPackingLabel();
        string shippingLabel = order.DisplayShippingLabel();
        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);

        totalcost = totalcost + order.CalculateTotalCost();
        Console.WriteLine($"Total Cost: ${totalcost}");


        //CUSTOMER NUMBER 2
        Address address2 = new Address("street", "city", "state", "Argentina");
        Customer customer2 = new Customer("customer", address2);
        Console.WriteLine(customer2.DisplayAll());

        //Product details Display:
        List<string> customer2Products = ["Pink Cardstock", "Corrugated Paper", "Craft Scissors", "Professional Staples"];
        List<int> customer2ProductsID = [005, 006, 007, 008];
        List<double> customer2ProductsCost = [7.99, 2.99, 11.99, 12.99];
        List<int> customer2ProductsQuantity = [3, 10, 1, 2];
        List<string> products2 = new List<string>();
        double totalcost2 = 0;

        for (int i = 0; i < customer2Products.Count; i++)
        {
            Product product2 = new Product(customer2Products[i], customer2ProductsID[i], customer2ProductsCost[i], customer2ProductsQuantity[i]);
            totalcost2 = totalcost2 + product2.GetTotalCost();
            products2.Add(product2.DisplayAll());
        }

        //Console.WriteLine(product1.DisplayAll());
        Order order2 = new Order(products2, customer2, address2);
        string packingLabel2 = order2.DisplayPackingLabel();
        string shippingLabel2 = order2.DisplayShippingLabel();
        Console.WriteLine(packingLabel2);
        Console.WriteLine(shippingLabel2);

        totalcost2 = totalcost2 + order2.CalculateTotalCost();
        Console.WriteLine($"Total Cost: ${totalcost2}");


    }
}