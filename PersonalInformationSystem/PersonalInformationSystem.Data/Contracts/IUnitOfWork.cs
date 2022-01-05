namespace PersonalInformationSystem.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonalLeaveAllocationRepository personalLeaveAllocationRepository { get; }
        IPersonalLeaveRequestRepository personalLeaveRequestRepository { get; }
        IPersonalLeaveTypeRepository personalLeaveTypeRepository { get; }
        void Save();
    }
}