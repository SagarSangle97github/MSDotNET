using Microsoft.EntityFrameworkCore;

namespace CrudOperationInNetCore.Models
{
    public class BrandDBContext : DbContext
    {
        public BrandDBContext(DbContextOptions<BrandDBContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
    }
}