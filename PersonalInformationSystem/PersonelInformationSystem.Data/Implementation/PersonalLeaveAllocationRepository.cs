using PersonelInformationSystem.Data.Contracts;
using PersonelInformationSystem.Data.DataContext;
using PersonelInformationSystem.Data.Models;
using System.Linq.Expressions;

namespace PersonelInformationSystem.Data.Implementation
{
    public class PersonalLeaveAllocationRepository : Repository<PersonalLeaveAllocation>, IPersonalLeaveAllocationRepository
    {
        private readonly PersonelInformationContext _context;

        public PersonalLeaveAllocationRepository(PersonelInformationContext context) : base(context)
        {
            _context = context;
        }
    }
}
