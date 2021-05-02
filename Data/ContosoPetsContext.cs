using Microsoft.EntityFrameworkCore;
using DotNetCore5.Api.Lab.Models;

namespace DotNetCore5.Api.Lab.Data
{
    public class ContosoPetsContext : DbContext
    {
        public ContosoPetsContext(DbContextOptions<ContosoPetsContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
