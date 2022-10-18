namespace Micro.PurchaseApi.Dtos
{
    public class BillItemDto
    {
        public int Id { get; set; }
        public int Gnb { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
    }
}
