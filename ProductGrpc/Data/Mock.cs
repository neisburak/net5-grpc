using System;
using System.Collections.Generic;
using ProductGrpc.Models;

namespace ProductGrpc.Data
{
    public class Mock
    {
        public static List<Product> Data = new List<Product>
        {
            new Product { Id = 1, Name = "Telefon", Detail = "Telefon Açıklaması", Price = 219.99f, Status = ProductStatus.Low, CreatedOn = DateTime.UtcNow },
            new Product { Id = 2, Name = "Bilgisayar", Detail = "Bilgisayar Açıklaması", Price = 529.99f, Status = ProductStatus.InStock, CreatedOn = DateTime.UtcNow },
            new Product { Id = 3, Name = "Kitap", Detail = "Kitap Açıklaması", Price = 19.99f, Status = ProductStatus.None, CreatedOn = DateTime.UtcNow },
            new Product { Id = 4, Name = "Müzik", Detail = "Müzik Açıklaması", Price = 9.99f, Status = ProductStatus.InStock, CreatedOn = DateTime.UtcNow },
        };
    }
}