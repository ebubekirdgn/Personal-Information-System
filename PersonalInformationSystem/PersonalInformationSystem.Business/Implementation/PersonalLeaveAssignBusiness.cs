namespace PersonalInformationSystem.Business.Implementation
{
    public class PersonalLeaveAssignBusiness : IPersonalLeaveAssignBusiness
    {
        #region Variables

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion Variables

        #region Constructor

        public PersonalLeaveAssignBusiness(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion Constructor

        #region CustomMethods

        public Result<bool> ApprovedPersonalRequest(int id)
        {
            if (id > 0)
            {
                try
                {
                    var data = _unitOfWork.PersonalLeaveRequestRepository.GetFirstOrDefault(u => u.Id == id);
                    if (data != null)
                    {
                        PersonalLeaveAllocation createModel = new PersonalLeaveAllocation();
                        createModel.DateCreated = DateTime.Now;
                        createModel.PersonalId = data.RequestingPersonalId;
                        createModel.PersonalLeaveTypeId = data.PersonalLeaveTypeId;
                        var day = (data.EndDate.Day - data.StartDate.Day);
                        createModel.NumberOfDays = day < 0 ? -day : day;
                        createModel.Period = 1;
                        _unitOfWork.PersonalLeaveAllocation.Add(createModel);
                    }

                    data.Approved = (int)EnumPersonalLeaveRequestStatus.Approved;
                    _unitOfWork.PersonalLeaveRequestRepository.Update(data);
                    _unitOfWork.Save();
                    return new Result<bool>(true, ResultConstant.RecordCreateSuccessfully);
                }
                catch (Exception ex)
                {
                    return new Result<bool>(false, ResultConstant.RecordCreateNotSuccessfully + "=>" + ex.Message.ToString());
                }
            }
            else
                return new Result<bool>(false, "Parametre Olarak Geçilen Data Boş Olamaz!");
        }

        #endregion CustomMethods
    }
}