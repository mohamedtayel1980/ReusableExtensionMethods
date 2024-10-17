namespace ReusableExtensionMethods
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        //public string GenerateReport(string header)
        //{
        //    return $"Order Header: {header}\nOrder ID: {Id}\nProduct: {ProductName}\nQuantity: {Quantity}\nOrder Date: {OrderDate:d}";
        //}
        public string GenerateReport(string header)
        {
            return "Instance Method called!";
        }
    }
}
