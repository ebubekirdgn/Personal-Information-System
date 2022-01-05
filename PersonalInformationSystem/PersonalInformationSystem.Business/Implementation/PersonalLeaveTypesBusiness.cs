﻿using AutoMapper;
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
            return new Result<List<PersonalLeaveTypeVM>>(true, ResultConstant.RecordCreateSuccessfully, leaveTypes); 
            #endregion
        }
 
        #endregion CustomMethods
    }
}