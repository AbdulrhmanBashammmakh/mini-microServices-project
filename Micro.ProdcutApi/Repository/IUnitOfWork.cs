using Micro.ProdcutApi.Repository.Categories;
using Micro.ProdcutApi.Repository.Item;
using Micro.ProdcutApi.Repository.Items;
using Micro.ProdcutApi.Repository.Stacks;
using System.Threading.Tasks;

namespace Micro.ProdcutApi.Repository
{
    public interface IUnitOfWork
    {

        IItemsRepository Items { get; }
        ICatesRepository Cates { get; }
        IStacksRepository Stacks { get; }


        Task CompleteAsync();
    }
}
