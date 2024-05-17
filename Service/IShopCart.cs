using ShopMate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMate.Service
{
    internal interface IShopCart
    {
        Task CreateAsync(ShopCart shopCart);
        Task<IEnumerable<ShopCart>> GetAllasync();
        Task <ShopCart> GetByIdAsync(int id);
        Task UpdateAsync(ShopCart shopCart);
        Task DeleteAsync(ShopCart shopCart);

    }
}
