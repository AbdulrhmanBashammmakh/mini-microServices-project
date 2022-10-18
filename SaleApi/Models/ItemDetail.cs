namespace SaleApi.Models
{
    public class ItemDetail
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int InvoiceId { get; set; }

        public int Quantity { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
    }
}
