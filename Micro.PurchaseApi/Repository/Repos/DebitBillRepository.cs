using Micro.PurchaseApi.Data;
using Micro.PurchaseApi.Models;
using Micro.PurchaseApi.Repository.interfaces;
using Microsoft.Extensions.Logging;

namespace Micro.PurchaseApi.Repository.Repos
{
    public class DebitBillRepository : GenericRepository<DebitBill>, IDebitBillRepository
    {
        public DebitBillRepository(PurchaseDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
