﻿using System.Collections;

namespace BlazorApp1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<Product_Prop> ProductProperties { get; set; }
    }
}
