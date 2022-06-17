﻿namespace GenshinCalculator.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Rarity { get; set; }
        public string? ImagePath { get; set; }
    }
}
