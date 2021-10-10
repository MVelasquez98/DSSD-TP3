using ApiRestMercadoUNLa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestMercadoUNLa.Data
{
    public class ProductoContext : DbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext> options) : base(options)
        {
        }
        //crear nuestro dbset
        public DbSet<Producto> Productos { get; set; }
    }
}
