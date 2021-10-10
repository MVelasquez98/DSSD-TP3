using ApiRestMercadoUNLa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestMercadoUNLa.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        //crear nuestro dbset
        public DbSet<User> Users { get; set; }
    }
}
