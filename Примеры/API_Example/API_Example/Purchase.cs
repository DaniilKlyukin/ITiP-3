namespace API_Example
{
    public class Purchase
    {
        public required int Id { get; set; }
        public required Product Product { get; set; }
        public required decimal Price { get; set; }
        public required int Amount { get; set; }
    }
}
