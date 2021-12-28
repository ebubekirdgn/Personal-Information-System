using PersonelInformationSystem.Data.DataContext;
using PersonelInformationSystem.Data.Models;

namespace PersonelInformationSystem.Data.Implementation
{
    public class PersonalLeaveRequestRepository : Repository<PersonalLeaveRequest>, IPersonalLeaveRequestRepository
    {
        private readonly PersonelInformationContext _context;
        public PersonalLeaveRequestRepository(PersonelInformationContext context) : base(context)
        {
            _context = context;
        }
    }
}
