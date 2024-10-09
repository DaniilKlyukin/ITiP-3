namespace API_Example
{
    public class Payment
    {
        public required int Id { get; set; }
        public required Order Order { get; set; }
        public required DateTime Date { get; set; }
        public required string PaymentMethod { get; set; }
    }
}
