using Micro.ProdcutApi.Data;
using Micro.ProdcutApi.Repository.Categories;
using Micro.ProdcutApi.Repository.Item;
using Micro.ProdcutApi.Repository.Items;
using Micro.ProdcutApi.Repository.Stacks;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Micro.ProdcutApi.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private readonly ProductDbContext _context;
        private readonly ILogger _logger;

        public IItemsRepository Items { get; private set; }

        public ICatesRepository Cates { get; private set; }

        public IStacksRepository Stacks { get; private set; }

        public UnitOfWork(ProductDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

           Items=new ItemRepository(context, _logger);
            Cates =new CatesRepository(context, _logger);
            Stacks=new StacksRepository(context, _logger);
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
