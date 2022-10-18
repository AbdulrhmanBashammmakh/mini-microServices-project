namespace SaleApi.Models
{
    public class Invoice
    {
        public int Id { get; set; }
    
        public double Total { get; set; }
        public int CustomerId { get; set; }
        public int CashOrDebitId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual CashOrDebit cashOrDebit { get; set; } = null!;
    }
}
