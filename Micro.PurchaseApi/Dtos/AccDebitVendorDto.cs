namespace Micro.PurchaseApi.Dtos
{
    public class AccDebitVendorDto
    {
        public int Id { get; set; }
        public int AccNum { get; set; }
        public int VendorId { get; set; }
        public double DebitAmount { get; set; }
        public double CerditAmount { get; set; }
    }
}
