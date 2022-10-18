namespace Micro.PurchaseApi.Dtos
{
    public class DebitBillDto
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public double Amount { get; set; }
        public int FinancialAccountId { get; set; }
    }
}
