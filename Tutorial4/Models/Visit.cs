﻿
namespace Tutorial4.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime VisitDate { get; set; }
        public Animal Animal { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}