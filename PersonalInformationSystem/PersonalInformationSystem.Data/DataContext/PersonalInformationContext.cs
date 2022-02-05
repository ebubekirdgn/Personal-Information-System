namespace PersonalInformationSystem.Data.DataContext
{
    public class PersonalInformationContext : IdentityDbContext
    {
        public PersonalInformationContext(DbContextOptions<PersonalInformationContext> options)
            : base(options)
        {
        }

        public DbSet<Personal> Personal { get; set; }
        public DbSet<PersonalLeaveAllocation> PersonalLeaveAllocations { get; set; }
        public DbSet<PersonalLeaveRequest> PersonalLeaveRequests { get; set; }
        public DbSet<PersonalLeaveType> PersonalLeaveTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<PersonalLeaveRequest>().HasOne(i => i.RequestingPersonal).WithMany();
            modelBuilder.Entity<PersonalLeaveRequest>()
                .HasOne(e => e.RequestingPersonal)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PersonalLeaveType>().HasData(
                new PersonalLeaveType() 
                { 
                    Id = 1, Name = "Yıllık İzin"
                },
                 new PersonalLeaveType()
                 {
                     Id = 2,
                     Name = "Doğum İzni"
                 }
                );
        }
    }
}