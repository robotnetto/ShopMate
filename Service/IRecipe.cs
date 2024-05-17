using ShopMate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMate.Service
{
    internal interface IRecipe
    {
         Task CreateAsync(Recipe recipe);
        Task<IEnumerable<Recipe>> GetAllAsync();
        Task<Recipe> GetByIdAsync(int id);
        Task UpdateAsync(Recipe recipe);
        Task DeleteAsync(Recipe recipe);
    }
}
