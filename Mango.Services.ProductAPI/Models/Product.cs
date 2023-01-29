﻿using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1,1000)]
        public double Price { get; set; }
        public string Discription { get; set; }
        public string CategoryName { get; set; } //then add a separate table using foreign key(потом добавить отдельную таблицу с использованием внешеного ключа)
        public string ImageUrl { get; set; }
    }
}
