using Micro.PurchaseApi.Data;
using Micro.PurchaseApi.Models;
using Micro.PurchaseApi.Repository.interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Micro.PurchaseApi.Repository.Repos
{
    public class VendorRepository : GenericRepository<Vendor>, IVendorRepository
    {
        public VendorRepository(PurchaseDbContext context, ILogger logger) : base(context, logger)
        {
        }
        public override async Task<bool> Upsert(Vendor entity)
        {
            try
            {
                var existing = await dbSet.Where(x => x.Id == entity.Id)
                                                    .FirstOrDefaultAsync();

                if (existing == null)
                    return await Add(entity);

                else
                {
                    dbSet.Update(entity);
                }

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Upsert function error", typeof(VendorRepository));
                return false;
            }
        }
    }
}

