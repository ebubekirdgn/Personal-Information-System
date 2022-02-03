using PersonalInformationSystem.Data.Implementation;

namespace PersonalInformationSystem.DataAccess.Contracts
{
    public class PersonalRepository : Repository<Personal>, IPersonalRepository
    {
        private readonly PersonalInformationContext _context;

        public PersonalRepository(PersonalInformationContext context) : base(context)
        {
            _context = context;
        }
    }
}