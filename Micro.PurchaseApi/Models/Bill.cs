using System.ComponentModel.DataAnnotations.Schema;

namespace Micro.PurchaseApi.Models
{
    public class Bill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Vendor")]

        public int VendorId { get; set; }
        public int Gnb { get; set; }
        public double Total { get; set; }

        [ForeignKey("CashOrDebit")]

        public int cashOrDebitId { get; set; }

        public virtual Vendor Vendor { get; set; } = null!;
        public virtual CashOrDebit cashOrDebit { get; set; } = null!;
    }
}
