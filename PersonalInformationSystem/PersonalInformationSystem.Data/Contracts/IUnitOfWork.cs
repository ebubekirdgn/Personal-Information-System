namespace PersonalInformationSystem.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonalLeaveAllocationRepository PersonalLeaveAllocation { get; }
        IPersonalLeaveRequestRepository PersonalLeaveRequestRepository { get; }
        IPersonalLeaveTypeRepository PersonalLeaveTypeRepository { get; }
        IPersonalRepository PersonalRepository { get; }

        /// <summary>
        /// Bu method kaydeder.
        /// </summary>
        void Save();

        /*
         Unit Of Work Design Pattern Nedir?

            Unit Of Work tasarım deseni, yazılım uygulamamızda veritabanıyla ilgili her bir aksiyonun anlık olarak veritabanına yansıtılmasını
        engelleyen ve buna nazaran tüm aksiyonları biriktirip bir bütün olarak bir defada tek bir connection üzerinden gerçekleştirilmesini
        sağlayan ve böylece veritabanı maliyetlerini oldukça minimize eden bir tasarım desenidir.*/
    }
}