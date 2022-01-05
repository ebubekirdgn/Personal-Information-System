using AutoMapper;
using PersonalInformationSystem.Common.VModels;
using PersonalInformationSystem.Data.Models;

namespace PersonalInformationSystem.Common.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<PersonalLeaveType, PersonalLeaveTypeVM>().ReverseMap();
            //CreateMap<PersonalLeaveTypeVM, PersonalLeaveType>();
            CreateMap<PersonalLeaveAllocation, PersonalLeaveAllocationsVM>().ReverseMap();

            CreateMap<PersonalLeaveRequest, PersonalLeaveRequestVM>().ReverseMap();
            CreateMap<Personal, PersonalVM>().ReverseMap();
        }
    }
}
