﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMate.Data
{
    public class Item
    {

        [Key]
        public int Id { get; set; }

        public string ItemName { get; set; } = string.Empty;

        public bool Active { get; set; }

        //[ForeignKey(nameof(ShopCart))] // Specify the type of the foreign key property
        //public int ShopCartId { get; set; } // Foreign key property referencing ShopCart
    }
}
