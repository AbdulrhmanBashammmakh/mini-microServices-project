using System.ComponentModel.DataAnnotations.Schema;

namespace Micro.PurchaseApi.Models
{
    public class DebitBill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BillId { get; set; }
        public double Amount { get; set; }

        [ForeignKey("AccDebitVendor")]
        public int FinancialAccountId { get; set; }

        public virtual AccDebitVendor FinancialAccount { get; set; }
    }
}
