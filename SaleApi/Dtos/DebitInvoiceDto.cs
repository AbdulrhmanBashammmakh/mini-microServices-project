namespace SaleApi.Dtos
{
    public class DebitInvoiceDto
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public double Amount { get; set; }
        public int FinancialAccountId { get; set; }
    }
}
