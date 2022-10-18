using Micro.PurchaseApi.Data;
using Micro.PurchaseApi.Models;
using Micro.PurchaseApi.Repository.interfaces;
using Microsoft.Extensions.Logging;

namespace Micro.PurchaseApi.Repository.Repos
{
    public class BillitemsRepository : GenericRepository<BillItem>, IBillitemsRepository
    {
        public BillitemsRepository(PurchaseDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
