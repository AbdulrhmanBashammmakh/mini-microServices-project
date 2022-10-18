using Micro.ProdcutApi.Data;
using Micro.ProdcutApi.Repository.Generic;
using Micro.ProdcutApi.Repository.Items;
using Micro.ProductApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Micro.ProdcutApi.Repository.Item
{
    public class ItemRepository : GenericRepository<ProductApi.Models.Item>, IItemsRepository
    {
        public ItemRepository(ProductDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public override async Task<bool> Upsert(ProductApi.Models.Item entity)
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
                _logger.LogError(ex, "{Repo} Upsert function error", typeof(ItemRepository));
                return false;
            }
        }
    }
}
