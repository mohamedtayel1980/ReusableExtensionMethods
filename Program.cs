﻿namespace ReusableExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                Id = 1,
                ProductName = "Laptop",
                Quantity = 5,
                OrderDate = DateTime.Now
            };

            string report = order.GenerateReport();
            Console.WriteLine(report);

            string reportWithHeader = order.GenerateReport(header: "Order Summary");
            Console.WriteLine(reportWithHeader);

            string reportWithFooter = order.GenerateReport(footer:"Thank you for your order!");
            Console.WriteLine(reportWithFooter);
        }
    }
}