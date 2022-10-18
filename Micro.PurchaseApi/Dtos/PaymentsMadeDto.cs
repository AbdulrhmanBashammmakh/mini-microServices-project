namespace Micro.PurchaseApi.Dtos
{
    public class PaymentsMadeDto
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public int PaymentToAccountId { get; set; }
        public double Amount { get; set; }
        public string ReceiptReferance { get; set; }
    }
}
