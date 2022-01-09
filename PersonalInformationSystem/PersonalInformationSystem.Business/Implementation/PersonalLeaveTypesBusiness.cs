using AutoMapper;
using PersonalInformationSystem.Common.ConstantsModels;
using PersonalInformationSystem.Common.VModels;

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
            var data = _unitOfWork.personalLeaveTypeRepository.GetAll().ToList();
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
            #endregion

            //Mapperli
            #region 2.Yontem
            var leaveTypes = _mapper.Map<List<PersonalLeaveType>, List<PersonalLeaveTypeVM>>(data);
            return new Result<List<PersonalLeaveTypeVM>>(true, ResultConstant.RecordFound, leaveTypes);
            #endregion
        }

        public Result<PersonalLeaveTypeVM> CreatePersonalLeaveType(PersonalLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<PersonalLeaveTypeVM, PersonalLeaveType>(model);
                    leaveType.DateCreated = DateTime.Now;
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

        public Result<PersonalLeaveTypeVM> GetAllEmployeeLeaveType(int id)
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

        public Result<PersonalLeaveTypeVM> EditEmployeeLeaveType(PersonalLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<PersonalLeaveTypeVM, PersonalLeaveType>(model);
                    _unitOfWork.personalLeaveTypeRepository.Update(leaveType);
                    _unitOfWork.Save();
                    return new Result<PersonalLeaveTypeVM>(true, ResultConstant.RecordCreateSuccessfully);
                }
                catch (Exception ex)
                {
                    return new Result<PersonalLeaveTypeVM>(false, ResultConstant.RecordCreateNotSuccessfully + "=>" + ex.Message.ToString());
                }
            }
            else
                return new Result<PersonalLeaveTypeVM>(false, "Parametre Olarak Geçilen Data Boş Olamaz!");
        }



        public Result<PersonalLeaveTypeVM> RemoveEmployeeLeaveType(int id)
        {
            var data = _unitOfWork.personalLeaveTypeRepository.Get(id);
            if (data != null)
            {
                _unitOfWork.personalLeaveTypeRepository.Update(data);
                _unitOfWork.Save();
                return new Result<PersonalLeaveTypeVM>(true, ResultConstant.RecordCreateSuccessfully);
            }
            else
                return new Result<PersonalLeaveTypeVM>(false, ResultConstant.RecordCreateNotSuccessfully);
        }

        #endregion CustomMethods
    }
}