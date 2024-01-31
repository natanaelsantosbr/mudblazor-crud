using Dot7.BlazorWasm.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dot7.BlazorWasm.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<SuperHeroes> SuperHeroes { get; set; }
    }
}
