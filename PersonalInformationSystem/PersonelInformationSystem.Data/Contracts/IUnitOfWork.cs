namespace PersonelInformationSystem.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
