using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonelInformationSystem.Data.Models;

namespace PersonelInformationSystem.Data.DataContext
{
    public class PersonelInformationContext :IdentityDbContext
    {
        public PersonelInformationContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Personal> Personal { get; set; }
    }
}
