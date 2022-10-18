namespace Micro.PurchaseApi.Dtos
{
    public class BillDto
    {
        public int Id { get; set; }
        

        public int VendorId { get; set; }
        public int Gnb { get; set; }
        public double Total { get; set; }


        public int cashOrDebitId { get; set; }
    }
}
