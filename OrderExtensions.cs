using ReusableExtensionMethods;

public static class OrderExtensions
{
    public static string GenerateReport(this Order order)
    {
        return $"Order Report: \nOrder ID: {order.Id}\nProduct: {order.ProductName}\nQuantity: {order.Quantity}\nOrder Date: {order.OrderDate:d}";
    }
    //public static string GenerateReport(this Order order, string footer)
    //{
    //    return $"Order Report: \nOrder ID: {order.Id}\nProduct: {order.ProductName}\nQuantity: {order.Quantity}\nOrder Date: {order.OrderDate:d}\nFooter: {footer}";
    //}

    public static string GenerateReport(this Order order, string header)
    {
        return "Extension Method called!";
    }
}