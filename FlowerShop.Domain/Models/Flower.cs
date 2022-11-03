using FlowerShop.Domain.DTOs;
using FlowerShop.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlowerShop.Domain.Models
{
    public class Flower
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)] 
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Rank { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public FlowerType Type { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }

        public static explicit operator Flower(FlowerDTO flower)
        {
            return new Flower
            {
                Name = flower.Name,
                Price = flower.Price,
                Rank = flower.Rank,
                Description = flower.Description,
                Type = flower.Type,
                ImagePath = flower.ImagePath,
                Status = flower.Status,
                Count = flower.Count
            };
        }
    }
}
