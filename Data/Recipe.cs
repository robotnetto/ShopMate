﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMate.Data
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; } 
        //public int Rate { get; set; }
        public bool Favorite { get; set; }  
        public string? ImageStream { get; set; }
    }
}