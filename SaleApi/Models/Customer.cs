using System.Collections.Generic;

namespace SaleApi.Models
{
    public class Customer
    {
        public Customer()
        {
            AccDebitCustomers = new HashSet<AccDebitCustomer>();
            Invoices = new HashSet<Invoice>();
            PaymentReceiveds = new HashSet<PaymentReceived>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public virtual ICollection<AccDebitCustomer> AccDebitCustomers { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<PaymentReceived> PaymentReceiveds { get; set; }
    }
}
