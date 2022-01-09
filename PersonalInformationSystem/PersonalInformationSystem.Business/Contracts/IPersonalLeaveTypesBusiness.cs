

namespace PersonalInformationSystem.Business.Contracts
{
    public interface IPersonalLeaveTypesBusiness
    {
        Result<List<PersonalLeaveTypeVM>> GetAllPersonalLeaveType();
        Result<PersonalLeaveTypeVM> CreatePersonalLeaveType(PersonalLeaveTypeVM model);
        Result<PersonalLeaveTypeVM> GetAllPersonalLeaveType(int id);
        Result<PersonalLeaveTypeVM> EditPersonalLeaveType(PersonalLeaveTypeVM model);
        Result<PersonalLeaveTypeVM> RemovePersonalLeaveType(int id);
    }
}
