using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Micro.PurchaseApi.Models
{
    public class AccDebitVendor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int AccNum { get; set; }

        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        public double DebitAmount { get; set; }
        public double CerditAmount { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<DebitBill> DebitBills { get; set; }
    }
}
