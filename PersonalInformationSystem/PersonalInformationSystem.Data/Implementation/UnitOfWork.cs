namespace PersonalInformationSystem.Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PersonalInformationContext _context;

        public UnitOfWork(PersonalInformationContext context)
        {
            _context = context;
            personalLeaveAllocationRepository = new PersonalLeaveAllocationRepository(_context);
            personalLeaveRequestRepository = new PersonalLeaveRequestRepository(_context);
            personalLeaveTypeRepository = new PersonalLeaveTypeRepository(_context);
        }

        public IPersonalLeaveAllocationRepository personalLeaveAllocationRepository { get; private set; }
        public IPersonalLeaveRequestRepository personalLeaveRequestRepository { get; private set; }
        public IPersonalLeaveTypeRepository personalLeaveTypeRepository { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}