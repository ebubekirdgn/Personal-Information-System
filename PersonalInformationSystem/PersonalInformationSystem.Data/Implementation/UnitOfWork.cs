namespace PersonalInformationSystem.Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PersonalInformationContext _context;

        public UnitOfWork(PersonalInformationContext context)
        {
            _context = context;
            PersonalLeaveAllocation = new PersonalLeaveAllocationRepository(_context);
            PersonalLeaveRequestRepository = new PersonalLeaveRequestRepository(_context);
            PersonalLeaveTypeRepository = new PersonalLeaveTypeRepository(_context);
            PersonalRepository = new PersonalRepository(_context);
        }

        public IPersonalLeaveAllocationRepository PersonalLeaveAllocation { get; private set; }
        public IPersonalLeaveRequestRepository PersonalLeaveRequestRepository { get; private set; }
        public IPersonalLeaveTypeRepository PersonalLeaveTypeRepository { get; private set; }
        public IPersonalRepository PersonalRepository { get; private set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}