namespace PersonalInformationSystem.Data.Implementation
{
    public class PersonalLeaveTypeRepository : Repository<PersonalLeaveType>, IPersonalLeaveTypeRepository
    {
        private readonly PersonalInformationContext _context;

        public PersonalLeaveTypeRepository(PersonalInformationContext context) : base(context)
        {
            _context = context;
        }
    }
}