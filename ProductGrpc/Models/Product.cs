using System;

namespace ProductGrpc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public float Price { get; set; }
        public ProductStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public enum ProductStatus
    {
        None = 0,
        Low = 1,
        InStock = 2
    }
}