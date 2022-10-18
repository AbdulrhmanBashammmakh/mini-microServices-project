namespace SaleApi.Dtos
{
    public class InvoiceDto
    {
        public int Id { get; set; }

        public double Total { get; set; }
        public int CustomerId { get; set; }
        public int CashOrDebitId { get; set; }
    }
}
