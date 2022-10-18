using System.ComponentModel.DataAnnotations.Schema;

namespace Micro.PurchaseApi.Models
{
    public class PaymentsMade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Vendor")]

        public int VendorId { get; set; }
        public int PaymentToAccountId { get; set; }
        public double Amount { get; set; }
        public string ReceiptReferance { get; set; }

        public virtual Vendor Vendor { get; set; } = null!;
    }
}
