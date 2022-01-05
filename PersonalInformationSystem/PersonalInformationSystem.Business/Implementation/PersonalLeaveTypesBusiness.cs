

namespace PersonalInformationSystem.Business.Implementation
{
    public class PersonalLeaveTypesBusiness: IPersonalLeaveTypesBusiness
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonalLeaveTypesBusiness(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


    }
}
