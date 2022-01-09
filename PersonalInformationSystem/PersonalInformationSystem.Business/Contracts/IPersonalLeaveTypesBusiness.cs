

namespace PersonalInformationSystem.Business.Contracts
{
    public interface IPersonalLeaveTypesBusiness
    {
        Result<List<PersonalLeaveTypeVM>> GetAllPersonalLeaveType();
        Result<PersonalLeaveTypeVM> CreatePersonalLeaveType(PersonalLeaveTypeVM model);
        Result<PersonalLeaveTypeVM> GetAllEmployeeLeaveType(int id);
        Result<PersonalLeaveTypeVM> EditEmployeeLeaveType(PersonalLeaveTypeVM model);
        Result<PersonalLeaveTypeVM> RemoveEmployeeLeaveType(int id);
    }
}
