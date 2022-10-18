using System.Collections.Generic;

namespace SaleApi.Models
{
    public class CashOrDebit
    {
        public CashOrDebit()
        {
            Invoices = new HashSet<Invoice>();
        }
        public int Id { get; set; }
        public string title { get; set; }


        public virtual ICollection<Invoice> Invoices { get; set; }

    }
}
