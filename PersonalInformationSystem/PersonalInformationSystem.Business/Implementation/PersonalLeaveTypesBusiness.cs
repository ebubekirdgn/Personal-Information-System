namespace PersonalInformationSystem.Business.Implementation
{
    public class PersonalLeaveTypesBusiness : IPersonalLeaveTypesBusiness
    {
        #region Variables

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion Variables

        #region Constructor

        public PersonalLeaveTypesBusiness(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion Constructor

        #region CustomMethods

        public Result<List<PersonalLeaveTypeVM>> GetAllPersonalLeaveType()
        {
            var data = _unitOfWork.personalLeaveTypeRepository.GetAll(e => e.IsActive == true).ToList();

            // Mappersiz

            #region 1.Yöntem

            /*
             if (data != null)
             {
                 List<PersonalLeaveType> returnData = new List<PersonalLeaveType>();
                 foreach (var item in data)
                 {
                     returnData.Add(new PersonalLeaveType()
                     {
                         Id = item.Id,
                         DateCreated = item.DateCreated,
                         DefaultDays = item.DefaultDays,
                         Name = item.Name,
                     });
                 }
                 return new Result<List<PersonalLeaveType>>(true,ResultConstant.RecordCreateSuccessfully, returnData);
             }
             else
                 return new Result<List<PersonalLeaveType>>(true, ResultConstant.RecordNotFound);
             */

            #endregion 1.Yöntem

            //Mapperli

            #region 2.Yontem

            var leaveTypes = _mapper.Map<List<PersonalLeaveType>, List<PersonalLeaveTypeVM>>(data);
            return new Result<List<PersonalLeaveTypeVM>>(true, ResultConstant.RecordFound, leaveTypes);

            #endregion 2.Yontem
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Result<PersonalLeaveTypeVM> CreatePersonalLeaveType(PersonalLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<PersonalLeaveTypeVM, PersonalLeaveType>(model);
                    leaveType.DateCreated = DateTime.Now;
                    leaveType.IsActive = true;
                    _unitOfWork.personalLeaveTypeRepository.Add(leaveType);
                    _unitOfWork.Save();
                    return new Result<PersonalLeaveTypeVM>(true, ResultConstant.RecordCreateSuccessfully);
                }
                catch (Exception ex)
                {
                    return new Result<PersonalLeaveTypeVM>(false, ResultConstant.RecordCreateNotSuccessfully + "->" + ex.Message.ToString());
                }
            }
            else
            {
                return new Result<PersonalLeaveTypeVM>(false, "Parametre olarak geçilen data boş olamaz.");
            }
        }

        public Result<PersonalLeaveTypeVM> GetAllPersonalLeaveType(int id)
        {
            var data = _unitOfWork.personalLeaveTypeRepository.Get(id);
            if (data != null)
            {
                var leaveType = _mapper.Map<PersonalLeaveType, PersonalLeaveTypeVM>(data);
                return new Result<PersonalLeaveTypeVM>(true, ResultConstant.RecordFound, leaveType);
            }
            else
                return new Result<PersonalLeaveTypeVM>(false, ResultConstant.RecordNotFound);
        }

        public Result<PersonalLeaveTypeVM> EditPersonalLeaveType(PersonalLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<PersonalLeaveTypeVM, PersonalLeaveType>(model);
                    leaveType.IsActive = true;
                    _unitOfWork.personalLeaveTypeRepository.Update(leaveType);
                    _unitOfWork.Save();

                    return new Result<PersonalLeaveTypeVM>(true, ResultConstant.RecordEditSuccessfully);
                }
                catch (Exception ex)
                {
                    return new Result<PersonalLeaveTypeVM>(false, ResultConstant.RecordEditNotSuccessfully + "=>" + ex.Message.ToString());
                }
            }
            else
                return new Result<PersonalLeaveTypeVM>(false, "Parametre Olarak Geçilen Data Boş Olamaz!");
        }

        public Result<PersonalLeaveTypeVM> RemovePersonalLeaveType(int id)
        {
            var data = _unitOfWork.personalLeaveTypeRepository.Get(id);
            if (data != null)
            {
                data.IsActive = false;
                _unitOfWork.personalLeaveTypeRepository.Remove(data);
                _unitOfWork.Save();
                return new Result<PersonalLeaveTypeVM>(true, ResultConstant.RecordRemoveSuccessfully);
            }
            else
                return new Result<PersonalLeaveTypeVM>(false, ResultConstant.RecordRemoveNotSuccessfully);
        }

        #endregion CustomMethods
    }
}