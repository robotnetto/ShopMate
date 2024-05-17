using Microsoft.EntityFrameworkCore;
using ShopMate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMate.Service
{
    internal class ShopCartRepository : IShopCart
    {
        private readonly LocalDbService localDbService;

        public ShopCartRepository(LocalDbService localDbService)
        {
            this.localDbService = localDbService;
        }
        public async Task CreateAsync(ShopCart shopCart)
        {
           await localDbService.ShopCarts.AddAsync(shopCart);
            await localDbService.SaveChangesAsync();
        }

        public async Task DeleteAsync(ShopCart shopCart)
        {
             localDbService.ShopCarts.Remove(shopCart);
            await localDbService.SaveChangesAsync();
           
        }

        public async Task<IEnumerable<ShopCart>> GetAllasync()
        {
            return await localDbService.ShopCarts.Include(i => i.Items).ToListAsync();
        }
        public async Task<ShopCart> GetByIdAsync(int id)
        {
            return await localDbService.ShopCarts.Where(s => s.Id == id).Include( i => i.Items).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(ShopCart shopCart)
        {
             localDbService.ShopCarts.Update(shopCart);
            await localDbService.SaveChangesAsync();
        }
    }
}
