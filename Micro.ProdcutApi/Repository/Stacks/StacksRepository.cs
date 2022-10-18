using Micro.ProdcutApi.Data;
using Micro.ProdcutApi.Repository.Generic;
using Micro.ProductApi.Models;
using Microsoft.Extensions.Logging;

namespace Micro.ProdcutApi.Repository.Stacks
{
    public class StacksRepository : GenericRepository<Stack>, IStacksRepository
    {
        public StacksRepository(ProductDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
