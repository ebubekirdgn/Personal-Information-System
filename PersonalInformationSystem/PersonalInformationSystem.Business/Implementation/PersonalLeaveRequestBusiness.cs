using PersonalInformationSystem.Common.Extension;

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

        #endregion Constructor

        #region CustomMethods

        public Result<List<PersonalLeaveRequestVM>> GetAllLeaveRequestByUserId(string userId)
        {
            var data = _unitOfWork.PersonalLeaveRequestRepository.GetAll(
                u => u.RequestingPersonalId == userId
                && u.Cancelled == false,
                includeProperties: "RequestingPersonal,PersonalLeaveType").ToList();

            if (data != null)
            {
                List<PersonalLeaveRequestVM> returnData = new();
                foreach (var item in data)
                {
                    returnData.Add(new PersonalLeaveRequestVM()
                    {
                        Id = item.Id,

#pragma warning disable CS8629 // Nullable value type may be null.
                        ApprovedStatus = (EnumPersonalLeaveRequestStatus)item.Approved,
#pragma warning restore CS8629 // Nullable value type may be null.

#pragma warning disable CS8601 // Possible null reference assignment.
                        ApprovedText = EnumExtension<EnumPersonalLeaveRequestStatus>.GetDisplayValue((EnumPersonalLeaveRequestStatus)item.Approved),
#pragma warning restore CS8601 // Possible null reference assignment.

                        Cancelled = item.Cancelled,
                        DateRequested = item.DateRequested,
                        PersonalLeaveTypeId = item.PersonalLeaveTypeId,
                        LeaveTypeText = item.PersonalLeaveType.Name,
                        StartDate = item.StartDate,
                        EndDate = item.EndDate,
                        RequestComments = item.RequestComments,
                        RequestingPersonalId = item.RequestingPersonalId
                    });
                }
                return new Result<List<PersonalLeaveRequestVM>>(true, ResultConstant.RecordFound, returnData);
            }
            else
                return new Result<List<PersonalLeaveRequestVM>>(false, ResultConstant.RecordNotFound);
        }

        /// <summary>
        /// Create Personal Leave Request(Çalışan İzin Talebi oluşturma Methodu)
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
                    leaveRequest.Approved = (int)EnumPersonalLeaveRequestStatus.Send_Approved;
                    leaveRequest.DateRequested = DateTime.Now;

                    _unitOfWork.PersonalLeaveRequestRepository.Add(leaveRequest);
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

        /// <summary>
        /// Edit To Personal Leave Request(Çalışan İzin Talep Güncelleme)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Result<PersonalLeaveRequestVM> EditPersonalLeaveRequest(PersonalLeaveRequestVM model, SessionContext user)
        {
            if (model != null)
            {
                try
                {
                    var leaveRequest = _mapper.Map<PersonalLeaveRequestVM, PersonalLeaveRequest>(model);
                    leaveRequest.Approved = (int)model.ApprovedStatus;
                    leaveRequest.RequestingPersonalId = user.LoginId;
                    _unitOfWork.PersonalLeaveRequestRepository.Update(leaveRequest);
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

        public Result<PersonalLeaveRequestVM> GetAllLeaveRequestById(int id)
        {
            var data = _unitOfWork.PersonalLeaveRequestRepository.Get(id);
            if (data != null)
            {
                var leaveRequest = _mapper.Map<PersonalLeaveRequest, PersonalLeaveRequestVM>(data);
                return new Result<PersonalLeaveRequestVM>(true, ResultConstant.RecordFound, leaveRequest);
            }
            else
                return new Result<PersonalLeaveRequestVM>(false, ResultConstant.RecordNotFound);
        }

        public Result<PersonalLeaveRequestVM> RemovePersonalRequest(int id)
        {
            var data = _unitOfWork.PersonalLeaveRequestRepository.Get(id);
            if (data != null)
            {
                data.Cancelled = true;
                _unitOfWork.PersonalLeaveRequestRepository.Update(data);
                _unitOfWork.Save();
                return new Result<PersonalLeaveRequestVM>(true, ResultConstant.RecordCreateSuccessfully);
            }
            else
                return new Result<PersonalLeaveRequestVM>(false, ResultConstant.RecordCreateNotSuccessfully);
        }

        #endregion CustomMethods
    }
}