using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Micro.PurchaseApi.Models
{
    public class CashOrDebit
    {
        [Key]
        public int Id { get; set; }
        public string title { get; set; }


        public virtual ICollection<Bill> Bills { get; set; }
    }
}
