using AutoMapper;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Models.Dtos;

namespace LeaveManagement.Web.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<Employee, EmployeeListDto>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationEditDto>().ReverseMap();
        }
    }
}
