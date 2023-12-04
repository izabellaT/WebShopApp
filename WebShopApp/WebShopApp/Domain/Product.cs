﻿using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Domain
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string ProductName { get; set; }

        [Required]
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public String Picture { get; set; }

        [Required]
        [MaxLength(5000)]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();

    }
}
