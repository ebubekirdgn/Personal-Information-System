

namespace PersonalInformationSystem.Business.Contracts
{
    public interface IPersonalLeaveTypesBusiness
    {
        Result<List<PersonalLeaveTypeVM>> GetAllPersonalLeaveType();
        Result<PersonalLeaveTypeVM> CreatePersonalLeaveType(PersonalLeaveTypeVM model);
    }
}
