using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMate.Data
{
    public class ShopCart
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<Item> Items { get; set; } = new List<Item>();

    }
    
}
