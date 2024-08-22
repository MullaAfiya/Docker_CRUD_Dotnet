using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRUD_RegistrationAfiya_CO.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
