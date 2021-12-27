using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonelInformationSystem.Data.Models;

namespace PersonelInformationSystem.Data.DataContext
{
    public class PersonelInformationContext : IdentityDbContext
    {
        public PersonelInformationContext(DbContextOptions options) : base(options)
        { }

         public virtual  DbSet<Personal> Personal { get; set; }
         public virtual  DbSet<PersonalLeaveAllocation> PersonalLeaveAllocations { get; set; }
        public virtual DbSet<PersonalLeaveRequest> PersonalLeaveRequest { get; set; }
         public virtual  DbSet<PersonalLeaveType> PersonalLeaveTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<PersonalLeaveRequest>().HasOne(i => i.RequestingPersonal).WithMany();
            modelBuilder.Entity<PersonalLeaveRequest>()
            .HasOne(e => e.RequestingPersonal)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
        }


    }
}