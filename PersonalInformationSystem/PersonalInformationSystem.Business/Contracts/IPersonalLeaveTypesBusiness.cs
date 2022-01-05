

namespace PersonalInformationSystem.Business.Contracts
{
    public interface IPersonalLeaveTypesBusiness
    {
        Result<List<PersonalLeaveTypeVM>> GetAllPersonalLeaveType();
    }
}
