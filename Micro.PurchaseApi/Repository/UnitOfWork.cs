using Micro.PurchaseApi.Data;
using Micro.PurchaseApi.Repository.interfaces;
using Micro.PurchaseApi.Repository.Repos;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Micro.PurchaseApi.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PurchaseDbContext _context;
        private readonly ILogger _logger;

        public IAccDebitRepository AccDebit { get; private set; }
        public IBillitemsRepository Billitems { get; private set; }

        public IBillsRepository Bills { get; private set; }

        public IVendorRepository Vendor { get; private set; }
        public IPaymentsRepository Payments { get; private set; }

        public IDebitBillRepository DebitBill { get; private set; }

        public UnitOfWork(PurchaseDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            AccDebit = new AccDebitRepository(context, _logger);
            Billitems = new BillitemsRepository(context, _logger);
            Bills = new BillsRepository(context, _logger);
            Vendor = new VendorRepository(context, _logger);
            Payments = new PaymentsRepository(context, _logger);
            DebitBill = new DebitBillRepository(context, _logger);

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
