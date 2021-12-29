namespace PersonalInformationSystem.Data.Implementation
{
    public class PersonalLeaveAllocationRepository : Repository<PersonalLeaveAllocation>, IPersonalLeaveAllocationRepository
    {
        private readonly PersonalInformationContext _context;

        public PersonalLeaveAllocationRepository(PersonalInformationContext context) : base(context)
        {
            _context = context;
        }
    }
}