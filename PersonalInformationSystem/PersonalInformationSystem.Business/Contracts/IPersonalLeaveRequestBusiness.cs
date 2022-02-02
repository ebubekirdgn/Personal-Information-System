namespace PersonalInformationSystem.Business.Contracts
{
    public interface IPersonalLeaveRequestBusiness
    {
        Result<List<PersonalLeaveRequestVM>> GetAllLeaveRequestByUserId(string userId);

    }
}