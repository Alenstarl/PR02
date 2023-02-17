using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HomeExec02API
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public static class ProductData
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product { Id = 1, Name = "A", Price = 1000, Quantity = 10 },
            new Product { Id = 2, Name = "B", Price = 2000, Quantity = 5 },
            new Product { Id = 3, Name = "C", Price = 3000, Quantity = 3 },
        };
    }

// Validasi
    if (product.Name || product.Name.Length < 3 || product.Name.Length > 32)
    {
        return BadRequest("Nama Produk harus diisi dan memiliki panjang 3-32 karakter.");
    }
    if (product.Price < 500 || product.Price > 1000000)
    {
        return BadRequest("Harga Produk harus diisi dengan harga dari 500,00Rp ~ 1.000.000,00Rp.");
    }
    if (product.Quantity < 1 || product.Quantity > 100)
    {
        return BadRequest("Jumlah Produk diisi dengan nilai dari 1-100.");
    }

}