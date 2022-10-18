using Micro.PurchaseApi.Repository.interfaces;
using System.Threading.Tasks;

namespace Micro.PurchaseApi.Repository
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
        IAccDebitRepository AccDebit { get; }
        IBillitemsRepository Billitems { get; }
        IBillsRepository Bills { get; } 
        IVendorRepository Vendor { get; }
        IPaymentsRepository Payments { get; }
        IDebitBillRepository DebitBill { get; }

    }
}
