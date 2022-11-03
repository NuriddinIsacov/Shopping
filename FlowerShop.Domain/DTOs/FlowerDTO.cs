using FlowerShop.Domain.Enums;
using System;

namespace FlowerShop.Domain.DTOs
{
    public class FlowerDTO
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Rank { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public FlowerType Type { get; set; }
        public string ImagePath { get; set; }
        public Status Status { get; set; }
    }
}
