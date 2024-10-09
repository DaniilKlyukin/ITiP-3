namespace API_Example
{
    public class Order
    {
        public required int Id { get; set; }
        public required Customer Customer { get; set; }
        public required List<Purchase> Purchases { get; set; }
        public decimal Total => Purchases.Sum(p => p.Price * p.Amount);
    }
}
