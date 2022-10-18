namespace SaleApi.Dtos
{
    public class PaymentReceivedDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public double Amount { get; set; }
        public int DepositedToAccountId { get; set; }
    }
}
