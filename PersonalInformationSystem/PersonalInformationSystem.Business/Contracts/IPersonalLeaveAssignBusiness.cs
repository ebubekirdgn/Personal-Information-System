namespace PersonalInformationSystem.Business.Contracts
{
    public interface IPersonalLeaveAssignBusiness
    {
        Result<bool> ApprovedPersonalRequest(int id);
    }
}