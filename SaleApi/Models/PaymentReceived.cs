namespace SaleApi.Models
{
    public class PaymentReceived
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public double Amount { get; set; }
        public int DepositedToAccountId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
