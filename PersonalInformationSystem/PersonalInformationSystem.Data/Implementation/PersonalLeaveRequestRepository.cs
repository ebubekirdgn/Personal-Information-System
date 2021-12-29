namespace PersonalInformationSystem.Data.Implementation
{
    public class PersonalLeaveRequestRepository : Repository<PersonalLeaveRequest>, IPersonalLeaveRequestRepository
    {
        private readonly PersonalInformationContext _context;

        public PersonalLeaveRequestRepository(PersonalInformationContext context) : base(context)
        {
            _context = context;
        }
    }
}