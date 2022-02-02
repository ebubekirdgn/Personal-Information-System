
namespace PersonalInformationSystem.Business.Contracts
{
    public interface IPersonalLeaveRequestBusiness
    {
        Result<List<PersonalLeaveRequestVM>> GetAllLeaveRequestByUserId(string userId);
        Result<PersonalLeaveRequestVM> CreatePersonalLeaveRequest(PersonalLeaveRequestVM model, SessionContext user);
        Result<PersonalLeaveRequestVM> EditPersonalLeaveRequest(PersonalLeaveRequestVM model, SessionContext user);
        Result<PersonalLeaveRequestVM> GetAllLeaveRequestById(int id);
        Result<PersonalLeaveRequestVM> RemovePersonalRequest(int id);
        Result<List<PersonalLeaveRequestVM>> GetSendApprovedLeaveRequests();
        Result<bool> RejectPersonalLeaveRequest(int id);

    }
}