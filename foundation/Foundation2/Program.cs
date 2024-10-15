using System;

class Program
{
    static void Main(string[] args)
    {
        // INFO FOR COSTOMER NUMBER 1 DISPLAY ALL FROM ADDRESS, CUSTOMER, AND PRODUCT

        Address address1 = new Address("4501 State Street", "Los Angeles", "California", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Console.WriteLine(customer1.DisplayAll());

        //Creating a list for each item in the product invoice - product name list, product ID list, product cost, and product quantity, 
        // then calling the list to get the total cost added to the total cost list and FOR loop

        List<string> customer1Products = ["Cardstock", "Paper", "Scissors", "Staples"];
        List<int> customer1ProductsID = [205888, 205588, 125000, 123456];
        List<double> customer1ProductsCost = [5.99, 1.99, 11.99, 2.99];
        List<int> customer1ProductsQuantity = [3, 10, 1, 2];
        List<string> products1 = new List<string>();
        double totalcost1 = 0;

        for (int i = 0; i < customer1Products.Count; i++)
        {
            Product product1 = new Product(customer1Products[i], customer1ProductsID[i], customer1ProductsCost[i], customer1ProductsQuantity[i]);
            totalcost1 = totalcost1 + product1.GetTotalCost(); // getting the total cost which is 0 plus the cost of the item already multiplied by the quantity (GetTotalCost METHOD)
            products1.Add(product1.DisplayAll()); //adding to products1 list and returning to DisplayAll() method.
        }

        // calling ORDER to get total cost, packing and shipping labels.

        Order order1 = new Order(products1, customer1, address1);

        //PACKING LABEL 1
        string packingLabel = order1.DisplayPackingLabel();
        Console.WriteLine(packingLabel);
        totalcost1 = totalcost1 + order1.CalculateTotalCost();
        Console.WriteLine($"Total Cost: ${totalcost1} {"\n"}");

        //SHIPPING LABEL 1
        string shippingLabel = order1.DisplayShippingLabel();
        Console.WriteLine(shippingLabel);

        Console.WriteLine("--------------------------------------------------------------------------------------");

        //CUSTOMER NUMBER 2
        Address address2 = new Address("4321 Alfonzo Street", "Ciudad Evita", "Buenos Aires", "Argentina");
        Customer customer2 = new Customer("Maria Lucia", address2);
        Console.WriteLine(customer2.DisplayAll());

        //Product details Display:
        List<string> customer2Products = ["Pink Cardstock", "Corrugated Paper", "Craft Scissors", "Professional Staples"];
        List<int> customer2ProductsID = [005, 006, 007, 008];
        List<double> customer2ProductsCost = [7.99, 2.99, 11.99, 12.99];
        List<int> customer2ProductsQuantity = [2, 4, 6, 1];
        List<string> products2 = new List<string>();
        double totalcost2 = 0;

        for (int i = 0; i < customer2Products.Count; i++)
        {
            Product product2 = new Product(customer2Products[i], customer2ProductsID[i], customer2ProductsCost[i], customer2ProductsQuantity[i]);
            totalcost2 = totalcost2 + product2.GetTotalCost();
            products2.Add(product2.DisplayAll());
        }


        // calling ORDER to get total cost, packing and shipping labels.

        Order order2 = new Order(products2, customer2, address2);

        // PACKING LABEL 2:
        string packingLabel2 = order2.DisplayPackingLabel();
        Console.WriteLine(packingLabel2);
        totalcost2 = totalcost2 + order2.CalculateTotalCost();
        Console.WriteLine($"Total Cost: ${totalcost2} {"\n"}");

        //SHIPPING LABEL 2:
        string shippingLabel2 = order2.DisplayShippingLabel();
        Console.WriteLine(shippingLabel2);

        Console.WriteLine("--------------------------------------------------------------------------------------");




    }
}