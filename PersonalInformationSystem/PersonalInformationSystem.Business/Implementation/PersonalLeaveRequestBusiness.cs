namespace PersonalInformationSystem.Business.Implementation
{
    public class PersonalLeaveRequestBusiness : IPersonalLeaveRequestBusiness
    {
        #region Variables

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion Variables

        #region Constructor

        public PersonalLeaveRequestBusiness(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Result<PersonalLeaveRequestVM> CreatePersonalLeaveRequest(PersonalLeaveRequestVM model, SessionContext user)
        {
            throw new NotImplementedException();
        }

        public Result<PersonalLeaveRequestVM> EditPersonalLeaveRequest(PersonalLeaveRequestVM model, SessionContext user)
        {
            throw new NotImplementedException();
        }

        public Result<PersonalLeaveRequestVM> GetAllLeaveRequestById(int id)
        {
            throw new NotImplementedException();
        }

        #endregion Constructor

        #region CustomMethods

        public Result<List<PersonalLeaveRequestVM>> GetAllLeaveRequestByUserId(string userId)
        {
            var data = _unitOfWork.personalLeaveRequestRepository.GetAll(
                u => u.RequestingPersonalId == userId
                && u.Cancelled == false,
                includeProperties: "RequestingPersonal,PersonalLeaveType").ToList();

            #region 1.yöntem

            var leaveTypes = _mapper.Map<List<PersonalLeaveRequest>, List<PersonalLeaveRequestVM>>(data);
            return new Result<List<PersonalLeaveRequestVM>>(true, ResultConstant.RecordFound, leaveTypes);

            #endregion 1.yöntem

            #region 2.Yöntem

            if (data != null)
            {
                List<PersonalLeaveRequestVM> returnData = new List<PersonalLeaveRequestVM>();
                foreach (var item in data)
                {
                    returnData.Add(new PersonalLeaveRequestVM()
                    {
                        Id = item.Id,
                        ApprovedPersonalId = item.ApprovedPersonalId,
                        Cancelled = item.Cancelled,
                        DateRequested = item.DateRequested,
                        PersonalLeaveTypeId = item.PersonalLeaveTypeId,
                        LeaveTypeText = item.PersonalLeaveType.Name,
                        EndDate = item.EndDate,
                        StartDate = item.StartDate,
                        RequestComments = item.RequestComments,
                        RequestingPersonalId = item.RequestingPersonalId
                    });
                }
                return new Result<List<PersonalLeaveRequestVM>>(true, ResultConstant.RecordFound, returnData);
            }
            else
                return new Result<List<PersonalLeaveRequestVM>>(false, ResultConstant.RecordNotFound);

            #endregion 2.Yöntem
        }

        public Result<List<PersonalLeaveRequestVM>> GetSendApprovedLeaveRequests()
        {
            throw new NotImplementedException();
        }

        /*
        public Result<List<PersonalLeaveRequestVM>> GetSendApprovedLeaveRequests()
        {
           var data = _unitOfWork.personalLeaveRequestRepository.GetAll(
               u => u.Approved == (int)EnumEmployeeLeaveRequestStatus.Send_Approved
               && u.Cancelled == false,
               includeProperties: "RequestingEmployee,EmployeeLeaveType").ToList();

           if (data != null)
           {
               List<PersonalLeaveRequestVM> returnData = new List<PersonalLeaveRequestVM>();
               foreach (var item in data)
               {
                   returnData.Add(new PersonalLeaveRequestVM()
                   {
                       Id = item.Id,
                       ApprovedStatus = (EnumEmployeeLeaveRequestStatus)item.Approved,
                       ApprovedText = EnumExtension<EnumEmployeeLeaveRequestStatus>.GetDisplayValue((EnumEmployeeLeaveRequestStatus)item.Approved),
                       ApprovedEmployeeId = item.ApprovedEmployeeId,
                       Cancelled = item.Cancelled,
                       DateRequested = item.DateRequested,
                       EmployeeLeaveTypeId = item.EmployeeLeaveTypeId,
                       LeaveTypeText = item.EmployeeLeaveType.Name,
                       EndDate = item.EndDate,
                       StartDate = item.StartDate,
                       RequestComments = item.RequestComments,
                       RequestingEmployeeId = item.RequestingEmployeeId,
                       RequestEmployeeName = item.RequestingEmployee.Email
                   });
               }
               return new Result<List<EmployeeLeaveRequestVM>>(true, ResultConstant.RecordFound, returnData);
           }
           else
               return new Result<List<EmployeeLeaveRequestVM>>(false, ResultConstant.RecordNotFound);
        }
        */

        public Result<bool> RejectPersonalLeaveRequest(int id)
        {
            throw new NotImplementedException();
        }

        public Result<PersonalLeaveRequestVM> RemovePersonalRequest(int id)
        {
            throw new NotImplementedException();
        }

        #endregion CustomMethods
    }
}