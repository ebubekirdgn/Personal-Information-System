namespace PersonalInformationSystem.Business.Contracts
{
    public interface IPersonalLeaveRequestBusiness
    {
        Result<List<PersonalLeaveRequestVM>> GetAllLeaveRequestByUserId(string userId);

        Result<PersonalLeaveRequestVM> CreatePersonalLeaveRequest(PersonalLeaveRequestVM model, SessionContext user);

        Result<PersonalLeaveRequestVM> EditPersonalLeaveRequest(PersonalLeaveRequestVM model, SessionContext user);

        Result<PersonalLeaveRequestVM> RemoveEmployeeRequest(int id);
    }
}