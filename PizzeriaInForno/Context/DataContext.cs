using Microsoft.EntityFrameworkCore;
using PizzeriaInForno.Models;
using System.Data;

namespace PizzeriaInForno.Context
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        public DataContext(DbContextOptions<DataContext> opt) : base(opt) { }
    }
}
