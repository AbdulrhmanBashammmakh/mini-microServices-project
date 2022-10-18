using Micro.ProdcutApi.Data;
using Micro.ProdcutApi.Repository.Generic;
using Micro.ProductApi.Models;
using Microsoft.Extensions.Logging;

namespace Micro.ProdcutApi.Repository.Categories
{
    public class CatesRepository : GenericRepository<Category>, ICatesRepository
    {
        public CatesRepository(ProductDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
