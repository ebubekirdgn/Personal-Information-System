﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonelInformationSystem.Data.Models;

namespace PersonelInformationSystem.Data.DataContext
{
    public class PersonelInformationContext : IdentityDbContext
    {
        public PersonelInformationContext(DbContextOptions options) : base(options)
        { }

         public DbSet<Personal> Personal { get; set; }
         public DbSet<PersonalLeaveAllocation> PersonalLeaveAllocations { get; set; }
        public DbSet<PersonalLeaveRequest> PersonalLeaveRequest { get; set; }
        public DbSet<PersonalLeaveType> PersonalLeaveTypes { get; set; }


    }
}