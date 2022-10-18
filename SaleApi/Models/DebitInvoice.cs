namespace SaleApi.Models
{
    public class DebitInvoice
    {

        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public double Amount { get; set; }
        public int FinancialAccountId { get; set; }

        public virtual AccDebitCustomer FinancialAccount { get; set; }
    }
}
