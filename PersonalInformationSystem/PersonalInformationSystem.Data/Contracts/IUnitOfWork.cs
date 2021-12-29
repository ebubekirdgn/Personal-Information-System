namespace PersonalInformationSystem.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}