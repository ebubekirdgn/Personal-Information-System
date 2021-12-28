using PersonelInformationSystem.Data.Contracts;
using PersonelInformationSystem.Data.DataContext;
using PersonelInformationSystem.Data.Models;

namespace PersonelInformationSystem.Data.Implementation
{
    public class PersonalLeaveTypeRepository : Repository<PersonalLeaveType>, IPersonalLeaveTypeRepository
    {
        private readonly PersonelInformationContext _context;

        public PersonalLeaveTypeRepository(PersonelInformationContext context) : base(context)
        {
            _context = context;
        }
    }
}
