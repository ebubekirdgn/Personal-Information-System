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

        /// <summary>
        /// Create Employee Leave Request(Çalışan İzin Talebi oluşturma Methodu)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Result<PersonalLeaveRequestVM> CreatePersonalLeaveRequest(PersonalLeaveRequestVM model, SessionContext user)
        {
            if (model != null)
            {
                try
                {
                    var leaveRequest = _mapper.Map<PersonalLeaveRequestVM, PersonalLeaveRequest>(model);
                    leaveRequest.RequestingPersonalId = user.LoginId;
                    leaveRequest.Cancelled = false;
                    leaveRequest.DateRequested = DateTime.Now;
                    _unitOfWork.personalLeaveRequestRepository.Add(leaveRequest);
                    _unitOfWork.Save();
                    return new Result<PersonalLeaveRequestVM>(true, ResultConstant.RecordCreateSuccessfully);
                }
                catch (Exception ex)
                {
                    return new Result<PersonalLeaveRequestVM>(false, ResultConstant.RecordCreateNotSuccessfully + "=>" + ex.Message.ToString());
                }
            }
            else
                return new Result<PersonalLeaveRequestVM>(false, "Parametre Olarak Geçilen Data Boş Olamaz!");
        }

        public Result<PersonalLeaveRequestVM> EditPersonalLeaveRequest(PersonalLeaveRequestVM model, SessionContext user)
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

        #endregion CustomMethods
    }
}