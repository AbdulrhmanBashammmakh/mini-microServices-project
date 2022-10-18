using System.Collections.Generic;

namespace SaleApi.Models
{
    public class AccDebitCustomer
    {

        public AccDebitCustomer()
        {
            DebitInvoices = new HashSet<DebitInvoice>();
        }

        public int Id { get; set; }
        public int AccNum { get; set; }
        public int CustomerId { get; set; }
        public double DebitAmount { get; set; }
        public double CreditAmount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<DebitInvoice> DebitInvoices { get; set; }
    }
}
