using Microsoft.EntityFrameworkCore;
using ShopMate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMate.Service
{
    internal class RecipeRepository : IRecipe
    {
        private readonly LocalDbService localDbService;

        public RecipeRepository(LocalDbService localDbService) => this.localDbService = localDbService;
        public async Task CreateAsync(Recipe recipe)
        {
            if (recipe != null)
            {
                await localDbService.AddAsync(recipe);
                await localDbService.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(Recipe recipe )
        {
           
            localDbService.Remove(recipe);
            await localDbService.SaveChangesAsync();
        }

        public async Task<IEnumerable<Recipe>> GetAllAsync()
        {
            return await localDbService.Recipes.ToListAsync();
        }

        public async Task<Recipe> GetByIdAsync(int id)
        {
            return await localDbService.Recipes!.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Recipe recipe)
        {
            localDbService.Recipes.Update(recipe);
            await localDbService.SaveChangesAsync();
        }
    }
}
